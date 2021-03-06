﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using BLL;
using linQ;


namespace QuanLyThuVien
{
    public partial class fMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        fDSTaiLieu fDSTL;
        fDSNhanVien fDSNV;
        fDSTacGia fDSTG;
        fDSNhaXuatBan fDSNXB;
        fViTri fVT;
        fTheLoai fTL;
        fChucVu fCV;
        fMuonTaiLieu fMTL;
        fDanhSachSV fDSSV;
        fDSMuon fDSM;
        fTraTaiLieu fTTL;
        fDSPhat fDSP;
        fThongKeDoanhThu fTKDT;
        fDSDatOnline fDSDONL;
        fDatHang fDH;
        fNhapHang fNH;

        //Account
        string loai;
        string tenDN;
        string maNV;
        Conection con = new Conection();

        public fMain()
        {
            InitializeComponent();
        }

        public fMain(string tenDN, string loai)
        {
            InitializeComponent();
            this.tenDN = tenDN;
            this.loai = loai;
            maNV = con.findNV(tenDN);
        }

        private Form kiemtraForm(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }

        private void btnDSTaiLieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (loai == "2")
            {
                MessageBox.Show("Truy cập không được phép", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            Form frm = kiemtraForm(typeof(fDSTaiLieu));
            if (frm == null)
            {
                fDSTL = new fDSTaiLieu();
                fDSTL.MdiParent = this;
                fDSTL.Show();
            }
            else
            {
                frm.Close();
                fDSTL = new fDSTaiLieu();
                fDSTL.MdiParent = this;
                fDSTL.Show();
            }
        }

        private void btnDSNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (loai == "2" || loai == "3")
            {
                MessageBox.Show("Truy cập không được phép", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            Form frm = kiemtraForm(typeof(fDSNhanVien));
            if (frm == null)
            {
                fDSNV = new fDSNhanVien();
                fDSNV.MdiParent = this;
                fDSNV.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnTacGia_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (loai == "2")
            {
                MessageBox.Show("Truy cập không được phép", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            Form frm = kiemtraForm(typeof(fDSTacGia));
            if (frm == null)
            {
                fDSTG = new fDSTacGia();
                fDSTG.MdiParent = this;
                fDSTG.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnNXB_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (loai == "2")
            {
                MessageBox.Show("Truy cập không được phép", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            Form frm = kiemtraForm(typeof(fDSNhaXuatBan));
            if (frm == null)
            {
                fDSNXB = new fDSNhaXuatBan();
                fDSNXB.MdiParent = this;
                fDSNXB.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnViTri_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (loai == "2")
            {
                MessageBox.Show("Truy cập không được phép", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            Form frm = kiemtraForm(typeof(fViTri));
            if (frm == null)
            {
                fVT = new fViTri();
                fVT.MdiParent = this;
                fVT.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnTheLoai_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (loai == "2")
            {
                MessageBox.Show("Truy cập không được phép", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            Form frm = kiemtraForm(typeof(fTheLoai));
            if (frm == null)
            {
                fTL = new fTheLoai();
                fTL.MdiParent = this;
                fTL.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnChucVu_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (loai == "2" || loai == "3")
            {
                MessageBox.Show("Truy cập không được phép", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            Form frm = kiemtraForm(typeof(fChucVu));
            if (frm == null)
            {
                fCV = new fChucVu();
                fCV.MdiParent = this;
                fCV.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnMuonTaiLieu_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (loai == "3")
            {
                MessageBox.Show("Truy cập không được phép", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            Form frm = kiemtraForm(typeof(fMuonTaiLieu));
            if (frm == null)
            {
                fMTL = new fMuonTaiLieu(maNV);
                fMTL.MdiParent = this;
                fMTL.Show();
            }
            else
            {
                frm.Close();
                fMTL = new fMuonTaiLieu();
                fMTL.MdiParent = this;
                fMTL.Show();
            }
        }

        private void btnSV_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = kiemtraForm(typeof(fDanhSachSV));
            if (frm == null)
            {
                fDSSV = new fDanhSachSV();
                fDSSV.MdiParent = this;
                fDSSV.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnDSMuon_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = kiemtraForm(typeof(fDSMuon));
            if (frm == null)
            {
                fDSM = new fDSMuon();
                fDSM.MdiParent = this;
                fDSM.Show();
            }
            else
            {
                frm.Close();
                fDSM = new fDSMuon();
                fDSM.MdiParent = this;
                fDSM.Show();
            }
        }

        private void btnTraTaiLieu_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (loai == "3")
            {
                MessageBox.Show("Truy cập không được phép", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            Form frm = kiemtraForm(typeof(fTraTaiLieu));
            if (frm == null)
            {
                fTTL = new fTraTaiLieu(maNV);
                fTTL.MdiParent = this;
                fTTL.Show();
            }
            else
            {
                frm.Close();
                fTTL = new fTraTaiLieu(maNV);
                fTTL.MdiParent = this;
                fTTL.Show();
            }
        }

        private void btnDSPhat_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (loai == "3")
            {
                MessageBox.Show("Truy cập không được phép", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            Form frm = kiemtraForm(typeof(fDSPhat));
            if (frm == null)
            {
                fDSP = new fDSPhat();
                fDSP.MdiParent = this;
                fDSP.Show();
            }
            else
            {
                frm.Close();
                fDSP = new fDSPhat();
                fDSP.MdiParent = this;
                fDSP.Show();
            }
        }

        TaiKhoanBLL taikhoan = new TaiKhoanBLL();

        private void fMain_Load(object sender, EventArgs e)
        {
            //this.tenDN = this.Tag.ToString();
            //loai = taikhoan.getLoai(tenDN);
            //maNV = taikhoan.getMaNV(tenDN);
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = kiemtraForm(typeof(fThongKeDoanhThu));
            if (frm == null)
            {
                fTKDT = new fThongKeDoanhThu();
                fTKDT.MdiParent = this;
                fTKDT.Show();
            }
            else
            {
                frm.Close();
                fTKDT = new fThongKeDoanhThu();
                fTKDT.MdiParent = this;
                fTKDT.Show();
            }
        }

        private void btnSetting_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (loai == "3")
            {
                MessageBox.Show("Truy cập không được phép", "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnDatOnline_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = kiemtraForm(typeof(fDSDatOnline));
            if (frm == null)
            {
                fDSDONL = new fDSDatOnline(maNV);
                fDSDONL.MdiParent = this;
                fDSDONL.Show();
            }
            else
            {
                frm.Close();
                fDSDONL = new fDSDatOnline(maNV);
                fDSDONL.MdiParent = this;
                fDSDONL.Show();
            }
        }

        private void btnDatHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = kiemtraForm(typeof(fDatHang));
            if (frm == null)
            {
                fDH = new fDatHang(maNV);
                fDH.MdiParent = this;
                fDH.Show();
            }
            else
            {
                frm.Close();
                fDH = new fDatHang(maNV);
                fDH.MdiParent = this;
                fDH.Show();
            }
        }

        private void btnNhapHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = kiemtraForm(typeof(fNhapHang));
            if (frm == null)
            {
                fNH = new fNhapHang();
                fNH.MdiParent = this;
                fNH.Show();
            }
            else
            {
                frm.Close();
                fNH = new fNhapHang();
                fNH.MdiParent = this;
                fNH.Show();
            }
        }


    }
}