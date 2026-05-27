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
    public class DonBanDAL : DBConnection
    {
        public DataTable LoadLoaiSP()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT MALOAISP, TENLOAI FROM LOAISANPHAM", conn);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable LoadNhaCC()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT MANCC, TENNCC FROM NHACC", conn);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable LoadSanPham()
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_LoadSanPham", conn);

            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable LocSanPham(string ten,object maloai,object mancc)
        {
            SqlCommand cmd = new SqlCommand("sp_LocSanPham", conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TENSP", string.IsNullOrEmpty(ten) ? (object)DBNull.Value : ten);
            cmd.Parameters.AddWithValue("@MALOAISP", maloai ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@MANCC", mancc ?? (object)DBNull.Value);

            SqlDataAdapter da =
                new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public string ThemDonBan(DonBanDTO db, DataGridView dgv)
        {
            conn.Open();

            SqlTransaction tran = conn.BeginTransaction();

            string madb = "";

            try
            {
                SqlCommand cmdDonBan =
                    new SqlCommand(
                    "sp_ThemDonBan",
                    conn,
                    tran);

                cmdDonBan.CommandType =
                    CommandType.StoredProcedure;

                cmdDonBan.Parameters.AddWithValue(
                    "@MANV",
                    db.MANV);

                cmdDonBan.Parameters.AddWithValue(
                    "@MAKH",
                    db.MAKH);

                object result =
                    cmdDonBan.ExecuteScalar();

                madb = result.ToString();

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.IsNewRow)
                        continue;

                    string masp =
                        row.Cells["MASP"].Value.ToString();

                    int sl =
                        Convert.ToInt32(
                            row.Cells["SL"].Value);

                    decimal gia =
                        Convert.ToDecimal(
                            row.Cells["GIA"].Value);


                    SqlCommand cmdCT =
                        new SqlCommand(
                        "sp_ThemCTDonBan",
                        conn,
                        tran);

                    cmdCT.CommandType =
                        CommandType.StoredProcedure;

                    cmdCT.Parameters.AddWithValue(
                        "@MADB",
                        madb);

                    cmdCT.Parameters.AddWithValue(
                        "@MASP",
                        masp);

                    cmdCT.Parameters.AddWithValue(
                        "@SL",
                        sl);

                    cmdCT.Parameters.AddWithValue(
                        "@GIA",
                        gia);

                    cmdCT.ExecuteNonQuery();

                    SqlCommand cmdTru =
                        new SqlCommand(
                        "sp_TruSoLuongSanPham",
                        conn,
                        tran);

                    cmdTru.CommandType =
                        CommandType.StoredProcedure;

                    cmdTru.Parameters.AddWithValue(
                        "@MASP",
                        masp);

                    cmdTru.Parameters.AddWithValue(
                        "@SL",
                        sl);

                    cmdTru.ExecuteNonQuery();
                }

                SqlCommand cmdTongTien =
                    new SqlCommand(
                    "sp_CapNhatTongTienDonBan",
                    conn,
                    tran);

                cmdTongTien.CommandType =
                    CommandType.StoredProcedure;

                cmdTongTien.Parameters.AddWithValue(
                    "@MADB",
                    madb);

                cmdTongTien.ExecuteNonQuery();

                tran.Commit();
            }
            catch
            {
                tran.Rollback();
                throw;
            }

            conn.Close();

            return madb;
        }

        public DataTable InHoaDon(string madb)
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_InHoaDon",conn);

            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@MADB", madb);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }
    }
}
