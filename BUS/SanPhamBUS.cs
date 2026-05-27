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
        public class SanPhamBUS
        {
            SanPhamDAL dal =
                new SanPhamDAL();

            public DataTable GetSanPham()
            {
                return dal.GetSanPham();
            }

            public DataTable GetNCC()
            {
                return dal.GetNCC();
            }

            public DataTable GetLoai()
            {
                return dal.GetLoai();
            }

            public void InsertSanPham(
                SanPhamDTO sp)
            {
                dal.InsertSanPham(sp);
            }

            public void UpdateSanPham(
                SanPhamDTO sp)
            {
                dal.UpdateSanPham(sp);
            }

            public void DeleteSanPham(
                string ma)
            {
                dal.DeleteSanPham(ma);
            }

            public DataTable SearchSanPham(
                string ten)
            {
                return dal.SearchSanPham(ten);
            }
        }
}
