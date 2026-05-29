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
    public partial class fQuanLyDonNhap : Form
    {
        DonNhapBUS bus = new DonNhapBUS();



        public fQuanLyDonNhap()
        {
            InitializeComponent();
        }

        private void fQuanLyDonNhap_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
            LoadNCC();
            LoadKhuyenMai();
            LoadSanPham();
            LoadDonNhap();

            TaoCotCTPN();
            dgv_ChuaNhapKho.AllowUserToAddRows = false;
        }

        void LoadNhanVien()
        {
            cmb_MaNV.DataSource = bus.GetNhanVien();
            cmb_MaNV.DisplayMember = "MANV";
            cmb_MaNV.ValueMember = "MANV";
        }

        void LoadNCC()
        {
            cmb_MaNCC.DataSource = bus.GetNCC();
            cmb_MaNCC.DisplayMember = "MANCC";
            cmb_MaNCC.ValueMember = "MANCC";
        }

        void LoadKhuyenMai()
        {
            cmb_MaKM.DataSource = bus.GetKhuyenMai();
            cmb_MaKM.DisplayMember = "MAKM";
            cmb_MaKM.ValueMember = "MAKM";
        }

        void LoadSanPham()
        {
            dgv_DonNhap.DataSource = bus.GetSanPham();
        }

        void LoadDonNhap()
        {
            dgv_ChuaNhapKho.DataSource = bus.GetDonNhap();
        }

        void TaoCotCTPN()
        {
            dgv_CTPN.Columns.Clear();

            dgv_CTPN.Columns.Add("MASP", "Mã SP");
            dgv_CTPN.Columns.Add("TENSP", "Tên SP");
            dgv_CTPN.Columns.Add("SLNHAP", "SL Nhập");
            dgv_CTPN.Columns.Add("DONGIANHAP", "Đơn Giá");
        }

        private void btn_TaoPhieu_Click(object sender, EventArgs e)
        {
            txt_MaDN.Text = bus.TaoMaDN();
        }

        

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (dgv_DonNhap.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm");
                return;
            }

            string masp = dgv_DonNhap.CurrentRow.Cells["MASP"].Value.ToString();
            string tensp = dgv_DonNhap.CurrentRow.Cells["TENSP"].Value.ToString();
            string dongia = dgv_DonNhap.CurrentRow.Cells["DONGIANHAP"].Value.ToString();

            dgv_CTPN.Rows.Add(masp,tensp,1,dongia);
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                DonNhapDTO dn = new DonNhapDTO();

                dn.MADN = txt_MaDN.Text;
                dn.MANV = cmb_MaNV.Text;
                dn.MANCC = cmb_MaNCC.Text;
                dn.NGAYNHAP = dpK_NgayNhap.Value;
                dn.MAKM = cmb_MaKM.Text;

                List<ChiTietDonNhapDTO> dsCT = new List<ChiTietDonNhapDTO>();

                foreach (DataGridViewRow row in dgv_CTPN.Rows)
                {
                    if (row.Cells[0].Value == null)
                        continue;

                    ChiTietDonNhapDTO ct = new ChiTietDonNhapDTO();

                    ct.MADN = txt_MaDN.Text;
                    ct.MASP = row.Cells[0].Value.ToString();
                    ct.SLNHAP = Convert.ToInt32(row.Cells[2].Value);

                    ct.DONGIANHAP = Convert.ToDecimal(row.Cells[3].Value);

                    dsCT.Add(ct);
                }

                bus.InsertDonNhap(dn, dsCT);

                MessageBox.Show("Lưu thành công");

                LoadDonNhap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_XNNK_Click(object sender, EventArgs e)
        {
            if (dgv_ChuaNhapKho.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn đơn nhập");
                return;
            }

            string madn =
                dgv_ChuaNhapKho.CurrentRow.Cells["MADN"].Value.ToString();

            bus.XacNhanNhapKho(madn);

            MessageBox.Show("Đã nhập kho");

            LoadSanPham();
            LoadDonNhap();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            txt_MaDN.Clear();

            dgv_CTPN.Rows.Clear();
        }


        private void dgv_ChuaNhapKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txt_MaDN.Text = dgv_ChuaNhapKho.Rows[e.RowIndex].Cells["MADN"].Value.ToString();
            }
            
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaDN.Text))
            {
                MessageBox.Show("Chưa chọn đơn nhập");

                return;
            }

            DialogResult rs =
                MessageBox.Show(
                    "Bạn có chắc muốn xóa?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo);

            if (rs == DialogResult.Yes)
            {
                bus.DeleteDonNhap(txt_MaDN.Text);

                MessageBox.Show("Xóa thành công");

                LoadDonNhap();

                txt_MaDN.Clear();
            }
        }

        
    }

}
