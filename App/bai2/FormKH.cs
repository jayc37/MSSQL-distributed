using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai2
{
    public partial class dgvKHACHHANG : Form
    {
        // Chuỗi kết nối
        string connectionString;
        SqlConnection conn = null;
        SqlDataAdapter daKhachHang = null;
        DataTable dtKhachHang = null;
        //SqlDataAdapter daThanhPho = null;
        //DataTable dtThanhPho = null;
        bool Them;

        public dgvKHACHHANG(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            load_data();
        }
        //
        void load_data()
        {
            try
            {
                conn = new SqlConnection(connectionString);
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                daKhachHang = new SqlDataAdapter("sp_get_Khachhang", conn);
                dtKhachHang = new DataTable();
                dtKhachHang.Clear();
                daKhachHang.Fill(dtKhachHang);

                dataGridView1.DataSource = dtKhachHang;
                // Xóa trống các đối tượng trong Panel
                this.txtMaKH.ResetText();
                this.txtHoTenKH.ResetText();
                this.txtDiaChi.ResetText();
                this.txtSoDienThoai.ResetText();
                this.txtfax.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy
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
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                // Lấy thứ tự record hiện hành 
                int i = dataGridView1.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành 
                string strMAKH = dataGridView1.Rows[i].Cells[1].Value.ToString();
                // Viết câu lệnh SQL  
                cmd.CommandText = "sp_Xoa_KhachHang";
                cmd.Parameters.Add(new SqlParameter("@idkhachhang",strMAKH));
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // Đóng kết nối
            conn.Close();
        }//button xóa


        private void DgvKHACHHANG_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Giải phóng tài nguyên
            dtKhachHang.Dispose();
            dtKhachHang = null;
            // Hủy kết nối
            conn = null;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them
            Them = true;
            // Xóa trống các đối tượng trong Panel
            this.txtMaKH.ResetText();
            this.txtHoTenKH.ResetText();
            this.txtDiaChi.ResetText();
            this.txtfax.ResetText();
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.button3.Enabled = false;
            
            this.txtMaKH.Focus();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa
            Them = false;

            this.txtMaKH.Enabled = false;
            this.panel.Enabled = true;
            // Thứ tự dòng hiện hành
            int r = dataGridView1.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtMaKH.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            this.txtHoTenKH.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
            this.txtDiaChi.Text = dataGridView1.Rows[r].Cells[2].Value.ToString();
            this.txtSoDienThoai.Text = dataGridView1.Rows[r].Cells[3].Value.ToString();
            this.txtfax.Text = dataGridView1.Rows[r].Cells[4].Value.ToString();
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.button3.Enabled = false;
            // Đưa con trỏ đến TextField txtMaKH
            this.txtMaKH.Focus();
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

                    cmd.Parameters.Add(new SqlParameter("@MaKH", txtMaKH.Text));
                    cmd.Parameters.Add(new SqlParameter("@HoTenKH", txtHoTenKH.Text));
                    cmd.Parameters.Add(new SqlParameter("@DiaChi", txtDiaChi.Text));
                    cmd.Parameters.Add(new SqlParameter("@DienThoai", txtSoDienThoai.Text));
                    cmd.Parameters.Add(new SqlParameter("@Fax", txtfax.Text));
                    
                    cmd.CommandText = "sp_Them_KhachHang";
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
                    int r = dataGridView1.CurrentCell.RowIndex;
                    // MaKH hiện hành
                    string strMAKH =
                    dataGridView1.Rows[r].Cells[0].Value.ToString();


                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@HoTenKH", txtHoTenKH.Text));
                    cmd.Parameters.Add(new SqlParameter("@DiaChi", txtDiaChi.Text));
                    cmd.Parameters.Add(new SqlParameter("@DienThoai", txtSoDienThoai.Text));
                    cmd.Parameters.Add(new SqlParameter("@Fax", txtfax.Text));
                    cmd.Parameters.Add(new SqlParameter("@MaKH", strMAKH));
                    
                    // Cập nhật
                    cmd.CommandText = "sp_sua_KhachHang";
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
            this.txtMaKH.ResetText();
            this.txtMaKH.Enabled = true;
            this.txtHoTenKH.ResetText();
            this.txtDiaChi.ResetText();
            this.txtSoDienThoai.ResetText();
            this.txtfax.ResetText();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}