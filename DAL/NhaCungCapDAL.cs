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
    public class NhaCungCapDAL : DBConnection
    {
        // LOAD NCC
        public DataTable GetNCC()
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_GetNCC_Full", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        // CHECK MÃ NCC
        public bool CheckMaNCC(string ma)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM NHACC WHERE MANCC = @ma", conn);

            cmd.Parameters.AddWithValue("@ma", ma);

            int count = (int)cmd.ExecuteScalar();

            conn.Close();

            return count > 0;
        }

        // CHECK KHÓA NGOẠI
        public bool CheckSanPham(string ma)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM SANPHAM WHERE MANCC = @ma",conn);
            cmd.Parameters.AddWithValue("@ma", ma);
            int count = (int)cmd.ExecuteScalar();

            conn.Close();

            return count > 0;
        }

        // THÊM
        public void InsertNCC(NhaCungCapDTO ncc)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("sp_InsertNCC", conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mancc", ncc.MANCC);
            cmd.Parameters.AddWithValue("@tenncc", ncc.TENNCC);
            cmd.Parameters.AddWithValue("@diachi", ncc.DIACHI);
            cmd.Parameters.AddWithValue("@sdt", ncc.SDT);
            cmd.Parameters.AddWithValue("@email", ncc.EMAIL);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        // SỬA
        public void UpdateNCC(NhaCungCapDTO ncc)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("sp_UpdateNCC", conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mancc", ncc.MANCC);
            cmd.Parameters.AddWithValue("@tenncc", ncc.TENNCC);
            cmd.Parameters.AddWithValue("@diachi", ncc.DIACHI);
            cmd.Parameters.AddWithValue("@sdt", ncc.SDT);
            cmd.Parameters.AddWithValue("@email", ncc.EMAIL);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        // XÓA
        public void DeleteNCC(string ma)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("sp_DeleteNCC", conn);

            cmd.CommandType =CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mancc", ma);
            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
