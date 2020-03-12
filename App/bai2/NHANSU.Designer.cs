namespace bai2
{
    partial class formNHANSU
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_bophan = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_get_bophan = new System.Windows.Forms.Panel();
            this.txtten_khoa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtid_khoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_huy_bophan = new System.Windows.Forms.Button();
            this.btn_luu_bophan = new System.Windows.Forms.Button();
            this.btn_sua_bophan = new System.Windows.Forms.Button();
            this.btn_them_bophan = new System.Windows.Forms.Button();
            this.btn_xoa_bophan = new System.Windows.Forms.Button();
            this.txt_ngaysinh = new System.Windows.Forms.TextBox();
            this.dgv_nhanvien = new System.Windows.Forms.DataGridView();
            this.HDNHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bnbb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_xem_nhanvien = new System.Windows.Forms.Button();
            this.btn_click_sinhvien = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel_get_nhanvien = new System.Windows.Forms.Panel();
            this.txt_hinhanh = new System.Windows.Forms.TextBox();
            this.txt_khoahoc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_lylich = new System.Windows.Forms.TextBox();
            this.txt_noisinh_sinhvien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtid_Sinhvien = new System.Windows.Forms.TextBox();
            this.txt_ten_sinhvien = new System.Windows.Forms.TextBox();
            this.txt_dchi_sinhvien = new System.Windows.Forms.TextBox();
            this.btn_huy_nhanvien = new System.Windows.Forms.Button();
            this.btn_luu_nhanvien = new System.Windows.Forms.Button();
            this.btn_sua_nhanvien = new System.Windows.Forms.Button();
            this.btn_them_nhanvien = new System.Windows.Forms.Button();
            this.btn_xoa_nhanvien = new System.Windows.Forms.Button();
            this.btn_click_khoa = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.panel_edit_Bophan = new System.Windows.Forms.Panel();
            this.panel_edit_nhanvien = new System.Windows.Forms.Panel();
            this.txt_gioitinh = new System.Windows.Forms.TextBox();
            this.ca = new System.Windows.Forms.Label();
            this.txt_tenkhoa = new System.Windows.Forms.TextBox();
            this.txtidlop = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bophan)).BeginInit();
            this.panel_get_bophan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhanvien)).BeginInit();
            this.panel_get_nhanvien.SuspendLayout();
            this.panel_edit_Bophan.SuspendLayout();
            this.panel_edit_nhanvien.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_bophan
            // 
            this.dgv_bophan.AllowUserToAddRows = false;
            this.dgv_bophan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bophan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgv_bophan.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_bophan.Location = new System.Drawing.Point(9, 423);
            this.dgv_bophan.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_bophan.Name = "dgv_bophan";
            this.dgv_bophan.RowHeadersWidth = 51;
            this.dgv_bophan.RowTemplate.Height = 24;
            this.dgv_bophan.Size = new System.Drawing.Size(357, 292);
            this.dgv_bophan.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "khoa_id";
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "IDKHOA";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tenkhoa";
            this.Column2.HeaderText = "TENKHOA";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // panel_get_bophan
            // 
            this.panel_get_bophan.Controls.Add(this.txtten_khoa);
            this.panel_get_bophan.Controls.Add(this.label5);
            this.panel_get_bophan.Controls.Add(this.txtid_khoa);
            this.panel_get_bophan.Controls.Add(this.label1);
            this.panel_get_bophan.Location = new System.Drawing.Point(3, 59);
            this.panel_get_bophan.Margin = new System.Windows.Forms.Padding(2);
            this.panel_get_bophan.Name = "panel_get_bophan";
            this.panel_get_bophan.Size = new System.Drawing.Size(507, 178);
            this.panel_get_bophan.TabIndex = 14;
            // 
            // txtten_khoa
            // 
            this.txtten_khoa.Location = new System.Drawing.Point(263, 55);
            this.txtten_khoa.Name = "txtten_khoa";
            this.txtten_khoa.Size = new System.Drawing.Size(100, 20);
            this.txtten_khoa.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-3, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "tênkhoa";
            // 
            // txtid_khoa
            // 
            this.txtid_khoa.Location = new System.Drawing.Point(263, 29);
            this.txtid_khoa.Name = "txtid_khoa";
            this.txtid_khoa.Size = new System.Drawing.Size(100, 20);
            this.txtid_khoa.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "idkhoa";
            // 
            // btn_huy_bophan
            // 
            this.btn_huy_bophan.Location = new System.Drawing.Point(224, 0);
            this.btn_huy_bophan.Margin = new System.Windows.Forms.Padding(2);
            this.btn_huy_bophan.Name = "btn_huy_bophan";
            this.btn_huy_bophan.Size = new System.Drawing.Size(56, 19);
            this.btn_huy_bophan.TabIndex = 53;
            this.btn_huy_bophan.Text = "hủy";
            this.btn_huy_bophan.UseVisualStyleBackColor = true;
            this.btn_huy_bophan.Click += new System.EventHandler(this.btnhuyloainl_Click);
            // 
            // btn_luu_bophan
            // 
            this.btn_luu_bophan.Location = new System.Drawing.Point(152, 2);
            this.btn_luu_bophan.Margin = new System.Windows.Forms.Padding(2);
            this.btn_luu_bophan.Name = "btn_luu_bophan";
            this.btn_luu_bophan.Size = new System.Drawing.Size(56, 19);
            this.btn_luu_bophan.TabIndex = 52;
            this.btn_luu_bophan.Text = "lưu";
            this.btn_luu_bophan.UseVisualStyleBackColor = true;
            this.btn_luu_bophan.Click += new System.EventHandler(this.btnluuloainl_Click);
            // 
            // btn_sua_bophan
            // 
            this.btn_sua_bophan.Location = new System.Drawing.Point(71, 2);
            this.btn_sua_bophan.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sua_bophan.Name = "btn_sua_bophan";
            this.btn_sua_bophan.Size = new System.Drawing.Size(56, 19);
            this.btn_sua_bophan.TabIndex = 51;
            this.btn_sua_bophan.Text = "sửa";
            this.btn_sua_bophan.UseVisualStyleBackColor = true;
            this.btn_sua_bophan.Click += new System.EventHandler(this.btnsualoainl_Click);
            // 
            // btn_them_bophan
            // 
            this.btn_them_bophan.Location = new System.Drawing.Point(2, 2);
            this.btn_them_bophan.Margin = new System.Windows.Forms.Padding(2);
            this.btn_them_bophan.Name = "btn_them_bophan";
            this.btn_them_bophan.Size = new System.Drawing.Size(56, 19);
            this.btn_them_bophan.TabIndex = 50;
            this.btn_them_bophan.Text = "thêm";
            this.btn_them_bophan.UseVisualStyleBackColor = true;
            this.btn_them_bophan.Click += new System.EventHandler(this.btnthemloainl_Click);
            // 
            // btn_xoa_bophan
            // 
            this.btn_xoa_bophan.Location = new System.Drawing.Point(296, 2);
            this.btn_xoa_bophan.Margin = new System.Windows.Forms.Padding(2);
            this.btn_xoa_bophan.Name = "btn_xoa_bophan";
            this.btn_xoa_bophan.Size = new System.Drawing.Size(56, 19);
            this.btn_xoa_bophan.TabIndex = 49;
            this.btn_xoa_bophan.Text = "xóa";
            this.btn_xoa_bophan.UseVisualStyleBackColor = true;
            this.btn_xoa_bophan.Click += new System.EventHandler(this.btnxoalnl_Click);
            // 
            // txt_ngaysinh
            // 
            this.txt_ngaysinh.Location = new System.Drawing.Point(525, 33);
            this.txt_ngaysinh.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ngaysinh.Name = "txt_ngaysinh";
            this.txt_ngaysinh.Size = new System.Drawing.Size(121, 20);
            this.txt_ngaysinh.TabIndex = 21;
            // 
            // dgv_nhanvien
            // 
            this.dgv_nhanvien.AllowUserToAddRows = false;
            this.dgv_nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HDNHAP,
            this.Column6,
            this.SLK,
            this.DVT,
            this.Column3,
            this.Column4,
            this.Column5,
            this.bnbb,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgv_nhanvien.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_nhanvien.Location = new System.Drawing.Point(766, 424);
            this.dgv_nhanvien.Name = "dgv_nhanvien";
            this.dgv_nhanvien.RowHeadersWidth = 51;
            this.dgv_nhanvien.Size = new System.Drawing.Size(629, 292);
            this.dgv_nhanvien.TabIndex = 0;
            // 
            // HDNHAP
            // 
            this.HDNHAP.DataPropertyName = "sinhvien_id";
            this.HDNHAP.HeaderText = "Ma SV";
            this.HDNHAP.MinimumWidth = 6;
            this.HDNHAP.Name = "HDNHAP";
            this.HDNHAP.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "tensinhvien";
            this.Column6.HeaderText = "Tên SV";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // SLK
            // 
            this.SLK.DataPropertyName = "gioitinh";
            this.SLK.HeaderText = "Giới Tính";
            this.SLK.MinimumWidth = 6;
            this.SLK.Name = "SLK";
            this.SLK.Width = 125;
            // 
            // DVT
            // 
            this.DVT.DataPropertyName = "ngaysinh";
            this.DVT.HeaderText = "Ngày sinh";
            this.DVT.Name = "DVT";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "noisinh";
            this.Column3.HeaderText = "Nơi sinh";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "noiohientai";
            this.Column4.HeaderText = "Nơi ở hiện tại";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "khoahoc";
            this.Column5.HeaderText = "Khóa";
            this.Column5.Name = "Column5";
            // 
            // bnbb
            // 
            this.bnbb.DataPropertyName = "lylich";
            this.bnbb.HeaderText = "Lý lịch";
            this.bnbb.Name = "bnbb";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "hinhanh";
            this.Column7.HeaderText = "Hinhanh";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "tenkhoa";
            this.Column8.HeaderText = "Tên khoa";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "ID_lop";
            this.Column9.HeaderText = "IDlop";
            this.Column9.Name = "Column9";
            // 
            // btn_xem_nhanvien
            // 
            this.btn_xem_nhanvien.Location = new System.Drawing.Point(107, 722);
            this.btn_xem_nhanvien.Name = "btn_xem_nhanvien";
            this.btn_xem_nhanvien.Size = new System.Drawing.Size(99, 23);
            this.btn_xem_nhanvien.TabIndex = 16;
            this.btn_xem_nhanvien.Text = "Xem SV";
            this.btn_xem_nhanvien.UseVisualStyleBackColor = true;
            this.btn_xem_nhanvien.Click += new System.EventHandler(this.btnxem_Click);
            // 
            // btn_click_sinhvien
            // 
            this.btn_click_sinhvien.Location = new System.Drawing.Point(1016, 395);
            this.btn_click_sinhvien.Name = "btn_click_sinhvien";
            this.btn_click_sinhvien.Size = new System.Drawing.Size(150, 23);
            this.btn_click_sinhvien.TabIndex = 19;
            this.btn_click_sinhvien.Text = "SINH VIÊN";
            this.btn_click_sinhvien.UseVisualStyleBackColor = true;
            this.btn_click_sinhvien.Click += new System.EventHandler(this.btnNL_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-3, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Mã SV";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-3, 58);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Tên SV";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(402, 118);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "idlop";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(402, 5);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Khoa hoc";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 123);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Noisinh";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 91);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "diachi";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(402, 33);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "Ngaysinh";
            // 
            // panel_get_nhanvien
            // 
            this.panel_get_nhanvien.Controls.Add(this.txtidlop);
            this.panel_get_nhanvien.Controls.Add(this.txt_tenkhoa);
            this.panel_get_nhanvien.Controls.Add(this.txt_gioitinh);
            this.panel_get_nhanvien.Controls.Add(this.ca);
            this.panel_get_nhanvien.Controls.Add(this.txt_hinhanh);
            this.panel_get_nhanvien.Controls.Add(this.txt_khoahoc);
            this.panel_get_nhanvien.Controls.Add(this.label8);
            this.panel_get_nhanvien.Controls.Add(this.txt_lylich);
            this.panel_get_nhanvien.Controls.Add(this.txt_noisinh_sinhvien);
            this.panel_get_nhanvien.Controls.Add(this.label4);
            this.panel_get_nhanvien.Controls.Add(this.label3);
            this.panel_get_nhanvien.Controls.Add(this.txtid_Sinhvien);
            this.panel_get_nhanvien.Controls.Add(this.txt_ten_sinhvien);
            this.panel_get_nhanvien.Controls.Add(this.txt_dchi_sinhvien);
            this.panel_get_nhanvien.Controls.Add(this.label6);
            this.panel_get_nhanvien.Controls.Add(this.label13);
            this.panel_get_nhanvien.Controls.Add(this.txt_ngaysinh);
            this.panel_get_nhanvien.Controls.Add(this.label12);
            this.panel_get_nhanvien.Controls.Add(this.label11);
            this.panel_get_nhanvien.Controls.Add(this.label10);
            this.panel_get_nhanvien.Controls.Add(this.label7);
            this.panel_get_nhanvien.Controls.Add(this.label9);
            this.panel_get_nhanvien.Location = new System.Drawing.Point(726, 59);
            this.panel_get_nhanvien.Margin = new System.Windows.Forms.Padding(2);
            this.panel_get_nhanvien.Name = "panel_get_nhanvien";
            this.panel_get_nhanvien.Size = new System.Drawing.Size(682, 287);
            this.panel_get_nhanvien.TabIndex = 38;
            // 
            // txt_hinhanh
            // 
            this.txt_hinhanh.Location = new System.Drawing.Point(525, 143);
            this.txt_hinhanh.Margin = new System.Windows.Forms.Padding(2);
            this.txt_hinhanh.Name = "txt_hinhanh";
            this.txt_hinhanh.Size = new System.Drawing.Size(121, 20);
            this.txt_hinhanh.TabIndex = 65;
            // 
            // txt_khoahoc
            // 
            this.txt_khoahoc.Location = new System.Drawing.Point(525, 2);
            this.txt_khoahoc.Margin = new System.Windows.Forms.Padding(2);
            this.txt_khoahoc.Name = "txt_khoahoc";
            this.txt_khoahoc.Size = new System.Drawing.Size(121, 20);
            this.txt_khoahoc.TabIndex = 64;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 207);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 61;
            this.label8.Text = "tenkhoa";
            // 
            // txt_lylich
            // 
            this.txt_lylich.Location = new System.Drawing.Point(525, 84);
            this.txt_lylich.Margin = new System.Windows.Forms.Padding(2);
            this.txt_lylich.Name = "txt_lylich";
            this.txt_lylich.Size = new System.Drawing.Size(121, 20);
            this.txt_lylich.TabIndex = 59;
            // 
            // txt_noisinh_sinhvien
            // 
            this.txt_noisinh_sinhvien.Location = new System.Drawing.Point(62, 120);
            this.txt_noisinh_sinhvien.Name = "txt_noisinh_sinhvien";
            this.txt_noisinh_sinhvien.Size = new System.Drawing.Size(121, 20);
            this.txt_noisinh_sinhvien.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "hinhanh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "lylich";
            // 
            // txtid_Sinhvien
            // 
            this.txtid_Sinhvien.Location = new System.Drawing.Point(62, 12);
            this.txtid_Sinhvien.Name = "txtid_Sinhvien";
            this.txtid_Sinhvien.Size = new System.Drawing.Size(121, 20);
            this.txtid_Sinhvien.TabIndex = 49;
            // 
            // txt_ten_sinhvien
            // 
            this.txt_ten_sinhvien.Location = new System.Drawing.Point(62, 55);
            this.txt_ten_sinhvien.Name = "txt_ten_sinhvien";
            this.txt_ten_sinhvien.Size = new System.Drawing.Size(121, 20);
            this.txt_ten_sinhvien.TabIndex = 41;
            // 
            // txt_dchi_sinhvien
            // 
            this.txt_dchi_sinhvien.Location = new System.Drawing.Point(62, 88);
            this.txt_dchi_sinhvien.Name = "txt_dchi_sinhvien";
            this.txt_dchi_sinhvien.Size = new System.Drawing.Size(121, 20);
            this.txt_dchi_sinhvien.TabIndex = 40;
            // 
            // btn_huy_nhanvien
            // 
            this.btn_huy_nhanvien.Location = new System.Drawing.Point(219, 0);
            this.btn_huy_nhanvien.Margin = new System.Windows.Forms.Padding(2);
            this.btn_huy_nhanvien.Name = "btn_huy_nhanvien";
            this.btn_huy_nhanvien.Size = new System.Drawing.Size(56, 19);
            this.btn_huy_nhanvien.TabIndex = 48;
            this.btn_huy_nhanvien.Text = "hủy";
            this.btn_huy_nhanvien.UseVisualStyleBackColor = true;
            this.btn_huy_nhanvien.Click += new System.EventHandler(this.btn_huy_nhanvien_Click);
            // 
            // btn_luu_nhanvien
            // 
            this.btn_luu_nhanvien.Location = new System.Drawing.Point(145, 2);
            this.btn_luu_nhanvien.Margin = new System.Windows.Forms.Padding(2);
            this.btn_luu_nhanvien.Name = "btn_luu_nhanvien";
            this.btn_luu_nhanvien.Size = new System.Drawing.Size(56, 19);
            this.btn_luu_nhanvien.TabIndex = 47;
            this.btn_luu_nhanvien.Text = "lưu";
            this.btn_luu_nhanvien.UseVisualStyleBackColor = true;
            this.btn_luu_nhanvien.Click += new System.EventHandler(this.btn_luu_nhanvien_Click);
            // 
            // btn_sua_nhanvien
            // 
            this.btn_sua_nhanvien.Location = new System.Drawing.Point(73, 2);
            this.btn_sua_nhanvien.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sua_nhanvien.Name = "btn_sua_nhanvien";
            this.btn_sua_nhanvien.Size = new System.Drawing.Size(56, 19);
            this.btn_sua_nhanvien.TabIndex = 46;
            this.btn_sua_nhanvien.Text = "sửa";
            this.btn_sua_nhanvien.UseVisualStyleBackColor = true;
            this.btn_sua_nhanvien.Click += new System.EventHandler(this.btn_sua_nhanvien_Click);
            // 
            // btn_them_nhanvien
            // 
            this.btn_them_nhanvien.Location = new System.Drawing.Point(2, 2);
            this.btn_them_nhanvien.Margin = new System.Windows.Forms.Padding(2);
            this.btn_them_nhanvien.Name = "btn_them_nhanvien";
            this.btn_them_nhanvien.Size = new System.Drawing.Size(56, 19);
            this.btn_them_nhanvien.TabIndex = 45;
            this.btn_them_nhanvien.Text = "thêm";
            this.btn_them_nhanvien.UseVisualStyleBackColor = true;
            this.btn_them_nhanvien.Click += new System.EventHandler(this.btn_them_nhanvien_Click);
            // 
            // btn_xoa_nhanvien
            // 
            this.btn_xoa_nhanvien.Location = new System.Drawing.Point(289, 2);
            this.btn_xoa_nhanvien.Margin = new System.Windows.Forms.Padding(2);
            this.btn_xoa_nhanvien.Name = "btn_xoa_nhanvien";
            this.btn_xoa_nhanvien.Size = new System.Drawing.Size(56, 19);
            this.btn_xoa_nhanvien.TabIndex = 44;
            this.btn_xoa_nhanvien.Text = "xóa";
            this.btn_xoa_nhanvien.UseVisualStyleBackColor = true;
            this.btn_xoa_nhanvien.Click += new System.EventHandler(this.btn_xoa_nhanvien_Click);
            // 
            // btn_click_khoa
            // 
            this.btn_click_khoa.Location = new System.Drawing.Point(85, 395);
            this.btn_click_khoa.Name = "btn_click_khoa";
            this.btn_click_khoa.Size = new System.Drawing.Size(150, 23);
            this.btn_click_khoa.TabIndex = 41;
            this.btn_click_khoa.Text = "KHOA";
            this.btn_click_khoa.UseVisualStyleBackColor = true;
            this.btn_click_khoa.Click += new System.EventHandler(this.btnLNL_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(1435, 11);
            this.button10.Margin = new System.Windows.Forms.Padding(2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(56, 19);
            this.button10.TabIndex = 43;
            this.button10.Text = "thoát";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(1375, 11);
            this.button11.Margin = new System.Windows.Forms.Padding(2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(56, 19);
            this.button11.TabIndex = 42;
            this.button11.Text = "reload";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // panel_edit_Bophan
            // 
            this.panel_edit_Bophan.Controls.Add(this.btn_them_bophan);
            this.panel_edit_Bophan.Controls.Add(this.btn_huy_bophan);
            this.panel_edit_Bophan.Controls.Add(this.btn_sua_bophan);
            this.panel_edit_Bophan.Controls.Add(this.btn_xoa_bophan);
            this.panel_edit_Bophan.Controls.Add(this.btn_luu_bophan);
            this.panel_edit_Bophan.Location = new System.Drawing.Point(85, 266);
            this.panel_edit_Bophan.Name = "panel_edit_Bophan";
            this.panel_edit_Bophan.Size = new System.Drawing.Size(354, 21);
            this.panel_edit_Bophan.TabIndex = 44;
            // 
            // panel_edit_nhanvien
            // 
            this.panel_edit_nhanvien.Controls.Add(this.btn_them_nhanvien);
            this.panel_edit_nhanvien.Controls.Add(this.btn_sua_nhanvien);
            this.panel_edit_nhanvien.Controls.Add(this.btn_huy_nhanvien);
            this.panel_edit_nhanvien.Controls.Add(this.btn_luu_nhanvien);
            this.panel_edit_nhanvien.Controls.Add(this.btn_xoa_nhanvien);
            this.panel_edit_nhanvien.Location = new System.Drawing.Point(932, 354);
            this.panel_edit_nhanvien.Name = "panel_edit_nhanvien";
            this.panel_edit_nhanvien.Size = new System.Drawing.Size(352, 25);
            this.panel_edit_nhanvien.TabIndex = 45;
            // 
            // txt_gioitinh
            // 
            this.txt_gioitinh.Location = new System.Drawing.Point(62, 158);
            this.txt_gioitinh.Name = "txt_gioitinh";
            this.txt_gioitinh.Size = new System.Drawing.Size(121, 20);
            this.txt_gioitinh.TabIndex = 68;
            // 
            // ca
            // 
            this.ca.AutoSize = true;
            this.ca.Location = new System.Drawing.Point(5, 161);
            this.ca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ca.Name = "ca";
            this.ca.Size = new System.Drawing.Size(45, 13);
            this.ca.TabIndex = 67;
            this.ca.Text = "giới tính";
            // 
            // txt_tenkhoa
            // 
            this.txt_tenkhoa.Location = new System.Drawing.Point(62, 204);
            this.txt_tenkhoa.Name = "txt_tenkhoa";
            this.txt_tenkhoa.Size = new System.Drawing.Size(121, 20);
            this.txt_tenkhoa.TabIndex = 69;
            // 
            // txtidlop
            // 
            this.txtidlop.Location = new System.Drawing.Point(525, 118);
            this.txtidlop.Name = "txtidlop";
            this.txtidlop.Size = new System.Drawing.Size(121, 20);
            this.txtidlop.TabIndex = 70;
            // 
            // formNHANSU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1493, 818);
            this.Controls.Add(this.panel_edit_nhanvien);
            this.Controls.Add(this.panel_edit_Bophan);
            this.Controls.Add(this.btn_click_khoa);
            this.Controls.Add(this.panel_get_nhanvien);
            this.Controls.Add(this.btn_click_sinhvien);
            this.Controls.Add(this.btn_xem_nhanvien);
            this.Controls.Add(this.dgv_nhanvien);
            this.Controls.Add(this.panel_get_bophan);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.dgv_bophan);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formNHANSU";
            this.Text = "NHANSU";
            this.Load += new System.EventHandler(this.formNHANSU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bophan)).EndInit();
            this.panel_get_bophan.ResumeLayout(false);
            this.panel_get_bophan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhanvien)).EndInit();
            this.panel_get_nhanvien.ResumeLayout(false);
            this.panel_get_nhanvien.PerformLayout();
            this.panel_edit_Bophan.ResumeLayout(false);
            this.panel_edit_nhanvien.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_bophan;
        private System.Windows.Forms.Panel panel_get_bophan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ngaysinh;
        private System.Windows.Forms.DataGridView dgv_nhanvien;
        private System.Windows.Forms.Button btn_xem_nhanvien;
        private System.Windows.Forms.Button btn_click_sinhvien;
        private System.Windows.Forms.TextBox txtten_khoa;
        private System.Windows.Forms.TextBox txtid_khoa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel_get_nhanvien;
        private System.Windows.Forms.TextBox txt_ten_sinhvien;
        private System.Windows.Forms.TextBox txt_dchi_sinhvien;
        private System.Windows.Forms.Button btn_click_khoa;
        private System.Windows.Forms.Button btn_huy_bophan;
        private System.Windows.Forms.Button btn_luu_bophan;
        private System.Windows.Forms.Button btn_sua_bophan;
        private System.Windows.Forms.Button btn_them_bophan;
        private System.Windows.Forms.Button btn_xoa_bophan;
        private System.Windows.Forms.TextBox txtid_Sinhvien;
        private System.Windows.Forms.Button btn_huy_nhanvien;
        private System.Windows.Forms.Button btn_luu_nhanvien;
        private System.Windows.Forms.Button btn_sua_nhanvien;
        private System.Windows.Forms.Button btn_them_nhanvien;
        private System.Windows.Forms.Button btn_xoa_nhanvien;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Panel panel_edit_Bophan;
        private System.Windows.Forms.Panel panel_edit_nhanvien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_lylich;
        private System.Windows.Forms.TextBox txt_noisinh_sinhvien;
        private System.Windows.Forms.TextBox txt_hinhanh;
        private System.Windows.Forms.TextBox txt_khoahoc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn HDNHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLK;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn bnbb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.TextBox txt_gioitinh;
        private System.Windows.Forms.Label ca;
        private System.Windows.Forms.TextBox txtidlop;
        private System.Windows.Forms.TextBox txt_tenkhoa;
    }
}