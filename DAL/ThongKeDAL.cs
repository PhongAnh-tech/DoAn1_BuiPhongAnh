using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan1_Cuahangbanggiay.DAL
{
    public class ThongKeDAL : DBConnection
    {
        public int TongSanPhamDaBan()
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("sp_TongSanPhamDaBan", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            int tong = Convert.ToInt32(cmd.ExecuteScalar());

            conn.Close();

            return tong;
        }

        public decimal TongDoanhThu()
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("sp_TongDoanhThu", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            decimal tong = Convert.ToDecimal(cmd.ExecuteScalar());

            conn.Close();

            return tong;
        }

        public int TongKhachHang()
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("sp_TongKhachHang", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            int tong = Convert.ToInt32(cmd.ExecuteScalar());

            conn.Close();

            return tong;
        }

        public DataTable DoanhThuTheoNgay(string boLoc)
        {
            SqlCommand cmd = new SqlCommand("sp_DoanhThuTheoNgay",conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BoLoc",boLoc);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }

        public DataTable TopSanPham(string kieuThongKe, string boLoc)
        {
            SqlCommand cmd = new SqlCommand("sp_TopSanPham", conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@KieuThongKe", kieuThongKe);
            cmd.Parameters.AddWithValue("@BoLoc",boLoc);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }
    }
}
