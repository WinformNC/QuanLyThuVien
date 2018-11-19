using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linQ_View
{
    public class View_Linq
    {
        QUANLYTHUVIENDataContext linq = new QUANLYTHUVIENDataContext();
        
        public List<SACHVIEW> loadSach()
        {
            return linq.SACHVIEWs.Select(t => t).ToList<SACHVIEW>();
        }

        public List<SACHVIEW> loadSach(string masach)
        {
            return linq.SACHVIEWs.Where(t => t.MASACH == masach).Select(t => t).ToList<SACHVIEW>();
        }

        public List<VIEWCT> loadViewCT()
        {
            return linq.VIEWCTs.Select(t => t).Where(t => t.TINHTRANG == "chưa trả").ToList<VIEWCT>();
        }
        public List<VIEWCT> loadViewCT(string maSV)
        {
            return linq.VIEWCTs.Where(t => t.MADG == maSV).Select(t => t).ToList<VIEWCT>();
        }

        public List<VIEWPHAT> loadPhat()
        {
            return linq.VIEWPHATs.Where(t => t.GHICHU == "0").Select(t => t).ToList<VIEWPHAT>();
        }

        public List<SACH> loadSach_NXB(string maNXB)
        {
            return linq.SACHES.Where(t => t.MANXB == maNXB).Select(t => t).ToList<SACH>();
        }

        public List<CHITIETDONDATHANG> loadChiTietDDHChuaNhap(string maNXB)
        {
            return linq.CHITIETDONDATHANGs.Where(t => t.DONDATHANG.MANXB == maNXB && t.GHICHU == "0").Select(t => t).ToList<CHITIETDONDATHANG>(); 
        }

        public int addDonDatHang(string ma, string nv, string nxb)
        {
            try
            {
                DONDATHANG ddh = new DONDATHANG();
                ddh.MADDH = ma;
                ddh.MANV = nv;
                ddh.MANXB = nxb;
                linq.DONDATHANGs.InsertOnSubmit(ddh);
                linq.SubmitChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int addCTDonHang(string ma, string maSach, int soluong, float dongia)
        {
            try
            {
                CHITIETDONDATHANG ct = new CHITIETDONDATHANG();
                ct.MADDH = ma;
                ct.MASACH = maSach;
                ct.SOLUONGNHAP = soluong;
                ct.DONGIANHAP = dongia;
                ct.GHICHU = "0";
                linq.CHITIETDONDATHANGs.InsertOnSubmit(ct);
                linq.SubmitChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int nhapSach(string maDDH, string maSach)
        {
            try
            {
                CHITIETDONDATHANG ct = linq.CHITIETDONDATHANGs.Where(t => t.MADDH == maDDH && t.MASACH == maSach).Select(t => t).FirstOrDefault();
                int soluong = ct.SOLUONGNHAP.Value;
                ct.GHICHU = "1";

                SACH sach = linq.SACHES.Where(t => t.MASACH == ct.MASACH).Select(t => t).FirstOrDefault();
                sach.SOLUONG += soluong;

                linq.SubmitChanges();

                return 1;
            }
            catch
            {
                return 0;
            }
        }
    }
}
