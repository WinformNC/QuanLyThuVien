using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class frmPhieuMuon : Form
    {
        rptPhieuMuon phieuMuon = new rptPhieuMuon();

        string maMuon;
        string tenNhanVien;

        public frmPhieuMuon(string ma, string tenNV)
        {
            InitializeComponent();
            maMuon = ma;
            tenNhanVien = tenNV;

            phieuMuon.SetParameterValue("maMuon", maMuon);
            phieuMuon.SetParameterValue("hanTra", DateTime.Parse(DateTime.Now.AddDays(10).ToShortDateString()).ToString("dd/MM/yyyy"));
            crystalReportViewer1.ReportSource = phieuMuon;
            crystalReportViewer1.Refresh();
        }

        private void frmPhieuMuon_Load(object sender, EventArgs e)
        {
            phieuMuon.SetParameterValue("maMuon", maMuon);
            phieuMuon.SetParameterValue("hanTra", DateTime.Parse(DateTime.Now.AddDays(10).ToShortDateString()).ToString("dd/MM/yyyy"));
            crystalReportViewer1.ReportSource = phieuMuon;
            crystalReportViewer1.Refresh();
        }
    }
}
