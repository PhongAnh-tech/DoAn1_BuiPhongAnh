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
            SqlDataAdapter da =
                new SqlDataAdapter(
                    "SELECT MANV FROM NHANVIEN",
                    conn);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable GetNCC()
        {
            SqlDataAdapter da =
                new SqlDataAdapter(
                    "SELECT MANCC FROM NHACC",
                    conn);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable GetKhuyenMai()
        {
            SqlDataAdapter da =
                new SqlDataAdapter(
                    "SELECT MAKM FROM KHUYENMAI",
                    conn);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable GetSanPham()
        {
            SqlDataAdapter da =
                new SqlDataAdapter(
                @"SELECT
                    sp.MASP,
                    sp.TENSP,
                    lsp.TENLOAI,
                    sp.SOLUONG,
                    sp.DONGIANHAP,
                    sp.DONGIABAN,
                    sp.KHUYENMAI
                  FROM SANPHAM sp
                  JOIN LOAISANPHAM lsp
                  ON sp.MALOAISP = lsp.MALOAISP",
                  conn);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable GetDonNhap()
        {
            SqlDataAdapter da =
                new SqlDataAdapter(
                @"SELECT *
                  FROM DONHANGNHAP",
                  conn);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public string TaoMaDN()
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand(
            @"SELECT TOP 1 MADN
              FROM DONHANGNHAP
              ORDER BY MADN DESC",
              conn);

            object result = cmd.ExecuteScalar();

            conn.Close();

            int so = 1;

            if (result != null)
            {
                string ma =
                    result.ToString().Substring(2);

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
                    (
                        MADN,
                        MANV,
                        MANCC,
                        NGAYNHAP,
                        MAKM,
                        DANGNHAPKHO
                    )
                    VALUES
                    (
                        @MADN,
                        @MANV,
                        @MANCC,
                        @NGAY,
                        @MAKM,
                        0
                    )",
                    conn,
                    tran);

                cmd.Parameters.AddWithValue("@MADN", dn.MADN);
                cmd.Parameters.AddWithValue("@MANV", dn.MANV);
                cmd.Parameters.AddWithValue("@MANCC", dn.MANCC);
                cmd.Parameters.AddWithValue("@NGAY", dn.NGAYNHAP);
                cmd.Parameters.AddWithValue("@MAKM", dn.MAKM);

                cmd.ExecuteNonQuery();

                foreach (ChiTietDonNhapDTO ct in dsCT)
                {
                    SqlCommand cmdCT =
                        new SqlCommand(
                        @"INSERT INTO CHITIETDONNHAP
                        VALUES(@MADN,@MASP,@SL,@GIA)",
                        conn,
                        tran);

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

            SqlTransaction tran =
                conn.BeginTransaction();

            try
            {
                SqlCommand cmd =
                    new SqlCommand(
                    @"SELECT MASP, SLNHAP
                      FROM CHITIETDONNHAP
                      WHERE MADN = @MADN",
                    conn,
                    tran);

                cmd.Parameters.AddWithValue("@MADN", madn);

                SqlDataAdapter da =
                    new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    SqlCommand updateSP =
                        new SqlCommand(
                        @"UPDATE SANPHAM
                          SET SOLUONG = SOLUONG + @SL
                          WHERE MASP = @MASP",
                        conn,
                        tran);

                    updateSP.Parameters.AddWithValue(
                        "@SL",
                        row["SLNHAP"]);

                    updateSP.Parameters.AddWithValue(
                        "@MASP",
                        row["MASP"]);

                    updateSP.ExecuteNonQuery();
                }

                SqlCommand updateDN =
                    new SqlCommand(
                    @"UPDATE DONHANGNHAP
                      SET DANGNHAPKHO = 1
                      WHERE MADN = @MADN",
                    conn,
                    tran);

                updateDN.Parameters.AddWithValue(
                    "@MADN",
                    madn);

                updateDN.ExecuteNonQuery();

                tran.Commit();
            }
            catch
            {
                tran.Rollback();
                throw;
            }

            conn.Close();
        }

        public void DeleteDonNhap(string madn)
        {
            conn.Open();

            SqlTransaction tran = conn.BeginTransaction();

            try
            {
                SqlCommand cmdCT = new SqlCommand(
                @"DELETE FROM CHITIETDONNHAP
          WHERE MADN = @MADN",
                conn, tran);

                cmdCT.Parameters.AddWithValue("@MADN", madn);

                cmdCT.ExecuteNonQuery();

                SqlCommand cmdDN = new SqlCommand(
                @"DELETE FROM DONHANGNHAP
          WHERE MADN = @MADN",
                conn, tran);

                cmdDN.Parameters.AddWithValue("@MADN", madn);

                cmdDN.ExecuteNonQuery();

                tran.Commit();
            }
            catch
            {
                tran.Rollback();
                throw;
            }

            conn.Close();
        }
    }
}
