using doan1_Cuahangbanggiay.BUS;
using doan1_Cuahangbanggiay.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doan1_Cuahangbanggiay.GUI_Winforms_
{
    public partial class fThietLap : Form
    {
        ThietLapBUS bus = new ThietLapBUS();

        public fThietLap()
        {
            InitializeComponent();
        }

        

        private void dgv_TKNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_TKNhanVien.Rows[e.RowIndex];

                txt_Username.Text = row.Cells["USERNAME"].Value.ToString();
                txt_Password.Text = row.Cells["PASSWORD"].Value.ToString();
                txt_Role.Text = row.Cells["ROLE"].Value.ToString();
                txt_TenNV.Text = row.Cells["HOTEN"].Value.ToString();
                txt_LoaiNV.Text = row.Cells["TENLOAI"].Value.ToString();
            }
        }


        void LoadTaiKhoan()
        {
            dgv_TKNhanVien.DataSource = bus.GetTaiKhoan();
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            ThietLapDTO tk = new ThietLapDTO();

            tk.USERNAME = txt_Username.Text;
            tk.PASSWORD = txt_Password.Text;
            tk.ROLE = txt_Role.Text;

            bus.UpdateTaiKhoan(tk);

            MessageBox.Show("Cập nhật thành công!");

            LoadTaiKhoan();
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            if (txt_MKMoi.Text != txt_NhapLaiMK.Text)
            {
                MessageBox.Show(
                    "Mật khẩu nhập lại không khớp!");

                return;
            }

            bool check =
                bus.CheckPassword(
                    txt_Username.Text,
                    txt_MKHienTai.Text);

            if (!check)
            {
                MessageBox.Show(
                    "Mật khẩu hiện tại sai!");

                return;
            }

            bus.ChangePassword(txt_Username.Text, txt_MKMoi.Text);

            MessageBox.Show("Đổi mật khẩu thành công!");
        }

        private void fThietLap_Load(object sender, EventArgs e)
        {
            LoadTaiKhoan();
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn quay lại Login ?",
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
