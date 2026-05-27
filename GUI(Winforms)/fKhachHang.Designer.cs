namespace doan1_Cuahangbanggiay.GUI_Winforms_
{
    partial class fKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fKhachHang));
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_KhachHang = new System.Windows.Forms.DataGridView();
            this.txt_EmailKH = new System.Windows.Forms.TextBox();
            this.DTP_NgayDK = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_GioiTinhKH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_SDTKH = new System.Windows.Forms.TextBox();
            this.txt_DiaChiKH = new System.Windows.Forms.TextBox();
            this.txt_TenKH = new System.Windows.Forms.TextBox();
            this.txt_MaKH = new System.Windows.Forms.TextBox();
            this.txt_TimKiemKH = new System.Windows.Forms.TextBox();
            this.btn_TimKiemKH = new System.Windows.Forms.Button();
            this.btn_XoaKH = new System.Windows.Forms.Button();
            this.btn_SuaKH = new System.Windows.Forms.Button();
            this.btn_ThemKH = new System.Windows.Forms.Button();
            this.btn_LamMoiKH = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 34);
            this.label1.TabIndex = 23;
            this.label1.Text = "THÔNG TIN KHÁCH HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_KhachHang
            // 
            this.dgv_KhachHang.BackgroundColor = System.Drawing.Color.White;
            this.dgv_KhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KhachHang.Location = new System.Drawing.Point(512, 123);
            this.dgv_KhachHang.Name = "dgv_KhachHang";
            this.dgv_KhachHang.RowHeadersWidth = 51;
            this.dgv_KhachHang.RowTemplate.Height = 24;
            this.dgv_KhachHang.Size = new System.Drawing.Size(679, 559);
            this.dgv_KhachHang.TabIndex = 0;
            this.dgv_KhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_KhachHang_CellContentClick);
            // 
            // txt_EmailKH
            // 
            this.txt_EmailKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_EmailKH.Location = new System.Drawing.Point(145, 399);
            this.txt_EmailKH.Name = "txt_EmailKH";
            this.txt_EmailKH.Size = new System.Drawing.Size(305, 22);
            this.txt_EmailKH.TabIndex = 18;
            // 
            // DTP_NgayDK
            // 
            this.DTP_NgayDK.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_NgayDK.Location = new System.Drawing.Point(145, 343);
            this.DTP_NgayDK.Name = "DTP_NgayDK";
            this.DTP_NgayDK.Size = new System.Drawing.Size(144, 22);
            this.DTP_NgayDK.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(53, 399);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 22);
            this.label8.TabIndex = 16;
            this.label8.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(33, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 22);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ngày DK:";
            // 
            // txt_GioiTinhKH
            // 
            this.txt_GioiTinhKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_GioiTinhKH.Location = new System.Drawing.Point(145, 292);
            this.txt_GioiTinhKH.Name = "txt_GioiTinhKH";
            this.txt_GioiTinhKH.Size = new System.Drawing.Size(305, 22);
            this.txt_GioiTinhKH.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(31, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Giới Tính:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(41, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tên KH:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(61, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "SDT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(41, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Địa Chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(45, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã KH:";
            // 
            // txt_SDTKH
            // 
            this.txt_SDTKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SDTKH.Location = new System.Drawing.Point(145, 230);
            this.txt_SDTKH.Name = "txt_SDTKH";
            this.txt_SDTKH.Size = new System.Drawing.Size(305, 22);
            this.txt_SDTKH.TabIndex = 5;
            // 
            // txt_DiaChiKH
            // 
            this.txt_DiaChiKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DiaChiKH.Location = new System.Drawing.Point(145, 173);
            this.txt_DiaChiKH.Name = "txt_DiaChiKH";
            this.txt_DiaChiKH.Size = new System.Drawing.Size(305, 22);
            this.txt_DiaChiKH.TabIndex = 4;
            // 
            // txt_TenKH
            // 
            this.txt_TenKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TenKH.Location = new System.Drawing.Point(146, 120);
            this.txt_TenKH.Name = "txt_TenKH";
            this.txt_TenKH.Size = new System.Drawing.Size(304, 22);
            this.txt_TenKH.TabIndex = 2;
            // 
            // txt_MaKH
            // 
            this.txt_MaKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaKH.Location = new System.Drawing.Point(146, 65);
            this.txt_MaKH.Name = "txt_MaKH";
            this.txt_MaKH.Size = new System.Drawing.Size(304, 22);
            this.txt_MaKH.TabIndex = 1;
            // 
            // txt_TimKiemKH
            // 
            this.txt_TimKiemKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TimKiemKH.Location = new System.Drawing.Point(159, 55);
            this.txt_TimKiemKH.Name = "txt_TimKiemKH";
            this.txt_TimKiemKH.Size = new System.Drawing.Size(491, 22);
            this.txt_TimKiemKH.TabIndex = 1;
            // 
            // btn_TimKiemKH
            // 
            this.btn_TimKiemKH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiemKH.ForeColor = System.Drawing.Color.Black;
            this.btn_TimKiemKH.Image = ((System.Drawing.Image)(resources.GetObject("btn_TimKiemKH.Image")));
            this.btn_TimKiemKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TimKiemKH.Location = new System.Drawing.Point(8, 42);
            this.btn_TimKiemKH.Name = "btn_TimKiemKH";
            this.btn_TimKiemKH.Size = new System.Drawing.Size(148, 45);
            this.btn_TimKiemKH.TabIndex = 0;
            this.btn_TimKiemKH.Text = "Tìm kiếm";
            this.btn_TimKiemKH.UseVisualStyleBackColor = true;
            this.btn_TimKiemKH.Click += new System.EventHandler(this.btn_TimKiemKH_Click);
            // 
            // btn_XoaKH
            // 
            this.btn_XoaKH.BackColor = System.Drawing.Color.Tomato;
            this.btn_XoaKH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaKH.ForeColor = System.Drawing.Color.Black;
            this.btn_XoaKH.Image = ((System.Drawing.Image)(resources.GetObject("btn_XoaKH.Image")));
            this.btn_XoaKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XoaKH.Location = new System.Drawing.Point(306, 484);
            this.btn_XoaKH.Name = "btn_XoaKH";
            this.btn_XoaKH.Size = new System.Drawing.Size(144, 53);
            this.btn_XoaKH.TabIndex = 3;
            this.btn_XoaKH.Text = "Xóa";
            this.btn_XoaKH.UseVisualStyleBackColor = false;
            this.btn_XoaKH.Click += new System.EventHandler(this.btn_XoaKH_Click);
            // 
            // btn_SuaKH
            // 
            this.btn_SuaKH.BackColor = System.Drawing.Color.DarkOrchid;
            this.btn_SuaKH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaKH.ForeColor = System.Drawing.Color.Black;
            this.btn_SuaKH.Image = ((System.Drawing.Image)(resources.GetObject("btn_SuaKH.Image")));
            this.btn_SuaKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SuaKH.Location = new System.Drawing.Point(50, 572);
            this.btn_SuaKH.Name = "btn_SuaKH";
            this.btn_SuaKH.Size = new System.Drawing.Size(144, 53);
            this.btn_SuaKH.TabIndex = 2;
            this.btn_SuaKH.Text = "Sửa ";
            this.btn_SuaKH.UseVisualStyleBackColor = false;
            this.btn_SuaKH.Click += new System.EventHandler(this.btn_SuaKH_Click);
            // 
            // btn_ThemKH
            // 
            this.btn_ThemKH.BackColor = System.Drawing.Color.Lime;
            this.btn_ThemKH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemKH.ForeColor = System.Drawing.Color.Black;
            this.btn_ThemKH.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThemKH.Image")));
            this.btn_ThemKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThemKH.Location = new System.Drawing.Point(50, 484);
            this.btn_ThemKH.Name = "btn_ThemKH";
            this.btn_ThemKH.Size = new System.Drawing.Size(144, 53);
            this.btn_ThemKH.TabIndex = 1;
            this.btn_ThemKH.Text = "Thêm";
            this.btn_ThemKH.UseVisualStyleBackColor = false;
            this.btn_ThemKH.Click += new System.EventHandler(this.btn_ThemKH_Click);
            // 
            // btn_LamMoiKH
            // 
            this.btn_LamMoiKH.BackColor = System.Drawing.Color.Cyan;
            this.btn_LamMoiKH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LamMoiKH.ForeColor = System.Drawing.Color.Black;
            this.btn_LamMoiKH.Image = ((System.Drawing.Image)(resources.GetObject("btn_LamMoiKH.Image")));
            this.btn_LamMoiKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LamMoiKH.Location = new System.Drawing.Point(306, 564);
            this.btn_LamMoiKH.Name = "btn_LamMoiKH";
            this.btn_LamMoiKH.Size = new System.Drawing.Size(144, 53);
            this.btn_LamMoiKH.TabIndex = 0;
            this.btn_LamMoiKH.Text = "Làm mới";
            this.btn_LamMoiKH.UseVisualStyleBackColor = false;
            this.btn_LamMoiKH.Click += new System.EventHandler(this.btn_LamMoiKH_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.txt_EmailKH);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.DTP_NgayDK);
            this.panel1.Controls.Add(this.btn_XoaKH);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btn_SuaKH);
            this.panel1.Controls.Add(this.txt_GioiTinhKH);
            this.panel1.Controls.Add(this.btn_ThemKH);
            this.panel1.Controls.Add(this.btn_LamMoiKH);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_SDTKH);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_DiaChiKH);
            this.panel1.Controls.Add(this.txt_MaKH);
            this.panel1.Controls.Add(this.txt_TenKH);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 682);
            this.panel1.TabIndex = 24;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(511, 109);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(653, 519);
            this.panel4.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.panel2.Controls.Add(this.txt_TimKiemKH);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.btn_TimKiemKH);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(512, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(679, 103);
            this.panel2.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(675, 34);
            this.label9.TabIndex = 27;
            this.label9.Text = "BỘ LỌC";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 109);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(605, 519);
            this.panel3.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(509, 97);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(682, 34);
            this.label10.TabIndex = 28;
            this.label10.Text = "DANH SÁCH KHÁCH HÀNG";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 681);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgv_KhachHang);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KHACHHANG";
            this.Load += new System.EventHandler(this.fKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_KhachHang;
        private System.Windows.Forms.TextBox txt_GioiTinhKH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_SDTKH;
        private System.Windows.Forms.TextBox txt_DiaChiKH;
        private System.Windows.Forms.TextBox txt_TenKH;
        private System.Windows.Forms.TextBox txt_MaKH;
        private System.Windows.Forms.TextBox txt_TimKiemKH;
        private System.Windows.Forms.Button btn_TimKiemKH;
        private System.Windows.Forms.Button btn_XoaKH;
        private System.Windows.Forms.Button btn_SuaKH;
        private System.Windows.Forms.Button btn_ThemKH;
        private System.Windows.Forms.Button btn_LamMoiKH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_EmailKH;
        private System.Windows.Forms.DateTimePicker DTP_NgayDK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}