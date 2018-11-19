using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class SachDatNXB_Item : UserControl
    {
        public string maSach { get; set; }
        public string tenSach { get; set; }
        public int soluong { get; set; }
        public float dongia { get; set; }
        public bool ktChon { get; set; }
        public float tongtien { get; set; }

        public SachDatNXB_Item()
        {
            InitializeComponent();
        }

        public SachDatNXB_Item(string maSach, string tenSach, string hinhanh, float dongia)
        {
            InitializeComponent();

            txtMaSach.Text = maSach; this.maSach = maSach;
            txtTenSach.Text = tenSach; this.tenSach = tenSach;
            txtDonGia.Text = dongia.ToString(); this.dongia = dongia;
            txtSoLuong.Text = "0"; this.soluong = 0;
            txtTongTien.Text = "0"; this.tongtien = 0;
            ktChon = false;
            try
            {
                pictureBox1.Load(hinhanh);
            }
            catch
            {
                pictureBox1.Image = Properties.Resources.Book_96px;
            }


        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            if (txtSoLuong.Text.Trim().Length != 0)
            {
                txtTongTien.Text = (dongia * int.Parse(txtSoLuong.Text)).ToString();
                soluong = int.Parse(txtSoLuong.Text.Trim());
                tongtien = float.Parse(txtTongTien.Text);
            }
            else
            {
                txtTongTien.Text = "0";
            }
        }

        private void chk_Check_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Check.Checked)
            {
                ktChon = true;
            }
            else
            {
                ktChon = false;
            }
        }
    }
}
