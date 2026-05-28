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
    public class LoaiGiayDAL : DBConnection
    {
        // LOAD
        public DataTable GetLoaiGiay()
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_GetLoaiGiay", conn);

            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        // CHECK MÃ
        public bool CheckMaLoai(string ma)
        {
            conn.Open();

            SqlCommand cmd =
                new SqlCommand("SELECT COUNT(*) FROM LOAISANPHAM WHERE MALOAISP = @ma",conn);

            cmd.Parameters.AddWithValue("@ma", ma);

            int count = (int)cmd.ExecuteScalar();

            conn.Close();

            return count > 0;
        }

        // THÊM
        public void InsertLoaiGiay(LoaiGiayDTO lg)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("sp_InsertLoaiGiay", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ma", lg.MALOAISP);
            cmd.Parameters.AddWithValue("@ten", lg.TENLOAI);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        // SỬA
        public void UpdateLoaiGiay(LoaiGiayDTO lg)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("sp_UpdateLoaiGiay", conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ma", lg.MALOAISP);
            cmd.Parameters.AddWithValue("@ten", lg.TENLOAI);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        // XÓA
        public void DeleteLoaiGiay(string ma)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("sp_DeleteLoaiGiay", conn);

            cmd.CommandType =CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ma", ma);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
