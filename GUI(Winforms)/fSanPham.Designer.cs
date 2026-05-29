namespace doan1_Cuahangbanggiay.GUI_Winforms_
{
    partial class fSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSanPham));
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Giay = new System.Windows.Forms.DataGridView();
            this.txt_KhuyenMai = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_MaNCC = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_DGBan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_DGNhap = new System.Windows.Forms.TextBox();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.cmb_Loai = new System.Windows.Forms.ComboBox();
            this.txt_TenGiay = new System.Windows.Forms.TextBox();
            this.txt_MaGiay = new System.Windows.Forms.TextBox();
            this.txt_TimKiemGiay = new System.Windows.Forms.TextBox();
            this.btn_TimKiemGiay = new System.Windows.Forms.Button();
            this.btn_XoaGiay = new System.Windows.Forms.Button();
            this.btn_SuaGiay = new System.Windows.Forms.Button();
            this.btn_ThemGiay = new System.Windows.Forms.Button();
            this.btn_LamMoiGiay = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_NhaCungCap = new System.Windows.Forms.Button();
            this.btn_LoaiGiay = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Giay)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(-6, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(572, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "THÀNH PHẦN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_Giay
            // 
            this.dgv_Giay.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Giay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Giay.Location = new System.Drawing.Point(0, 24);
            this.dgv_Giay.Name = "dgv_Giay";
            this.dgv_Giay.RowHeadersWidth = 51;
            this.dgv_Giay.RowTemplate.Height = 24;
            this.dgv_Giay.Size = new System.Drawing.Size(620, 549);
            this.dgv_Giay.TabIndex = 0;
            this.dgv_Giay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Giay_CellContentClick);
            // 
            // txt_KhuyenMai
            // 
            this.txt_KhuyenMai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_KhuyenMai.Location = new System.Drawing.Point(120, 423);
            this.txt_KhuyenMai.Name = "txt_KhuyenMai";
            this.txt_KhuyenMai.Size = new System.Drawing.Size(230, 22);
            this.txt_KhuyenMai.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(8, 423);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "Khuyến Mãi:";
            // 
            // cmb_MaNCC
            // 
            this.cmb_MaNCC.FormattingEnabled = true;
            this.cmb_MaNCC.Location = new System.Drawing.Point(120, 130);
            this.cmb_MaNCC.Name = "cmb_MaNCC";
            this.cmb_MaNCC.Size = new System.Drawing.Size(230, 24);
            this.cmb_MaNCC.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(31, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "Mã NCC:";
            // 
            // txt_DGBan
            // 
            this.txt_DGBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DGBan.Location = new System.Drawing.Point(120, 370);
            this.txt_DGBan.Name = "txt_DGBan";
            this.txt_DGBan.Size = new System.Drawing.Size(230, 22);
            this.txt_DGBan.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(37, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "DG Bán:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(28, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "DG Nhập:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(25, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Số Lượng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(43, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mã LG:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(30, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên Giày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã Giày:";
            // 
            // txt_DGNhap
            // 
            this.txt_DGNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DGNhap.Location = new System.Drawing.Point(120, 310);
            this.txt_DGNhap.Name = "txt_DGNhap";
            this.txt_DGNhap.Size = new System.Drawing.Size(230, 22);
            this.txt_DGNhap.TabIndex = 5;
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SoLuong.Location = new System.Drawing.Point(120, 254);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(230, 22);
            this.txt_SoLuong.TabIndex = 4;
            // 
            // cmb_Loai
            // 
            this.cmb_Loai.FormattingEnabled = true;
            this.cmb_Loai.Location = new System.Drawing.Point(120, 193);
            this.cmb_Loai.Name = "cmb_Loai";
            this.cmb_Loai.Size = new System.Drawing.Size(230, 24);
            this.cmb_Loai.TabIndex = 3;
            this.cmb_Loai.SelectedIndexChanged += new System.EventHandler(this.cmb_Loai_SelectedIndexChanged);
            // 
            // txt_TenGiay
            // 
            this.txt_TenGiay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TenGiay.Location = new System.Drawing.Point(120, 73);
            this.txt_TenGiay.Name = "txt_TenGiay";
            this.txt_TenGiay.Size = new System.Drawing.Size(230, 22);
            this.txt_TenGiay.TabIndex = 2;
            // 
            // txt_MaGiay
            // 
            this.txt_MaGiay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaGiay.Location = new System.Drawing.Point(120, 20);
            this.txt_MaGiay.Name = "txt_MaGiay";
            this.txt_MaGiay.Size = new System.Drawing.Size(230, 22);
            this.txt_MaGiay.TabIndex = 1;
            // 
            // txt_TimKiemGiay
            // 
            this.txt_TimKiemGiay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TimKiemGiay.Location = new System.Drawing.Point(165, 50);
            this.txt_TimKiemGiay.Name = "txt_TimKiemGiay";
            this.txt_TimKiemGiay.Size = new System.Drawing.Size(408, 22);
            this.txt_TimKiemGiay.TabIndex = 1;
            // 
            // btn_TimKiemGiay
            // 
            this.btn_TimKiemGiay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiemGiay.ForeColor = System.Drawing.Color.Black;
            this.btn_TimKiemGiay.Image = ((System.Drawing.Image)(resources.GetObject("btn_TimKiemGiay.Image")));
            this.btn_TimKiemGiay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TimKiemGiay.Location = new System.Drawing.Point(14, 37);
            this.btn_TimKiemGiay.Name = "btn_TimKiemGiay";
            this.btn_TimKiemGiay.Size = new System.Drawing.Size(145, 45);
            this.btn_TimKiemGiay.TabIndex = 0;
            this.btn_TimKiemGiay.Text = "Tìm kiếm";
            this.btn_TimKiemGiay.UseVisualStyleBackColor = true;
            this.btn_TimKiemGiay.Click += new System.EventHandler(this.btn_TimKiemGiay_Click);
            // 
            // btn_XoaGiay
            // 
            this.btn_XoaGiay.BackColor = System.Drawing.Color.Tomato;
            this.btn_XoaGiay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaGiay.ForeColor = System.Drawing.Color.Black;
            this.btn_XoaGiay.Image = ((System.Drawing.Image)(resources.GetObject("btn_XoaGiay.Image")));
            this.btn_XoaGiay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XoaGiay.Location = new System.Drawing.Point(401, 263);
            this.btn_XoaGiay.Name = "btn_XoaGiay";
            this.btn_XoaGiay.Size = new System.Drawing.Size(143, 53);
            this.btn_XoaGiay.TabIndex = 3;
            this.btn_XoaGiay.Text = "Xóa";
            this.btn_XoaGiay.UseVisualStyleBackColor = false;
            this.btn_XoaGiay.Click += new System.EventHandler(this.btn_XoaGiay_Click);
            // 
            // btn_SuaGiay
            // 
            this.btn_SuaGiay.BackColor = System.Drawing.Color.DarkOrchid;
            this.btn_SuaGiay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaGiay.ForeColor = System.Drawing.Color.Black;
            this.btn_SuaGiay.Image = ((System.Drawing.Image)(resources.GetObject("btn_SuaGiay.Image")));
            this.btn_SuaGiay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SuaGiay.Location = new System.Drawing.Point(401, 145);
            this.btn_SuaGiay.Name = "btn_SuaGiay";
            this.btn_SuaGiay.Size = new System.Drawing.Size(143, 53);
            this.btn_SuaGiay.TabIndex = 2;
            this.btn_SuaGiay.Text = "Sửa ";
            this.btn_SuaGiay.UseVisualStyleBackColor = false;
            this.btn_SuaGiay.Click += new System.EventHandler(this.btn_SuaGiay_Click);
            // 
            // btn_ThemGiay
            // 
            this.btn_ThemGiay.BackColor = System.Drawing.Color.Lime;
            this.btn_ThemGiay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemGiay.ForeColor = System.Drawing.Color.Black;
            this.btn_ThemGiay.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThemGiay.Image")));
            this.btn_ThemGiay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThemGiay.Location = new System.Drawing.Point(401, 23);
            this.btn_ThemGiay.Name = "btn_ThemGiay";
            this.btn_ThemGiay.Size = new System.Drawing.Size(143, 53);
            this.btn_ThemGiay.TabIndex = 1;
            this.btn_ThemGiay.Text = "Thêm";
            this.btn_ThemGiay.UseVisualStyleBackColor = false;
            this.btn_ThemGiay.Click += new System.EventHandler(this.btn_ThemGiay_Click);
            // 
            // btn_LamMoiGiay
            // 
            this.btn_LamMoiGiay.BackColor = System.Drawing.Color.Cyan;
            this.btn_LamMoiGiay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LamMoiGiay.ForeColor = System.Drawing.Color.Black;
            this.btn_LamMoiGiay.Image = ((System.Drawing.Image)(resources.GetObject("btn_LamMoiGiay.Image")));
            this.btn_LamMoiGiay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LamMoiGiay.Location = new System.Drawing.Point(401, 392);
            this.btn_LamMoiGiay.Name = "btn_LamMoiGiay";
            this.btn_LamMoiGiay.Size = new System.Drawing.Size(143, 53);
            this.btn_LamMoiGiay.TabIndex = 0;
            this.btn_LamMoiGiay.Text = "Làm mới";
            this.btn_LamMoiGiay.UseVisualStyleBackColor = false;
            this.btn_LamMoiGiay.Click += new System.EventHandler(this.btn_LamMoiGiay_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.panel1.Controls.Add(this.txt_KhuyenMai);
            this.panel1.Controls.Add(this.btn_XoaGiay);
            this.panel1.Controls.Add(this.btn_SuaGiay);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_ThemGiay);
            this.panel1.Controls.Add(this.txt_DGBan);
            this.panel1.Controls.Add(this.btn_LamMoiGiay);
            this.panel1.Controls.Add(this.cmb_MaNCC);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txt_DGNhap);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_SoLuong);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cmb_Loai);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_TenGiay);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_MaGiay);
            this.panel1.Location = new System.Drawing.Point(-5, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 549);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_TimKiemGiay);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.btn_TimKiemGiay);
            this.panel2.Location = new System.Drawing.Point(568, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(623, 109);
            this.panel2.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(620, 29);
            this.label10.TabIndex = 17;
            this.label10.Text = "BỘ LỌC";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.dgv_Giay);
            this.panel3.Location = new System.Drawing.Point(568, 109);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(623, 573);
            this.panel3.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label11.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(623, 29);
            this.label11.TabIndex = 17;
            this.label11.Text = "DANH SÁCH SẢN PHẨM";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_NhaCungCap);
            this.panel4.Controls.Add(this.btn_LoaiGiay);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(1, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(566, 109);
            this.panel4.TabIndex = 23;
            // 
            // btn_NhaCungCap
            // 
            this.btn_NhaCungCap.BackColor = System.Drawing.Color.Red;
            this.btn_NhaCungCap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_NhaCungCap.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NhaCungCap.Image = ((System.Drawing.Image)(resources.GetObject("btn_NhaCungCap.Image")));
            this.btn_NhaCungCap.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_NhaCungCap.Location = new System.Drawing.Point(283, 30);
            this.btn_NhaCungCap.Name = "btn_NhaCungCap";
            this.btn_NhaCungCap.Size = new System.Drawing.Size(283, 79);
            this.btn_NhaCungCap.TabIndex = 18;
            this.btn_NhaCungCap.Text = "Nhà Cung Cấp";
            this.btn_NhaCungCap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NhaCungCap.UseVisualStyleBackColor = false;
            this.btn_NhaCungCap.Click += new System.EventHandler(this.btn_NhaCungCap_Click);
            // 
            // btn_LoaiGiay
            // 
            this.btn_LoaiGiay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_LoaiGiay.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoaiGiay.Image = ((System.Drawing.Image)(resources.GetObject("btn_LoaiGiay.Image")));
            this.btn_LoaiGiay.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_LoaiGiay.Location = new System.Drawing.Point(0, 30);
            this.btn_LoaiGiay.Name = "btn_LoaiGiay";
            this.btn_LoaiGiay.Size = new System.Drawing.Size(286, 79);
            this.btn_LoaiGiay.TabIndex = 17;
            this.btn_LoaiGiay.Text = "Loại Giày";
            this.btn_LoaiGiay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LoaiGiay.UseVisualStyleBackColor = true;
            this.btn_LoaiGiay.Click += new System.EventHandler(this.btn_LoaiGiay_Click);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label12.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(-3, 109);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(570, 29);
            this.label12.TabIndex = 24;
            this.label12.Text = "THÔNG TIN SẢN PHẨM";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 681);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SANPHAM";
            this.Load += new System.EventHandler(this.fSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Giay)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_TimKiemGiay;
        private System.Windows.Forms.TextBox txt_DGNhap;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.ComboBox cmb_Loai;
        private System.Windows.Forms.TextBox txt_TenGiay;
        private System.Windows.Forms.TextBox txt_MaGiay;
        private System.Windows.Forms.TextBox txt_TimKiemGiay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_Giay;
        private System.Windows.Forms.Button btn_XoaGiay;
        private System.Windows.Forms.Button btn_SuaGiay;
        private System.Windows.Forms.Button btn_ThemGiay;
        private System.Windows.Forms.Button btn_LamMoiGiay;
        private System.Windows.Forms.TextBox txt_DGBan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_MaNCC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_KhuyenMai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_NhaCungCap;
        private System.Windows.Forms.Button btn_LoaiGiay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}