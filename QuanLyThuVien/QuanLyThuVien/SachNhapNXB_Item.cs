using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using linQ_View;

namespace QuanLyThuVien
{
    public partial class SachNhapNXB_Item : UserControl
    {
        View_Linq view = new View_Linq();

        public SachNhapNXB_Item()
        {
            InitializeComponent();
        }

        public SachNhapNXB_Item(string maDDH, string maSach, string tenSach, string hinhanh, string soluong, string dongia)
        {
            InitializeComponent();

            txtMaDDH.Text = maDDH;
            txtMaSach.Text = maSach;
            txtTenSach.Text = tenSach;
            txtSoLuong.Text = soluong;
            txtTongTien.Text = dongia;

            try
            {
                pictureBox1.Load(hinhanh);
            }
            catch
            {
                pictureBox1.Image = Properties.Resources.Book_96px;
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            int res = view.nhapSach(txtMaDDH.Text, txtMaSach.Text);
            if (res == 1)
            {
                MessageBox.Show("Nhập hàng thành công", "Thông báo", MessageBoxButtons.OK);
                this.Parent.Controls.Remove(this);
            }
            else
            {
                MessageBox.Show("Nhập hàng thất bại", "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}
