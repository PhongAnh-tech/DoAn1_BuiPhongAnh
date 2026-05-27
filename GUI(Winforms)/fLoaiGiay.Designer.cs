namespace doan1_Cuahangbanggiay.GUI_Winforms_
{
    partial class fLoaiGiay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLoaiGiay));
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_LoaiGiay = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TenLoaiGiay = new System.Windows.Forms.TextBox();
            this.txt_MaLoaiGiay = new System.Windows.Forms.TextBox();
            this.btn_XoaLG = new System.Windows.Forms.Button();
            this.btn_SuaLG = new System.Windows.Forms.Button();
            this.btn_ThemLG = new System.Windows.Forms.Button();
            this.btn_LamMoiLG = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_TatForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoaiGiay)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, -1);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1138, 52);
            this.label1.TabIndex = 24;
            this.label1.Text = "LOẠI GIÀY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_LoaiGiay
            // 
            this.dgv_LoaiGiay.BackgroundColor = System.Drawing.Color.White;
            this.dgv_LoaiGiay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LoaiGiay.Location = new System.Drawing.Point(3, 0);
            this.dgv_LoaiGiay.Name = "dgv_LoaiGiay";
            this.dgv_LoaiGiay.RowHeadersWidth = 51;
            this.dgv_LoaiGiay.RowTemplate.Height = 24;
            this.dgv_LoaiGiay.Size = new System.Drawing.Size(526, 282);
            this.dgv_LoaiGiay.TabIndex = 0;
            this.dgv_LoaiGiay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_LoaiGiay_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(94, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tên Loại Giày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(96, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã Loại Giày:";
            // 
            // txt_TenLoaiGiay
            // 
            this.txt_TenLoaiGiay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TenLoaiGiay.Location = new System.Drawing.Point(211, 127);
            this.txt_TenLoaiGiay.Name = "txt_TenLoaiGiay";
            this.txt_TenLoaiGiay.Size = new System.Drawing.Size(309, 22);
            this.txt_TenLoaiGiay.TabIndex = 2;
            // 
            // txt_MaLoaiGiay
            // 
            this.txt_MaLoaiGiay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaLoaiGiay.Location = new System.Drawing.Point(211, 59);
            this.txt_MaLoaiGiay.Name = "txt_MaLoaiGiay";
            this.txt_MaLoaiGiay.Size = new System.Drawing.Size(309, 22);
            this.txt_MaLoaiGiay.TabIndex = 1;
            // 
            // btn_XoaLG
            // 
            this.btn_XoaLG.BackColor = System.Drawing.Color.Tomato;
            this.btn_XoaLG.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaLG.ForeColor = System.Drawing.Color.Black;
            this.btn_XoaLG.Image = ((System.Drawing.Image)(resources.GetObject("btn_XoaLG.Image")));
            this.btn_XoaLG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XoaLG.Location = new System.Drawing.Point(301, 229);
            this.btn_XoaLG.Name = "btn_XoaLG";
            this.btn_XoaLG.Size = new System.Drawing.Size(143, 53);
            this.btn_XoaLG.TabIndex = 3;
            this.btn_XoaLG.Text = "Xóa";
            this.btn_XoaLG.UseVisualStyleBackColor = false;
            this.btn_XoaLG.Click += new System.EventHandler(this.btn_XoaLG_Click);
            // 
            // btn_SuaLG
            // 
            this.btn_SuaLG.BackColor = System.Drawing.Color.DarkOrchid;
            this.btn_SuaLG.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaLG.ForeColor = System.Drawing.Color.Black;
            this.btn_SuaLG.Image = ((System.Drawing.Image)(resources.GetObject("btn_SuaLG.Image")));
            this.btn_SuaLG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SuaLG.Location = new System.Drawing.Point(152, 229);
            this.btn_SuaLG.Name = "btn_SuaLG";
            this.btn_SuaLG.Size = new System.Drawing.Size(143, 53);
            this.btn_SuaLG.TabIndex = 2;
            this.btn_SuaLG.Text = "Sửa ";
            this.btn_SuaLG.UseVisualStyleBackColor = false;
            this.btn_SuaLG.Click += new System.EventHandler(this.btn_SuaLG_Click);
            // 
            // btn_ThemLG
            // 
            this.btn_ThemLG.BackColor = System.Drawing.Color.Lime;
            this.btn_ThemLG.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemLG.ForeColor = System.Drawing.Color.Black;
            this.btn_ThemLG.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThemLG.Image")));
            this.btn_ThemLG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThemLG.Location = new System.Drawing.Point(3, 229);
            this.btn_ThemLG.Name = "btn_ThemLG";
            this.btn_ThemLG.Size = new System.Drawing.Size(143, 53);
            this.btn_ThemLG.TabIndex = 1;
            this.btn_ThemLG.Text = "Thêm";
            this.btn_ThemLG.UseVisualStyleBackColor = false;
            this.btn_ThemLG.Click += new System.EventHandler(this.btn_ThemLG_Click);
            // 
            // btn_LamMoiLG
            // 
            this.btn_LamMoiLG.BackColor = System.Drawing.Color.Cyan;
            this.btn_LamMoiLG.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LamMoiLG.ForeColor = System.Drawing.Color.Black;
            this.btn_LamMoiLG.Image = ((System.Drawing.Image)(resources.GetObject("btn_LamMoiLG.Image")));
            this.btn_LamMoiLG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LamMoiLG.Location = new System.Drawing.Point(450, 229);
            this.btn_LamMoiLG.Name = "btn_LamMoiLG";
            this.btn_LamMoiLG.Size = new System.Drawing.Size(143, 53);
            this.btn_LamMoiLG.TabIndex = 0;
            this.btn_LamMoiLG.Text = "Làm mới";
            this.btn_LamMoiLG.UseVisualStyleBackColor = false;
            this.btn_LamMoiLG.Click += new System.EventHandler(this.btn_LamMoiLG_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.panel1.Controls.Add(this.btn_XoaLG);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_SuaLG);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_ThemLG);
            this.panel1.Controls.Add(this.txt_TenLoaiGiay);
            this.panel1.Controls.Add(this.btn_LamMoiLG);
            this.panel1.Controls.Add(this.txt_MaLoaiGiay);
            this.panel1.Location = new System.Drawing.Point(-1, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 295);
            this.panel1.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_LoaiGiay);
            this.panel2.Location = new System.Drawing.Point(605, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(532, 282);
            this.panel2.TabIndex = 28;
            // 
            // btn_TatForm
            // 
            this.btn_TatForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btn_TatForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TatForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_TatForm.ForeColor = System.Drawing.Color.White;
            this.btn_TatForm.Location = new System.Drawing.Point(1089, 7);
            this.btn_TatForm.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TatForm.Name = "btn_TatForm";
            this.btn_TatForm.Size = new System.Drawing.Size(45, 33);
            this.btn_TatForm.TabIndex = 30;
            this.btn_TatForm.Tag = "";
            this.btn_TatForm.Text = "X";
            this.btn_TatForm.UseVisualStyleBackColor = false;
            this.btn_TatForm.Click += new System.EventHandler(this.btn_TatForm_Click);
            // 
            // fLoaiGiay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 335);
            this.Controls.Add(this.btn_TatForm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fLoaiGiay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOAIGIAY";
            this.Load += new System.EventHandler(this.fLoaiGiay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoaiGiay)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_LoaiGiay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TenLoaiGiay;
        private System.Windows.Forms.TextBox txt_MaLoaiGiay;
        private System.Windows.Forms.Button btn_XoaLG;
        private System.Windows.Forms.Button btn_SuaLG;
        private System.Windows.Forms.Button btn_ThemLG;
        private System.Windows.Forms.Button btn_LamMoiLG;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_TatForm;
    }
}