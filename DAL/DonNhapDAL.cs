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
    public class DonNhapDAL : DBConnection
    {
        public DataTable GetNhanVien()
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_GetNhanVien", conn);

            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable GetNCC()
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_GetNCC", conn);

            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable GetKhuyenMai()
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_GetKhuyenMai", conn);

            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable GetSanPham()
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_GetSanPham", conn);

            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable GetDonNhap()
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_GetDonNhap", conn);

            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public string TaoMaDN()
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("sp_TaoMaDN", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            object result = cmd.ExecuteScalar();

            conn.Close();

            int so = 1;

            if (result != null)
            {
                string ma = result.ToString().Substring(2);

                so = int.Parse(ma) + 1;
            }

            return "DN" + so.ToString("00");
        }

        public void InsertDonNhap(
            DonNhapDTO dn,
            List<ChiTietDonNhapDTO> dsCT)
        {
            conn.Open();

            SqlTransaction tran =
                conn.BeginTransaction();

            try
            {
                SqlCommand cmd =
                    new SqlCommand(
                    @"INSERT INTO DONHANGNHAP
                    (MADN, MANV, MANCC, NGAYNHAP, MAKM, DANGNHAPKHO)
                    VALUES
                    (@MADN, @MANV, @MANCC, @NGAY, @MAKM, 0)", conn, tran);

                cmd.Parameters.AddWithValue("@MADN", dn.MADN);
                cmd.Parameters.AddWithValue("@MANV", dn.MANV);
                cmd.Parameters.AddWithValue("@MANCC", dn.MANCC);
                cmd.Parameters.AddWithValue("@NGAY", dn.NGAYNHAP);
                cmd.Parameters.AddWithValue("@MAKM", dn.MAKM);

                cmd.ExecuteNonQuery();

                foreach (ChiTietDonNhapDTO ct in dsCT)
                {
                    SqlCommand cmdCT = new SqlCommand(
                        @"INSERT INTO CHITIETDONNHAP
                        VALUES(@MADN,@MASP,@SL,@GIA)", conn, tran);

                    cmdCT.Parameters.AddWithValue("@MADN", ct.MADN);
                    cmdCT.Parameters.AddWithValue("@MASP", ct.MASP);
                    cmdCT.Parameters.AddWithValue("@SL", ct.SLNHAP);
                    cmdCT.Parameters.AddWithValue("@GIA", ct.DONGIANHAP);

                    cmdCT.ExecuteNonQuery();
                }

                tran.Commit();
            }
            catch
            {
                tran.Rollback();
                throw;
            }

            conn.Close();
        }

        public void XacNhanNhapKho(string madn)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("sp_XacNhanNhapKho", conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MADN", madn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void DeleteDonNhap(string madn)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("sp_DeleteDonNhap", conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MADN", madn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
