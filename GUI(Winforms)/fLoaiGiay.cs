using doan1_Cuahangbanggiay.BUS;
using doan1_Cuahangbanggiay.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doan1_Cuahangbanggiay.GUI_Winforms_
{
    public partial class fLoaiGiay : Form
    {
        LoaiGiayBUS bus = new LoaiGiayBUS();
        public fLoaiGiay()
        {
            InitializeComponent();
        }

        private void dgv_LoaiGiay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_LoaiGiay.Rows[e.RowIndex];
                txt_MaLoaiGiay.Text = row.Cells["MALOAISP"].Value.ToString();
                txt_TenLoaiGiay.Text = row.Cells["TENLOAI"].Value.ToString();
            }
        }


        private void fLoaiGiay_Load(object sender, EventArgs e)
        {
            LoadLoaiGiay();
        }

        void LoadLoaiGiay()
        {
            dgv_LoaiGiay.DataSource = bus.GetLoaiGiay();
        }

        private void btn_ThemLG_Click(object sender, EventArgs e)
        {
            if (bus.CheckMaLoai(txt_MaLoaiGiay.Text))
            {
                MessageBox.Show("Mã loại giày đã tồn tại!");

                return;
            }

            LoaiGiayDTO lg = new LoaiGiayDTO();

            lg.MALOAISP = txt_MaLoaiGiay.Text;
            lg.TENLOAI = txt_TenLoaiGiay.Text;
            bus.InsertLoaiGiay(lg);

            MessageBox.Show("Thêm thành công!");

            LoadLoaiGiay();
        }

        private void btn_SuaLG_Click(object sender, EventArgs e)
        {
            LoaiGiayDTO lg = new LoaiGiayDTO();

            lg.MALOAISP = txt_MaLoaiGiay.Text;
            lg.TENLOAI = txt_TenLoaiGiay.Text;
            bus.UpdateLoaiGiay(lg);

            MessageBox.Show("Sửa thành công!");

            LoadLoaiGiay();
        }

        private void btn_XoaLG_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaLoaiGiay.Text))
            {
                MessageBox.Show("Chưa chọn loại giày!");
                return;
            }

            DialogResult rs = MessageBox.Show(
                    "Bạn có chắc muốn xóa?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo);

            if (rs == DialogResult.Yes)
            {
                bus.DeleteLoaiGiay(txt_MaLoaiGiay.Text);
                MessageBox.Show("Xóa thành công!");
                LoadLoaiGiay();
            }
        }

        private void btn_LamMoiLG_Click(
            object sender,
            EventArgs e)
        {
            txt_MaLoaiGiay.Clear();

            txt_TenLoaiGiay.Clear();

            LoadLoaiGiay();
        }

        private void btn_TatForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
