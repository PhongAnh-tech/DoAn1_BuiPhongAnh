using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan1_Cuahangbanggiay.DAL
{
    public class DBConnection
    {
        protected SqlConnection conn =
            new SqlConnection(
                @"Data Source=PhongAnhh;
                Initial Catalog=doan1_Cuahangbangiay;
                Integrated Security=True;
                TrustServerCertificate=True"
            );
    }
}
