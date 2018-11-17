using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using linQ;

namespace QuanLyThuVien
{
    public partial class SachDatOnline_Item : UserControl
    {
        Connection1 con = new Connection1();
        CreatePrimaryKey pk = new CreatePrimaryKey();
        Conection conn = new Conection();

        public SachDatOnline_Item()
        {
            InitializeComponent();
        }

        string maDG;
        string maNV;

        public SachDatOnline_Item(string maDG, string hinhanh, string maSach, string tenSach, DateTime ngayDat, DateTime ngayLay, string maNV)
        {
            InitializeComponent();

            this.maDG = maDG;
            this.maNV = maNV;
            try
            {
                pictureBox1.Load(hinhanh);
            }
            catch
            {
                pictureBox1.Image = Properties.Resources.Book_96px;
            }

            txtMaSach.Text = maSach;
            txtTenSach.Text = tenSach;

            txtNgayDat.Text = ngayDat.Day.ToString();
            txtThangDat.Text = ngayDat.Month.ToString();
            txtNamDat.Text = ngayDat.Year.ToString();

            txtNgayLay.Text = ngayLay.Day.ToString();
            txtThangLay.Text = ngayLay.Month.ToString();
            txtNamLay.Text = ngayLay.Year.ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            string ma = pk.createKeyMuonSach();
            int kt = con.addPhieuMuon(ma, maNV, maDG, 1, new List<string>() {txtMaSach.Text});
            if (kt == 1)
            {
                MessageBox.Show("Thêm thành công ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.delDatOnline(maDG, txtMaSach.Text);
                this.Parent.Controls.Remove(this);
                //frmPhieuMuon phieuMuon = new frmPhieuMuon(ma.ToString(), maNV);
                //phieuMuon.Show();
            }
            else if (kt == 2)
                MessageBox.Show("Sinh viên chưa đóng phạt ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (kt == 3)
                MessageBox.Show("Sinh viên chưa trả sách ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Thêm không thành công ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
