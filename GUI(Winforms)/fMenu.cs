using doan1_Cuahangbanggiay.GUI_Winforms_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doan1_Cuahangbanggiay
{
    public partial class fMenu : Form
    {
        Form currentFormChild;
        public fMenu()
        {
            InitializeComponent();
        }

        string manv;
        string role;
        string hoten;

        public fMenu(string role, string hoten, string manv)
        {
            InitializeComponent();
            this.role = role;
            this.hoten = hoten;
            this.manv = manv;

            HienThongTin();
            PhanQuyen();


        }

        void HienThongTin()
        {
            lblName.Text = "Xin chào: " + hoten;
            lblRole.Text = "Quyền: " + role;
        }


        void PhanQuyen()
        {
            if (role == "Nhân viên")
            {
                btn_ThongKe.Enabled = false;
                btn_ThongKe.BackColor = Color.LightGray;

                btn_NhapSP.Enabled = false;
                btn_NhapSP.BackColor = Color.LightGray;

                btn_ThietLap.Enabled = false;
                btn_ThietLap.BackColor = Color.LightGray;
            }
        }


        private void OpenChildForm(Form childForm, string title)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

            // Đổi tiêu đề
            lbl_Title.Text = title;

            currentFormChild = childForm;

            childForm.Tag = this.manv;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            Panel_Form.Controls.Clear();
            Panel_Form.Controls.Add(childForm);
            Panel_Form.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fThongKe(), "THỐNG KÊ");
        }

        private void btn_BanSP_Click(object sender, EventArgs e)
        {
            fQuanLyDonBan frmBan = new fQuanLyDonBan();
            frmBan.Tag = this.manv;
            OpenChildForm(new fQuanLyDonBan(), "BÁN SẢN PHẨM");
        }

        private void btn_SanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fSanPham(), "SẢN PHẨM");
        }

        private void btn_NhapSP_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fQuanLyDonNhap(), "NHẬP SẢN PHẨM");
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fNhanVien(), "NHÂN VIÊN");
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fKhachHang(), "KHÁCH HÀNG");
        }


        private void btn_ThietLap_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fThietLap(), "THIẾT LẬP");
        }


        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn đăng xuất không?",
                                      "Xác nhận",
                                      MessageBoxButtons.YesNo);

            if (rs == DialogResult.Yes)
            {
                this.Hide();

                fLogin f = new fLogin(); 
                f.ShowDialog();

                this.Close();
            }
        }

        
    }
}
