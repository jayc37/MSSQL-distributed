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
    public partial class NHANVIEN : Form
    {
        #region khai báo
        // Chuỗi kết nối
        string connectionString;
        SqlConnection conn = null;
        SqlDataAdapter daKhachHang = null;
        DataTable dtKhachHang = null;
        List<Class.NHANVIEN> listNV;
        //SqlDataAdapter daThanhPho = null;
        //DataTable dtThanhPho = null;
        bool Them;

        #endregion
        public NHANVIEN(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            resetValue();
        }

        private void resetValue()
        {
            // Xóa trống các đối tượng trong Panel
            cboLoaiNV.DataSource = new List<string> { "Biên chế", "Không biên chế" };
            this.txtMaNV.ResetText();
            this.txtHoTen.ResetText();
            numLuong.Value = 0;

            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = true;
            //this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = false;
            this.button3.Enabled = true;
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
                daKhachHang = new SqlDataAdapter("sp_get_nhanvien", conn);
                dtKhachHang = new DataTable();
                dtKhachHang.Clear();
                daKhachHang.Fill(dtKhachHang);

                dataGridView1.DataSource = dtKhachHang;

                resetValue();

                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;

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
            load_data();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
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
                cmd.CommandText = "sp_Xoa_nhanvien";
                cmd.Parameters.Add(new SqlParameter("@manv",strMAKH));
                
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
            this.txtMaNV.ResetText();
            this.txtHoTen.ResetText();
            numLuong.Value = 0;

            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            //this.panel.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.button3.Enabled = false;
            
            // Đưa dữ liệu lên ComboBox
            //this.txtsodienthoai.DataSource = dtThanhPho;
            //this.txtsodienthoai.DisplayMember = "TenThanhPho";
            //this.txtsodienthoai.ValueMember = "ThanhPho";
            // Đưa con trỏ đến TextField txtMaKH
            //this.txtMaKH.Focus();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa
            //Them = false;
            //// Đưa dữ liệu lên ComboBox
            ////this.txtsodienthoai.DataSource = dtThanhPho;
            ////this.txtsodienthoai.DisplayMember = "TenThanhPho";
            ////this.txtsodienthoai.ValueMember = "ThanhPho";
            //// Cho phép thao tác trên Panel
            //panel.Enabled = true;
            //// Thứ tự dòng hiện hành
            //int r = dataGridView1.CurrentCell.RowIndex;
            //var nv = (Class.NHANVIEN)dataGridView1.Rows[r];
            //// Chuyển thông tin lên panel
            ///
            ///
            //txtMaNV.Text = nv.MANV;
            //txtMaNV.Enabled = false;
            //txtHoTen.Text = nv.HOTENNV;
            //checkNam.Checked = nv.GIOITINH;
            //cboLoaiNV.SelectedIndex = nv.LOAINV == "Bien che" ? 0 : 1;
            //numLuong.Value = nv.LUONGCB;
            //txtNote.Text = nv.GHICHU;
            //dateNgaySinh.Value = nv.NGAYSINH;
            //// Cho thao tác trên các nút Lưu / Hủy / Panel
            //this.btnLuu.Enabled = true;
            //this.btnHuy.Enabled = true;
            //this.panel.Enabled = true;
            //// Không cho thao tác trên các nút Thêm / Xóa / Thoát
            //this.btnThem.Enabled = false;
            //this.btnSua.Enabled = false;
            //
            //this.button3.Enabled = false;
            //// Đưa con trỏ đến TextField txtMaKH
            //this.txtMaKH.Focus();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);
            // Mở kết nối
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            // Thêm dữ liệu
            //if (Them)
            //{
            //    try
            //    {
            //        // Thực hiện lệnh
            //        SqlCommand cmd = new SqlCommand();
            //        cmd.Connection = conn;
            //        cmd.CommandType = CommandType.StoredProcedure;
            //        cmd.CommandText = "sp_Them_khachhang";
            //        cmd.Parameters.Add(new SqlParameter("@MaKH", txtMaKH.Text));
            //        cmd.Parameters.Add(new SqlParameter("@HoTenKH", txtHoTenKH.Text));
            //        cmd.Parameters.Add(new SqlParameter("@DiaChi", txtDiaChi.Text));
            //        cmd.Parameters.Add(new SqlParameter("@DienThoai", txtSoDienThoai.Text));
            //        cmd.Parameters.Add(new SqlParameter("@Fax", txtfax.Text));
            //        // Lệnh Insert InTo
            //        //cmd.CommandText = System.String.Concat("Insert Into KhachHang Values(" + "'" +
            //        //this.txtMaKH.Text.ToString() + "',N'" +
            //        //this.txtTenCty.Text.ToString() + "',N'" +
            //        //this.txtDiaChi.Text.ToString() + "','" +
            //        //this.cbThanhPho.SelectedValue.ToString() +
            //        //"','" + this.txtDienThoai.Text.ToString() +
            //        //"')");
            //        cmd.CommandText = "sp_Them_KhachHang";
            //        cmd.ExecuteNonQuery();
            //        // Load lại dữ liệu trên DataGridView
            //        load_data();
            //        // Thông báo
            //        MessageBox.Show("Đã thêm xong!");
            //    }
            //    catch (SqlException)
            //    {
            //        MessageBox.Show("Không thêm được. Lỗi rồi!");
            //    }
            //}
            //if (!Them)
            //{
            //    try
            //    {
            //        // Thực hiện lệnh
            //        SqlCommand cmd = new SqlCommand();
            //        cmd.Connection = conn;

            //        // Thứ tự dòng hiện hành
            //        int r = dataGridView1.CurrentCell.RowIndex;
            //        // MaKH hiện hành
            //        string strMAKH =
            //        dataGridView1.Rows[r].Cells[0].Value.ToString();


            //        cmd.CommandType = CommandType.StoredProcedure;
            //        cmd.CommandText = "sp_Sua_KhachHang";

            //        cmd.Parameters.Add(new SqlParameter("@HoTenKH", txtHoTenKH.Text));
            //        cmd.Parameters.Add(new SqlParameter("@DiaChi", txtDiaChi.Text));
            //        cmd.Parameters.Add(new SqlParameter("@DienThoai", txtSoDienThoai.Text));
            //        cmd.Parameters.Add(new SqlParameter("@Fax", txtfax.Text));
            //        cmd.Parameters.Add(new SqlParameter("@MaKH", strMAKH));
            //        // Câu lệnh SQL
            //        //cmd.CommandText = System.String.Concat("Update KhachHang Set TenCty=N'" +
            //        //this.txtHoTenKH.Text.ToString() + "', DiaChi=N'"
            //        //+ this.txtDiaChi.Text.ToString() + "', ThanhPho='" +
            //        //this.txtsodienthoai.SelectedValue.ToString() + "', DienThoai='" +
            //        //this.txtfax.Text.ToString() + "' Where MaKH='" + strMAKH + "'");
            //        // Cập nhật
            //        cmd.CommandText = "sp_Sua_KhachHang";
            //        cmd.ExecuteNonQuery();
            //        // Load lại dữ liệu trên DataGridView
            //        load_data();
            //        // Thông báo
            //        MessageBox.Show("Đã sửa xong!");
            //    }
            //    catch (SqlException)
            //    {
            //        MessageBox.Show("Không sửa được. Lỗi rồi!");
            //    }
            //}
            //// Đóng kết nối
            //conn.Close();
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            //// Xóa trống các đối tượng trong Panel
            //this.txtMaKH.ResetText();
            //this.txtHoTenKH.ResetText();
            //this.txtDiaChi.ResetText();
            //this.txtSoDienThoai.ResetText();
            //this.txtfax.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.button3.Enabled = true;
            
            // Không cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            //this.panel.Enabled = false;
        }
        #endregion

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}