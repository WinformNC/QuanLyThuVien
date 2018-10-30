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

namespace QuanLyThuVien
{
    public partial class fLogin : DevExpress.XtraEditors.XtraForm
    {
        string conn = Properties.Settings.Default.connectionString;
        
        string table = "TAIKHOAN";
        public fLogin()
        {
            InitializeComponent();

            bool res = testConnection();
            if (!res)
            {
                DialogResult r = MessageBox.Show("Chuỗi kết nối không hợp lệ. Thiết lập chuỗi kết nối ?", "Thông báo", MessageBoxButtons.OK);
                if (r == System.Windows.Forms.DialogResult.OK)
                {
                    fThietLapKetNoi f = new fThietLapKetNoi();
                    f.ShowDialog();
                    conn = Properties.Settings.Default.connectionString;
                }
                else
                    this.Close();
            }
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            fMain f = new fMain();
            loginFrom1.setValue(f, this, table, conn);
        }

        private bool testConnection()
        {
            SqlConnection con = new SqlConnection(conn);
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }      
        }
    }
}