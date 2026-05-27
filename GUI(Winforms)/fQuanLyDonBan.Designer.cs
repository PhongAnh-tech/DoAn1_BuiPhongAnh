namespace doan1_Cuahangbanggiay.GUI_Winforms_
{
    partial class fQuanLyDonBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQuanLyDonBan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_TenKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.dgv_DonBan = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_ApDung = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_NhaCC = new System.Windows.Forms.ComboBox();
            this.cmb_LSP = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TenSP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.lbl_TongHoaDon = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_SanPham = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DonBan)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txt_TenKH);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 235);
            this.panel1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(10, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 22);
            this.label9.TabIndex = 36;
            this.label9.Text = "Tên khách hàng:";
            // 
            // txt_TenKH
            // 
            this.txt_TenKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TenKH.Location = new System.Drawing.Point(133, 108);
            this.txt_TenKH.Name = "txt_TenKH";
            this.txt_TenKH.Size = new System.Drawing.Size(471, 22);
            this.txt_TenKH.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-5, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(658, 29);
            this.label1.TabIndex = 32;
            this.label1.Text = "THÔNG TIN KHÁCH HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.BackColor = System.Drawing.Color.Cyan;
            this.btn_LamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LamMoi.ForeColor = System.Drawing.Color.Black;
            this.btn_LamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btn_LamMoi.Image")));
            this.btn_LamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LamMoi.Location = new System.Drawing.Point(325, 149);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(167, 53);
            this.btn_LamMoi.TabIndex = 1;
            this.btn_LamMoi.Text = "Làm mới";
            this.btn_LamMoi.UseVisualStyleBackColor = false;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // dgv_DonBan
            // 
            this.dgv_DonBan.BackgroundColor = System.Drawing.Color.White;
            this.dgv_DonBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DonBan.Location = new System.Drawing.Point(0, 32);
            this.dgv_DonBan.Name = "dgv_DonBan";
            this.dgv_DonBan.RowHeadersWidth = 51;
            this.dgv_DonBan.RowTemplate.Height = 24;
            this.dgv_DonBan.Size = new System.Drawing.Size(657, 280);
            this.dgv_DonBan.TabIndex = 0;
            this.dgv_DonBan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DonBan_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.panel2.Controls.Add(this.btn_ApDung);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.btn_LamMoi);
            this.panel2.Controls.Add(this.cmb_NhaCC);
            this.panel2.Controls.Add(this.cmb_LSP);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_TenSP);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(658, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(531, 235);
            this.panel2.TabIndex = 1;
            // 
            // btn_ApDung
            // 
            this.btn_ApDung.BackColor = System.Drawing.Color.Azure;
            this.btn_ApDung.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ApDung.ForeColor = System.Drawing.Color.Black;
            this.btn_ApDung.Image = ((System.Drawing.Image)(resources.GetObject("btn_ApDung.Image")));
            this.btn_ApDung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ApDung.Location = new System.Drawing.Point(107, 149);
            this.btn_ApDung.Name = "btn_ApDung";
            this.btn_ApDung.Size = new System.Drawing.Size(167, 53);
            this.btn_ApDung.TabIndex = 41;
            this.btn_ApDung.Text = "Áp dụng";
            this.btn_ApDung.UseVisualStyleBackColor = false;
            this.btn_ApDung.Click += new System.EventHandler(this.btn_ApDung_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(406, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 19);
            this.label12.TabIndex = 40;
            this.label12.Text = "Nhà cung cấp";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(274, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 19);
            this.label11.TabIndex = 39;
            this.label11.Text = "Loại sản phẩm:";
            // 
            // cmb_NhaCC
            // 
            this.cmb_NhaCC.FormattingEnabled = true;
            this.cmb_NhaCC.Location = new System.Drawing.Point(410, 94);
            this.cmb_NhaCC.Name = "cmb_NhaCC";
            this.cmb_NhaCC.Size = new System.Drawing.Size(121, 24);
            this.cmb_NhaCC.TabIndex = 38;
            // 
            // cmb_LSP
            // 
            this.cmb_LSP.FormattingEnabled = true;
            this.cmb_LSP.Location = new System.Drawing.Point(278, 94);
            this.cmb_LSP.Name = "cmb_LSP";
            this.cmb_LSP.Size = new System.Drawing.Size(121, 24);
            this.cmb_LSP.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 19);
            this.label4.TabIndex = 36;
            this.label4.Text = "Tên sản phẩm:";
            // 
            // txt_TenSP
            // 
            this.txt_TenSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TenSP.Location = new System.Drawing.Point(16, 94);
            this.txt_TenSP.Name = "txt_TenSP";
            this.txt_TenSP.Size = new System.Drawing.Size(230, 22);
            this.txt_TenSP.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(531, 29);
            this.label2.TabIndex = 33;
            this.label2.Text = "BỘ LỌC";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.panel3.Controls.Add(this.btn_Huy);
            this.panel3.Controls.Add(this.btn_ThanhToan);
            this.panel3.Controls.Add(this.lbl_TongHoaDon);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.dgv_DonBan);
            this.panel3.Location = new System.Drawing.Point(2, 235);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(657, 442);
            this.panel3.TabIndex = 32;
            // 
            // btn_Huy
            // 
            this.btn_Huy.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_Huy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.Image = ((System.Drawing.Image)(resources.GetObject("btn_Huy.Image")));
            this.btn_Huy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Huy.Location = new System.Drawing.Point(390, 373);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(214, 51);
            this.btn_Huy.TabIndex = 39;
            this.btn_Huy.Text = "HỦY";
            this.btn_Huy.UseVisualStyleBackColor = false;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_ThanhToan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThanhToan.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThanhToan.Image")));
            this.btn_ThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThanhToan.Location = new System.Drawing.Point(87, 373);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(214, 51);
            this.btn_ThanhToan.TabIndex = 38;
            this.btn_ThanhToan.Text = "THANH TOÁN ";
            this.btn_ThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ThanhToan.UseVisualStyleBackColor = false;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // lbl_TongHoaDon
            // 
            this.lbl_TongHoaDon.AutoSize = true;
            this.lbl_TongHoaDon.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TongHoaDon.ForeColor = System.Drawing.Color.Orange;
            this.lbl_TongHoaDon.Location = new System.Drawing.Point(191, 326);
            this.lbl_TongHoaDon.Name = "lbl_TongHoaDon";
            this.lbl_TongHoaDon.Size = new System.Drawing.Size(24, 25);
            this.lbl_TongHoaDon.TabIndex = 37;
            this.lbl_TongHoaDon.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(54, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 24);
            this.label5.TabIndex = 34;
            this.label5.Text = "Tổng hóa đơn:";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(-1, 0);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(658, 29);
            this.label10.TabIndex = 33;
            this.label10.Text = "THÔNG TIN HÓA ĐƠN";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(658, 235);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(531, 29);
            this.label3.TabIndex = 34;
            this.label3.Text = "DANH SÁCH SẢN PHẨM";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_SanPham
            // 
            this.dgv_SanPham.BackgroundColor = System.Drawing.Color.White;
            this.dgv_SanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SanPham.Location = new System.Drawing.Point(663, 267);
            this.dgv_SanPham.Name = "dgv_SanPham";
            this.dgv_SanPham.RowHeadersWidth = 51;
            this.dgv_SanPham.RowTemplate.Height = 24;
            this.dgv_SanPham.Size = new System.Drawing.Size(526, 410);
            this.dgv_SanPham.TabIndex = 35;
            this.dgv_SanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SanPham_CellContentClick);
            // 
            // fQuanLyDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 681);
            this.Controls.Add(this.dgv_SanPham);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fQuanLyDonBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DONBAN & CHITIETDONBAN";
            this.Load += new System.EventHandler(this.fQuanLyDonBan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DonBan)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_DonBan;
        private System.Windows.Forms.Button btn_LamMoi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_TenKH;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_NhaCC;
        private System.Windows.Forms.ComboBox cmb_LSP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_TenSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_ThanhToan;
        private System.Windows.Forms.Label lbl_TongHoaDon;
        private System.Windows.Forms.Button btn_ApDung;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgv_SanPham;
    }
}