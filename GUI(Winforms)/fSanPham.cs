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
    public partial class fSanPham : Form
    {
        
        public fSanPham()
        {
            InitializeComponent();
        }

        SanPhamBUS bus = new SanPhamBUS();

        private void dgv_Giay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_Giay.Rows[e.RowIndex];
                txt_MaGiay.Text = row.Cells["MASP"].Value.ToString();
                txt_TenGiay.Text = row.Cells["TENSP"].Value.ToString();
                txt_SoLuong.Text = row.Cells["SOLUONG"].Value.ToString();
                txt_DGNhap.Text = row.Cells["DONGIANHAP"].Value.ToString();
                txt_DGBan.Text = row.Cells["DONGIABAN"].Value.ToString();
                txt_KhuyenMai.Text = row.Cells["KHUYENMAI"].Value.ToString();
                cmb_MaNCC.SelectedValue = row.Cells["MANCC"].Value;
                cmb_Loai.SelectedValue = row.Cells["MALOAISP"].Value;
            }
        }

        private void fSanPham_Load(object sender, EventArgs e)
        {
            LoadNCC();
            LoadLoai();
            LoadSanPham();
        }


        void LoadSanPham()
        {
            dgv_Giay.DataSource = bus.GetSanPham();
        }


        void LoadNCC()
        {
            DataTable dt = bus.GetNCC();
            cmb_MaNCC.DataSource = dt;
            cmb_MaNCC.DisplayMember = "MANCC";
            cmb_MaNCC.ValueMember ="MANCC";
        }

        void LoadLoai()
        {
            DataTable dt = bus.GetLoai();

            cmb_Loai.DataSource = dt;
            cmb_Loai.DisplayMember = "MALOAISP";
            cmb_Loai.ValueMember = "MALOAISP";
        }

        private void btn_ThemGiay_Click(object sender, EventArgs e)
        {
            SanPhamDTO sp = new SanPhamDTO();

            sp.MASP = txt_MaGiay.Text;
            sp.TENSP = txt_TenGiay.Text;
            sp.MANCC = cmb_MaNCC.SelectedValue.ToString();
            sp.MALOAISP = cmb_Loai.SelectedValue.ToString();
            sp.SOLUONG = int.Parse(txt_SoLuong.Text);
            sp.DONGIANHAP = decimal.Parse(txt_DGNhap.Text);
            sp.DONGIABAN = decimal.Parse(txt_DGBan.Text);

            decimal km = 0;

            decimal.TryParse(txt_KhuyenMai.Text, out km);

            sp.KHUYENMAI = km;

            bus.InsertSanPham(sp);

            MessageBox.Show("Thêm thành công");

            LoadSanPham();
        }

        private void btn_SuaGiay_Click(object sender, EventArgs e)
        {
            SanPhamDTO sp = new SanPhamDTO();

            sp.MASP = txt_MaGiay.Text;
            sp.TENSP = txt_TenGiay.Text;
            sp.MANCC = cmb_MaNCC.SelectedValue.ToString();
            sp.MALOAISP = cmb_Loai.SelectedValue.ToString();
            sp.SOLUONG = int.Parse(txt_SoLuong.Text);
            sp.DONGIANHAP = decimal.Parse(txt_DGNhap.Text);
            sp.DONGIABAN = decimal.Parse(txt_DGBan.Text);

            decimal km = 0;

            decimal.TryParse(txt_KhuyenMai.Text, out km);

            sp.KHUYENMAI = km;

            bus.UpdateSanPham(sp);

            MessageBox.Show("Sửa thành công");

            LoadSanPham();
        }

        private void btn_XoaGiay_Click(object sender, EventArgs e)
        {
            DialogResult rs =
                MessageBox.Show(
                    "Bạn có chắc muốn xóa?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo);

            if (rs == DialogResult.Yes)
            {
                bus.DeleteSanPham(txt_MaGiay.Text);

                MessageBox.Show("Xóa thành công");

                LoadSanPham();
            }
        }



        private void btn_LamMoiGiay_Click(object sender, EventArgs e)
        {
            txt_MaGiay.Clear();
            txt_TenGiay.Clear();
            txt_SoLuong.Clear();
            txt_DGNhap.Clear();
            txt_DGBan.Clear();
            txt_KhuyenMai.Clear();

            cmb_MaNCC.SelectedIndex = -1;
            cmb_Loai.SelectedIndex = -1;

            LoadSanPham();
        }

        private void btn_TimKiemGiay_Click(object sender, EventArgs e)
        {
            dgv_Giay.DataSource = bus.SearchSanPham(txt_TimKiemGiay.Text.Trim());
        }

        private void btn_NhaCungCap_Click(object sender, EventArgs e)
        {
            fNhaCungCap f = new fNhaCungCap();
            f.Show();
        }

        private void btn_LoaiGiay_Click(object sender, EventArgs e)
        {
            fLoaiGiay f = new fLoaiGiay();
            f.Show();
        }
    }
}
