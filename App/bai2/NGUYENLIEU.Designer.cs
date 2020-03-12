namespace bai2
{
    partial class formNGUYENLIEU
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
            this.dgvLoainguyenlieu = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_loainguyenlieu = new System.Windows.Forms.Panel();
            this.tenloainguyenlieu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtidloainguyenlieu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnhuyloainl = new System.Windows.Forms.Button();
            this.btnluuloainl = new System.Windows.Forms.Button();
            this.btnsualoainl = new System.Windows.Forms.Button();
            this.btnthemloainl = new System.Windows.Forms.Button();
            this.btnxoalnl = new System.Windows.Forms.Button();
            this.NSL = new System.Windows.Forms.NumericUpDown();
            this.cbtrangthai = new System.Windows.Forms.ComboBox();
            this.txtgianhap = new System.Windows.Forms.TextBox();
            this.dgvnguyenlieu = new System.Windows.Forms.DataGridView();
            this.HDNHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnxemNL = new System.Windows.Forms.Button();
            this.dgvchitietkho = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXemHangton = new System.Windows.Forms.Button();
            this.btnNL = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel_nguyenlieu = new System.Windows.Forms.Panel();
            this.cbidloainguyenlieu = new System.Windows.Forms.ComboBox();
            this.txtidnguyenlieu = new System.Windows.Forms.TextBox();
            this.txttennguyenlieu = new System.Windows.Forms.TextBox();
            this.txtdvtinh = new System.Windows.Forms.TextBox();
            this.richtxtmota = new System.Windows.Forms.RichTextBox();
            this.btnhuynguyenlieu = new System.Windows.Forms.Button();
            this.btnluunguyenlieu = new System.Windows.Forms.Button();
            this.btnsuanguyenlieu = new System.Windows.Forms.Button();
            this.btnthemnguyenlieu = new System.Windows.Forms.Button();
            this.btnxoanguyenlieu = new System.Windows.Forms.Button();
            this.btntonkho = new System.Windows.Forms.Button();
            this.btnLNL = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.panel_edit_loainguyenlieu = new System.Windows.Forms.Panel();
            this.panel_edit_nguyenlieu = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoainguyenlieu)).BeginInit();
            this.panel_loainguyenlieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnguyenlieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvchitietkho)).BeginInit();
            this.panel_nguyenlieu.SuspendLayout();
            this.panel_edit_loainguyenlieu.SuspendLayout();
            this.panel_edit_nguyenlieu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLoainguyenlieu
            // 
            this.dgvLoainguyenlieu.AllowUserToAddRows = false;
            this.dgvLoainguyenlieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoainguyenlieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvLoainguyenlieu.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvLoainguyenlieu.Location = new System.Drawing.Point(11, 424);
            this.dgvLoainguyenlieu.Margin = new System.Windows.Forms.Padding(2);
            this.dgvLoainguyenlieu.Name = "dgvLoainguyenlieu";
            this.dgvLoainguyenlieu.RowHeadersWidth = 51;
            this.dgvLoainguyenlieu.RowTemplate.Height = 24;
            this.dgvLoainguyenlieu.Size = new System.Drawing.Size(357, 292);
            this.dgvLoainguyenlieu.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "idloainguyenlieu";
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Loại NL";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tenloainguyenlieu";
            this.Column2.HeaderText = "Tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // panel_loainguyenlieu
            // 
            this.panel_loainguyenlieu.Controls.Add(this.tenloainguyenlieu);
            this.panel_loainguyenlieu.Controls.Add(this.label5);
            this.panel_loainguyenlieu.Controls.Add(this.txtidloainguyenlieu);
            this.panel_loainguyenlieu.Controls.Add(this.label1);
            this.panel_loainguyenlieu.Location = new System.Drawing.Point(11, 194);
            this.panel_loainguyenlieu.Margin = new System.Windows.Forms.Padding(2);
            this.panel_loainguyenlieu.Name = "panel_loainguyenlieu";
            this.panel_loainguyenlieu.Size = new System.Drawing.Size(365, 131);
            this.panel_loainguyenlieu.TabIndex = 14;
            // 
            // tenloainguyenlieu
            // 
            this.tenloainguyenlieu.Location = new System.Drawing.Point(223, 55);
            this.tenloainguyenlieu.Name = "tenloainguyenlieu";
            this.tenloainguyenlieu.Size = new System.Drawing.Size(100, 20);
            this.tenloainguyenlieu.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Tên Loại NL";
            // 
            // txtidloainguyenlieu
            // 
            this.txtidloainguyenlieu.Location = new System.Drawing.Point(223, 26);
            this.txtidloainguyenlieu.Name = "txtidloainguyenlieu";
            this.txtidloainguyenlieu.Size = new System.Drawing.Size(100, 20);
            this.txtidloainguyenlieu.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã Loại NL";
            // 
            // btnhuyloainl
            // 
            this.btnhuyloainl.Location = new System.Drawing.Point(224, 0);
            this.btnhuyloainl.Margin = new System.Windows.Forms.Padding(2);
            this.btnhuyloainl.Name = "btnhuyloainl";
            this.btnhuyloainl.Size = new System.Drawing.Size(56, 19);
            this.btnhuyloainl.TabIndex = 53;
            this.btnhuyloainl.Text = "hủy";
            this.btnhuyloainl.UseVisualStyleBackColor = true;
            this.btnhuyloainl.Click += new System.EventHandler(this.btnhuyloainl_Click);
            // 
            // btnluuloainl
            // 
            this.btnluuloainl.Location = new System.Drawing.Point(152, 2);
            this.btnluuloainl.Margin = new System.Windows.Forms.Padding(2);
            this.btnluuloainl.Name = "btnluuloainl";
            this.btnluuloainl.Size = new System.Drawing.Size(56, 19);
            this.btnluuloainl.TabIndex = 52;
            this.btnluuloainl.Text = "lưu";
            this.btnluuloainl.UseVisualStyleBackColor = true;
            this.btnluuloainl.Click += new System.EventHandler(this.btnluuloainl_Click);
            // 
            // btnsualoainl
            // 
            this.btnsualoainl.Location = new System.Drawing.Point(71, 2);
            this.btnsualoainl.Margin = new System.Windows.Forms.Padding(2);
            this.btnsualoainl.Name = "btnsualoainl";
            this.btnsualoainl.Size = new System.Drawing.Size(56, 19);
            this.btnsualoainl.TabIndex = 51;
            this.btnsualoainl.Text = "sửa";
            this.btnsualoainl.UseVisualStyleBackColor = true;
            this.btnsualoainl.Click += new System.EventHandler(this.btnsualoainl_Click);
            // 
            // btnthemloainl
            // 
            this.btnthemloainl.Location = new System.Drawing.Point(2, 2);
            this.btnthemloainl.Margin = new System.Windows.Forms.Padding(2);
            this.btnthemloainl.Name = "btnthemloainl";
            this.btnthemloainl.Size = new System.Drawing.Size(56, 19);
            this.btnthemloainl.TabIndex = 50;
            this.btnthemloainl.Text = "thêm";
            this.btnthemloainl.UseVisualStyleBackColor = true;
            this.btnthemloainl.Click += new System.EventHandler(this.btnthemloainl_Click);
            // 
            // btnxoalnl
            // 
            this.btnxoalnl.Location = new System.Drawing.Point(296, 2);
            this.btnxoalnl.Margin = new System.Windows.Forms.Padding(2);
            this.btnxoalnl.Name = "btnxoalnl";
            this.btnxoalnl.Size = new System.Drawing.Size(56, 19);
            this.btnxoalnl.TabIndex = 49;
            this.btnxoalnl.Text = "xóa";
            this.btnxoalnl.UseVisualStyleBackColor = true;
            this.btnxoalnl.Click += new System.EventHandler(this.btnxoalnl_Click);
            // 
            // NSL
            // 
            this.NSL.Location = new System.Drawing.Point(525, 5);
            this.NSL.Name = "NSL";
            this.NSL.Size = new System.Drawing.Size(129, 20);
            this.NSL.TabIndex = 29;
            // 
            // cbtrangthai
            // 
            this.cbtrangthai.FormattingEnabled = true;
            this.cbtrangthai.Location = new System.Drawing.Point(62, 80);
            this.cbtrangthai.Name = "cbtrangthai";
            this.cbtrangthai.Size = new System.Drawing.Size(121, 21);
            this.cbtrangthai.TabIndex = 17;
            // 
            // txtgianhap
            // 
            this.txtgianhap.Location = new System.Drawing.Point(525, 33);
            this.txtgianhap.Margin = new System.Windows.Forms.Padding(2);
            this.txtgianhap.Name = "txtgianhap";
            this.txtgianhap.Size = new System.Drawing.Size(121, 20);
            this.txtgianhap.TabIndex = 21;
            // 
            // dgvnguyenlieu
            // 
            this.dgvnguyenlieu.AllowUserToAddRows = false;
            this.dgvnguyenlieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnguyenlieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HDNHAP,
            this.Column6,
            this.Column7,
            this.SLK,
            this.DVT,
            this.Column3});
            this.dgvnguyenlieu.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvnguyenlieu.Location = new System.Drawing.Point(386, 424);
            this.dgvnguyenlieu.Name = "dgvnguyenlieu";
            this.dgvnguyenlieu.RowHeadersWidth = 51;
            this.dgvnguyenlieu.Size = new System.Drawing.Size(753, 292);
            this.dgvnguyenlieu.TabIndex = 0;
            // 
            // HDNHAP
            // 
            this.HDNHAP.DataPropertyName = "tennguyenlieu";
            this.HDNHAP.HeaderText = "Tên NL";
            this.HDNHAP.MinimumWidth = 6;
            this.HDNHAP.Name = "HDNHAP";
            this.HDNHAP.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "trangthai";
            this.Column6.HeaderText = "Trạng Thái";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "mota";
            this.Column7.HeaderText = "Mô tả";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // SLK
            // 
            this.SLK.DataPropertyName = "soluong";
            this.SLK.HeaderText = "SL tồn";
            this.SLK.MinimumWidth = 6;
            this.SLK.Name = "SLK";
            this.SLK.Width = 125;
            // 
            // DVT
            // 
            this.DVT.DataPropertyName = "donvitinh";
            this.DVT.HeaderText = "DVTinh";
            this.DVT.Name = "DVT";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "gianhap";
            this.Column3.HeaderText = "Giá nhập";
            this.Column3.Name = "Column3";
            // 
            // btnxemNL
            // 
            this.btnxemNL.Location = new System.Drawing.Point(107, 722);
            this.btnxemNL.Name = "btnxemNL";
            this.btnxemNL.Size = new System.Drawing.Size(99, 23);
            this.btnxemNL.TabIndex = 16;
            this.btnxemNL.Text = "XemNL";
            this.btnxemNL.UseVisualStyleBackColor = true;
            this.btnxemNL.Click += new System.EventHandler(this.btnxem_Click);
            // 
            // dgvchitietkho
            // 
            this.dgvchitietkho.AllowUserToAddRows = false;
            this.dgvchitietkho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvchitietkho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvchitietkho.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvchitietkho.Location = new System.Drawing.Point(1156, 424);
            this.dgvchitietkho.Name = "dgvchitietkho";
            this.dgvchitietkho.RowHeadersWidth = 51;
            this.dgvchitietkho.Size = new System.Drawing.Size(305, 292);
            this.dgvchitietkho.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idkho";
            this.dataGridViewTextBoxColumn1.HeaderText = "Kho";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "soluongton";
            this.dataGridViewTextBoxColumn2.HeaderText = "Số lượng tồn";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // btnXemHangton
            // 
            this.btnXemHangton.Location = new System.Drawing.Point(665, 722);
            this.btnXemHangton.Name = "btnXemHangton";
            this.btnXemHangton.Size = new System.Drawing.Size(133, 23);
            this.btnXemHangton.TabIndex = 18;
            this.btnXemHangton.Text = "Xem hàng tồn";
            this.btnXemHangton.UseVisualStyleBackColor = true;
            this.btnXemHangton.Click += new System.EventHandler(this.btnXemHangton_Click);
            // 
            // btnNL
            // 
            this.btnNL.Location = new System.Drawing.Point(665, 395);
            this.btnNL.Name = "btnNL";
            this.btnNL.Size = new System.Drawing.Size(150, 23);
            this.btnNL.TabIndex = 19;
            this.btnNL.Text = "NGUYÊN LIỆU";
            this.btnNL.UseVisualStyleBackColor = true;
            this.btnNL.Click += new System.EventHandler(this.btnNL_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Mã NL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 48);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Tên NL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 80);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Trạng thái";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(354, 154);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Mô tả";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(354, 7);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "SL";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 177);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Mã LNL";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 119);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "DV tính";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(354, 40);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "Giá Nhập";
            // 
            // panel_nguyenlieu
            // 
            this.panel_nguyenlieu.Controls.Add(this.cbidloainguyenlieu);
            this.panel_nguyenlieu.Controls.Add(this.txtidnguyenlieu);
            this.panel_nguyenlieu.Controls.Add(this.txttennguyenlieu);
            this.panel_nguyenlieu.Controls.Add(this.txtdvtinh);
            this.panel_nguyenlieu.Controls.Add(this.richtxtmota);
            this.panel_nguyenlieu.Controls.Add(this.label6);
            this.panel_nguyenlieu.Controls.Add(this.label13);
            this.panel_nguyenlieu.Controls.Add(this.txtgianhap);
            this.panel_nguyenlieu.Controls.Add(this.label12);
            this.panel_nguyenlieu.Controls.Add(this.cbtrangthai);
            this.panel_nguyenlieu.Controls.Add(this.label11);
            this.panel_nguyenlieu.Controls.Add(this.NSL);
            this.panel_nguyenlieu.Controls.Add(this.label10);
            this.panel_nguyenlieu.Controls.Add(this.label7);
            this.panel_nguyenlieu.Controls.Add(this.label8);
            this.panel_nguyenlieu.Controls.Add(this.label9);
            this.panel_nguyenlieu.Location = new System.Drawing.Point(417, 35);
            this.panel_nguyenlieu.Margin = new System.Windows.Forms.Padding(2);
            this.panel_nguyenlieu.Name = "panel_nguyenlieu";
            this.panel_nguyenlieu.Size = new System.Drawing.Size(682, 290);
            this.panel_nguyenlieu.TabIndex = 38;
            // 
            // cbidloainguyenlieu
            // 
            this.cbidloainguyenlieu.FormattingEnabled = true;
            this.cbidloainguyenlieu.Location = new System.Drawing.Point(62, 169);
            this.cbidloainguyenlieu.Name = "cbidloainguyenlieu";
            this.cbidloainguyenlieu.Size = new System.Drawing.Size(121, 21);
            this.cbidloainguyenlieu.TabIndex = 50;
            // 
            // txtidnguyenlieu
            // 
            this.txtidnguyenlieu.Location = new System.Drawing.Point(62, 5);
            this.txtidnguyenlieu.Name = "txtidnguyenlieu";
            this.txtidnguyenlieu.Size = new System.Drawing.Size(121, 20);
            this.txtidnguyenlieu.TabIndex = 49;
            // 
            // txttennguyenlieu
            // 
            this.txttennguyenlieu.Location = new System.Drawing.Point(62, 45);
            this.txttennguyenlieu.Name = "txttennguyenlieu";
            this.txttennguyenlieu.Size = new System.Drawing.Size(121, 20);
            this.txttennguyenlieu.TabIndex = 41;
            // 
            // txtdvtinh
            // 
            this.txtdvtinh.Location = new System.Drawing.Point(62, 119);
            this.txtdvtinh.Name = "txtdvtinh";
            this.txtdvtinh.Size = new System.Drawing.Size(121, 20);
            this.txtdvtinh.TabIndex = 40;
            // 
            // richtxtmota
            // 
            this.richtxtmota.Location = new System.Drawing.Point(393, 90);
            this.richtxtmota.Name = "richtxtmota";
            this.richtxtmota.Size = new System.Drawing.Size(279, 132);
            this.richtxtmota.TabIndex = 38;
            this.richtxtmota.Text = "";
            // 
            // btnhuynguyenlieu
            // 
            this.btnhuynguyenlieu.Location = new System.Drawing.Point(219, 0);
            this.btnhuynguyenlieu.Margin = new System.Windows.Forms.Padding(2);
            this.btnhuynguyenlieu.Name = "btnhuynguyenlieu";
            this.btnhuynguyenlieu.Size = new System.Drawing.Size(56, 19);
            this.btnhuynguyenlieu.TabIndex = 48;
            this.btnhuynguyenlieu.Text = "hủy";
            this.btnhuynguyenlieu.UseVisualStyleBackColor = true;
            this.btnhuynguyenlieu.Click += new System.EventHandler(this.btnhuynguyenlieu_Click);
            // 
            // btnluunguyenlieu
            // 
            this.btnluunguyenlieu.Location = new System.Drawing.Point(145, 2);
            this.btnluunguyenlieu.Margin = new System.Windows.Forms.Padding(2);
            this.btnluunguyenlieu.Name = "btnluunguyenlieu";
            this.btnluunguyenlieu.Size = new System.Drawing.Size(56, 19);
            this.btnluunguyenlieu.TabIndex = 47;
            this.btnluunguyenlieu.Text = "lưu";
            this.btnluunguyenlieu.UseVisualStyleBackColor = true;
            this.btnluunguyenlieu.Click += new System.EventHandler(this.btnluunguyenlieu_Click);
            // 
            // btnsuanguyenlieu
            // 
            this.btnsuanguyenlieu.Location = new System.Drawing.Point(73, 2);
            this.btnsuanguyenlieu.Margin = new System.Windows.Forms.Padding(2);
            this.btnsuanguyenlieu.Name = "btnsuanguyenlieu";
            this.btnsuanguyenlieu.Size = new System.Drawing.Size(56, 19);
            this.btnsuanguyenlieu.TabIndex = 46;
            this.btnsuanguyenlieu.Text = "sửa";
            this.btnsuanguyenlieu.UseVisualStyleBackColor = true;
            this.btnsuanguyenlieu.Click += new System.EventHandler(this.btnsuanguyenlieu_Click);
            // 
            // btnthemnguyenlieu
            // 
            this.btnthemnguyenlieu.Location = new System.Drawing.Point(2, 2);
            this.btnthemnguyenlieu.Margin = new System.Windows.Forms.Padding(2);
            this.btnthemnguyenlieu.Name = "btnthemnguyenlieu";
            this.btnthemnguyenlieu.Size = new System.Drawing.Size(56, 19);
            this.btnthemnguyenlieu.TabIndex = 45;
            this.btnthemnguyenlieu.Text = "thêm";
            this.btnthemnguyenlieu.UseVisualStyleBackColor = true;
            this.btnthemnguyenlieu.Click += new System.EventHandler(this.btnthemnguyenlieu_Click);
            // 
            // btnxoanguyenlieu
            // 
            this.btnxoanguyenlieu.Location = new System.Drawing.Point(289, 2);
            this.btnxoanguyenlieu.Margin = new System.Windows.Forms.Padding(2);
            this.btnxoanguyenlieu.Name = "btnxoanguyenlieu";
            this.btnxoanguyenlieu.Size = new System.Drawing.Size(56, 19);
            this.btnxoanguyenlieu.TabIndex = 44;
            this.btnxoanguyenlieu.Text = "xóa";
            this.btnxoanguyenlieu.UseVisualStyleBackColor = true;
            this.btnxoanguyenlieu.Click += new System.EventHandler(this.btnxoanguyenlieu_Click);
            // 
            // btntonkho
            // 
            this.btntonkho.Location = new System.Drawing.Point(1234, 395);
            this.btntonkho.Name = "btntonkho";
            this.btntonkho.Size = new System.Drawing.Size(150, 23);
            this.btntonkho.TabIndex = 40;
            this.btntonkho.Text = "TỒN KHO";
            this.btntonkho.UseVisualStyleBackColor = true;
            // 
            // btnLNL
            // 
            this.btnLNL.Location = new System.Drawing.Point(85, 395);
            this.btnLNL.Name = "btnLNL";
            this.btnLNL.Size = new System.Drawing.Size(150, 23);
            this.btnLNL.TabIndex = 41;
            this.btnLNL.Text = "LOẠI NGUYÊN LIỆU";
            this.btnLNL.UseVisualStyleBackColor = true;
            this.btnLNL.Click += new System.EventHandler(this.btnLNL_Click);
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
            // panel_edit_loainguyenlieu
            // 
            this.panel_edit_loainguyenlieu.Controls.Add(this.btnthemloainl);
            this.panel_edit_loainguyenlieu.Controls.Add(this.btnhuyloainl);
            this.panel_edit_loainguyenlieu.Controls.Add(this.btnsualoainl);
            this.panel_edit_loainguyenlieu.Controls.Add(this.btnxoalnl);
            this.panel_edit_loainguyenlieu.Controls.Add(this.btnluuloainl);
            this.panel_edit_loainguyenlieu.Location = new System.Drawing.Point(14, 330);
            this.panel_edit_loainguyenlieu.Name = "panel_edit_loainguyenlieu";
            this.panel_edit_loainguyenlieu.Size = new System.Drawing.Size(354, 21);
            this.panel_edit_loainguyenlieu.TabIndex = 44;
            // 
            // panel_edit_nguyenlieu
            // 
            this.panel_edit_nguyenlieu.Controls.Add(this.btnthemnguyenlieu);
            this.panel_edit_nguyenlieu.Controls.Add(this.btnsuanguyenlieu);
            this.panel_edit_nguyenlieu.Controls.Add(this.btnhuynguyenlieu);
            this.panel_edit_nguyenlieu.Controls.Add(this.btnluunguyenlieu);
            this.panel_edit_nguyenlieu.Controls.Add(this.btnxoanguyenlieu);
            this.panel_edit_nguyenlieu.Location = new System.Drawing.Point(538, 332);
            this.panel_edit_nguyenlieu.Name = "panel_edit_nguyenlieu";
            this.panel_edit_nguyenlieu.Size = new System.Drawing.Size(352, 25);
            this.panel_edit_nguyenlieu.TabIndex = 45;
            // 
            // formNGUYENLIEU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1493, 818);
            this.Controls.Add(this.panel_edit_nguyenlieu);
            this.Controls.Add(this.panel_edit_loainguyenlieu);
            this.Controls.Add(this.btnLNL);
            this.Controls.Add(this.btntonkho);
            this.Controls.Add(this.panel_nguyenlieu);
            this.Controls.Add(this.btnNL);
            this.Controls.Add(this.btnXemHangton);
            this.Controls.Add(this.dgvchitietkho);
            this.Controls.Add(this.btnxemNL);
            this.Controls.Add(this.dgvnguyenlieu);
            this.Controls.Add(this.panel_loainguyenlieu);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.dgvLoainguyenlieu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formNGUYENLIEU";
            this.Text = "Phiếu nhập";
            this.Load += new System.EventHandler(this.formNGUYENLIEU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoainguyenlieu)).EndInit();
            this.panel_loainguyenlieu.ResumeLayout(false);
            this.panel_loainguyenlieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnguyenlieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvchitietkho)).EndInit();
            this.panel_nguyenlieu.ResumeLayout(false);
            this.panel_nguyenlieu.PerformLayout();
            this.panel_edit_loainguyenlieu.ResumeLayout(false);
            this.panel_edit_nguyenlieu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLoainguyenlieu;
        private System.Windows.Forms.Panel panel_loainguyenlieu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtgianhap;
        private System.Windows.Forms.DataGridView dgvnguyenlieu;
        private System.Windows.Forms.Button btnxemNL;
        private System.Windows.Forms.ComboBox cbtrangthai;
        private System.Windows.Forms.NumericUpDown NSL;
        private System.Windows.Forms.DataGridView dgvchitietkho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn HDNHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLK;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnXemHangton;
        private System.Windows.Forms.Button btnNL;
        private System.Windows.Forms.TextBox tenloainguyenlieu;
        private System.Windows.Forms.TextBox txtidloainguyenlieu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel_nguyenlieu;
        private System.Windows.Forms.TextBox txttennguyenlieu;
        private System.Windows.Forms.TextBox txtdvtinh;
        private System.Windows.Forms.RichTextBox richtxtmota;
        private System.Windows.Forms.Button btntonkho;
        private System.Windows.Forms.Button btnLNL;
        private System.Windows.Forms.Button btnhuyloainl;
        private System.Windows.Forms.Button btnluuloainl;
        private System.Windows.Forms.Button btnsualoainl;
        private System.Windows.Forms.Button btnthemloainl;
        private System.Windows.Forms.Button btnxoalnl;
        private System.Windows.Forms.ComboBox cbidloainguyenlieu;
        private System.Windows.Forms.TextBox txtidnguyenlieu;
        private System.Windows.Forms.Button btnhuynguyenlieu;
        private System.Windows.Forms.Button btnluunguyenlieu;
        private System.Windows.Forms.Button btnsuanguyenlieu;
        private System.Windows.Forms.Button btnthemnguyenlieu;
        private System.Windows.Forms.Button btnxoanguyenlieu;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Panel panel_edit_loainguyenlieu;
        private System.Windows.Forms.Panel panel_edit_nguyenlieu;
    }
}