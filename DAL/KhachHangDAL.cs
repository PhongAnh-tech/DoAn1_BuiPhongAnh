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
    public class KhachHangDAL : DBConnection
    {
        public DataTable GetKhachHang()
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_GetKhachHang", conn);

            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public bool CheckMaKH(string ma)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM KHACHHANG WHERE MAKH = @makh", conn);

            cmd.Parameters.AddWithValue("@makh", ma);

            int count = (int)cmd.ExecuteScalar();

            conn.Close();

            return count > 0;
        }

        public void InsertKhachHang(KhachHangDTO kh)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("sp_InsertKhachHang", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@makh", kh.MAKH);
            cmd.Parameters.AddWithValue("@tenkh", kh.TENKH);
            cmd.Parameters.AddWithValue("@diachi", kh.DIACHI);
            cmd.Parameters.AddWithValue("@sdt", kh.SDT);
            cmd.Parameters.AddWithValue("@gioitinh", kh.GIOITINH);
            cmd.Parameters.AddWithValue("@ngaydk", kh.NGAYDANGKY);
            cmd.Parameters.AddWithValue("@email", kh.EMAIL);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void UpdateKhachHang(KhachHangDTO kh)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("sp_UpdateKhachHang", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@makh", kh.MAKH);
            cmd.Parameters.AddWithValue("@tenkh", kh.TENKH);
            cmd.Parameters.AddWithValue("@diachi", kh.DIACHI);
            cmd.Parameters.AddWithValue("@sdt", kh.SDT);
            cmd.Parameters.AddWithValue("@gioitinh", kh.GIOITINH);
            cmd.Parameters.AddWithValue("@ngaydk", kh.NGAYDANGKY);
            cmd.Parameters.AddWithValue("@email", kh.EMAIL);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void DeleteKhachHang(string ma)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("sp_DeleteKhachHang", conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@makh", ma);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public DataTable SearchKhachHang(string ten)
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_SearchKhachHang", conn);

            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@tenkh", ten);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }
    }
}
