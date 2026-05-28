using doan1_Cuahangbanggiay.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan1_Cuahangbanggiay.DAL
{
    public class ThietLapDAL : DBConnection
    {
        public DataTable GetTaiKhoan()
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_GetTaiKhoan", conn);

            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public void UpdateTaiKhoan(ThietLapDTO tk)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("sp_UpdateTaiKhoan", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@user", tk.USERNAME);
            cmd.Parameters.AddWithValue("@pass", tk.PASSWORD);
            cmd.Parameters.AddWithValue("@role", tk.ROLE);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public bool CheckPassword(
            string user,
            string pass)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("sp_CheckPassword", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pass", pass);

            int count = (int)cmd.ExecuteScalar();

            conn.Close();

            return count > 0;
        }

        public void ChangePassword(string user, string newPass)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("sp_ChangePassword", conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@newPass", newPass);

            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
