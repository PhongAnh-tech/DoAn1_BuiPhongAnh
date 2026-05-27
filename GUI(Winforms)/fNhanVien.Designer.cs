namespace doan1_Cuahangbanggiay.GUI_Winforms_
{
    partial class fNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fNhanVien));
            this.btn_XoaNV = new System.Windows.Forms.Button();
            this.btn_SuaNV = new System.Windows.Forms.Button();
            this.btn_ThemNV = new System.Windows.Forms.Button();
            this.btn_LamMoiNV = new System.Windows.Forms.Button();
            this.DTP_NgaySinhNV = new System.Windows.Forms.DateTimePicker();
            this.txt_SDTNV = new System.Windows.Forms.TextBox();
            this.txt_EmailNV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_GioiTinhNV = new System.Windows.Forms.TextBox();
            this.txt_MaLoai = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TenNV = new System.Windows.Forms.TextBox();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.txt_TimKiemNV = new System.Windows.Forms.TextBox();
            this.btn_TimKiemNV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_NhanVien = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_XoaNV
            // 
            this.btn_XoaNV.BackColor = System.Drawing.Color.Tomato;
            this.btn_XoaNV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaNV.ForeColor = System.Drawing.Color.Black;
            this.btn_XoaNV.Image = ((System.Drawing.Image)(resources.GetObject("btn_XoaNV.Image")));
            this.btn_XoaNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XoaNV.Location = new System.Drawing.Point(297, 465);
            this.btn_XoaNV.Name = "btn_XoaNV";
            this.btn_XoaNV.Size = new System.Drawing.Size(143, 53);
            this.btn_XoaNV.TabIndex = 3;
            this.btn_XoaNV.Text = "Xóa";
            this.btn_XoaNV.UseVisualStyleBackColor = false;
            this.btn_XoaNV.Click += new System.EventHandler(this.btn_XoaNV_Click);
            // 
            // btn_SuaNV
            // 
            this.btn_SuaNV.BackColor = System.Drawing.Color.DarkOrchid;
            this.btn_SuaNV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaNV.ForeColor = System.Drawing.Color.Black;
            this.btn_SuaNV.Image = ((System.Drawing.Image)(resources.GetObject("btn_SuaNV.Image")));
            this.btn_SuaNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SuaNV.Location = new System.Drawing.Point(66, 546);
            this.btn_SuaNV.Name = "btn_SuaNV";
            this.btn_SuaNV.Size = new System.Drawing.Size(143, 53);
            this.btn_SuaNV.TabIndex = 2;
            this.btn_SuaNV.Text = "Sửa ";
            this.btn_SuaNV.UseVisualStyleBackColor = false;
            this.btn_SuaNV.Click += new System.EventHandler(this.btn_SuaNV_Click);
            // 
            // btn_ThemNV
            // 
            this.btn_ThemNV.BackColor = System.Drawing.Color.Lime;
            this.btn_ThemNV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemNV.ForeColor = System.Drawing.Color.Black;
            this.btn_ThemNV.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThemNV.Image")));
            this.btn_ThemNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThemNV.Location = new System.Drawing.Point(66, 465);
            this.btn_ThemNV.Name = "btn_ThemNV";
            this.btn_ThemNV.Size = new System.Drawing.Size(143, 53);
            this.btn_ThemNV.TabIndex = 1;
            this.btn_ThemNV.Text = "Thêm";
            this.btn_ThemNV.UseVisualStyleBackColor = false;
            this.btn_ThemNV.Click += new System.EventHandler(this.btn_ThemNV_Click);
            // 
            // btn_LamMoiNV
            // 
            this.btn_LamMoiNV.BackColor = System.Drawing.Color.Cyan;
            this.btn_LamMoiNV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LamMoiNV.ForeColor = System.Drawing.Color.Black;
            this.btn_LamMoiNV.Image = ((System.Drawing.Image)(resources.GetObject("btn_LamMoiNV.Image")));
            this.btn_LamMoiNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LamMoiNV.Location = new System.Drawing.Point(297, 546);
            this.btn_LamMoiNV.Name = "btn_LamMoiNV";
            this.btn_LamMoiNV.Size = new System.Drawing.Size(143, 53);
            this.btn_LamMoiNV.TabIndex = 0;
            this.btn_LamMoiNV.Text = "Làm mới";
            this.btn_LamMoiNV.UseVisualStyleBackColor = false;
            this.btn_LamMoiNV.Click += new System.EventHandler(this.btn_LamMoiNV_Click);
            // 
            // DTP_NgaySinhNV
            // 
            this.DTP_NgaySinhNV.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_NgaySinhNV.Location = new System.Drawing.Point(124, 246);
            this.DTP_NgaySinhNV.Name = "DTP_NgaySinhNV";
            this.DTP_NgaySinhNV.Size = new System.Drawing.Size(142, 22);
            this.DTP_NgaySinhNV.TabIndex = 16;
            // 
            // txt_SDTNV
            // 
            this.txt_SDTNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SDTNV.Location = new System.Drawing.Point(123, 179);
            this.txt_SDTNV.Name = "txt_SDTNV";
            this.txt_SDTNV.Size = new System.Drawing.Size(266, 22);
            this.txt_SDTNV.TabIndex = 15;
            // 
            // txt_EmailNV
            // 
            this.txt_EmailNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_EmailNV.Location = new System.Drawing.Point(124, 301);
            this.txt_EmailNV.Name = "txt_EmailNV";
            this.txt_EmailNV.Size = new System.Drawing.Size(265, 22);
            this.txt_EmailNV.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(62, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "SDT:";
            // 
            // txt_GioiTinhNV
            // 
            this.txt_GioiTinhNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_GioiTinhNV.Location = new System.Drawing.Point(124, 353);
            this.txt_GioiTinhNV.Name = "txt_GioiTinhNV";
            this.txt_GioiTinhNV.Size = new System.Drawing.Size(265, 22);
            this.txt_GioiTinhNV.TabIndex = 4;
            // 
            // txt_MaLoai
            // 
            this.txt_MaLoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaLoai.Location = new System.Drawing.Point(124, 406);
            this.txt_MaLoai.Name = "txt_MaLoai";
            this.txt_MaLoai.Size = new System.Drawing.Size(265, 22);
            this.txt_MaLoai.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(55, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(46, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mã loại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(26, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày Sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(36, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Giới Tính:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(44, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên NV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(47, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã NV:";
            // 
            // txt_TenNV
            // 
            this.txt_TenNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TenNV.Location = new System.Drawing.Point(122, 125);
            this.txt_TenNV.Name = "txt_TenNV";
            this.txt_TenNV.Size = new System.Drawing.Size(267, 22);
            this.txt_TenNV.TabIndex = 2;

            // 
            // txt_MaNV
            // 
            this.txt_MaNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaNV.Location = new System.Drawing.Point(122, 76);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(267, 22);
            this.txt_MaNV.TabIndex = 1;
            // 
            // txt_TimKiemNV
            // 
            this.txt_TimKiemNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TimKiemNV.Location = new System.Drawing.Point(140, 70);
            this.txt_TimKiemNV.Name = "txt_TimKiemNV";
            this.txt_TimKiemNV.Size = new System.Drawing.Size(508, 22);
            this.txt_TimKiemNV.TabIndex = 1;
            // 
            // btn_TimKiemNV
            // 
            this.btn_TimKiemNV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiemNV.ForeColor = System.Drawing.Color.Black;
            this.btn_TimKiemNV.Image = ((System.Drawing.Image)(resources.GetObject("btn_TimKiemNV.Image")));
            this.btn_TimKiemNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TimKiemNV.Location = new System.Drawing.Point(6, 61);
            this.btn_TimKiemNV.Name = "btn_TimKiemNV";
            this.btn_TimKiemNV.Size = new System.Drawing.Size(128, 37);
            this.btn_TimKiemNV.TabIndex = 0;
            this.btn_TimKiemNV.Text = "Tìm kiếm";
            this.btn_TimKiemNV.UseVisualStyleBackColor = true;
            this.btn_TimKiemNV.Click += new System.EventHandler(this.btn_TimKiemNV_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 34);
            this.label1.TabIndex = 22;
            this.label1.Text = "THÔNG TIN NHÂN VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_NhanVien
            // 
            this.dgv_NhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dgv_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NhanVien.Location = new System.Drawing.Point(0, 33);
            this.dgv_NhanVien.Name = "dgv_NhanVien";
            this.dgv_NhanVien.RowHeadersWidth = 51;
            this.dgv_NhanVien.RowTemplate.Height = 24;
            this.dgv_NhanVien.Size = new System.Drawing.Size(661, 524);
            this.dgv_NhanVien.TabIndex = 0;
            this.dgv_NhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NhanVien_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_SDTNV);
            this.panel1.Controls.Add(this.DTP_NgaySinhNV);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_LamMoiNV);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_EmailNV);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btn_XoaNV);
            this.panel1.Controls.Add(this.btn_ThemNV);
            this.panel1.Controls.Add(this.txt_GioiTinhNV);
            this.panel1.Controls.Add(this.btn_SuaNV);
            this.panel1.Controls.Add(this.txt_MaLoai);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_MaNV);
            this.panel1.Controls.Add(this.txt_TenNV);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 682);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.panel2.Controls.Add(this.txt_TimKiemNV);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.btn_TimKiemNV);
            this.panel2.Location = new System.Drawing.Point(529, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(661, 127);
            this.panel2.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(661, 34);
            this.label9.TabIndex = 23;
            this.label9.Text = "BỘ LỌC";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgv_NhanVien);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(529, 125);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(661, 557);
            this.panel3.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(-7, 0);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(668, 34);
            this.label10.TabIndex = 24;
            this.label10.Text = "DANH SÁCH NHÂN VIÊN";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 681);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NHANVIEN";
            this.Load += new System.EventHandler(this.fNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_XoaNV;
        private System.Windows.Forms.Button btn_SuaNV;
        private System.Windows.Forms.Button btn_ThemNV;
        private System.Windows.Forms.Button btn_LamMoiNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MaLoai;
        private System.Windows.Forms.TextBox txt_GioiTinhNV;
        private System.Windows.Forms.TextBox txt_TenNV;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.TextBox txt_TimKiemNV;
        private System.Windows.Forms.Button btn_TimKiemNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_NhanVien;
        private System.Windows.Forms.TextBox txt_SDTNV;
        private System.Windows.Forms.TextBox txt_EmailNV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DTP_NgaySinhNV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
    }
}