using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linQ
{
    public class Conection
    {
        string datra =  "Đã trả ",chuatra =  "Chưa trả";
        DataTVDataContext linq = new DataTVDataContext();
        createPrimaryKey pk = new createPrimaryKey();
        public Conection()
        { }
        public List<TACGIA> loadTacGia()
        {
            return linq.TACGIAs.Select(t => t).ToList<TACGIA>();
        }
        public List<VITRI> loadViTri()
        {
            return linq.VITRIs.Select(t => t).ToList<VITRI>();
        }
        public List<THELOAI> loadTheLoai()
        {
            return linq.THELOAIs.Select(t => t).ToList<THELOAI>();
        }
        public List<sachView> loadSach()
        {
            return linq.sachViews.Select(t => t).ToList<sachView>();
        }
        public List<sachView> loadSach(string masach)
        {
            return linq.sachViews.Where(t=>t.MASACH == masach).Select(t => t).ToList<sachView>();
        }
        public List<NHAXB> loadNXB()
        {
            return linq.NHAXBs.Select(t => t).ToList<NHAXB>();
        }

        public int saveSach()
        {
            try
            {
                linq.SubmitChanges();
                return 1;
            }
            catch {
                return 0;
            }
        } 
        public int addSach(string masach,string manxb,string matheloai,string matacgia,string mavitri,string tensach,string namxb,string hinhanhsach,string mota,string soluong,string gia)
        {
            try
            {
                SACH s = new SACH();
                s.MASACH = masach;
                s.MANXB = manxb;
                s.MATHELOAI = matheloai;
                s.MATACGIA = matacgia;
                s.MAVITRI = mavitri;
                s.TENSACH = tensach;
                s.NAMXB = int.Parse(namxb);
                s.HINHANHSACH = hinhanhsach;
                s.MOTA = mota;
                s.SOLUONG = int.Parse(soluong);
                s.Gia = float.Parse(gia);
                linq.SACHes.InsertOnSubmit(s);
                
                return 1;
            }
            catch {
                return 0;
            }
        }
        public int delSach(string masach)
        {
            try
            {
                SACH s = linq.SACHes.Where(t => t.MASACH == masach).Select(t => t).FirstOrDefault();
                linq.SACHes.DeleteOnSubmit(s);
                linq.SubmitChanges();
                return 1;
            }
            catch { return 0; }
        }
        public int upSach(string masach, string manxb, string matheloai, string matacgia, string mavitri, string tensach, string namxb, string hinhanhsach, string mota, string soluong,string gia)
        {
            try
            {

                SACH s = linq.SACHes.Where(t => t.MASACH == masach).Select(t => t).FirstOrDefault();
                s.MANXB = manxb;
                s.MATHELOAI = matheloai;
                s.MATACGIA = matacgia;
                s.MAVITRI = mavitri;
                s.TENSACH = tensach;
                s.NAMXB = int.Parse(namxb);
                s.HINHANHSACH = hinhanhsach;
                s.MOTA = mota;
                s.SOLUONG = int.Parse(soluong);
                s.Gia = float.Parse(gia);
                
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public List<PHIEUMUONTRA> loadMuonSach()
        {
            return linq.PHIEUMUONTRAs.Select(t => t).ToList<PHIEUMUONTRA>();
        }


        public List<SINHVIEN> loadSinhVien()
        {
            return linq.SINHVIENs.Select(t => t).ToList<SINHVIEN>();
        }

        public int addPhieuMuon(string maphieumuon,string manv,string masinhvien,int sosach,List<string> masach)
        {
            try
            {
                if (ktSVPhat(masinhvien))
                {
                    if (ktSVMuon(masinhvien))
                    {
                        PHIEUMUONTRA ptm = new PHIEUMUONTRA();
                        ptm.MAPHIEUMUON = maphieumuon;
                        ptm.MANV = manv;
                        ptm.MASINHVIEN = masinhvien;
                        DateTime ngaymuon = DateTime.Today;
                        ptm.NGAYMUON = ngaymuon;
                        ptm.NGAYDUKIENTRA = ngaymuon.AddDays(10);
                        ptm.PHICOC = 150000;
                        ptm.PHIMUON = 20000;

                        linq.PHIEUMUONTRAs.InsertOnSubmit(ptm);
                        foreach (string sach in masach)
                            addCTPhieuMuonTra(maphieumuon, sach);
                        linq.SubmitChanges();
                        return 1;
                    }
                    else
                        return 3;
                }
                else 
                    return 2;
                
            }
            catch {
                return 0;
            }
        }
        private void updateMuonSLSach(string masach)
        {
            SACH s = linq.SACHes.Where(t => t.MASACH == masach).Select(t => t).FirstOrDefault();
            s.SOLUONG -= 1;
            linq.SubmitChanges();
        }
        private void updateTraSLSach(string masach)
        {
            SACH s = linq.SACHes.Where(t => t.MASACH == masach).Select(t => t).FirstOrDefault();
            s.SOLUONG += 1;
            linq.SubmitChanges();
        }
        //Phieu muon tra
        public void addCTPhieuMuonTra(string maphieumuon, string masach)
        {
            CHITIETMUONTRA ct = new CHITIETMUONTRA();
            ct.MAPHIEUMUON = maphieumuon;
            ct.MASACH = masach;
            updateMuonSLSach(masach);
            ct.TINHTRANG = chuatra;
            linq.CHITIETMUONTRAs.InsertOnSubmit(ct);
            
        }

        public int addCTPhieuTra(string maphieumuon,string masach,string masinhvien,DateTime ngaytra,float sotienphat,string lydo,string tinhtrang)
        {
            if (tinhtrang !=  datra)
            {
                try
                {
                    CHITIETMUONTRA ct = new CHITIETMUONTRA();
                    ct = linq.CHITIETMUONTRAs.Where(t => t.MAPHIEUMUON == maphieumuon && t.MASACH == masach).FirstOrDefault();
                    ct.NGAYTRA = ngaytra;
                    ct.TINHTRANG = datra;
                    updateTraSLSach(masach);
                    linq.SubmitChanges();
                    if (sotienphat > 1)
                        addPhat(masinhvien, sotienphat, lydo);
                    return 1;
                }
                catch
                {
                    return 0;
                }
            }
            else
                return 2;
        }
        public void addPhat(string masinhvien,float sotienphat , string lydo )
        {
            PHAT ph = new PHAT();
            ph.MAPHAT = pk.createKeyPhat();
            ph.MASINHVIEN = masinhvien;
            ph.SOTIENPHAT = sotienphat;
            ph.LYDO = lydo;
            ph.TINHTRANG = chuatra;
            linq.PHATs.InsertOnSubmit(ph);
            linq.SubmitChanges();
        }
        public int delPhat(string maphat)
        {
            try
            {
                PHAT ph = linq.PHATs.Where(t => t.MAPHAT == maphat).FirstOrDefault();
                ph.TINHTRANG = datra;
                linq.SubmitChanges();
                return 1;
            }
            catch { return 0; }
        }


        public List<PHAT> loadPhat()
        {
            return linq.PHATs.Select(t => t).ToList<PHAT>();
        }
        public List<ViewCT> loadViewCT()
        {
            return linq.ViewCTs.Select(t => t).ToList<ViewCT>();
        }
        public List<ViewCT> loadViewCT(string maSV)
        {
            return linq.ViewCTs.Where(t => t.MASINHVIEN == maSV).Select(t => t).ToList<ViewCT>();
        }

        //XuLy
        public double tienphat(DateTime ngaydukien,DateTime ngaytra)
        {
            double day = (ngaytra - ngaydukien).TotalDays;
            day = (double) Math.Round((decimal)day);
            if (day < 1)
                return 0;
            else
            {
                return day * 1000;
            }
        }

        private bool ktSVMuon(string masv)
        {
            List<ViewCT> ct = linq.ViewCTs.Where(t => t.MASINHVIEN == masv).Select(t => t).ToList<ViewCT>();
            foreach (ViewCT ctt in ct)
                if (ctt.TINHTRANG == chuatra)
                    return false;
            return true;
        }
        private bool ktSVPhat(string masv)
        {
            if (linq.PHATs.Where(t => t.MASINHVIEN == masv).Select(t => t).FirstOrDefault() != null)
                return false;
            return true;
        }
    }
}
