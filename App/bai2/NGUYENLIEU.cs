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
    public partial class formNGUYENLIEU : Form
    {
        #region khai báo
        // Chuỗi kết nối
        string connectionString;
        SqlConnection conn = null;
        // Khai báo -- LOAINGUYENLIEU
        SqlDataAdapter daloainguyenlieu = null;
        DataTable dtloainguyenlieu = null;
        //khai báo  -- NGUYENLIEU
        SqlDataAdapter danguyenlieu = null;
        DataTable dtnguyenlieu = null;
        //khai báo  -- CHITIETKHO
        SqlDataAdapter dactkho = null;
        DataTable dtctkho = null;
        bool Them;

        #endregion
        public formNGUYENLIEU(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
        }
        //
        #region resetvalues
        private void resetValue_loainguyenlieu()
        {
            this.txtidloainguyenlieu.ResetText();
            this.txttennguyenlieu.ResetText();
        }
        private void HIDE()
        {
            //hide gridview
            panel_edit_loainguyenlieu.Hide();
            panel_edit_nguyenlieu.Hide();
            panel_loainguyenlieu.Enabled = false;
            panel_nguyenlieu.Enabled = false;
            panel_edit_nguyenlieu.Enabled = false;
            panel_edit_loainguyenlieu.Enabled = false;
            dgvchitietkho.Hide();
            dgvnguyenlieu.Hide();
            //hide button
            btnNL.Hide();
            btnXemHangton.Hide();
            btntonkho.Hide();
            panel_nguyenlieu.Hide();
            panel_loainguyenlieu.Hide();
        }
        private void resetValue_nguyenlieu()
        {
            this.txtidnguyenlieu.ResetText();
            this.txttennguyenlieu.ResetText();
            this.txtdvtinh.ResetText();
            this.txtgianhap.ResetText();
            cbtrangthai.DataSource = new List<string> { "Còn hàng", "Hết hàng"};
            this.txtdvtinh.ResetText();
            cbidloainguyenlieu.DataSource = new List<string> { "NLM", "NLN" };
            NSL.Value = 0;
            this.txtdvtinh.ResetText();
            this.richtxtmota.ResetText();
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
                daloainguyenlieu = new SqlDataAdapter("sp_get_loainguyenlieu", conn);
                dtloainguyenlieu = new DataTable();
                dtloainguyenlieu.Clear();
                daloainguyenlieu.Fill(dtloainguyenlieu);
                dgvLoainguyenlieu.DataSource = dtloainguyenlieu;
                resetValue_loainguyenlieu();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } // hàm load dữ liệu
        private void formNGUYENLIEU_Load(object sender, EventArgs e)
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
        private void DgvNGUYENLIEU_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Giải phóng tài nguyên
            dtnguyenlieu.Dispose();
            dtnguyenlieu = null;
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
        //BUTTON hiển thị table NGUYENLIEU
        private void btnxem_Click(object sender, EventArgs e)
        {
            try
            {
                dgvnguyenlieu.Show();
                btnNL.Show();
                btnXemHangton.Show();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                // Lấy thứ tự record hiện hành 
                int i = dgvLoainguyenlieu.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành 
                string strIDLOAINL = dgvLoainguyenlieu.Rows[i].Cells[0].Value.ToString();
                // Viết câu lệnh SQL  
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_get_nguyenlieu";
                cmd.Parameters.Add(new SqlParameter("@idloainguyenlieu", strIDLOAINL));
                cmd.CommandType = CommandType.StoredProcedure;
                dtnguyenlieu = new DataTable();
                dtnguyenlieu.Clear();
                danguyenlieu = new SqlDataAdapter();
                danguyenlieu.SelectCommand = cmd;
                danguyenlieu.Fill(dtnguyenlieu);
                dgvnguyenlieu.DataSource = dtnguyenlieu;
            }
            catch
            {
                MessageBox.Show("click vào loại nguyên liệu muốn xem");
            }
        }
        // button hiển thị CHITIETKHO
        private void btnXemHangton_Click(object sender, EventArgs e)
        {
            try
            {
                dgvchitietkho.Show();
                btntonkho.Show();

                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                // Lấy thứ tự record hiện hành 
                int i = dgvnguyenlieu.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành 
                string strIDNGUYENLIEU = dgvnguyenlieu.Rows[i].Cells[0].Value.ToString();
                // Viết câu lệnh SQL  
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_get_chitietho";
                cmd.Parameters.Add(new SqlParameter("@tennguyenlieu", strIDNGUYENLIEU));
                cmd.CommandType = CommandType.StoredProcedure;
                dtctkho = new DataTable();
                dtctkho.Clear();
                dactkho = new SqlDataAdapter();
                dactkho.SelectCommand = cmd;
                dactkho.Fill(dtctkho);
                dgvchitietkho.DataSource = dtctkho;
            }
            catch
            {
                MessageBox.Show("click vào nguyên liệu muốn xem");
            }

        }
        //
        private void btnNL_Click(object sender, EventArgs e)
        {
            panel_loainguyenlieu.Hide();
            panel_edit_loainguyenlieu.Hide();
            panel_nguyenlieu.Show();
            panel_edit_nguyenlieu.Show();
            panel_edit_nguyenlieu.Enabled = true;
            btnluunguyenlieu.Enabled = false;
            btnhuynguyenlieu.Enabled = false;
        }
        //button loại nguyên liêu: hiển thị panel thao tác trên loại nguyên liệu
        private void btnLNL_Click(object sender, EventArgs e)
        {
            panel_nguyenlieu.Hide();
            panel_edit_nguyenlieu.Hide();
            panel_loainguyenlieu.Show();
            panel_edit_loainguyenlieu.Show();
            panel_edit_loainguyenlieu.Enabled = true;
            btnluuloainl.Enabled = false;
            btnhuyloainl.Enabled = false;
        }
#endregion

        #region LOAINGUYENLIEU
        //thêm
        private void btnthemloainl_Click(object sender, EventArgs e)
        {
            Them = true;

            this.panel_loainguyenlieu.Enabled = true;
            resetValue_loainguyenlieu();
            btnsualoainl.Enabled = false;
            btnluuloainl.Enabled = true;
            btnhuyloainl.Enabled = true;
            btnxoalnl.Enabled = false;
        }

        private void btnhuyloainl_Click(object sender, EventArgs e)
        {
            resetValue_loainguyenlieu();
            this.panel_loainguyenlieu.Enabled = false;
            this.btnthemloainl.Enabled = true;
            this.btnsualoainl.Enabled = true;
            this.btnxoalnl.Enabled = true;
            this.btnhuyloainl.Enabled = false;
            this.btnluuloainl.Enabled = false;
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
                int i = dgvLoainguyenlieu.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành 
                string strIDLNL = dgvLoainguyenlieu.Rows[i].Cells[0].Value.ToString();
                // Viết câu lệnh SQL  
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_xoa_loainguyenlieu";
                cmd.Parameters.Add(new SqlParameter("@idloainguyenlieu", strIDLNL));
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
            this.panel_loainguyenlieu.Enabled = true;
            resetValue_loainguyenlieu();
            int r = dgvLoainguyenlieu.CurrentCell.RowIndex;
            this.txtidloainguyenlieu.Text = dgvLoainguyenlieu.Rows[r].Cells[0].Value.ToString();
            this.txttennguyenlieu.Text = dgvLoainguyenlieu.Rows[r].Cells[1].Value.ToString();
            btnthemloainl.Enabled = false;
            btnluuloainl.Enabled = true;
            btnhuyloainl.Enabled = true;
            btnxoalnl.Enabled = false;
            this.tenloainguyenlieu.Focus();
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

                    cmd.Parameters.Add(new SqlParameter("@idloainguyenlieu", txtidloainguyenlieu.Text));
                    cmd.Parameters.Add(new SqlParameter("@tenloainguyenlieu", tenloainguyenlieu.Text));

                    cmd.CommandText = "sp_Them_loainguyenlieu";
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
                    int r = dgvLoainguyenlieu.CurrentCell.RowIndex;
                    // MaKH hiện hành
                    string stridloainguyenlieu =
                    dgvLoainguyenlieu.Rows[r].Cells[0].Value.ToString();


                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@idloainguyenlieu", txtidloainguyenlieu.Text));
                    cmd.Parameters.Add(new SqlParameter("@tenloainguyenlieu", tenloainguyenlieu.Text));

                    cmd.CommandText = "sp_Sua_loainguyenlieu";
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
        #region NGUYENLIEU

        private void btnthemnguyenlieu_Click(object sender, EventArgs e)
        {
            Them = true;

            panel_nguyenlieu.Enabled = true;
            resetValue_nguyenlieu();
            btnsuanguyenlieu.Enabled = false;
            btnxoanguyenlieu.Enabled = false;
            btnluunguyenlieu.Enabled = true;
            btnhuynguyenlieu.Enabled = true;
            this.txtidnguyenlieu.Focus();
        }

        private void btnsuanguyenlieu_Click(object sender, EventArgs e)
        {
            Them = false;
            try 
            {
            this.panel_nguyenlieu.Enabled = true;
            resetValue_nguyenlieu();
            btnthemnguyenlieu.Enabled = false;
            btnxoanguyenlieu.Enabled = false;
            btnluunguyenlieu.Enabled = true;
            btnhuynguyenlieu.Enabled = true;

            int r = dgvnguyenlieu.CurrentCell.RowIndex;

            this.txtidnguyenlieu.ResetText();
            this.txttennguyenlieu.Text = dgvnguyenlieu.Rows[r].Cells[0].Value.ToString();
            this.cbtrangthai.Text = dgvnguyenlieu.Rows[r].Cells[1].Value.ToString();
            this.txtdvtinh.Text = dgvnguyenlieu.Rows[r].Cells[4].Value.ToString();
                this.cbidloainguyenlieu.ResetText();
            this.txtgianhap.Text = dgvnguyenlieu.Rows[r].Cells[5].Value.ToString();
            this.richtxtmota.Text = dgvnguyenlieu.Rows[r].Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnhuynguyenlieu_Click(object sender, EventArgs e)
        {
            resetValue_nguyenlieu();
            this.panel_nguyenlieu.Enabled = true;
            this.btnthemnguyenlieu.Enabled = true;
            this.btnsuanguyenlieu.Enabled = true;
            this.btnxoalnl.Enabled = true;
            this.btnhuynguyenlieu.Enabled = false;
            this.btnluunguyenlieu.Enabled = false;
        }

        private void btnxoanguyenlieu_Click(object sender, EventArgs e)
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
                int i = dgvLoainguyenlieu.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành 
                string strIDNL = dgvLoainguyenlieu.Rows[i].Cells[0].Value.ToString();
                // Viết câu lệnh SQL  
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_xoa_nguyenlieu";
                cmd.Parameters.Add(new SqlParameter("@idnguyenlieu", strIDNL));
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
        private void btnluunguyenlieu_Click(object sender, EventArgs e)
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
                    cmd.Parameters.Add(new SqlParameter("@idnguyenlieu", txtidnguyenlieu.Text));
                    cmd.Parameters.Add(new SqlParameter("@tennguyenlieu", txttennguyenlieu.Text));
                    cmd.Parameters.Add(new SqlParameter("@trangthai", cbtrangthai.Text));
                    cmd.Parameters.Add(new SqlParameter("@donvitinh", txtdvtinh.Text));
                    cmd.Parameters.Add(new SqlParameter("@idloainguyenlieu", cbidloainguyenlieu.Text));
                    cmd.Parameters.Add(new SqlParameter("@soluong", NSL.Text));
                    cmd.Parameters.Add(new SqlParameter("@gianhap", txtgianhap.Text));
                    cmd.Parameters.Add(new SqlParameter("@mota", richtxtmota.Text));

                    cmd.CommandText = "sp_Them_nguyenlieu";
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
                    int r = dgvLoainguyenlieu.CurrentCell.RowIndex;
                    // MaKH hiện hành
                    string stridnguyenlieu =
                    dgvLoainguyenlieu.Rows[r].Cells[0].Value.ToString();


                    cmd.Parameters.Add(new SqlParameter("@idnguyenlieu", txtidnguyenlieu));
                    cmd.Parameters.Add(new SqlParameter("@tennguyenlieu", txttennguyenlieu.Text));
                    cmd.Parameters.Add(new SqlParameter("@trangthai", cbtrangthai.Text));
                    cmd.Parameters.Add(new SqlParameter("@donvitinh", txtdvtinh.Text));
                    cmd.Parameters.Add(new SqlParameter("@idloainguyenlieu", cbidloainguyenlieu.Text));
                    cmd.Parameters.Add(new SqlParameter("@soluong", NSL.Text));
                    cmd.Parameters.Add(new SqlParameter("@gianhap", txtgianhap.Text));
                    cmd.Parameters.Add(new SqlParameter("@mota", richtxtmota.Text));

                    cmd.CommandText = "sp_sua_nguyenlieu";
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
