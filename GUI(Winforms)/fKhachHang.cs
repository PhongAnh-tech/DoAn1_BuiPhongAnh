using doan1_Cuahangbanggiay.BUS;
using doan1_Cuahangbanggiay.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doan1_Cuahangbanggiay.GUI_Winforms_
{
    public partial class fKhachHang : Form
    {
        KhachHangBUS bus = new KhachHangBUS();

        public fKhachHang()
        {
            InitializeComponent();
        }

        private void dgv_KhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_KhachHang.Rows[e.RowIndex];

                txt_MaKH.Text = row.Cells["MAKH"].Value.ToString();
                txt_TenKH.Text = row.Cells["TENKH"].Value.ToString();
                txt_DiaChiKH.Text = row.Cells["DIACHI"].Value.ToString();
                txt_SDTKH.Text = row.Cells["SDT"].Value.ToString();
                txt_GioiTinhKH.Text = row.Cells["GIOITINH"].Value.ToString();
                txt_EmailKH.Text = row.Cells["EMAIL"].Value.ToString();

                DTP_NgayDK.Value = Convert.ToDateTime(row.Cells["NGAYDANGKY"].Value);
            }
        }

        private void fKhachHang_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
        }

        void LoadKhachHang()
        {
            dgv_KhachHang.DataSource = bus.GetKhachHang();
        }

        private void btn_ThemKH_Click(object sender, EventArgs e)
        {
            if (bus.CheckMaKH(txt_MaKH.Text))
            {
                MessageBox.Show("Mã khách hàng đã tồn tại!");

                return;
            }

            KhachHangDTO kh = new KhachHangDTO();

            kh.MAKH = txt_MaKH.Text;
            kh.TENKH = txt_TenKH.Text;
            kh.DIACHI = txt_DiaChiKH.Text;
            kh.SDT = txt_SDTKH.Text;
            kh.GIOITINH = txt_GioiTinhKH.Text;
            kh.NGAYDANGKY = DTP_NgayDK.Value;
            kh.EMAIL = txt_EmailKH.Text;

            bus.InsertKhachHang(kh);

            MessageBox.Show("Thêm thành công!");

            LoadKhachHang();
        }

        private void btn_SuaKH_Click(object sender, EventArgs e)
        {
            KhachHangDTO kh = new KhachHangDTO();

            kh.MAKH = txt_MaKH.Text;
            kh.TENKH = txt_TenKH.Text;
            kh.DIACHI = txt_DiaChiKH.Text;
            kh.SDT = txt_SDTKH.Text;
            kh.GIOITINH = txt_GioiTinhKH.Text;
            kh.NGAYDANGKY = DTP_NgayDK.Value;
            kh.EMAIL = txt_EmailKH.Text;

            bus.UpdateKhachHang(kh);

            MessageBox.Show("Sửa thành công!");

            LoadKhachHang();
        }

        private void btn_LamMoiKH_Click(object sender, EventArgs e)
        {
            txt_MaKH.Clear();
            txt_TenKH.Clear();
            txt_DiaChiKH.Clear();
            txt_SDTKH.Clear();
            txt_GioiTinhKH.Clear();
            txt_EmailKH.Clear();
            DTP_NgayDK.Value = DateTime.Now;

            LoadKhachHang();
        }

        private void btn_XoaKH_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaKH.Text))
            {
                MessageBox.Show("Chưa chọn khách hàng!");

                return;
            }

            DialogResult r =
                MessageBox.Show(
                    "Bạn có chắc muốn xóa?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {
                bus.DeleteKhachHang(txt_MaKH.Text);

                MessageBox.Show("Xóa thành công!");

                LoadKhachHang();
            }
        }

        private void btn_ThoatKH_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_TimKiemKH_Click(object sender, EventArgs e)
        {
            dgv_KhachHang.DataSource = bus.SearchKhachHang(txt_TimKiemKH.Text.Trim());
        }

        private void txt_TimKiemKH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_TimKiemKH_Click(sender, e);
            }
        }

        
    }
}
