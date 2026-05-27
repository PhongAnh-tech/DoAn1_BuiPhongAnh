using doan1_Cuahangbanggiay.BUS;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace doan1_Cuahangbanggiay.GUI_Winforms_
{
    public partial class fThongKe : Form
    {
        ThongKeBUS bus = new ThongKeBUS();

        public fThongKe()
        {
            InitializeComponent();
        }


        void LoadComboBox()
        {
            cmb_DoanhThu.Items.Add("Hôm nay");
            cmb_DoanhThu.Items.Add("Hôm qua");
            cmb_DoanhThu.Items.Add("7 ngày qua");
            cmb_DoanhThu.Items.Add("Tháng này");
            cmb_DoanhThu.Items.Add("Tháng trước");

         
            cmb_KieuThongKe.Items.Add("Theo số lượng");
            cmb_KieuThongKe.Items.Add("Theo doanh thu");

            cmb_ThoiGian.Items.Add("Hôm nay");
            cmb_ThoiGian.Items.Add("Hôm qua");
            cmb_ThoiGian.Items.Add("7 ngày qua");
            cmb_ThoiGian.Items.Add("Tháng này");
            cmb_ThoiGian.Items.Add("Tháng trước");

            cmb_DoanhThu.SelectedIndex = 0;
            cmb_KieuThongKe.SelectedIndex = 0;
            cmb_ThoiGian.SelectedIndex = 0;
        }

        void LoadThongKe()
        {
            lbl_TitleSP.Text = "SẢN PHẨM ĐÃ BÁN";
            lbl_TitleDT.Text = "TỔNG DOANH THU";
            lbl_TitleKH.Text = "TỔNG KHÁCH HÀNG";

            lblTongSP.Text = bus.TongSanPhamDaBan().ToString();
            lblDoanhThu.Text = bus.TongDoanhThu().ToString();
            lblKhachHang.Text = bus.TongKhachHang().ToString();
        }

        void LoadChartDoanhThu(string boLoc)
        {
            DataTable dt = bus.DoanhThuTheoNgay(boLoc);

            chart_DoanhThu.Series.Clear();

            chart_DoanhThu.Series.Add("DoanhThu");

            foreach (DataRow row in dt.Rows)
            {
                chart_DoanhThu.Series["DoanhThu"].Points.AddXY(Convert.ToDateTime(row["NGAYBAN"]).ToShortDateString(), row["DoanhThu"]);
            }
        }

        void LoadChartTopSP(string kieuThongKe, string boLoc)
        {
            DataTable dt = bus.TopSanPham(kieuThongKe, boLoc);

            chart_Top10.Series.Clear();

            Series series = chart_Top10.Series.Add("TopSP");

            series.ChartType = SeriesChartType.Pie;

            foreach (DataRow row in dt.Rows)
            {
                series.Points.AddXY(
                    row["TENSP"],
                    row["GiaTri"]);
            }
        }

        private void fThongKe_Load(object sender, EventArgs e)
        {
            LoadThongKe();
            LoadComboBox();
            LoadChartDoanhThu(cmb_DoanhThu.Text);
            LoadChartTopSP(cmb_KieuThongKe.Text, cmb_ThoiGian.Text);
        }

        private void cmb_DoanhThu_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadChartDoanhThu(cmb_DoanhThu.Text);
        }

        private void cmb_KieuThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadChartTopSP(cmb_KieuThongKe.Text, cmb_ThoiGian.Text);
        }

        private void cmb_ThoiGian_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadChartTopSP(cmb_KieuThongKe.Text, cmb_ThoiGian.Text);
        }
    }
}
