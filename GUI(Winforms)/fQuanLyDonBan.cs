using CrystalDecisions.CrystalReports.Engine;
using doan1_Cuahangbanggiay.BUS;
using doan1_Cuahangbanggiay.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doan1_Cuahangbanggiay.GUI_Winforms_
{
    public partial class fQuanLyDonBan : Form
    {

        DonBanBUS bus = new DonBanBUS();

        public fQuanLyDonBan()
        {
            InitializeComponent();
        }


        //ĐƠN BÁN

        private void fQuanLyDonBan_Load(object sender, EventArgs e)
        {
            LoadLoaiSP();
            LoadNhaCC();
            LoadSanPham();

            TaoCotDonBan();

        }

        void LoadLoaiSP()
        {
            cmb_LSP.DataSource = bus.LoadLoaiSP();
            cmb_LSP.DisplayMember = "TENLOAI";
            cmb_LSP.ValueMember = "MALOAISP";
            cmb_LSP.SelectedIndex = -1;
        }


        void LoadNhaCC()
        {
            cmb_NhaCC.DataSource = bus.LoadNhaCC();
            cmb_NhaCC.DisplayMember = "TENNCC";
            cmb_NhaCC.ValueMember = "MANCC";
            cmb_NhaCC.SelectedIndex = -1;
        }


        void LoadSanPham()
        {
            dgv_SanPham.DataSource = bus.LoadSanPham();
        }

        void TaoCotDonBan()
        {
            dgv_DonBan.Columns.Clear();

            dgv_DonBan.Columns.Add("MASP", "Mã SP");
            dgv_DonBan.Columns.Add("TENSP", "Tên SP");
            dgv_DonBan.Columns.Add("GIA", "Đơn giá");
            dgv_DonBan.Columns.Add("SL", "Số lượng");
            dgv_DonBan.Columns.Add("THANHTIEN", "Thành tiền");

            // Nút tăng
            DataGridViewButtonColumn btnTang = new DataGridViewButtonColumn();

            btnTang.Name = "Tang";
            btnTang.Text = "+";
            btnTang.UseColumnTextForButtonValue = true;

            dgv_DonBan.Columns.Add(btnTang);

            // Nút giảm
            DataGridViewButtonColumn btnGiam = new DataGridViewButtonColumn();

            btnGiam.Name = "Giam";
            btnGiam.Text = "-";
            btnGiam.UseColumnTextForButtonValue = true;

            dgv_DonBan.Columns.Add(btnGiam);
        }

        private void dgv_SanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgv_SanPham.Rows[e.RowIndex];

            string masp = row.Cells["MASP"].Value.ToString();
            string tensp = row.Cells["TENSP"].Value.ToString();
            decimal gia = Convert.ToDecimal(row.Cells["DONGIABAN"].Value);

            foreach (DataGridViewRow r
                in dgv_DonBan.Rows)
            {
                if (r.Cells["MASP"]
                    .Value?.ToString() == masp)
                {
                    int sl = Convert.ToInt32(r.Cells["SL"].Value) + 1;
                    r.Cells["SL"].Value = sl;
                    r.Cells["THANHTIEN"].Value = sl * gia;

                    TinhTongHoaDon();

                    return;
                }
            }

            dgv_DonBan.Rows.Add(masp, tensp, gia, 1, gia);

            TinhTongHoaDon();
        }


        void TinhTongHoaDon()
        {
            decimal tong = 0;

            foreach (DataGridViewRow row in dgv_DonBan.Rows)
            {
                if (row.Cells["THANHTIEN"].Value != null)
                {
                    tong += Convert.ToDecimal(row.Cells["THANHTIEN"].Value);
                }
            }

            lbl_TongHoaDon.Text = tong.ToString("N0");
        }


        private void dgv_DonBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            string columnName = dgv_DonBan.Columns[e.ColumnIndex].Name;
            DataGridViewRow row = dgv_DonBan.Rows[e.RowIndex];
            int sl = Convert.ToInt32(row.Cells["SL"].Value);

            decimal gia = Convert.ToDecimal(row.Cells["GIA"].Value);

            // ===== NÚT TĂNG =====
            if (columnName == "Tang")
            {
                // Lấy mã sản phẩm
                string masp = row.Cells["MASP"].Value.ToString();

                // Tìm tồn kho trong dgv_SanPham
                int tonKho = 0;

                foreach (DataGridViewRow spRow in dgv_SanPham.Rows)
                {
                    if (spRow.Cells["MASP"].Value.ToString() == masp)
                    {
                        tonKho =
                            Convert.ToInt32(
                                spRow.Cells["SOLUONG"].Value);

                        break;
                    }
                }

                // Kiểm tra tồn kho
                if (sl >= tonKho)
                {
                    MessageBox.Show("Sản phẩm không đủ số lượng");
                    return;
                }

                // Tăng số lượng
                sl++;

                row.Cells["SL"].Value = sl;

                row.Cells["THANHTIEN"].Value =
                    sl * gia;
            }


            else if (columnName == "Giam")
            {
                sl--;

                if (sl <= 0)
                {
                    dgv_DonBan.Rows.Remove(row);
                }
                else
                {
                    row.Cells["SL"].Value = sl;

                    row.Cells["THANHTIEN"].Value = sl * gia;
                }
            }

            TinhTongHoaDon();
        }

        private void btn_ApDung_Click(object sender, EventArgs e)
        {
            dgv_SanPham.DataSource = bus.LocSanPham(txt_TenSP.Text, cmb_LSP.SelectedValue, cmb_NhaCC.SelectedValue);
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            txt_TenSP.Clear();

            cmb_LSP.SelectedIndex = -1;
            cmb_NhaCC.SelectedIndex = -1;

            LoadSanPham();
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            if (dgv_DonBan.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có sản phẩm!");

                return;
            }



            DonBanDTO db = new DonBanDTO();

            db.MANV = this.Tag.ToString();
            db.MAKH = "KH01";

            string madb = bus.ThemDonBan(db, dgv_DonBan);

            MessageBox.Show("Thanh toán thành công!");
            
            LoadSanPham();

            dgv_DonBan.Rows.Clear();

            lbl_TongHoaDon.Text = "0";

            DataTable dt = bus.InHoaDon(madb);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!");

                return;
            }

            ReportDocument rpt = new ReportDocument();
            string path = Application.StartupPath + @"\GUI(Winforms)\ReportHoaDon.rpt";

            if (!File.Exists(path))
            {
                MessageBox.Show("Không tìm thấy report");
                return;
            }

            rpt.Load(path);

            rpt.Database.Tables[0]
                .SetDataSource(dt);

            rpt.SetParameterValue("MADB", madb);

            rpt.SetParameterValue("TienKhachDua", 0);

            fInhoadon f = new fInhoadon();

            f.LoadReport(rpt);

            f.ShowDialog();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
