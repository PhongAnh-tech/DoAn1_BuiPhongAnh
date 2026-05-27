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
    public partial class fNhanVien : Form
    {

        NhanVienBUS bus = new NhanVienBUS();
        public fNhanVien()
        {
            InitializeComponent();
        }

        private void dgv_NhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_NhanVien.Rows[e.RowIndex];

                txt_MaNV.Text = row.Cells["MANV"].Value?.ToString();
                txt_TenNV.Text = row.Cells["HOTEN"].Value?.ToString();
                txt_SDTNV.Text = row.Cells["SDT"].Value?.ToString();
                DTP_NgaySinhNV.Value = Convert.ToDateTime(row.Cells["NGAYSINH"].Value);
                txt_EmailNV.Text = row.Cells["EMAIL"].Value?.ToString();
                txt_GioiTinhNV.Text = row.Cells["GIOITINH"].Value?.ToString();
                txt_MaLoai.Text = row.Cells["MALOAI"].Value?.ToString();
            }
        }

        private void fNhanVien_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
        }

        void LoadNhanVien()
        {
            dgv_NhanVien.DataSource = bus.GetNhanVien();
        }

        private void btn_ThemNV_Click(object sender, EventArgs e)
        {
            if (bus.CheckMaNV(txt_MaNV.Text))
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!");

                return;
            }

            NhanVienDTO nv = new NhanVienDTO();

            nv.MANV = txt_MaNV.Text;
            nv.HOTEN = txt_TenNV.Text;
            nv.SDT = txt_SDTNV.Text;
            nv.NGAYSINH = DTP_NgaySinhNV.Value;
            nv.EMAIL = txt_EmailNV.Text;
            nv.GIOITINH = txt_GioiTinhNV.Text;
            nv.MALOAI = txt_MaLoai.Text;

            bus.InsertNhanVien(nv);

            MessageBox.Show("Thêm thành công!");

            LoadNhanVien();
        }

        private void btn_SuaNV_Click(object sender, EventArgs e)
        {
            NhanVienDTO nv = new NhanVienDTO();

            nv.MANV = txt_MaNV.Text;
            nv.HOTEN = txt_TenNV.Text;
            nv.SDT = txt_SDTNV.Text;
            nv.NGAYSINH = DTP_NgaySinhNV.Value;
            nv.EMAIL = txt_EmailNV.Text;
            nv.GIOITINH = txt_GioiTinhNV.Text;
            nv.MALOAI = txt_MaLoai.Text;

            bus.UpdateNhanVien(nv);

            MessageBox.Show("Sửa thành công!");

            LoadNhanVien();
        }

        private void btn_XoaNV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaNV.Text))
            {
                MessageBox.Show("Chưa chọn nhân viên!");

                return;
            }

            DialogResult rs =
                MessageBox.Show(
                    "Bạn có chắc muốn xóa?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo);

            if (rs == DialogResult.Yes)
            {
                bus.DeleteNhanVien(txt_MaNV.Text);

                MessageBox.Show("Xóa thành công!");

                LoadNhanVien();
            }
        }

        private void btn_LamMoiNV_Click(object sender, EventArgs e)
        {
            txt_MaNV.Clear();
            txt_TenNV.Clear();
            txt_SDTNV.Clear();
            txt_EmailNV.Clear();
            txt_GioiTinhNV.Clear();
            txt_MaLoai.Clear();
            DTP_NgaySinhNV.Value = DateTime.Now;

            LoadNhanVien();


        }

        private void btn_TimKiemNV_Click(object sender, EventArgs e)
        {
            dgv_NhanVien.DataSource = bus.SearchNhanVien(txt_TimKiemNV.Text.Trim());
        }

        private void txt_TimKiemNV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_TimKiemNV_Click(sender, e);
            }
        }

        private void btn_ThoatNV_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        
    }
}
