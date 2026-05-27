using doan1_Cuahangbanggiay.DAL;
using doan1_Cuahangbanggiay.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doan1_Cuahangbanggiay.BUS
{
    public class DonBanBUS
    {
        DonBanDAL dal = new DonBanDAL();

        public DataTable LoadLoaiSP()
        {
            return dal.LoadLoaiSP();
        }

        public DataTable LoadNhaCC()
        {
            return dal.LoadNhaCC();
        }

        public DataTable LoadSanPham()
        {
            return dal.LoadSanPham();
        }

        public DataTable LocSanPham(
            string ten,
            object maloai,
            object mancc)
        {
            return dal.LocSanPham(
                ten,
                maloai,
                mancc);
        }

        public string ThemDonBan(
            DonBanDTO db,
            DataGridView dgv)
        {
            return dal.ThemDonBan(db, dgv);
        }

        public DataTable InHoaDon(string madb)
        {
            return dal.InHoaDon(madb);
        }
    }
}
