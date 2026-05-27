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
    public partial class fNhaCungCap : Form
    {

        NhaCungCapBUS bus = new NhaCungCapBUS();
        public fNhaCungCap()
        {
            InitializeComponent();
        }

        private void fNhaCungCap_Load(object sender, EventArgs e)
        {
            LoadNCC();
        }

        void LoadNCC()
        {
            dgv_NhaCC.DataSource = bus.GetNCC();
        }

        private void dgv_NhaCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_NhaCC.Rows[e.RowIndex];

                txt_MaNCC.Text = row.Cells["MANCC"].Value.ToString();
                txt_TenNCC.Text = row.Cells["TENNCC"].Value.ToString();
                txt_DiaChiNCC.Text = row.Cells["DIACHI"].Value.ToString();
                txt_SDTNhaCC.Text = row.Cells["SDT"].Value.ToString();
                txt_EmailNCC.Text = row.Cells["EMAIL"].Value.ToString();
            }
        }

        private void btn_ThemNCC_Click(object sender, EventArgs e)
        {
            if (bus.CheckMaNCC(txt_MaNCC.Text))
            {
                MessageBox.Show("Mã NCC đã tồn tại!");

                return;
            }

            NhaCungCapDTO ncc = new NhaCungCapDTO();

            ncc.MANCC = txt_MaNCC.Text;
            ncc.TENNCC = txt_TenNCC.Text;
            ncc.DIACHI = txt_DiaChiNCC.Text;
            ncc.SDT = txt_SDTNhaCC.Text;
            ncc.EMAIL = txt_EmailNCC.Text;
            bus.InsertNCC(ncc);

            MessageBox.Show("Thêm thành công!");

            LoadNCC();
        }

        private void btn_SuaNCC_Click(object sender, EventArgs e)
        {
            NhaCungCapDTO ncc = new NhaCungCapDTO();

            ncc.MANCC = txt_MaNCC.Text;
            ncc.TENNCC = txt_TenNCC.Text;
            ncc.DIACHI = txt_DiaChiNCC.Text;
            ncc.SDT = txt_SDTNhaCC.Text;
            ncc.EMAIL = txt_EmailNCC.Text;
            bus.UpdateNCC(ncc);

            MessageBox.Show("Sửa thành công!");

            LoadNCC();
        }

        private void btn_XoaNCC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaNCC.Text))
            {
                MessageBox.Show("Chưa chọn nhà cung cấp!");

                return;
            }

            DialogResult rs =
                MessageBox.Show(
                    "Bạn có chắc muốn xóa?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo);

            if (rs == DialogResult.Yes)
            {
                if (bus.CheckSanPham(
                    txt_MaNCC.Text))
                {
                    MessageBox.Show("Không thể xóa vì còn sản phẩm liên quan!");

                    return;
                }

                bus.DeleteNCC(txt_MaNCC.Text);
                MessageBox.Show("Xóa thành công!");

                LoadNCC();
            }
        }
        
        private void btn_LamMoiNCC_Click(object sender, EventArgs e)
        {
            txt_MaNCC.Clear();
            txt_TenNCC.Clear();
            txt_DiaChiNCC.Clear();
            txt_SDTNhaCC.Clear();
            txt_EmailNCC.Clear();

            LoadNCC();
        }

        private void btn_ThoatNCC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_TatForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
