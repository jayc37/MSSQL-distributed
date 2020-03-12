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
    public partial class formBAN : Form
    {
        #region khai báo
        // Chuỗi kết nối
        string connectionString;
        SqlConnection conn = null;
        SqlDataAdapter daban = null;
        DataTable dtban = null;

        SqlDataAdapter daphancong = null;
        DataTable dtphancong = null;
        bool Them;

        #endregion
        public formBAN(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
        }
        //
        private void resetValue()
        {
            // Xóa trống các đối tượng trong Panel
            cbBan.DataSource = new List<string> { "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9", "B10" };
            cbcaphucvu.DataSource = new List<string> { "Ca Sáng", "Ca Chiều", "Ca Tối" };
            this.txtidnv.ResetText();
            NSLK.Value = 0;
        }
        void load_data()
        {
            try
            {
                conn = new SqlConnection(connectionString);
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                // Vận chuyển dữ liệu vào DataTable dtThanhPho  
                //daThanhPho = new SqlDataAdapter("SELECT * FROM THANHPHO", conn);
                //dtThanhPho = new DataTable();
                //dtThanhPho.Clear();
                //daThanhPho.Fill(dtThanhPho);
                //// Đưa dữ liệu lên ComboBox trong DataGridView  
                //(dataGridView1.Columns["Column4"] as DataGridViewComboBoxColumn).DataSource = dtThanhPho;
                //(dataGridView1.Columns["Column4"] as DataGridViewComboBoxColumn).DisplayMember = "TenThanhPho";
                //(dataGridView1.Columns["Column4"] as DataGridViewComboBoxColumn).ValueMember = "ThanhPho";
                // Vận chuyển dữ liệu lên DataTable dtKhachHang  
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                daban = new SqlDataAdapter("sp_get_ban", conn);
                dtban = new DataTable();
                dtban.Clear();
                daban.Fill(dtban);
                dgvBAN.DataSource = dtban;
                resetValue();
                dgvPHANCONG.Hide();
                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;
                this.panel.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.button3.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } // hàm load dữ liệu
        private void DgvKHACHHANG_Load(object sender, EventArgs e)
        {
            load_data();
        } // load dữ liệu lên form
        #region button
        private void Button1_Click(object sender, EventArgs e)
        {
            //tên hiển thị trên app : Reload

            load_data();
        }//reload data

        private void Button2_Click(object sender, EventArgs e)
        {
            //tên hiển thị trên app : thoát


            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp 
            traloi = MessageBox.Show("Chắc không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Ok không? 
            if (traloi == DialogResult.OK) Application.Exit();
        }//button thoát

        private void Button3_Click(object sender, EventArgs e)
        {
            //tên hiển thị trên app : Xóa
            // Mở kết nối  
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            //try
            //{
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            // Lấy thứ tự record hiện hành 
            int i = dgvPHANCONG.CurrentCell.RowIndex;
            // Lấy MaKH của record hiện hành 
            string strIDBAN = dgvPHANCONG.Rows[i].Cells[0].Value.ToString();
            // Viết câu lệnh SQL  
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_xoa_phucvuban";
            cmd.Parameters.Add(new SqlParameter("@idban", strIDBAN));
            // Thực hiện lệnh  
            // Hiện thông báo xác nhận việc xóa mẫu tin  
            // Khai báo biến traloi 
            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp 
            traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Ok không?  
            if (traloi == DialogResult.Yes)
            {
                // Thực hiện câu lệnh SQL 
                cmd.ExecuteNonQuery();
                // Cập nhật lại DataGridView  
                load_data();
                // Thông báo 
                MessageBox.Show("Đã xóa xong!");
            }
            else
            {
                // Thông báo 
                MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
            }
            //}
            //catch (SqlException)
            //{ MessageBox.Show("Không xóa được. Lỗi rồi!!!"); }
            // Đóng kết nối
            //conn.Close();
        }//button xóa

        private void DgvBAN_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Giải phóng tài nguyên
            dtban.Dispose();
            dtban = null;
            // Hủy kết nối
            conn = null;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them
            Them = true;
            // Xóa trống các đối tượng trong Panel
            resetValue();
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.button3.Enabled = false;

            // Đưa dữ liệu lên ComboBox
            //this.txtsodienthoai.DataSource = dtThanhPho;
            //this.txtsodienthoai.DisplayMember = "TenThanhPho";
            //this.txtsodienthoai.ValueMember = "ThanhPho";
            // Đưa con trỏ đến TextField txtMaKH
            this.cbBan.Focus();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa
            Them = false;
            // Cho phép thao tác trên Panel
            this.panel.Enabled = true;
            // Thứ tự dòng hiện hành
            int i = dgvBAN.CurrentCell.RowIndex;
            int r = dgvPHANCONG.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.cbBan.Text = dgvPHANCONG.Rows[r].Cells[0].Value.ToString();
            this.cbcaphucvu.Text = dgvPHANCONG.Rows[r].Cells[2].Value.ToString();
            this.NSLK.Text = dgvPHANCONG.Rows[r].Cells[3].Value.ToString();
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.button3.Enabled = false;
            // Đưa con trỏ đến TextField txtMaKH
            this.cbBan.Focus();
        }
        private void btnLuu_Click(object sender, EventArgs e)
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

                    cmd.Parameters.Add(new SqlParameter("@IDBAN", cbBan.Text));
                    cmd.Parameters.Add(new SqlParameter("@IDNHANVIEN", txtidnv.Text));
                    cmd.Parameters.Add(new SqlParameter("@CAPHUCVU", cbcaphucvu.Text));
                    cmd.Parameters.Add(new SqlParameter("@SLK", NSLK.Text));

                    cmd.CommandText = "sp_Them_phucvuban";
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
                    int r = dgvPHANCONG.CurrentCell.RowIndex;
                    // MaKH hiện hành
                    string stridban =
                    dgvPHANCONG.Rows[r].Cells[0].Value.ToString();


                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@IDBAN", stridban));
                    cmd.Parameters.Add(new SqlParameter("@IDNHANVIEN", txtidnv.Text));
                    cmd.Parameters.Add(new SqlParameter("@CAPHUCVU", cbcaphucvu.Text));
                    cmd.Parameters.Add(new SqlParameter("@SLK", NSLK.Text));

                    cmd.CommandText = "sp_Sua_phucvuban";
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
        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel
            resetValue();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.button3.Enabled = true;

            // Không cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            this.panel.Enabled = false;
        }
        #endregion

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
        private void btnxem_Click(object sender, EventArgs e)
        {
            try
            {
                dgvPHANCONG.Show();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                // Lấy thứ tự record hiện hành 
                int i = dgvBAN.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành 
                string stridban = dgvBAN.Rows[i].Cells[0].Value.ToString();
                // Viết câu lệnh SQL  
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_get_phucvuban";
                cmd.Parameters.Add(new SqlParameter("@idban", stridban));
                cmd.CommandType = CommandType.StoredProcedure;
                dtphancong = new DataTable();
                dtphancong.Clear();
                daphancong = new SqlDataAdapter();
                daphancong.SelectCommand = cmd;
                daphancong.Fill(dtphancong);
                dgvPHANCONG.DataSource = dtphancong;
            }
            catch
            {
                MessageBox.Show("Có lỗi xãy ra");
            }
        }
    }
}
