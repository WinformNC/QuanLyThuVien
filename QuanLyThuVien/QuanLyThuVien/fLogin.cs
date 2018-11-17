using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Configuration;
using System.Data.SqlClient;
using linQ;

namespace QuanLyThuVien
{
    public partial class fLogin : DevExpress.XtraEditors.XtraForm
    {
        Conection con = new Conection();

        public fLogin()
        {
            InitializeComponent();
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Text = Properties.Settings.Default.UserName;
            txtPass.Text = Properties.Settings.Default.Password;
            chkRemember.Checked = Properties.Settings.Default.RememberMe;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim().Length == 0 || txtPass.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui long nhap du thong tin", "Thong bao", MessageBoxButtons.OK);
                return;
            }

            int res = con.ktDangNhap(txtUsername.Text.Trim(), txtPass.Text.Trim());

            if (res == 0)
            {
                MessageBox.Show("Khong phai tai khoan nhan vien", "Thong bao", MessageBoxButtons.OK);
            }
            else if (res == -1)
            {
                MessageBox.Show("Tai khoan khong ton tai", "Thong bao", MessageBoxButtons.OK);
            }
            else
            {
                fMain f = new fMain(txtUsername.Text.Trim(), res.ToString());
                this.Hide();
                f.ShowDialog();
                this.Show();
                if (chkRemember.Checked)
                    return;
                else
                {
                    txtPass.Clear();
                    txtUsername.Focus();
                    return;
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (chkRemember.Checked)
            {
                Properties.Settings.Default.UserName = txtUsername.Text;
                Properties.Settings.Default.Password = txtPass.Text;
                Properties.Settings.Default.RememberMe = true;
            }
            else
            {
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.RememberMe = false;
            }
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void fLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (chkRemember.Checked)
            {
                Properties.Settings.Default.UserName = txtUsername.Text;
                Properties.Settings.Default.Password = txtPass.Text;
                Properties.Settings.Default.RememberMe = true;
            }
            else
            {
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.RememberMe = false;
            }
            Properties.Settings.Default.Save();
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin.PerformClick();
        }
    }
}