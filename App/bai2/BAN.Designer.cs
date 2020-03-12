namespace bai2
{
    partial class formBAN
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
            this.components = new System.ComponentModel.Container();
            this.dgvBAN = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.NSLK = new System.Windows.Forms.NumericUpDown();
            this.cbBan = new System.Windows.Forms.ComboBox();
            this.cbcaphucvu = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MaVT = new System.Windows.Forms.Label();
            this.txtidnv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPHANCONG = new System.Windows.Forms.DataGridView();
            this.HDNHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spgetchitiethoadonnhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.qUANLYCHUOINHAHANGDataSet = new bai2.QUANLYCHUOINHAHANGDataSet();
            //this.sp_get_chitiethoadonnhapTableAdapter = new bai2.QUANLYCHUOINHAHANGDataSetTableAdapters.sp_get_chitiethoadonnhapTableAdapter();
            this.btnxem = new System.Windows.Forms.Button();
            //this.quanlychuoinhahangDataSet1 = new bai2.QUANLYCHUOINHAHANGDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBAN)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NSLK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPHANCONG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetchitiethoadonnhapBindingSource)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.qUANLYCHUOINHAHANGDataSet)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.quanlychuoinhahangDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBAN
            // 
            this.dgvBAN.AllowUserToAddRows = false;
            this.dgvBAN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBAN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvBAN.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBAN.Location = new System.Drawing.Point(25, 238);
            this.dgvBAN.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBAN.Name = "dgvBAN";
            this.dgvBAN.RowHeadersWidth = 51;
            this.dgvBAN.RowTemplate.Height = 24;
            this.dgvBAN.Size = new System.Drawing.Size(427, 292);
            this.dgvBAN.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "idban";
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Mã Bàn";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tenban";
            this.Column2.HeaderText = "Tên Bàn";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "trangthai";
            this.Column3.HeaderText = "Trạng Thái";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(652, 565);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 1;
            this.button1.Text = "reload";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(712, 565);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 19);
            this.button2.TabIndex = 2;
            this.button2.Text = "thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(338, 565);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 19);
            this.button3.TabIndex = 3;
            this.button3.Text = "xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(25, 565);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(56, 19);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(99, 565);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(56, 19);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(180, 565);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(56, 19);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(255, 565);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(56, 19);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.NSLK);
            this.panel.Controls.Add(this.cbBan);
            this.panel.Controls.Add(this.cbcaphucvu);
            this.panel.Controls.Add(this.label6);
            this.panel.Controls.Add(this.MaVT);
            this.panel.Controls.Add(this.txtidnv);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.label1);
            this.panel.Location = new System.Drawing.Point(307, 41);
            this.panel.Margin = new System.Windows.Forms.Padding(2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(718, 169);
            this.panel.TabIndex = 14;
            // 
            // NSLK
            // 
            this.NSLK.Location = new System.Drawing.Point(140, 64);
            this.NSLK.Name = "NSLK";
            this.NSLK.Size = new System.Drawing.Size(129, 20);
            this.NSLK.TabIndex = 29;
            // 
            // cbBan
            // 
            this.cbBan.FormattingEnabled = true;
            this.cbBan.Location = new System.Drawing.Point(140, 25);
            this.cbBan.Name = "cbBan";
            this.cbBan.Size = new System.Drawing.Size(121, 21);
            this.cbBan.TabIndex = 27;
            // 
            // cbcaphucvu
            // 
            this.cbcaphucvu.FormattingEnabled = true;
            this.cbcaphucvu.Location = new System.Drawing.Point(453, 64);
            this.cbcaphucvu.Name = "cbcaphucvu";
            this.cbcaphucvu.Size = new System.Drawing.Size(129, 21);
            this.cbcaphucvu.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(342, 72);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Ca phục vụ";
            // 
            // MaVT
            // 
            this.MaVT.AutoSize = true;
            this.MaVT.Location = new System.Drawing.Point(342, 35);
            this.MaVT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MaVT.Name = "MaVT";
            this.MaVT.Size = new System.Drawing.Size(103, 13);
            this.MaVT.TabIndex = 25;
            this.MaVT.Text = "NV chịu trách nhiệm";
            // 
            // txtidnv
            // 
            this.txtidnv.Location = new System.Drawing.Point(453, 26);
            this.txtidnv.Margin = new System.Windows.Forms.Padding(2);
            this.txtidnv.Name = "txtidnv";
            this.txtidnv.Size = new System.Drawing.Size(129, 20);
            this.txtidnv.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Số Lượng Khách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Bàn";
            // 
            // dgvPHANCONG
            // 
            this.dgvPHANCONG.AllowUserToAddRows = false;
            this.dgvPHANCONG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPHANCONG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HDNHAP,
            this.Column6,
            this.Column7,
            this.SLK});
            this.dgvPHANCONG.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPHANCONG.Location = new System.Drawing.Point(628, 238);
            this.dgvPHANCONG.Name = "dgvPHANCONG";
            this.dgvPHANCONG.RowHeadersWidth = 51;
            this.dgvPHANCONG.Size = new System.Drawing.Size(553, 292);
            this.dgvPHANCONG.TabIndex = 0;
            // 
            // HDNHAP
            // 
            this.HDNHAP.DataPropertyName = "idban";
            this.HDNHAP.HeaderText = "Bàn";
            this.HDNHAP.MinimumWidth = 6;
            this.HDNHAP.Name = "HDNHAP";
            this.HDNHAP.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "tennhanvien";
            this.Column6.HeaderText = "NV";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "caphucvu";
            this.Column7.HeaderText = "Ca";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // SLK
            // 
            this.SLK.DataPropertyName = "SLK";
            this.SLK.HeaderText = "Số Lượng Khách";
            this.SLK.MinimumWidth = 6;
            this.SLK.Name = "SLK";
            this.SLK.Width = 125;
            // 
            // spgetchitiethoadonnhapBindingSource
            // 
            this.spgetchitiethoadonnhapBindingSource.DataMember = "sp_get_chitiethoadonnhap";

            // 
            // btnxem
            // 
            this.btnxem.Location = new System.Drawing.Point(1359, 561);
            this.btnxem.Name = "btnxem";
            this.btnxem.Size = new System.Drawing.Size(75, 23);
            this.btnxem.TabIndex = 16;
            this.btnxem.Text = "xem";
            this.btnxem.UseVisualStyleBackColor = true;
            this.btnxem.Click += new System.EventHandler(this.btnxem_Click);
            // 
            // quanlychuoinhahangDataSet1
            // 
            // 
            // formBAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 815);
            this.Controls.Add(this.btnxem);
            this.Controls.Add(this.dgvPHANCONG);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvBAN);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formBAN";
            this.Text = "Phiếu nhập";
            this.Load += new System.EventHandler(this.DgvKHACHHANG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBAN)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NSLK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPHANCONG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetchitiethoadonnhapBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBAN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label MaVT;
        private System.Windows.Forms.TextBox txtidnv;
        private System.Windows.Forms.DataGridView dgvPHANCONG;
        private System.Windows.Forms.BindingSource spgetchitiethoadonnhapBindingSource;
   
        private System.Windows.Forms.Button btnxem;
        private System.Windows.Forms.ComboBox cbcaphucvu;
        private System.Windows.Forms.ComboBox cbBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.NumericUpDown NSLK;
        private System.Windows.Forms.DataGridViewTextBoxColumn HDNHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLK;
    }
}