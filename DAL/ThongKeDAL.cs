using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

        public DataTable DoanhThuTheoNgay()
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_DoanhThuTheoNgay", conn);

            da.SelectCommand.CommandType =
                CommandType.StoredProcedure;

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }

        public DataTable TopSanPham()
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_TopSanPham", conn);

            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }
    }
}
