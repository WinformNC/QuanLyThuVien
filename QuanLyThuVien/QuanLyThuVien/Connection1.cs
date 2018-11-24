using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using linQ;

namespace QuanLyThuVien
{
    public class Connection1
    {
        QUANLYTHUVIENDataContext1 linqToMySQL1 = new QUANLYTHUVIENDataContext1();

        Conection con = new Conection();

        public Connection1() { }

        #region Tác giả
        public List<TACGIA> loadTacGia()
        {
            return linqToMySQL1.TACGIAs.Select(t => t).ToList<TACGIA>();
        }

        public int addTacGia(string ma, string ten, string dt, string dc)
        {
            try
            {
                TACGIA s = new TACGIA();
                s.MATACGIA = ma;
                s.TENTACGIA = ten;
                s.DTTACGIA = dt;
                s.DCTACGIA = dc;
                linqToMySQL1.TACGIAs.InsertOnSubmit(s);
                linqToMySQL1.SubmitChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int upTacGia(string ma, string ten, string dt, string dc)
        {
            try
            {
                TACGIA s = linqToMySQL1.TACGIAs.Where(t => t.MATACGIA == ma).Select(t => t).FirstOrDefault();
                s.TENTACGIA = ten;
                s.DTTACGIA = dt;
                s.DCTACGIA = dc;
                linqToMySQL1.SubmitChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int delTacGia(string ma)
        {
            try
            {
                TACGIA s = linqToMySQL1.TACGIAs.Where(t => t.MATACGIA == ma).Select(t => t).FirstOrDefault();
                linqToMySQL1.TACGIAs.DeleteOnSubmit(s);
                linqToMySQL1.SubmitChanges();
                return 1;
            }
            catch { return 0; }
        }
        #endregion

        #region Vị trí
        public List<VITRI> loadViTri()
        {
            return linqToMySQL1.VITRIs.Select(t => t).ToList<VITRI>();
        }

        public int addViTri(string ma, string ten)
        {
            try
            {
                VITRI s = new VITRI();
                s.MAVT = ma;
                s.TENVITRI = ten;
                linqToMySQL1.VITRIs.InsertOnSubmit(s);
                linqToMySQL1.SubmitChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int upViTri(string ma, string ten)
        {
            try
            {
                VITRI s = linqToMySQL1.VITRIs.Where(t => t.MAVT == ma).Select(t => t).FirstOrDefault();
                s.TENVITRI = ten;
                linqToMySQL1.SubmitChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int delViTri(string ma)
        {
            try
            {
                VITRI s = linqToMySQL1.VITRIs.Where(t => t.MAVT == ma).Select(t => t).FirstOrDefault();
                linqToMySQL1.VITRIs.DeleteOnSubmit(s);
                linqToMySQL1.SubmitChanges();
                return 1;
            }
            catch { return 0; }
        }
        #endregion

        #region Thể loại
        public List<THELOAI> loadTheLoai()
        {
            return linqToMySQL1.THELOAIs.Select(t => t).ToList<THELOAI>();
        }

        public int addTheLoai(string ma, string ten)
        {
            try
            {
                THELOAI s = new THELOAI();
                s.MATHELOAI = ma;
                s.TENTHELOAI = ten;
                linqToMySQL1.THELOAIs.InsertOnSubmit(s);
                linqToMySQL1.SubmitChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int upTheLoai(string ma, string ten)
        {
            try
            {
                THELOAI s = linqToMySQL1.THELOAIs.Where(t => t.MATHELOAI == ma).Select(t => t).FirstOrDefault();
                s.TENTHELOAI = ten;
                linqToMySQL1.SubmitChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int delTheLoai(string ma)
        {
            try
            {
                THELOAI s = linqToMySQL1.THELOAIs.Where(t => t.MATHELOAI == ma).Select(t => t).FirstOrDefault();
                linqToMySQL1.THELOAIs.DeleteOnSubmit(s);
                linqToMySQL1.SubmitChanges();
                return 1;
            }
            catch { return 0; }
        }
        #endregion

        #region
        public List<NHAXB> loadNXB()
        {
            return linqToMySQL1.NHAXBs.Select(t => t).ToList<NHAXB>();
        }

        public int addNXB(string ma, string ten, string dt, string dc)
        {
            try
            {
                NHAXB s = new NHAXB();
                s.MANXB = ma;
                s.TENNXB = ten;
                s.DTNXB = dt;
                s.DCNXB = dc;
                linqToMySQL1.NHAXBs.InsertOnSubmit(s);
                linqToMySQL1.SubmitChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int upNXB(string ma, string ten, string dt, string dc)
        {
            try
            {
                NHAXB s = linqToMySQL1.NHAXBs.Where(t => t.MANXB == ma).Select(t => t).FirstOrDefault();
                s.TENNXB = ten;
                s.DTNXB = dt;
                s.DCNXB = dc;
                linqToMySQL1.SubmitChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int delNXB(string ma)
        {
            try
            {
                NHAXB s = linqToMySQL1.NHAXBs.Where(t => t.MANXB == ma).Select(t => t).FirstOrDefault();
                linqToMySQL1.NHAXBs.DeleteOnSubmit(s);
                linqToMySQL1.SubmitChanges();
                return 1;
            }
            catch { return 0; }
        }
        #endregion

        public List<DOCGIA> loadDocGia()
        {
            return linqToMySQL1.DOCGIAs.Select(t => t).ToList<DOCGIA>();
        }

        public List<DOCGIA> searchDocGia(string x)
        {
            return linqToMySQL1.DOCGIAs.Select(t => t).Where(t => t.TENDG.StartsWith(x) || t.TENDG.EndsWith(x) || t.MADG == x).ToList<DOCGIA>();
        }

        public List<PHIEUMUONTRA> loadMuonSach()
        {
            return linqToMySQL1.PHIEUMUONTRAs.Select(t => t).ToList<PHIEUMUONTRA>();
        }

        public void upTinhTrangMuon(string maphieumuon, string masach)
        {
            CTPHIEUMUONTRA ct = linqToMySQL1.CTPHIEUMUONTRAs.Where(t => t.MAPHIEUMUON == maphieumuon && t.MASACH == masach).FirstOrDefault();
            ct.TINHTRANG = "đã trả";
            linqToMySQL1.SubmitChanges();
        }

        public int addPhieuMuon(string maphieumuon, string manv, string masinhvien, int sosach, List<string> masach)
        {
            try
            {

                if (con.ktSVPhat(masinhvien))
                {
                    if (ktSVMuon(maphieumuon))
                    {
                        PHIEUMUONTRA ptm = new PHIEUMUONTRA();
                        ptm.MAPHIEUMUON = maphieumuon;
                        ptm.MANV = manv;
                        ptm.MADG = masinhvien;
                        DateTime ngaymuon = DateTime.Today;
                        ptm.NGAYMUON = ngaymuon;
                        ptm.PHICOC = 150000;

                        linqToMySQL1.PHIEUMUONTRAs.InsertOnSubmit(ptm);
                        foreach (string sach in masach)
                            addCTPhieuMuonTra(maphieumuon, sach);
                        linqToMySQL1.SubmitChanges();
                        return 1;
                    }
                    else
                        return 3;
                }
                else
                    return 2;

            }
            catch
            {
                return 0;
            }
        }

        private bool ktSVMuon(string maphieumuon)
        {
            List<CTPHIEUMUONTRA> ct = linqToMySQL1.CTPHIEUMUONTRAs.Where(t => t.MAPHIEUMUON == maphieumuon).Select(t => t).ToList<CTPHIEUMUONTRA>();
            foreach (CTPHIEUMUONTRA ctt in ct)
                if (ctt.TINHTRANG == "0")
                    return false;
            return true;
        }
        private void updateMuonSLSach(string masach)
        {
            SACH s = linqToMySQL1.SACHES.Where(t => t.MASACH == masach).Select(t => t).FirstOrDefault();
            s.SOLUONG -= 1;
            linqToMySQL1.SubmitChanges();
        }
        private void updateTraSLSach(string masach)
        {
            SACH s = linqToMySQL1.SACHES.Where(t => t.MASACH == masach).Select(t => t).FirstOrDefault();
            s.SOLUONG += 1;
            linqToMySQL1.SubmitChanges();
        }
        //Phieu muon tra
        public void addCTPhieuMuonTra(string maphieumuon, string masach)
        {
            CTPHIEUMUONTRA ct = new CTPHIEUMUONTRA();
            ct.MAPHIEUMUON = maphieumuon;
            ct.MASACH = masach;
            ct.NGAYDUKIENTRA = DateTime.Today.AddDays(10);
            updateMuonSLSach(masach);
            ct.TINHTRANG = "0";
            linqToMySQL1.CTPHIEUMUONTRAs.InsertOnSubmit(ct);
        }

        public int addCTPhieuTra(string maphieumuon, string masach, string loai)
        {
            try
            {
                CTPHIEUMUONTRA ct = new CTPHIEUMUONTRA();
                ct = linqToMySQL1.CTPHIEUMUONTRAs.Where(t => t.MAPHIEUMUON == maphieumuon && t.MASACH == masach).FirstOrDefault();
                ct.NGAYTRA = DateTime.Now.Date;
                ct.TINHTRANG = "1";
                if (loai != "DK002")
                {
                    updateTraSLSach(masach);
                }
                
                linqToMySQL1.SubmitChanges();
                if (loai.Trim().Length != 0)
                {
                    TimeSpan ngayquahan = ct.NGAYTRA.Value - ct.NGAYDUKIENTRA.Value;
                    con.addPhat(ct.PHIEUMUONTRA.MADG, ct.PHIEUMUONTRA.MANV, loai, ngayquahan.Days, ct.MASACH);
                }                
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public List<CTPHIEUMUONTRA> loadCTMuon_DocGia(string maDG)
        {
            return linqToMySQL1.CTPHIEUMUONTRAs.Where(t => t.PHIEUMUONTRA.MADG == maDG && t.TINHTRANG == "0").Select(t => t).ToList<CTPHIEUMUONTRA>();
        }

        public int giaHanSach(string maPhieuMuon, string maSach, int ngay)
        {
            try
            {
                CTPHIEUMUONTRA ct = linqToMySQL1.CTPHIEUMUONTRAs.Where(t => t.MAPHIEUMUON == maPhieuMuon && t.MASACH == maSach).Select(t => t).FirstOrDefault();
                DateTime dt = ct.NGAYDUKIENTRA.Value;
                dt = dt.AddDays(ngay);
                ct.NGAYDUKIENTRA = dt;
                linqToMySQL1.SubmitChanges();
                return 1;
            }
            catch
            {
                return -1;
            }
        }        
    }
}
