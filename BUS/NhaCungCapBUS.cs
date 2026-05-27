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
    public class NhaCungCapBUS
    {
        NhaCungCapDAL dal = new NhaCungCapDAL();

        public DataTable GetNCC()
        {
            return dal.GetNCC();
        }

        public bool CheckMaNCC(string ma)
        {
            return dal.CheckMaNCC(ma);
        }

        public bool CheckSanPham(string ma)
        {
            return dal.CheckSanPham(ma);
        }

        public void InsertNCC(NhaCungCapDTO ncc)
        {
            dal.InsertNCC(ncc);
        }

        public void UpdateNCC(
            NhaCungCapDTO ncc)
        {
            dal.UpdateNCC(ncc);
        }

        public void DeleteNCC(string ma)
        {
            dal.DeleteNCC(ma);
        }
    }
}
