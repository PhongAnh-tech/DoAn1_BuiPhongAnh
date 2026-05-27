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
    public class KhachHangBUS
    {
        KhachHangDAL dal = new KhachHangDAL();

        public DataTable GetKhachHang()
        {
            return dal.GetKhachHang();
        }

        public bool CheckMaKH(string ma)
        {
            return dal.CheckMaKH(ma);
        }

        public void InsertKhachHang(KhachHangDTO kh)
        {
            dal.InsertKhachHang(kh);
        }

        public void UpdateKhachHang(KhachHangDTO kh)
        {
            dal.UpdateKhachHang(kh);
        }

        public void DeleteKhachHang(string ma)
        {
            dal.DeleteKhachHang(ma);
        }

        public DataTable SearchKhachHang(string ten)
        {
            return dal.SearchKhachHang(ten);
        }
    }
}
