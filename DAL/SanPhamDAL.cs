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
    public class SanPhamDAL : DBConnection
    {
        // LOAD SẢN PHẨM
        public DataTable GetSanPham()
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_GetSanPham", conn);

            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        // LOAD NHÀ CUNG CẤP
        public DataTable GetNCC()
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_GetNCC", conn);

            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        // LOAD LOẠI
        public DataTable GetLoai()
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_GetLoai", conn);

            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        // THÊM
        public void InsertSanPham(
            SanPhamDTO sp)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("sp_InsertSanPham", conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ma", sp.MASP);
            cmd.Parameters.AddWithValue("@ten", sp.TENSP);
            cmd.Parameters.AddWithValue("@mancc", sp.MANCC);
            cmd.Parameters.AddWithValue("@maloai", sp.MALOAISP);
            cmd.Parameters.AddWithValue("@sl", sp.SOLUONG);
            cmd.Parameters.AddWithValue("@nhap", sp.DONGIANHAP);
            cmd.Parameters.AddWithValue("@ban", sp.DONGIABAN);
            cmd.Parameters.AddWithValue("@km", sp.KHUYENMAI);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        // SỬA
        public void UpdateSanPham(
            SanPhamDTO sp)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("sp_UpdateSanPham", conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ma", sp.MASP);
            cmd.Parameters.AddWithValue("@ten", sp.TENSP);
            cmd.Parameters.AddWithValue("@mancc", sp.MANCC);
            cmd.Parameters.AddWithValue("@maloai", sp.MALOAISP);
            cmd.Parameters.AddWithValue("@sl", sp.SOLUONG);
            cmd.Parameters.AddWithValue("@nhap", sp.DONGIANHAP);
            cmd.Parameters.AddWithValue("@ban", sp.DONGIABAN);
            cmd.Parameters.AddWithValue("@km", sp.KHUYENMAI);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        // XÓA
        public void DeleteSanPham(string ma)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("sp_DeleteSanPham", conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ma", ma);
            cmd.ExecuteNonQuery();

            conn.Close();
        }


        public DataTable SearchSanPham(
            string ten)
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_SearchSanPham", conn);

            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@ten", ten);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}
