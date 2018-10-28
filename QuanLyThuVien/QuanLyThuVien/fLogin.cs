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

namespace QuanLyThuVien
{
    public partial class fLogin : DevExpress.XtraEditors.XtraForm
    {
        //string conn = "Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True";
        string conn = "Data Source=DESKTOP-VRRUJB7\\SQLEXPRESS;Initial Catalog=QuanLyThuVien;User ID=sa;Password=sa2012";
        string table = "TAIKHOAN";
        public fLogin()
        {
            InitializeComponent();
            
           
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            fMain f = new fMain();
            loginFrom1.setValue(f, this, table, conn);
        }
    }
}