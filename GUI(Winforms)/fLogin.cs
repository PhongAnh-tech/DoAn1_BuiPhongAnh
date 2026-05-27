using doan1_Cuahangbanggiay.BUS;
using System;
using System.Data;
using System.Windows.Forms;

namespace doan1_Cuahangbanggiay
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
            txt_Pass.UseSystemPasswordChar = true;

            check_ShowPass.CheckedChanged += check_ShowPass_CheckedChanged;
        }


        private void check_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (check_ShowPass.Checked)
            {
                txt_Pass.UseSystemPasswordChar = false; //Hiện mật khẩu
            }
            else
            {
                txt_Pass.UseSystemPasswordChar = true; //ẩn mật khẩu
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = txt_User.Text.Trim();

            string password = txt_Pass.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                AccountBUS bus = new AccountBUS();

                DataTable dt = bus.Login(username, password);

                if (dt.Rows.Count > 0)
                {
                    string role = dt.Rows[0]["ROLE"].ToString().Trim();
                    string hoten = dt.Rows[0]["HOTEN"].ToString();

                    MessageBox.Show(
                        "Đăng nhập thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);


                    string manv = dt.Rows[0]["MANV"].ToString();
                    fMenu f = new fMenu(role, hoten, manv);

                    f.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show(
                        "Sai tài khoản hoặc mật khẩu!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi: " + ex.Message);
            }

        }

        private void btn_TatForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AnForm_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        
    }
}

