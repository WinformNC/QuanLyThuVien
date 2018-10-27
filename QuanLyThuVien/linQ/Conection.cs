using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linQ
{
    public class Conection
    {
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
        public int addSach(string masach,string manxb,string matheloai,string matacgia,string mavitri,string tensach,string namxb,string hinhanhsach,string mota,string soluong)
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
                return 1;
            }
            catch { return 0; }
        }
        public int upSach(string masach, string manxb, string matheloai, string matacgia, string mavitri, string tensach, string namxb, string hinhanhsach, string mota, string soluong)
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
                addCTPhieuMuonTra(maphieumuon, masach);
                linq.SubmitChanges();
                return 1;

            }
            catch {
                return 0;
            }
        }

        //Phieu muon tra
        public void addCTPhieuMuonTra(string maphieumuon, List<string> masach)
        {
            for (int i = 0; i < masach.Count; i++)
            {
                CHITIETMUONTRA ct = new CHITIETMUONTRA();
                ct.MAPHIEUMUON = maphieumuon;
                ct.MASACH = masach[i];
                linq.CHITIETMUONTRAs.InsertOnSubmit(ct);
            }
            
            
        }


        public List<PMCT> loadPMCT()
        {
            return linq.PMCTs.Select(t => t).ToList<PMCT>();
        }
        public List<PMCT> loadPMCT(string maSV)
        {
            return linq.PMCTs.Where(t => t.MASINHVIEN == maSV).Select(t => t).ToList<PMCT>();
        }
    }
}
