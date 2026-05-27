namespace doan1_Cuahangbanggiay.GUI_Winforms_
{
    partial class fQuanLyDonNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQuanLyDonNhap));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_MaKM = new System.Windows.Forms.ComboBox();
            this.dpK_NgayNhap = new System.Windows.Forms.DateTimePicker();
            this.cmb_MaNCC = new System.Windows.Forms.ComboBox();
            this.cmb_MaNV = new System.Windows.Forms.ComboBox();
            this.btn_TaoPhieu = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_MaDN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_DonNhap = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_CTPN = new System.Windows.Forms.DataGridView();
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_XNNK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgv_ChuaNhapKho = new System.Windows.Forms.DataGridView();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DonNhap)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CTPN)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChuaNhapKho)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmb_MaKM);
            this.panel1.Controls.Add(this.dpK_NgayNhap);
            this.panel1.Controls.Add(this.cmb_MaNCC);
            this.panel1.Controls.Add(this.cmb_MaNV);
            this.panel1.Controls.Add(this.btn_TaoPhieu);
            this.panel1.Controls.Add(this.btn_Them);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txt_MaDN);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 404);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(33, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 19);
            this.label4.TabIndex = 38;
            this.label4.Text = "Mã Khuyến Mãi:";
            // 
            // cmb_MaKM
            // 
            this.cmb_MaKM.FormattingEnabled = true;
            this.cmb_MaKM.Location = new System.Drawing.Point(175, 268);
            this.cmb_MaKM.Name = "cmb_MaKM";
            this.cmb_MaKM.Size = new System.Drawing.Size(121, 24);
            this.cmb_MaKM.TabIndex = 37;
            // 
            // dpK_NgayNhap
            // 
            this.dpK_NgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpK_NgayNhap.Location = new System.Drawing.Point(175, 218);
            this.dpK_NgayNhap.Name = "dpK_NgayNhap";
            this.dpK_NgayNhap.Size = new System.Drawing.Size(121, 22);
            this.dpK_NgayNhap.TabIndex = 36;
            // 
            // cmb_MaNCC
            // 
            this.cmb_MaNCC.FormattingEnabled = true;
            this.cmb_MaNCC.Location = new System.Drawing.Point(175, 166);
            this.cmb_MaNCC.Name = "cmb_MaNCC";
            this.cmb_MaNCC.Size = new System.Drawing.Size(274, 24);
            this.cmb_MaNCC.TabIndex = 35;
            // 
            // cmb_MaNV
            // 
            this.cmb_MaNV.FormattingEnabled = true;
            this.cmb_MaNV.Location = new System.Drawing.Point(175, 120);
            this.cmb_MaNV.Name = "cmb_MaNV";
            this.cmb_MaNV.Size = new System.Drawing.Size(274, 24);
            this.cmb_MaNV.TabIndex = 34;
            // 
            // btn_TaoPhieu
            // 
            this.btn_TaoPhieu.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_TaoPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_TaoPhieu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaoPhieu.ForeColor = System.Drawing.Color.White;
            this.btn_TaoPhieu.Image = ((System.Drawing.Image)(resources.GetObject("btn_TaoPhieu.Image")));
            this.btn_TaoPhieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TaoPhieu.Location = new System.Drawing.Point(175, 9);
            this.btn_TaoPhieu.Name = "btn_TaoPhieu";
            this.btn_TaoPhieu.Size = new System.Drawing.Size(180, 42);
            this.btn_TaoPhieu.TabIndex = 30;
            this.btn_TaoPhieu.Text = "Tạo Phiếu";
            this.btn_TaoPhieu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TaoPhieu.UseVisualStyleBackColor = false;
            this.btn_TaoPhieu.Click += new System.EventHandler(this.btn_TaoPhieu_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Image = ((System.Drawing.Image)(resources.GetObject("btn_Them.Image")));
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(189, 339);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(144, 53);
            this.btn_Them.TabIndex = 2;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(44, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 19);
            this.label11.TabIndex = 6;
            this.label11.Text = "Mã Đơn Nhập:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(66, 218);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 19);
            this.label14.TabIndex = 17;
            this.label14.Text = "Ngày Nhập:";
            // 
            // txt_MaDN
            // 
            this.txt_MaDN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaDN.Location = new System.Drawing.Point(175, 78);
            this.txt_MaDN.Name = "txt_MaDN";
            this.txt_MaDN.Size = new System.Drawing.Size(274, 22);
            this.txt_MaDN.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(41, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Mã Nhân Viên:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(72, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Mã NCC:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, -7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 43);
            this.label1.TabIndex = 25;
            this.label1.Text = "THÔNG TIN NHẬP SẢN PHẨM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_DonNhap
            // 
            this.dgv_DonNhap.BackgroundColor = System.Drawing.Color.White;
            this.dgv_DonNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DonNhap.Location = new System.Drawing.Point(0, 0);
            this.dgv_DonNhap.Name = "dgv_DonNhap";
            this.dgv_DonNhap.RowHeadersWidth = 51;
            this.dgv_DonNhap.RowTemplate.Height = 24;
            this.dgv_DonNhap.Size = new System.Drawing.Size(682, 368);
            this.dgv_DonNhap.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_DonNhap);
            this.panel2.Location = new System.Drawing.Point(506, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(682, 370);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(506, -3);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(682, 34);
            this.label2.TabIndex = 26;
            this.label2.Text = "DANH SÁCH SẢN PHẨM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgv_CTPN);
            this.panel3.Location = new System.Drawing.Point(5, 440);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(503, 176);
            this.panel3.TabIndex = 27;
            // 
            // dgv_CTPN
            // 
            this.dgv_CTPN.BackgroundColor = System.Drawing.Color.White;
            this.dgv_CTPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CTPN.Location = new System.Drawing.Point(0, 0);
            this.dgv_CTPN.Name = "dgv_CTPN";
            this.dgv_CTPN.RowHeadersWidth = 51;
            this.dgv_CTPN.RowTemplate.Height = 24;
            this.dgv_CTPN.Size = new System.Drawing.Size(500, 173);
            this.dgv_CTPN.TabIndex = 0;
            // 
            // btn_huy
            // 
            this.btn_huy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.Image = ((System.Drawing.Image)(resources.GetObject("btn_huy.Image")));
            this.btn_huy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_huy.Location = new System.Drawing.Point(225, 622);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(117, 47);
            this.btn_huy.TabIndex = 29;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.Image = ((System.Drawing.Image)(resources.GetObject("btn_Luu.Image")));
            this.btn_Luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Luu.Location = new System.Drawing.Point(48, 622);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(117, 47);
            this.btn_Luu.TabIndex = 28;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_XNNK
            // 
            this.btn_XNNK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XNNK.Image = ((System.Drawing.Image)(resources.GetObject("btn_XNNK.Image")));
            this.btn_XNNK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XNNK.Location = new System.Drawing.Point(864, 622);
            this.btn_XNNK.Name = "btn_XNNK";
            this.btn_XNNK.Size = new System.Drawing.Size(226, 47);
            this.btn_XNNK.TabIndex = 30;
            this.btn_XNNK.Text = "Xác nhận nhập kho";
            this.btn_XNNK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_XNNK.UseVisualStyleBackColor = true;
            this.btn_XNNK.Click += new System.EventHandler(this.btn_XNNK_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(510, 401);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(678, 34);
            this.label3.TabIndex = 31;
            this.label3.Text = "DANH SÁCH PHIẾU NHẬP CHƯA NHẬP KHO";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgv_ChuaNhapKho);
            this.panel4.Location = new System.Drawing.Point(511, 440);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(677, 176);
            this.panel4.TabIndex = 31;
            // 
            // dgv_ChuaNhapKho
            // 
            this.dgv_ChuaNhapKho.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ChuaNhapKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ChuaNhapKho.Location = new System.Drawing.Point(3, 0);
            this.dgv_ChuaNhapKho.Name = "dgv_ChuaNhapKho";
            this.dgv_ChuaNhapKho.RowHeadersWidth = 51;
            this.dgv_ChuaNhapKho.RowTemplate.Height = 24;
            this.dgv_ChuaNhapKho.Size = new System.Drawing.Size(667, 173);
            this.dgv_ChuaNhapKho.TabIndex = 0;
            this.dgv_ChuaNhapKho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ChuaNhapKho_CellContentClick);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.Image")));
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(672, 622);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(117, 47);
            this.btn_Xoa.TabIndex = 32;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // fQuanLyDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 681);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btn_XNNK);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fQuanLyDonNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DONNHAP & CHITIETDONNHAP";
            this.Load += new System.EventHandler(this.fQuanLyDonNhap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DonNhap)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CTPN)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChuaNhapKho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_DonNhap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_MaDN;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv_CTPN;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_TaoPhieu;
        private System.Windows.Forms.Button btn_XNNK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgv_ChuaNhapKho;
        private System.Windows.Forms.ComboBox cmb_MaKM;
        private System.Windows.Forms.DateTimePicker dpK_NgayNhap;
        private System.Windows.Forms.ComboBox cmb_MaNCC;
        private System.Windows.Forms.ComboBox cmb_MaNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Xoa;
    }
}