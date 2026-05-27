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
    public class LoaiGiayBUS
    {
        LoaiGiayDAL dal = new LoaiGiayDAL();

        public DataTable GetLoaiGiay()
        {
            return dal.GetLoaiGiay();
        }

        public bool CheckMaLoai(string ma)
        {
            return dal.CheckMaLoai(ma);
        }

        public void InsertLoaiGiay(
            LoaiGiayDTO lg)
        {
            dal.InsertLoaiGiay(lg);
        }

        public void UpdateLoaiGiay(
            LoaiGiayDTO lg)
        {
            dal.UpdateLoaiGiay(lg);
        }

        public void DeleteLoaiGiay(
            string ma)
        {
            dal.DeleteLoaiGiay(ma);
        }
    }
}
