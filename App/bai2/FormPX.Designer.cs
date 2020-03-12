namespace bai2
{
    partial class formPHIEUXUAT
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.txtMaPX = new System.Windows.Forms.TextBox();
            this.txtNgayxuat = new System.Windows.Forms.TextBox();
            this.txtTrangthai = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.IDBan = new System.Windows.Forms.Label();
            this.txtGiaban = new System.Windows.Forms.TextBox();
            this.txtNVtt = new System.Windows.Forms.TextBox();
            this.txtIDban = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.MaKH = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grvchitiethdnhap = new System.Windows.Forms.DataGridView();
            this.HDNHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spgetchitiethoadonnhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnxem = new System.Windows.Forms.Button();
            this.txtIDmon = new System.Windows.Forms.TextBox();
            this.txtVAT = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvchitiethdnhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetchitiethoadonnhapBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.column,
            this.Column10,
            this.tongtien});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(25, 238);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(718, 292);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "idhoadon";
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "IDHD";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "trangthaithanhtoan";
            this.Column2.HeaderText = "Trạng Thái";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "thoigian";
            this.Column3.HeaderText = "Ngày Xuất";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "code";
            this.Column4.HeaderText = "code";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "idkhachhang";
            this.Column5.HeaderText = "Mã KH";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // column
            // 
            this.column.DataPropertyName = "idban";
            this.column.HeaderText = "ID BÀN";
            this.column.MinimumWidth = 6;
            this.column.Name = "column";
            this.column.Width = 125;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "idnhanvienthanhtoan";
            this.Column10.HeaderText = "NV thanh toán";
            this.Column10.Name = "Column10";
            // 
            // tongtien
            // 
            this.tongtien.DataPropertyName = "tongtien";
            this.tongtien.HeaderText = "Tổng tiền";
            this.tongtien.Name = "tongtien";
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
            // txtMaPX
            // 
            this.txtMaPX.Location = new System.Drawing.Point(155, 18);
            this.txtMaPX.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaPX.Name = "txtMaPX";
            this.txtMaPX.Size = new System.Drawing.Size(149, 20);
            this.txtMaPX.TabIndex = 8;
            // 
            // txtNgayxuat
            // 
            this.txtNgayxuat.Location = new System.Drawing.Point(155, 86);
            this.txtNgayxuat.Margin = new System.Windows.Forms.Padding(2);
            this.txtNgayxuat.Name = "txtNgayxuat";
            this.txtNgayxuat.Size = new System.Drawing.Size(149, 20);
            this.txtNgayxuat.TabIndex = 9;
            // 
            // txtTrangthai
            // 
            this.txtTrangthai.Location = new System.Drawing.Point(155, 56);
            this.txtTrangthai.Margin = new System.Windows.Forms.Padding(2);
            this.txtTrangthai.Name = "txtTrangthai";
            this.txtTrangthai.Size = new System.Drawing.Size(149, 20);
            this.txtTrangthai.TabIndex = 11;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(155, 110);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(149, 20);
            this.txtMaKH.TabIndex = 12;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.label10);
            this.panel.Controls.Add(this.label9);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.txtSL);
            this.panel.Controls.Add(this.txtVAT);
            this.panel.Controls.Add(this.txtIDmon);
            this.panel.Controls.Add(this.label8);
            this.panel.Controls.Add(this.label6);
            this.panel.Controls.Add(this.IDBan);
            this.panel.Controls.Add(this.txtGiaban);
            this.panel.Controls.Add(this.txtNVtt);
            this.panel.Controls.Add(this.txtIDban);
            this.panel.Controls.Add(this.txtCode);
            this.panel.Controls.Add(this.MaKH);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.txtMaPX);
            this.panel.Controls.Add(this.txtMaKH);
            this.panel.Controls.Add(this.txtNgayxuat);
            this.panel.Controls.Add(this.txtTrangthai);
            this.panel.Location = new System.Drawing.Point(25, 42);
            this.panel.Margin = new System.Windows.Forms.Padding(2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1409, 167);
            this.panel.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(698, 33);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Giá Bán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(381, 89);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "NVthanhtoan";
            // 
            // IDBan
            // 
            this.IDBan.AutoSize = true;
            this.IDBan.Location = new System.Drawing.Point(381, 56);
            this.IDBan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IDBan.Name = "IDBan";
            this.IDBan.Size = new System.Drawing.Size(37, 13);
            this.IDBan.TabIndex = 25;
            this.IDBan.Text = "IDBan";
            // 
            // txtGiaban
            // 
            this.txtGiaban.Location = new System.Drawing.Point(758, 30);
            this.txtGiaban.Margin = new System.Windows.Forms.Padding(2);
            this.txtGiaban.Name = "txtGiaban";
            this.txtGiaban.Size = new System.Drawing.Size(129, 20);
            this.txtGiaban.TabIndex = 24;
            // 
            // txtNVtt
            // 
            this.txtNVtt.Location = new System.Drawing.Point(463, 86);
            this.txtNVtt.Margin = new System.Windows.Forms.Padding(2);
            this.txtNVtt.Name = "txtNVtt";
            this.txtNVtt.Size = new System.Drawing.Size(176, 20);
            this.txtNVtt.TabIndex = 22;
            // 
            // txtIDban
            // 
            this.txtIDban.Location = new System.Drawing.Point(463, 56);
            this.txtIDban.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDban.Name = "txtIDban";
            this.txtIDban.Size = new System.Drawing.Size(176, 20);
            this.txtIDban.TabIndex = 21;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(463, 26);
            this.txtCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(176, 20);
            this.txtCode.TabIndex = 20;
            // 
            // MaKH
            // 
            this.MaKH.AutoSize = true;
            this.MaKH.Location = new System.Drawing.Point(81, 113);
            this.MaKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MaKH.Name = "MaKH";
            this.MaKH.Size = new System.Drawing.Size(37, 13);
            this.MaKH.TabIndex = 19;
            this.MaKH.Text = "MaKH";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(386, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Trangthai";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "NgayXuat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã PX";
            // 
            // grvchitiethdnhap
            // 
            this.grvchitiethdnhap.AllowUserToAddRows = false;
            this.grvchitiethdnhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvchitiethdnhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HDNHAP,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column11});
            this.grvchitiethdnhap.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grvchitiethdnhap.Location = new System.Drawing.Point(768, 238);
            this.grvchitiethdnhap.Name = "grvchitiethdnhap";
            this.grvchitiethdnhap.RowHeadersWidth = 51;
            this.grvchitiethdnhap.Size = new System.Drawing.Size(666, 292);
            this.grvchitiethdnhap.TabIndex = 0;
            // 
            // HDNHAP
            // 
            this.HDNHAP.DataPropertyName = "idhoadon";
            this.HDNHAP.HeaderText = "IDHD";
            this.HDNHAP.MinimumWidth = 6;
            this.HDNHAP.Name = "HDNHAP";
            this.HDNHAP.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "giahientai";
            this.Column6.HeaderText = "Giá bán";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "gianhap";
            this.Column7.HeaderText = "ID món";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "VAT";
            this.Column8.HeaderText = "VAT";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "soluong";
            this.Column9.HeaderText = "SL";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "thanhtien";
            this.Column11.HeaderText = "Thành Tiền";
            this.Column11.Name = "Column11";
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
            // txtIDmon
            // 
            this.txtIDmon.Location = new System.Drawing.Point(758, 60);
            this.txtIDmon.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDmon.Name = "txtIDmon";
            this.txtIDmon.Size = new System.Drawing.Size(129, 20);
            this.txtIDmon.TabIndex = 29;
            // 
            // txtVAT
            // 
            this.txtVAT.Location = new System.Drawing.Point(758, 89);
            this.txtVAT.Margin = new System.Windows.Forms.Padding(2);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.Size = new System.Drawing.Size(129, 20);
            this.txtVAT.TabIndex = 30;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(758, 117);
            this.txtSL.Margin = new System.Windows.Forms.Padding(2);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(129, 20);
            this.txtSL.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(698, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Id món";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(698, 96);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "VAT";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(698, 124);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "SL";
            // 
            // formPHIEUXUAT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 815);
            this.Controls.Add(this.btnxem);
            this.Controls.Add(this.grvchitiethdnhap);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formPHIEUXUAT";
            this.Text = "Phiếu nhập";
            this.Load += new System.EventHandler(this.DgvKHACHHANG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvchitiethdnhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spgetchitiethoadonnhapBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox txtMaPX;
        private System.Windows.Forms.TextBox txtNgayxuat;
        private System.Windows.Forms.TextBox txtTrangthai;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label MaKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label IDBan;
        private System.Windows.Forms.TextBox txtGiaban;
        private System.Windows.Forms.TextBox txtNVtt;
        private System.Windows.Forms.TextBox txtIDban;
        private System.Windows.Forms.DataGridView grvchitiethdnhap;
        private System.Windows.Forms.BindingSource spgetchitiethoadonnhapBindingSource;
        //private QUANLYCHUOINHAHANGDataSet qUANLYCHUOINHAHANGDataSet;
        //private QUANLYCHUOINHAHANGDataSetTableAdapters.sp_get_chitiethoadonnhapTableAdapter sp_get_chitiethoadonnhapTableAdapter;
        private System.Windows.Forms.Button btnxem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn HDNHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtVAT;
        private System.Windows.Forms.TextBox txtIDmon;
    }
}