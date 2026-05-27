using doan1_Cuahangbanggiay.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan1_Cuahangbanggiay.BUS
{
    public class ThongKeBUS
    {
        ThongKeDAL dal = new ThongKeDAL();

        public int TongSanPhamDaBan()
        {
            return dal.TongSanPhamDaBan();
        }

        public decimal TongDoanhThu()
        {
            return dal.TongDoanhThu();
        }

        public int TongKhachHang()
        {
            return dal.TongKhachHang();
        }

        public DataTable DoanhThuTheoNgay(string boLoc)
        {
            return dal.DoanhThuTheoNgay(boLoc);
        }

        public DataTable TopSanPham(string kieuThongKe, string boLoc)
        {
            return dal.TopSanPham(kieuThongKe, boLoc);
        }
    }
}
