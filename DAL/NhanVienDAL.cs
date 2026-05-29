using doan1_Cuahangbanggiay.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doan1_Cuahangbanggiay.DAL
{
    public class NhanVienDAL : DBConnection
    {
        public DataTable GetNhanVien()
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_GetNhanVien", conn);

            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public bool CheckMaNV(string manv)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM NHANVIEN WHERE MANV=@manv", conn);

            cmd.Parameters.AddWithValue("@manv", manv);
            int count = (int)cmd.ExecuteScalar();

            conn.Close();

            return count > 0;
        }

        public bool InsertNhanVien(NhanVienDTO nv)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("sp_InsertNhanVien", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@manv", nv.MANV);
            cmd.Parameters.AddWithValue("@hoten", nv.HOTEN);
            cmd.Parameters.AddWithValue("@sdt", nv.SDT);
            cmd.Parameters.AddWithValue("@ngaysinh", nv.NGAYSINH);
            cmd.Parameters.AddWithValue("@email", nv.EMAIL);
            cmd.Parameters.AddWithValue("@gioitinh", nv.GIOITINH);
            cmd.Parameters.AddWithValue("@maloai", nv.MALOAI);

            MessageBox.Show("Số điện thoại không hợp lệ");
            int result = cmd.ExecuteNonQuery();
            
            conn.Close();

            return result > 0;
        }

        public bool UpdateNhanVien(NhanVienDTO nv)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("sp_UpdateNhanVien", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@manv", nv.MANV);
            cmd.Parameters.AddWithValue("@hoten", nv.HOTEN);
            cmd.Parameters.AddWithValue("@sdt", nv.SDT);
            cmd.Parameters.AddWithValue("@ngaysinh", nv.NGAYSINH);
            cmd.Parameters.AddWithValue("@email", nv.EMAIL);
            cmd.Parameters.AddWithValue("@gioitinh", nv.GIOITINH);
            cmd.Parameters.AddWithValue("@maloai", nv.MALOAI);

            int result = cmd.ExecuteNonQuery();

            conn.Close();

            return result > 0;
        }

        public bool DeleteNhanVien(string manv)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("sp_DeleteNhanVien", conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@manv", manv);

            int result = cmd.ExecuteNonQuery();

            conn.Close();

            return result > 0;
        }

        public DataTable SearchNhanVien(string ten)
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_SearchNhanVien", conn);

            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@ten", ten);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }
    }
}
