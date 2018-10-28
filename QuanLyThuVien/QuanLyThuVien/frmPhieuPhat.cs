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
    public partial class frmPhieuPhat : Form
    {
        rptPhieuPhat phieuPhat = new rptPhieuPhat();

        string maDocGia, tenDocGia;
        double ngayQuaHan, tongTienPhat;
        string tenNhanVien;

        public frmPhieuPhat(string tenNV, string maDG, string tenDG, double ngayQH, double tongPhat)
        {
            InitializeComponent();

            tenNhanVien = tenNV;
            maDocGia = maDG;
            tenDocGia = tenDG;
            ngayQuaHan = Math.Floor(ngayQH);
            tongTienPhat = tongPhat;

            phieuPhat.SetParameterValue(0, maDocGia);
            phieuPhat.SetParameterValue(1, tenDocGia);
            phieuPhat.SetParameterValue(2, ngayQuaHan);
            phieuPhat.SetParameterValue(3, tongTienPhat);
            phieuPhat.SetParameterValue(4, tenNhanVien);
            crystalReportViewer1.ReportSource = phieuPhat;
            crystalReportViewer1.Refresh();
        }

        private void frmPhieuTra_Load(object sender, EventArgs e)
        {
            
        }
    }
}
