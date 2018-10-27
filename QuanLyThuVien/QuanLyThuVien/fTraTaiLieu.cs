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

namespace QuanLyThuVien
{
    public partial class fTraTaiLieu : DevExpress.XtraEditors.XtraForm
    {
        DSMuonBLL dsMuon = new DSMuonBLL();

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
            dtgvMuon.DataSource = dsMuon.LoadDSMuon();
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
        }

        private void btnTra_Click(object sender, EventArgs e)
        {

        }
    }
}