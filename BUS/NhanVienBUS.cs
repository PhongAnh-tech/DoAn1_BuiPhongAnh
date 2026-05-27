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
    public class NhanVienBUS
    {
        NhanVienDAL dalNV = new NhanVienDAL();

        public DataTable GetNhanVien()
        {
            return dalNV.GetNhanVien();
        }

        public bool CheckMaNV(string manv)
        {
            return dalNV.CheckMaNV(manv);
        }

        public bool InsertNhanVien(NhanVienDTO nv)
        {
            return dalNV.InsertNhanVien(nv);
        }

        public bool UpdateNhanVien(NhanVienDTO nv)
        {
            return dalNV.UpdateNhanVien(nv);
        }

        public bool DeleteNhanVien(string manv)
        {
            return dalNV.DeleteNhanVien(manv);
        }

        public DataTable SearchNhanVien(string ten)
        {
            return dalNV.SearchNhanVien(ten);
        }
    }
}
