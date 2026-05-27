using doan1_Cuahangbanggiay.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan1_Cuahangbanggiay.BUS
{
        public class AccountBUS
        {
            AccountDAL dal = new AccountDAL();

            public DataTable Login(string user,string pass)
            {
                return dal.Login(user, pass);
            }
        }
}
