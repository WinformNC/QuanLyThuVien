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
    public partial class SachMuon_Item : UserControl
    {
        Connection1 con = new Connection1();

        public SachMuon_Item()
        {
            InitializeComponent();
        }

        public SachMuon_Item(string maMuon, string nv, string maSach, string tenSach, string hinhanh, DateTime ngayMuon, DateTime ngayTra)
        {
            InitializeComponent();

            try
            {
                pictureBox1.Load(hinhanh);
            }
            catch
            {
                pictureBox1.Image = Properties.Resources.Book_96px;
            }

            txtMaPhieuMuon.Text = maMuon;
            txtNhanVien.Text = nv;
            txtMaSach.Text = maSach;
            txtTenSach.Text = tenSach;
            
            txtNgayMuon.Text = ngayMuon.Day.ToString();
            txtThangMuon.Text = ngayMuon.Month.ToString();
            txtNamMuon.Text = ngayMuon.Year.ToString();

            txtNgayTra.Text = ngayTra.Day.ToString();
            txtThangTra.Text = ngayTra.Month.ToString();
            txtNamTra.Text = ngayTra.Year.ToString();
            
        }

        private void SachMuon_Item_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            btnHuy.Visible = btnOK.Visible = txtGiaHan.Visible = true;
            txtGiaHan.Clear();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtGiaHan.Text.Trim().Length != 0)
            {
                int ngay = int.Parse(txtGiaHan.Text);
                con.giaHanSach(txtMaPhieuMuon.Text, txtMaSach.Text, ngay);
                DateTime dt = new DateTime(int.Parse(txtNamTra.Text), int.Parse(txtThangTra.Text), int.Parse(txtNgayTra.Text));
                dt = dt.AddDays(ngay);
                txtNgayTra.Text = dt.Day.ToString();
                txtThangTra.Text = dt.Month.ToString();
                txtNamTra.Text = dt.Year.ToString();
                btnHuy.Visible = btnOK.Visible = txtGiaHan.Visible = false;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnHuy.Visible = btnOK.Visible = txtGiaHan.Visible = false;
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            string loai = "";
            DateTime dt = new DateTime(int.Parse(txtNamTra.Text), int.Parse(txtThangTra.Text), int.Parse(txtNgayTra.Text));
            if (dt < DateTime.Now)
            {
                loai = "DK001";
            }
            int kt = con.addCTPhieuTra(txtMaPhieuMuon.Text, txtMaSach.Text, loai);
            if (kt == 1)
            {
                MessageBox.Show("Trả thành công ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Parent.Controls.Remove(this);
            }
            else
                MessageBox.Show("Trả không thành công ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void btnBaoMat_Click(object sender, EventArgs e)
        {
            con.addCTPhieuTra(txtMaPhieuMuon.Text, txtMaSach.Text, "DK002");
            MessageBox.Show("Trả thành công ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Parent.Controls.Remove(this);
        }
    }
}
