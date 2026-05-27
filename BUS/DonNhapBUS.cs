using doan1_Cuahangbanggiay.DAL;
using doan1_Cuahangbanggiay.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan1_Cuahangbanggiay.BUS
{
    public class DonNhapBUS
    {
        DonNhapDAL dal = new DonNhapDAL();

        public DataTable GetNhanVien()
        {
            return dal.GetNhanVien();
        }

        public DataTable GetNCC()
        {
            return dal.GetNCC();
        }

        public DataTable GetKhuyenMai()
        {
            return dal.GetKhuyenMai();
        }

        public DataTable GetSanPham()
        {
            return dal.GetSanPham();
        }

        public DataTable GetDonNhap()
        {
            return dal.GetDonNhap();
        }

        public string TaoMaDN()
        {
            return dal.TaoMaDN();
        }

        public void InsertDonNhap(
            DonNhapDTO dn,
            List<ChiTietDonNhapDTO> dsCT)
        {
            dal.InsertDonNhap(dn, dsCT);
        }

        public void XacNhanNhapKho(string madn)
        {
            dal.XacNhanNhapKho(madn);
        }

        public void DeleteDonNhap(string madn)
        {
            dal.DeleteDonNhap(madn);
        }
    }
}
