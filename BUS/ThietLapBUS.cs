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
    public class ThietLapBUS
    {
        ThietLapDAL dal = new ThietLapDAL();

        public DataTable GetTaiKhoan()
        {
            return dal.GetTaiKhoan();
        }

        public void UpdateTaiKhoan(ThietLapDTO tk)
        {
            dal.UpdateTaiKhoan(tk);
        }

        public bool CheckPassword(
            string user,
            string pass)
        {
            return dal.CheckPassword(user, pass);
        }

        public void ChangePassword(
            string user,
            string newPass)
        {
            dal.ChangePassword(user, newPass);
        }
    }
}
