using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login
{
    public partial class LoginFrom : UserControl
    {
        string  Conn;
        Form fmain, flogin;
        string table;
        public LoginFrom()
        {
            InitializeComponent();
            //this.BackgroundImage = Image.FromFile("F:\\Studio\\WinformNC\\bg.png");
        }
        public void setValue(Form fmain,Form flogin, string table, string conn)
        {
            this.fmain = fmain;
            this.flogin = flogin;
            this.table = table;
            this.Conn = conn;
        }
        public void LoginData()
        {
            string sql = "SELECT * from " + table + " where taikhoan ='" + textBox1.Text + "' and matkhau ='" + textBox2.Text + "'";
            SqlConnection connection = new SqlConnection(Conn);
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);
            DataTable dt = new DataTable();
           
            da.Fill(dt);
            connection.Close();
            if (dt.Rows.Count > 0)//dem so dong thoa dieu kien//
            {
                flogin.Hide();
                fmain.ShowDialog();
                
            }
            else
                MessageBox.Show("Thông tin đăng nhập sai ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
            

        }
        private void testAcount()
        {
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0)
                MessageBox.Show("Thiếu thông tin ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                LoginData();
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            testAcount();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text.Length == 0)
                errorProvider1.SetError(txt, "Bạn cần nhập thông tin ");
            else
                errorProvider1.Clear();
        }
    }
}
