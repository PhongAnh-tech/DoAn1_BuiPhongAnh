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

        void LoadThongKe()
        {
            lbl_TitleSP.Text = "SẢN PHẨM ĐÃ BÁN";
            lbl_TitleDT.Text = "TỔNG DOANH THU";
            lbl_TitleKH.Text = "TỔNG KHÁCH HÀNG";

            lblTongSP.Text = bus.TongSanPhamDaBan().ToString();
            lblDoanhThu.Text = bus.TongDoanhThu().ToString();
            lblKhachHang.Text = bus.TongKhachHang().ToString();
        }

        void LoadChartDoanhThu()
        {
            DataTable dt = bus.DoanhThuTheoNgay();

            chart_DoanhThu.Series.Clear();

            chart_DoanhThu.Series.Add("DoanhThu");

            foreach (DataRow row in dt.Rows)
            {
                chart_DoanhThu.Series["DoanhThu"].Points.AddXY(Convert.ToDateTime(row["NGAYBAN"]).ToShortDateString(), row["DoanhThu"]);
            }
        }

        void LoadChartTopSP()
        {
            DataTable dt = bus.TopSanPham();

            chart_Top10.Series.Clear();

            Series series = chart_Top10.Series.Add("TopSP");

            series.ChartType = SeriesChartType.Pie;

            foreach (DataRow row in dt.Rows)
            {
                series.Points.AddXY(row["TENSP"], row["TongBan"]);
            }
        }

        private void fThongKe_Load(object sender, EventArgs e)
        {
            LoadThongKe();
            LoadChartDoanhThu();
            LoadChartTopSP();
        }

        

        
    }
}
