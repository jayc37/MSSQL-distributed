using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai2
{
    public partial class formNHANSU : Form
    {
        #region khai báo
        // Chuỗi kết nối
        string connectionString;
        SqlConnection conn = null;
        // Khai báo -- _bophan
        SqlDataAdapter da_khoa = null;
        DataTable dt_khoa = null;
        //khai báo  -- _nhanvien
        SqlDataAdapter da_sinhvien = null;
        DataTable dt_sinhvien = null;
        bool Them;

        #endregion
        public formNHANSU(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
        }
        //
        #region resetvalues
        private void resetValue_bophan()
        {
            this.txtid_khoa.ResetText();
            this.txtten_khoa.ResetText();

        }
        private void HIDE()
        {
            //hide gridview
            panel_edit_Bophan.Hide();
            panel_edit_nhanvien.Hide();
            panel_get_bophan.Enabled = false;
            panel_get_nhanvien.Enabled = false;
            panel_edit_nhanvien.Enabled = false;
            panel_edit_Bophan.Enabled = false;
            dgv_nhanvien.Hide();
            //hide button
            btn_click_sinhvien.Hide();
            panel_get_nhanvien.Hide();
            panel_get_bophan.Hide();
        }
        private void resetValue_nhanvien()
        {
            this.txtid_Sinhvien.ResetText();
            this.txt_ten_sinhvien.ResetText();
            this.txt_ngaysinh.ResetText();
            this.txt_noisinh_sinhvien.ResetText();
            this.txt_khoahoc.ResetText();
            this.txt_lylich.ResetText();

            this.txt_dchi_sinhvien.ResetText();
            this.txt_noisinh_sinhvien.ResetText();
            this.txt_ngaysinh.ResetText();
            this.txt_lylich.ResetText();
           
        }
        #endregion
        void load_data()
        {
            try
            {
                // mở kết nối
                conn = new SqlConnection(connectionString);
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                HIDE();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                //gọi proc
                cmd.CommandType = CommandType.StoredProcedure;
                da_khoa = new SqlDataAdapter("sp_get_khoa", conn);
                dt_khoa = new DataTable();
                dt_khoa.Clear();
                da_khoa.Fill(dt_khoa);
                dgv_bophan.DataSource = dt_khoa;
                resetValue_bophan();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } // hàm load dữ liệu
        private void formNHANSU_Load(object sender, EventArgs e)
        {
            load_data();
        }
        #region Thoát + reload
        private void Button1_Click(object sender, EventArgs e)
        {
            // btnReload data

            load_data();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //thoát
            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp 
            traloi = MessageBox.Show("Chắc không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK) Application.Exit();
        }
        #endregion
        private void DgvNHANSU_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Giải phóng tài nguyên
            dt_sinhvien.Dispose();
            dt_sinhvien = null;
            // Hủy kết nối
            conn = null;
        }


        #region chuyển hướng
        //BUTTON hiển thị table NGUYENLIEU
        private void btnxem_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_nhanvien.Show();
                btn_click_sinhvien.Show();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                // Lấy thứ tự record hiện hành 
                int i = dgv_bophan.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành 
                string strIdbophan = dgv_bophan.Rows[i].Cells[1].Value.ToString();
                // Viết câu lệnh SQL  
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_get_sinhvien";
                cmd.Parameters.Add(new SqlParameter("@tenkhoa", strIdbophan));
                cmd.CommandType = CommandType.StoredProcedure;
                dt_sinhvien = new DataTable();
                dt_sinhvien.Clear();
                da_sinhvien = new SqlDataAdapter();
                da_sinhvien.SelectCommand = cmd;
                da_sinhvien.Fill(dt_sinhvien);
                dgv_nhanvien.DataSource = dt_sinhvien;
            }
            catch
            {
                MessageBox.Show("click vào KHOA muốn xem");
            }
        }
        // button hiển thị CHITIETKHO     
        //
        private void btnNL_Click(object sender, EventArgs e)
        {
            panel_get_bophan.Hide();
            panel_edit_Bophan.Hide();
            panel_get_nhanvien.Show();
            panel_edit_nhanvien.Show();
            panel_edit_nhanvien.Enabled = true;
            btn_luu_nhanvien.Enabled = false;
            btn_huy_nhanvien.Enabled = false;
        }
        //button loại nguyên liêu: hiển thị panel thao tác trên loại nguyên liệu
        private void btnLNL_Click(object sender, EventArgs e)
        {
            panel_get_nhanvien.Hide();
            panel_edit_nhanvien.Hide();
            panel_get_bophan.Show();
            panel_edit_Bophan.Show();
            panel_edit_Bophan.Enabled = true;
            btn_luu_bophan.Enabled = false;
            btn_huy_bophan.Enabled = false;
        }
        #endregion

        #region BOPHAN
        //thêm
        private void btnthemloainl_Click(object sender, EventArgs e)
        {
            Them = true;

            this.panel_get_bophan.Enabled = true;
            resetValue_bophan();

            btn_sua_bophan.Enabled = false;
            btn_luu_bophan.Enabled = true;
            btn_huy_bophan.Enabled = true;
            btn_xoa_bophan.Enabled = false;
        }

        private void btnhuyloainl_Click(object sender, EventArgs e)
        {
            resetValue_bophan();
            this.panel_get_bophan.Enabled = false;
            this.btn_them_bophan.Enabled = true;
            this.btn_sua_bophan.Enabled = true;
            this.btn_xoa_bophan.Enabled = true;
            this.btn_huy_bophan.Enabled = false;
            this.btn_luu_bophan.Enabled = false;
        }
        //xóa
        private void btnxoalnl_Click(object sender, EventArgs e)
        {
            // Mở kết nối  
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                // Lấy thứ tự record hiện hành 
                int i = dgv_nhanvien.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành 
                string stridsv = dgv_nhanvien.Rows[i].Cells[0].Value.ToString();
                // Viết câu lệnh SQL  
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_xoa_sinhvien";
                cmd.Parameters.Add(new SqlParameter("@idsinhvien", stridsv));
                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    load_data();
                    MessageBox.Show("Đã xóa xong!");
                }
                else
                {
                    // Thông báo 
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch (SqlException)
            { MessageBox.Show("Không xóa được. Lỗi rồi!!!"); }
            //Đóng kết nối
            conn.Close();
        }
        //sửa
        private void btnsualoainl_Click(object sender, EventArgs e)
        {
            Them = false;
            this.panel_get_bophan.Enabled = true;
            resetValue_bophan();
            int r = dgv_bophan.CurrentCell.RowIndex;
            this.txtid_khoa.Text = dgv_bophan.Rows[r].Cells[0].Value.ToString();
            this.txtten_khoa.Text = dgv_bophan.Rows[r].Cells[1].Value.ToString();
            btn_them_bophan.Enabled = false;
            btn_luu_bophan.Enabled = true;
            btn_huy_bophan.Enabled = true;
            btn_xoa_bophan.Enabled = false;
            this.txtten_khoa.Focus();
        }
        // Lưu
        private void btnluuloainl_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);
            // Mở kết nối
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            // Thêm dữ liệu
            if (Them)
            {
                try
                {
                    // Thực hiện lệnh
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@idkhoa", txtid_khoa.Text));
                    cmd.Parameters.Add(new SqlParameter("@tenkhoa", txtten_khoa.Text));

                    cmd.CommandText = "sp_Themkhoa";
                    cmd.ExecuteNonQuery();
                    // Load lại dữ liệu trên DataGridView
                    load_data();

                    // Thông báo
                    MessageBox.Show("Đã thêm xong!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (!Them)
            {
                try
                {
                    // Thực hiện lệnh
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    // Thứ tự dòng hiện hành
                    int r = dgv_bophan.CurrentCell.RowIndex;
                    // MaKH hiện hành
                    string stridbophan =
                    dgv_bophan.Rows[r].Cells[0].Value.ToString();


                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@idbophan", stridbophan));
                    cmd.Parameters.Add(new SqlParameter("@tenbophan", txtten_khoa.Text));

                    cmd.CommandText = "sp_Suakhoa";
                    cmd.ExecuteNonQuery();
                    // Load lại dữ liệu trên DataGridView
                    load_data();
                    // Thông báo
                    MessageBox.Show("Đã sửa xong!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            // Đóng kết nối
            conn.Close();
        }
        #endregion
        #region SINHVIEN

        private void btn_them_nhanvien_Click(object sender, EventArgs e)
        {
            Them = true;

            panel_get_nhanvien.Enabled = true;
            resetValue_nhanvien();
            btn_sua_nhanvien.Enabled = false;
            btn_xoa_nhanvien.Enabled = false;
            btn_luu_nhanvien.Enabled = true;
            btn_huy_nhanvien.Enabled = true;
            this.txtid_Sinhvien.Focus();
        }

        private void btn_sua_nhanvien_Click(object sender, EventArgs e)
        {
            Them = false;
            try
            {
                this.panel_get_nhanvien.Enabled = true;
                resetValue_nhanvien();
                btn_them_nhanvien.Enabled = false;
                btn_xoa_nhanvien.Enabled = false;
                btn_luu_nhanvien.Enabled = true;
                btn_huy_nhanvien.Enabled = true;

                int r = dgv_nhanvien.CurrentCell.RowIndex;

                //lay du lieu tu grid view
                this.txt_ten_sinhvien.Text = dgv_nhanvien.Rows[r].Cells[0].Value.ToString();
                this.txt_ten_sinhvien.Text = dgv_nhanvien.Rows[r].Cells[1].Value.ToString();
                this.txt_ngaysinh.Text = dgv_nhanvien.Rows[r].Cells[2].Value.ToString();
                this.txt_noisinh_sinhvien.Text = dgv_nhanvien.Rows[r].Cells[3].Value.ToString();

                this.txt_dchi_sinhvien.Text = dgv_nhanvien.Rows[r].Cells[1].Value.ToString();
                this.txt_ngaysinh.Text = dgv_nhanvien.Rows[r].Cells[3].Value.ToString();
                this.Text = dgv_nhanvien.Rows[r].Cells[4].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_huy_nhanvien_Click(object sender, EventArgs e)
        {
            resetValue_nhanvien();
            this.panel_get_nhanvien.Enabled = true;
            this.btn_them_nhanvien.Enabled = true;
            this.btn_sua_nhanvien.Enabled = true;
            this.btn_xoa_bophan.Enabled = true;
            this.btn_huy_nhanvien.Enabled = false;
            this.btn_luu_nhanvien.Enabled = false;
        }

        private void btn_xoa_nhanvien_Click(object sender, EventArgs e)
        {
            // Mở kết nối  
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                // Lấy thứ tự record hiện hành 
                int i = dgv_bophan.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành 
                string strIDNL = dgv_bophan.Rows[i].Cells[0].Value.ToString();
                // Viết câu lệnh SQL  
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_xoa_sinhvien";
                cmd.Parameters.Add(new SqlParameter("@idsinhvien", strIDNL));
                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    load_data();
                    MessageBox.Show("Đã xóa xong!");
                }
                else
                {
                    // Thông báo 
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch (SqlException)
            { MessageBox.Show("Không xóa được. Lỗi rồi!!!"); }
            //Đóng kết nối
            conn.Close();
        }
        //button lưu
        private void btn_luu_nhanvien_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);
            // Mở kết nối
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            // Thêm dữ liệu
            if (Them)
            {
                //try
                {
                    // Thực hiện lệnh
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    //thêm dữ liệu
                    cmd.Parameters.Add(new SqlParameter("@idsinhvien", txtid_Sinhvien.Text));
                    cmd.Parameters.Add(new SqlParameter("@tennhanvien", txt_ten_sinhvien.Text));
                    cmd.Parameters.Add(new SqlParameter("@Gioitinh", txt_gioitinh.Text));
                    cmd.Parameters.Add(new SqlParameter("@diachi", txt_dchi_sinhvien.Text));
                    cmd.Parameters.Add(new SqlParameter("@noisinh", txt_noisinh_sinhvien.Text));
                    cmd.Parameters.Add(new SqlParameter("@ngaysinh", txt_ngaysinh.Text));
                    cmd.Parameters.Add(new SqlParameter("@khoahoc", txt_khoahoc));
                    cmd.Parameters.Add(new SqlParameter("@lylich", txt_lylich.Text));
                    cmd.Parameters.Add(new SqlParameter("@tenkhoa", txt_tenkhoa.Text));
                    cmd.Parameters.Add(new SqlParameter("@hinhanh", txt_hinhanh.Text));
                    cmd.Parameters.Add(new SqlParameter("@idlop", txtidlop.Text));


                    cmd.CommandText = "sp_Them_sinhvien";
                    cmd.ExecuteNonQuery();
                    // Load lại dữ liệu trên DataGridView
                    load_data();

                    // Thông báo
                    MessageBox.Show("Đã thêm xong!");
                }
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}
            }
            if (!Them)
            {
                try
                {
                    // Thực hiện lệnh
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    // Thứ tự dòng hiện hành
                    int r = dgv_nhanvien.CurrentCell.RowIndex;
                    // MaKH hiện hành
                    string stridnhanvien =
                    dgv_nhanvien.Rows[r].Cells[0].Value.ToString();

                    //thêm dữ liệu
                    cmd.Parameters.Add(new SqlParameter("@idsinhvien", stridnhanvien));
                    cmd.Parameters.Add(new SqlParameter("@tennhanvien", txt_ten_sinhvien.Text));
                    cmd.Parameters.Add(new SqlParameter("@Gioitinh", txt_gioitinh.Text));
                    cmd.Parameters.Add(new SqlParameter("@diachi", txt_dchi_sinhvien.Text));
                    cmd.Parameters.Add(new SqlParameter("@noisinh", txt_noisinh_sinhvien.Text));
                    cmd.Parameters.Add(new SqlParameter("@ngaysinh", txt_ngaysinh.Text));
                    cmd.Parameters.Add(new SqlParameter("@khoahoc", txt_khoahoc));
                    cmd.Parameters.Add(new SqlParameter("@lylich", txt_lylich.Text));
                    cmd.Parameters.Add(new SqlParameter("@tenkhoa", txt_tenkhoa.Text));
                    cmd.Parameters.Add(new SqlParameter("@hinhanh", txt_hinhanh.Text));
                    cmd.Parameters.Add(new SqlParameter("@idlop", txtidlop.Text));


                    cmd.CommandText = "sp_sua_sinhvien";
                    cmd.ExecuteNonQuery();
                    // Load lại dữ liệu trên DataGridView
                    load_data();
                    // Thông báo
                    MessageBox.Show("Đã sửa xong!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion
    }
}
