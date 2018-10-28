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
using BLL;
using linQ;
namespace QuanLyThuVien
{
    public partial class fTraTaiLieu : DevExpress.XtraEditors.XtraForm
    {
        //DSMuonBLL dsMuon = new DSMuonBLL();
        Conection conn = new Conection();
        string phieumuon, masach, masinhvien, lydo, tinhtrang;
        DateTime ngaydukien;
        float sotienphat;
        public fTraTaiLieu()
        {
            InitializeComponent();
        }

        private void fTraTaiLieu_Load(object sender, EventArgs e)
        {
            loadDSMuon();
        }

        private void loadDSMuon()
        {
            dtgvMuon.DataSource = conn.loadViewCT();
            setNameCol();
        }

        private void setNameCol()
        {
            dtgvMuon.Columns[0].HeaderText = "Mã phiếu mượn";
            dtgvMuon.Columns[1].HeaderText = "Mã sách";
            dtgvMuon.Columns[2].HeaderText = "Mã nhân viên";
            dtgvMuon.Columns[3].HeaderText = "Mã sinh viên";
            dtgvMuon.Columns[4].HeaderText = "Ngày mượn";
            dtgvMuon.Columns[5].HeaderText = "Ngày dự kiến trả";
            dtgvMuon.Columns[6].HeaderText = "Phí mượn";
            dtgvMuon.Columns[7].HeaderText = "Phí cọc";
            dtgvMuon.Columns[8].HeaderText = "Tình trạng";
           
        }
        private void dtgvMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            ngaydukien = DateTime.Parse(dtgvMuon["NGAYDUKIENTRA", index].Value.ToString());
            masach = dtgvMuon["MASACH", index].Value.ToString();
            phieumuon = dtgvMuon["MAPHIEUMUON", index].Value.ToString();
            masinhvien = dtgvMuon["MASINHVIEN", index].Value.ToString();
            tinhtrang = dtgvMuon["TINHTRANG", index].Value.ToString();
        }
        
      

        private void btnTra_Click(object sender, EventArgs e)
        {
            if (phieumuon != null)
            {
                sotienphat = (float)conn.tienphat(ngaydukien, DateTime.Now.AddDays(11));
                if (sotienphat > 1)
                    lydo = "Không trả đúng hạn Sách " + masach;
                int kt = conn.addCTPhieuTra(phieumuon, masach, masinhvien, DateTime.Now.AddDays(11), sotienphat, lydo, tinhtrang);
                if (kt == 1)
                {
                    MessageBox.Show("Trả thành công ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtgvMuon.DataSource = conn.loadViewCT();
                }
                else if (kt == 2)
                    MessageBox.Show("Sách đã được trả rồi ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Trả không thành công ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Chưa chọn phiếu trả ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}