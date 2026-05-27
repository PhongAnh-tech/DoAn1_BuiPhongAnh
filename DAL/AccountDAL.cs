using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan1_Cuahangbanggiay.DAL
{
        public class AccountDAL : DBConnection
        {
            public DataTable Login(string user, string pass)
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_Login", conn);

                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@user", user);
                da.SelectCommand.Parameters.AddWithValue("@pass", pass);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
        }
}
