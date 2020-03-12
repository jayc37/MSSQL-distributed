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
    public partial class formPHIEUNHAP : Form
    {
        #region khai báo
        // Chuỗi kết nối
        string connectionString;
        SqlConnection conn = null;
        // Khai báo -- _kho
        SqlDataAdapter da_kho = null;
        DataTable dt_kho = null;
        //khai báo  -- _hoadon_nhap
        SqlDataAdapter da_hoadon_nhap = null;
        DataTable dt_hoadon_nhap = null;
        //khai báo  -- _mathangmoi
        SqlDataAdapter da_mathangmoi = null;
        DataTable dt_mathangmoi = null;
        bool Them;

        #endregion
        public formPHIEUNHAP(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
        }
        //
        #region resetvalues
        private void resetValue_kho()
        {
            this.txt_ma_kho.ResetText();
            this.txt_ten_kho.ResetText();
            this.txt_diachi_kho.ResetText();
            cb_tinhtrang_kho.DataSource = new List<string> { "Hoạt động", "Không hoạt động" };
        }
        private void resetValue_hoadon_nhap()
        {
            this.txt_ma_hoadon_nhap.ResetText();
            this.txt_ngaynhap_hoadon_nhap.ResetText();
            //number bõx
            number_dongia_hoadon_nhap.Value = 0;
            number_soluong_hoadon_nhap.Value = 0;
            // combo box

            cb_idnhacungcap_hoadon_nhap.DataSource = new List<string> { "NCC1", "NCC2", "NCC3", "NCC4", "NCC5", "NCC6" };
            cb_manguyenlieu_hoadon_nhap.DataSource = new List<string> { "nl1", "nl2", "nl3", "nl4", "nl5", "nl6", "nl7", "nl8", "nl9", "nl10" };
            cb_manhanvien_hoadon_nhap.DataSource = new List<string> { "NV1", "NV13", "NV17", "NV5", "NV9" }; //--NV_tram_1
            cb_tinhtrang_hoadon_nhap.DataSource = new List<string> { "HT", "CHT" };
            cb_makho_hoadon_nhap.DataSource = new List<string> { "K1", "K2", "K3", "K4" };
        }
        private void resetValue_mathangmoi()
        {
            //number bõx
            number_dongia_mathangmoi.Value = 0;
            number_soluong_mathangmoi.Value = 0;
            // combo box

            cb_manguyenlieu_mathangmoi.DataSource = new List<string> { "nl1", "nl2", "nl3", "nl4", "nl5", "nl6", "nl7", "nl8", "nl9", "nl10" };
        }
        private void HIDE()
        {
            //panel _edit
            panel_edit_kho.Hide();
            panel_edit_hoadon_nhap.Hide();
            panel_edit_mathangmoi.Hide();
            //panel thêm xóa sữa
            panel_button_kho.Hide();
            panel_button_hoadon_nhap.Hide();
            panel_button_mathangmoi.Hide();
            //grid view
            grv_hoadon_nhap.Hide();
            grv_mathangmoi.Hide();
            //button hiển thị panel _edit
            btn_hienthiedit_hoadon_nhap.Hide();
            btn_hienthiedit_mathangmoi.Hide();
            btn_xem_mathangmoi.Hide();

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
                da_kho = new SqlDataAdapter("sp_get_kho", conn);
                dt_kho = new DataTable();
                dt_kho.Clear();
                da_kho.Fill(dt_kho);
                grv_KHO.DataSource = dt_kho;
                resetValue_kho();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } // hàm load dữ liệu
        private void formPHIEUNHAP_Load(object sender, EventArgs e)
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
        private void dgvKHO_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Giải phóng tài nguyên
            dt_kho.Dispose();
            dt_kho = null;
            // Hủy kết nối
            conn = null;
        }
        private void dgv_hoadon_nhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Giải phóng tài nguyên
            dt_hoadon_nhap.Dispose();
            dt_hoadon_nhap = null;
            // Hủy kết nối
            conn = null;
        }
        private void dgv_mathangmoi_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Giải phóng tài nguyên
            dt_mathangmoi.Dispose();
            dt_mathangmoi = null;
            // Hủy kết nối
            conn = null;
        }


        #region chuyển hướng
        private void nHANVIENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NHANVIEN NHANVIEN = new NHANVIEN(connectionString);
            NHANVIEN.Show();
            this.Hide();
        }

        private void kHÁCHHÀNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvKHACHHANG KH = new dgvKHACHHANG(connectionString);
            KH.Show();
            this.Hide();
        }

        private void pHIEUNHAPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formPHIEUNHAP KH = new formPHIEUNHAP(connectionString);
            KH.Show();
            this.Hide();
        }

        private void pHIEUXUATToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formPHIEUXUAT KH = new formPHIEUXUAT(connectionString);
            KH.Show();
            this.Hide();
        }
        //BUTTON hiển thị table PHIEUNHAP
        private void btn_xem_hoadon_nhap_Click_1(object sender, EventArgs e)
        {
            try

            {
                btn_xem_mathangmoi.Show();
                grv_hoadon_nhap.Show();
                btn_hienthiedit_hoadon_nhap.Show();
                btn_hienthiedit_mathangmoi.Hide();
                grv_mathangmoi.Hide();

                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                // Lấy thứ tự record hiện hành 
                int i = grv_KHO.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành 
                string str_id_kho = grv_KHO.Rows[i].Cells[0].Value.ToString();
                // Viết câu lệnh SQL  
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_get_hoadonnhap";
                cmd.Parameters.Add(new SqlParameter("@idkho", str_id_kho));
                cmd.CommandType = CommandType.StoredProcedure;
                dt_hoadon_nhap = new DataTable();
                dt_hoadon_nhap.Clear();
                da_hoadon_nhap = new SqlDataAdapter();
                da_hoadon_nhap.SelectCommand = cmd;
                da_hoadon_nhap.Fill(dt_hoadon_nhap);
                grv_hoadon_nhap.DataSource = dt_hoadon_nhap;
            }
            catch
            {
                MessageBox.Show("click vào KHO muốn xem");
            }
        }
        // button hiển thị CHITIETHOADON     
        //
        private void btn_xem_mathangmoi_Click(object sender, EventArgs e)
        {
            panel_edit_kho.Hide();
            panel_button_kho.Hide();
            panel_edit_hoadon_nhap.Hide();
            panel_button_hoadon_nhap.Hide();
            grv_mathangmoi.Show();
            btn_hienthiedit_mathangmoi.Show();
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                // Lấy thứ tự record hiện hành 
                int i = grv_hoadon_nhap.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành 
                string str_id_hoadonnhap = grv_hoadon_nhap.Rows[i].Cells[0].Value.ToString();
                // Viết câu lệnh SQL  
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_get_chitiethoadonnhap";
                cmd.Parameters.Add(new SqlParameter("@idhoadonnhap", str_id_hoadonnhap));
                cmd.CommandType = CommandType.StoredProcedure;
                dt_mathangmoi = new DataTable();
                dt_mathangmoi.Clear();
                da_mathangmoi = new SqlDataAdapter();
                da_mathangmoi.SelectCommand = cmd;
                da_mathangmoi.Fill(dt_mathangmoi);
                grv_mathangmoi.DataSource = dt_mathangmoi;
            }
            catch
            {
                MessageBox.Show("click vào hóa đơn muốn xem");
            }
        }
        //button nhanvien: hiển thị panel button và panel edit
        private void btn_hienthiedit_hoadon_nhap_Click(object sender, EventArgs e)
        {
            // ẩn các panel edit kho
            panel_edit_kho.Hide();
            panel_button_kho.Hide();

            // ẩn các panel edit themmathangmoi
            panel_edit_mathangmoi.Hide();
            panel_button_mathangmoi.Hide();
            panel_edit_hoadon_nhap.Show();
            panel_button_hoadon_nhap.Show();
            btn_luu_hoadon_nhap.Enabled = false;
            btn_huy_hoadon_nhap.Enabled = false;
            panel_edit_hoadon_nhap.Enabled = false;
        }
        //hienthi _edit them mat hang moi
        private void btn_hienthiedit_mathangmoi_Click(object sender, EventArgs e)
        {
            // ẩn các panel edit kho
            panel_edit_kho.Hide();
            panel_button_kho.Hide();

            // ẩn các panel edit themmathangmoi

            panel_edit_mathangmoi.Show();
            panel_button_mathangmoi.Show();

            panel_edit_hoadon_nhap.Hide();
            panel_button_hoadon_nhap.Hide();

            btn_luu_mathang.Enabled = false;
            btn_huy_mathang.Enabled = false;
            panel_edit_mathangmoi.Enabled = false;
        }
        private void btn_hienthiedit_kho_Click(object sender, EventArgs e)
        {
            panel_edit_kho.Show();
            panel_button_kho.Show();

            // ẩn các panel edit themmathangmoi
            panel_edit_mathangmoi.Hide();
            panel_button_mathangmoi.Hide();
            panel_edit_hoadon_nhap.Hide();
            panel_button_hoadon_nhap.Hide();
            btn_luu_kho.Enabled = false;
            btn_huy_kho.Enabled = false;
            panel_edit_kho.Enabled = false;

        }
        #endregion

        #region KHO
        //hienthi panel

        //thêm
        private void btn_them_kho_Click(object sender, EventArgs e)
        {
            Them = true;

            this.panel_edit_kho.Enabled = true;
            resetValue_kho();
            btn_sua_kho.Enabled = false;
            btn_luu_kho.Enabled = true;
            btn_huy_kho.Enabled = true;
            btn_xoa_kho.Enabled = false;
        }

        private void btn_huy_kho_Click(object sender, EventArgs e)
        {
            resetValue_kho();
            this.panel_edit_kho.Enabled = false;
            this.btn_them_kho.Enabled = true;
            this.btn_sua_kho.Enabled = true;
            this.btn_xoa_kho.Enabled = true;
            this.btn_huy_kho.Enabled = false;
            this.btn_luu_kho.Enabled = false;
        }
        //xóa
        private void btn_xoa_kho_Click(object sender, EventArgs e)
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
                int i = grv_KHO.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành 
                string str_id_kho = grv_KHO.Rows[i].Cells[0].Value.ToString();
                // Viết câu lệnh SQL  
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_xoa_kho";
                cmd.Parameters.Add(new SqlParameter("@idkho", str_id_kho));
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
        private void btn_sua_kho_Click(object sender, EventArgs e)
        {
            Them = false;
            this.panel_edit_kho.Enabled = true;
            resetValue_kho();
            int r = grv_KHO.CurrentCell.RowIndex;
            this.txt_ma_kho.Text = grv_KHO.Rows[r].Cells[0].Value.ToString();
            this.txt_ten_kho.Text = grv_KHO.Rows[r].Cells[1].Value.ToString();
            btn_them_kho.Enabled = false;
            btn_luu_kho.Enabled = true;
            btn_huy_kho.Enabled = true;
            btn_xoa_kho.Enabled = false;
            this.txt_ma_kho.Focus();
        }
        // Lưu
        private void btn_luu_kho_Click(object sender, EventArgs e)
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

                    cmd.Parameters.Add(new SqlParameter("@idkho", txt_ma_kho.Text));
                    cmd.Parameters.Add(new SqlParameter("@tenkho", txt_ten_kho.Text));
                    cmd.Parameters.Add(new SqlParameter("@diachi", txt_diachi_kho.Text));
                    cmd.Parameters.Add(new SqlParameter("@tinhtrang", cb_tinhtrang_kho.Text));

                    cmd.CommandText = "sp_Them_KHO";
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
                    int r = grv_KHO.CurrentCell.RowIndex;
                    // MaKH hiện hành
                    string stridbophan =
                    grv_KHO.Rows[r].Cells[0].Value.ToString();


                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@idkho", txt_ma_kho.Text));
                    cmd.Parameters.Add(new SqlParameter("@tenkho", txt_ten_kho.Text));
                    cmd.Parameters.Add(new SqlParameter("@diachi", txt_diachi_kho.Text));
                    cmd.Parameters.Add(new SqlParameter("@tinhtrang", cb_tinhtrang_kho.Text));

                    cmd.CommandText = "sp_Sua_KHO";
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
        #region NHANVIEN

        private void btn_them_hoadon_nhap_Click(object sender, EventArgs e)
        {
            Them = true;
            resetValue_hoadon_nhap();
            panel_edit_hoadon_nhap.Enabled = true;
            btn_sua_hoadon_nhap.Enabled = false;
            btn_xoa_hoadon_nhap.Enabled = false;
            btn_luu_hoadon_nhap.Enabled = true;
            btn_huy_hoadon_nhap.Enabled = true;
            this.txt_ma_hoadon_nhap.Focus();
        }

        private void btn_sua_hoadon_nhap_Click(object sender, EventArgs e)
        {
            Them = false;
            try
            {
                resetValue_hoadon_nhap();
                panel_edit_hoadon_nhap.Enabled = true;
                btn_them_hoadon_nhap.Enabled = false;
                btn_xoa_hoadon_nhap.Enabled = false;
                btn_luu_hoadon_nhap.Enabled = true;
                btn_huy_hoadon_nhap.Enabled = true;
                this.txt_ma_hoadon_nhap.Focus();

                int r = grv_hoadon_nhap.CurrentCell.RowIndex;

                //lay du lieu tu grid view
                this.txt_ma_hoadon_nhap.Text = grv_hoadon_nhap.Rows[r].Cells[0].Value.ToString();
                this.txt_ngaynhap_hoadon_nhap.Text = grv_hoadon_nhap.Rows[r].Cells[2].Value.ToString();
                this.cb_idnhacungcap_hoadon_nhap.Text = grv_hoadon_nhap.Rows[r].Cells[1].Value.ToString();
                this.cb_tinhtrang_hoadon_nhap.Text = grv_hoadon_nhap.Rows[r].Cells[3].Value.ToString();
                this.cb_manhanvien_hoadon_nhap.Text = grv_hoadon_nhap.Rows[r].Cells[4].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_huy_hoadon_nhap_Click(object sender, EventArgs e)
        {
            resetValue_hoadon_nhap();
            panel_edit_hoadon_nhap.Enabled = false;

            btn_them_hoadon_nhap.Enabled = true;
            btn_sua_hoadon_nhap.Enabled = true;
            btn_xoa_hoadon_nhap.Enabled = true;
            btn_luu_hoadon_nhap.Enabled = false;
            btn_huy_hoadon_nhap.Enabled = false;
        }

        private void btn_xoa_hoadon_nhap_Click(object sender, EventArgs e)
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
                int i = grv_hoadon_nhap.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành 
                string str_id_hoadon_nhap = grv_hoadon_nhap.Rows[i].Cells[0].Value.ToString();
                // Viết câu lệnh SQL  
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_xoa_phieunhap";
                cmd.Parameters.Add(new SqlParameter("@idhoadonnhap", str_id_hoadon_nhap));
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
        private void btn_luu_hoadon_nhap_Click(object sender, EventArgs e)
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
                    //thêm dữ liệu
                    cmd.Parameters.Add(new SqlParameter("@idhoadonnhap", txt_ma_hoadon_nhap.Text));
                    cmd.Parameters.Add(new SqlParameter("@idnhacungcap", cb_idnhacungcap_hoadon_nhap.Text));
                    cmd.Parameters.Add(new SqlParameter("@ngaynhap", txt_ngaynhap_hoadon_nhap.Text));
                    cmd.Parameters.Add(new SqlParameter("@tinhtrang", cb_tinhtrang_hoadon_nhap.Text));
                    cmd.Parameters.Add(new SqlParameter("@idnguyenlieu", cb_manguyenlieu_hoadon_nhap.Text));
                    cmd.Parameters.Add(new SqlParameter("@idnhanvien", cb_manhanvien_hoadon_nhap.Text));
                    cmd.Parameters.Add(new SqlParameter("@gianhap", number_dongia_hoadon_nhap.Text));
                    cmd.Parameters.Add(new SqlParameter("@soluong", number_soluong_hoadon_nhap.Text));
                    cmd.Parameters.Add(new SqlParameter("@idkho", cb_makho_hoadon_nhap.Text));


                    cmd.CommandText = "sp_Them_phieunhap";
                    cmd.ExecuteNonQuery();
                    // Load lại dữ liệu trên DataGridView
                    load_data();

                    // Thông báo
                    MessageBox.Show("Đã thêm xong!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã thêm xong!");
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
                    int r = grv_hoadon_nhap.CurrentCell.RowIndex;
                    // MaKH hiện hành
                    string str_id_hoadon_nhap =
                    grv_hoadon_nhap.Rows[r].Cells[0].Value.ToString();

                    //thêm dữ liệu
                    cmd.Parameters.Add(new SqlParameter("@idhoadonnhap", str_id_hoadon_nhap));
                    cmd.Parameters.Add(new SqlParameter("@idnhacungcap", cb_idnhacungcap_hoadon_nhap.Text));
                    cmd.Parameters.Add(new SqlParameter("@ngaynhap", txt_ngaynhap_hoadon_nhap.Text));
                    cmd.Parameters.Add(new SqlParameter("@tinhtrang", cb_tinhtrang_hoadon_nhap.Text));
                    cmd.Parameters.Add(new SqlParameter("@idnguyenlieu", cb_manguyenlieu_hoadon_nhap.Text));
                    cmd.Parameters.Add(new SqlParameter("@idnhanvien", cb_manhanvien_hoadon_nhap.Text));
                    cmd.Parameters.Add(new SqlParameter("@gianhap", number_dongia_hoadon_nhap.Text));
                    cmd.Parameters.Add(new SqlParameter("@soluong", number_soluong_hoadon_nhap.Text));
                    cmd.Parameters.Add(new SqlParameter("@idkho", cb_makho_hoadon_nhap.Text));


                    cmd.CommandText = "sp_sua_phieunhap";
                    cmd.ExecuteNonQuery();
                    // Load lại dữ liệu trên DataGridView
                    load_data();
                    // Thông báo
                    MessageBox.Show("Đã sửa xong!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("thành công!!!!!");
                }
            }
        }
        #endregion
        #region CHITIET_HOADON_NHAP

        private void btn_them_mathang_Click(object sender, EventArgs e)
        {
            Them = true;
            resetValue_mathangmoi();
            panel_edit_mathangmoi.Enabled = true;
            btn_sua_mathang.Enabled = false;
            btn_xoa_mathang.Enabled = false;
            btn_luu_mathang.Enabled = true;
            btn_huy_mathang.Enabled = true;
            this.cb_manguyenlieu_mathangmoi.Focus();
        }

        private void btn_sua_mathang_Click(object sender, EventArgs e)
        {
            Them = false;
            try
            {
                resetValue_mathangmoi();
                panel_edit_mathangmoi.Enabled = true;
                btn_them_mathang.Enabled = false;
                btn_xoa_mathang.Enabled = false;
                btn_luu_mathang.Enabled = true;
                btn_huy_mathang.Enabled = true;
                this.cb_manguyenlieu_mathangmoi.Focus();

                int r = grv_mathangmoi.CurrentCell.RowIndex;

                //lay du lieu tu grid view
                this.cb_manguyenlieu_mathangmoi.Text = grv_mathangmoi.Rows[r].Cells[1].Value.ToString();
                this.number_soluong_mathangmoi.Text = grv_mathangmoi.Rows[r].Cells[3].Value.ToString();
                this.number_dongia_mathangmoi.Text = grv_mathangmoi.Rows[r].Cells[2].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_huy_mathang_Click(object sender, EventArgs e)
        {
            resetValue_mathangmoi();
            panel_edit_mathangmoi.Enabled = false;
            btn_them_mathang.Enabled = true;
            btn_sua_mathang.Enabled = true;
            btn_xoa_mathang.Enabled = true;
            btn_luu_mathang.Enabled = false;
            btn_huy_mathang.Enabled = false;
        }

        private void btn_xoa_mathang_Click(object sender, EventArgs e)
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
                int i = grv_mathangmoi.CurrentCell.RowIndex;
                int r = grv_hoadon_nhap.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành 
                string str_id_hoadon_nhap = grv_hoadon_nhap.Rows[r].Cells[0].Value.ToString();
                string str_id_nguyenlieu_mathangmoi = grv_mathangmoi.Rows[i].Cells[1].Value.ToString();
                // Viết câu lệnh SQL  
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_xoa_nhanvien";
                cmd.Parameters.Add(new SqlParameter("@idhoadonnhap", str_id_hoadon_nhap));
                cmd.Parameters.Add(new SqlParameter("@idnguyenlieu", str_id_nguyenlieu_mathangmoi));
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
        private void btn_luu_mathang_Click(object sender, EventArgs e)
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
                    //thêm dữ liệu
                    int i = grv_hoadon_nhap.CurrentCell.RowIndex;
                    // Lấy MaKH của record hiện hành 
                    string str_id_hoadon_nhap = grv_hoadon_nhap.Rows[i].Cells[0].Value.ToString();

                    cmd.Parameters.Add(new SqlParameter("@idhoadonnhap", str_id_hoadon_nhap));
                    cmd.Parameters.Add(new SqlParameter("@idnguyenlieu", cb_manguyenlieu_mathangmoi.Text));
                    cmd.Parameters.Add(new SqlParameter("@soluong", number_soluong_mathangmoi.Text));
                    cmd.Parameters.Add(new SqlParameter("@gianhap", number_dongia_mathangmoi.Text));
               

                    cmd.CommandText = "sp_Them_chitiethoadon";
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
                    int i = grv_hoadon_nhap.CurrentCell.RowIndex;
                    // Lấy MaKH của record hiện hành 
                    string str_id_hoadon_nhap = grv_hoadon_nhap.Rows[i].Cells[0].Value.ToString();
                    int r = grv_mathangmoi.CurrentCell.RowIndex;
                    // Lấy MaKH của record hiện hành 
                    string str_id_nguyenlieu_mathangmoi = grv_mathangmoi.Rows[r].Cells[1].Value.ToString();


                    cmd.Parameters.Add(new SqlParameter("@idhoadonnhap", str_id_hoadon_nhap));
                    cmd.Parameters.Add(new SqlParameter("@idnguyenlieu", str_id_nguyenlieu_mathangmoi));
                    cmd.Parameters.Add(new SqlParameter("@soluong", number_soluong_mathangmoi.Text));
                    cmd.Parameters.Add(new SqlParameter("@gianhap", number_dongia_mathangmoi.Text));


                    cmd.CommandText = "sp_Them_chitiethoadon";
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
