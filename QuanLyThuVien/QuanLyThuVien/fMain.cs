using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

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

        public fMain()
        {
            InitializeComponent();
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
            Form frm = kiemtraForm(typeof(fDSTaiLieu));
            if (frm == null)
            {
                fDSTL = new fDSTaiLieu();
                fDSTL.MdiParent = this;
                fDSTL.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnDSNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
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
            Form frm = kiemtraForm(typeof(fMuonTaiLieu));
            if (frm == null)
            {
                fMTL = new fMuonTaiLieu();
                fMTL.MdiParent = this;
                fMTL.Show();
            }
            else
            {
                frm.Activate();
            }
        }
    }
}