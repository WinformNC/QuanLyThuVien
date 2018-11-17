using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linQ
{
    public class Conection
    {
        QUANLYTHUVIENDataContext linqToMySQL = new QUANLYTHUVIENDataContext();

        public List<TAIKHOAN> loadTK()
        {
            return linqToMySQL.TAIKHOANs.Select(t => t).ToList<TAIKHOAN>();
        }

        #region Chức vụ
        public List<CHUCVU> loadChucVu()
        {
            return linqToMySQL.CHUCVUs.Select(t => t).ToList<CHUCVU>();
        }

        public int addChucVu(string macv, string tencv)
        {
            try
            {
                CHUCVU s = new CHUCVU();
                s.MACHUCVU = macv;
                s.TENCHUCVU = tencv;
                linqToMySQL.CHUCVUs.InsertOnSubmit(s);
                linqToMySQL.SubmitChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int upChucVu(string macv, string tencv)
        {
            try
            {
                CHUCVU s = linqToMySQL.CHUCVUs.Where(t => t.MACHUCVU == macv).Select(t => t).FirstOrDefault();
                s.TENCHUCVU = tencv;
                linqToMySQL.SubmitChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int delChucVu(string macv)
        {
            try
            {
                CHUCVU s = linqToMySQL.CHUCVUs.Where(t => t.MACHUCVU == macv).Select(t => t).FirstOrDefault();
                linqToMySQL.CHUCVUs.DeleteOnSubmit(s);
                linqToMySQL.SubmitChanges();
                return 1;
            }
            catch { return 0; }
        }
        #endregion

        #region Nhân viên
        public List<NHANVIEN> loadNV()
        {
            return linqToMySQL.NHANVIENs.Select(t => t).ToList<NHANVIEN>();
        }

        private bool checkMaNV(string ma)
        {
            NHANVIEN nv = linqToMySQL.NHANVIENs.Where(t => t.MANV == ma).Select(t => t).FirstOrDefault();
            if (nv != null)
                return true;
            return false;
        }

        private bool checkEmail(string email)
        {
            NHANVIEN nv = linqToMySQL.NHANVIENs.Where(t => t.EMAIL == email).Select(t => t).FirstOrDefault();
            if (nv != null)
                return true;
            return false;
        }

        public int addNV(string ma, string ten, string cv, DateTime ns, string cmnd, string dc, string dt, string email)
        {
            try
            {
                bool checkNV = checkMaNV(ma);
                if (checkNV)
                    return 2;
                bool checkMail = checkEmail(email);
                if (checkMail)
                    return 3;

                NHANVIEN nv = new NHANVIEN();
                nv.MANV = ma;
                nv.TENNV = ten;
                nv.MACHUCVU = cv;
                nv.NGAYSINH = ns;
                nv.SOCMND = cmnd;
                nv.DIACHITHUONGTRU = dc;
                nv.SODT = dt;
                nv.EMAIL = email;
                nv.TAIKHOAN = email;
                addTK(email, dt);
                linqToMySQL.NHANVIENs.InsertOnSubmit(nv);
                linqToMySQL.SubmitChanges();
                return 1;
            }
            catch
            {
                return -1;
            }
        }

        public int addTK(string email, string sdt)
        {
            try
            {
                TAIKHOAN tk = new TAIKHOAN();
                tk.TAIKHOAN1 = email;
                tk.MATKHAU = sdt;
                tk.MALOAITK = "LTK01";
                linqToMySQL.TAIKHOANs.InsertOnSubmit(tk);
                linqToMySQL.SubmitChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        private bool checkEmailUpdate(string ma, string email)
        {
            NHANVIEN nv = linqToMySQL.NHANVIENs.Where(t => t.MANV != ma && t.EMAIL == email).Select(t => t).FirstOrDefault();
            if (nv != null)
                return true;
            return false;
        }

        public int upNV(string ma, string ten, string cv, DateTime ns, string cmnd, string dc, string dt, string email)
        {
            try
            {
                bool checkMail = checkEmailUpdate(ma, email);
                if (checkMail)
                {
                    return 0;
                }
                NHANVIEN nv = linqToMySQL.NHANVIENs.Where(t => t.MANV == ma).Select(t => t).FirstOrDefault();
                string mail = nv.EMAIL;

                nv.TENNV = ten;
                nv.MACHUCVU = cv;
                nv.NGAYSINH = ns;
                nv.SOCMND = cmnd;
                nv.DIACHITHUONGTRU = dc;
                nv.SODT = dt;
                nv.EMAIL = email;
                linqToMySQL.SubmitChanges();
                return 1;
            }
            catch
            {
                return -1;
            }
        }

        public int upTK(string email, string email2)
        {
            try
            {
                TAIKHOAN tk = linqToMySQL.TAIKHOANs.Where(t => t.TAIKHOAN1 == email).Select(t => t).FirstOrDefault();
                tk.TAIKHOAN1 = email2;
                linqToMySQL.SubmitChanges();
                return 1;
            }
            catch
            {
                return -1;
            }
        }
        #endregion


        string datra =  "Đã trả ",chuatra =  "Chưa trả";
        createPrimaryKey pk = new createPrimaryKey();
        public Conection()
        { }

        #region Sách
        public int saveSach()
        {
            try
            {
                linqToMySQL.SubmitChanges();
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
                s.MAVT = mavitri;
                s.TENSACH = tensach;
                s.NAMXB = int.Parse(namxb);
                s.HINHANHSACH = hinhanhsach;
                s.MOTA = mota;
                s.SOLUONG = int.Parse(soluong);
                s.GIA = float.Parse(gia);
                linqToMySQL.SACHES.InsertOnSubmit(s);
                
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
                SACH s = linqToMySQL.SACHES.Where(t => t.MASACH == masach).Select(t => t).FirstOrDefault();
                linqToMySQL.SACHES.DeleteOnSubmit(s);
                linqToMySQL.SubmitChanges();
                return 1;
            }
            catch { return 0; }
        }
        
        public int upSach(string masach, string manxb, string matheloai, string matacgia, string mavitri, string tensach, string namxb, string hinhanhsach, string mota, string soluong,string gia)
        {
            try
            {

                SACH s = linqToMySQL.SACHES.Where(t => t.MASACH == masach).Select(t => t).FirstOrDefault();
                s.MANXB = manxb;
                s.MATHELOAI = matheloai;
                s.MATACGIA = matacgia;
                s.MAVT = mavitri;
                s.TENSACH = tensach;
                s.NAMXB = int.Parse(namxb);
                s.HINHANHSACH = hinhanhsach;
                s.MOTA = mota;
                s.SOLUONG = int.Parse(soluong);
                s.GIA = float.Parse(gia);
                linqToMySQL.SubmitChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        #endregion

        public List<DOCGIA> loadSinhVien()
        {
            return linqToMySQL.DOCGIAs.Select(t => t).ToList<DOCGIA>();
        }


        public void addPhat(string masinhvien, string manv, string loai, int ngayquahan, string masach)
        {
            PHAT ph = new PHAT();
            string key = pk.createKeyPhat();
            ph.MAPHAT = key;
            ph.MADG = masinhvien;
            ph.MANV = manv;
            linqToMySQL.PHATs.InsertOnSubmit(ph);
            linqToMySQL.SubmitChanges();
            addCTPhat(key, loai, masach, ngayquahan);
        }

        public void addCTPhat(string maphat, string loai, string masach, int ngayquahan)
        {
            CHITIETPHAT ct = new CHITIETPHAT();
            ct.MAPHAT = maphat;
            ct.MALOAIVIPHAM = loai;
            ct.GHICHU = "0";
            DIEUKHOANVIPHAM dk = linqToMySQL.DIEUKHOANVIPHAMs.Where(t => t.MADIEUKHOAN == loai).Select(t => t).FirstOrDefault();
            if (dk.MADIEUKHOAN == "DK001")
            {
                ct.TIENPHAT = dk.SOTIENPHAT * ngayquahan;
            }
            else
            {
                SACH s = linqToMySQL.SACHES.Where(t => t.MASACH == masach).Select(t => t).FirstOrDefault();
                ct.TIENPHAT = dk.SOTIENPHAT / 100 * s.GIA;
            }
            linqToMySQL.CHITIETPHATs.InsertOnSubmit(ct);
            linqToMySQL.SubmitChanges();
        }

        public int delPhat(string maphat)
        {
            try
            {
                CHITIETPHAT ph = linqToMySQL.CHITIETPHATs.Where(t => t.MAPHAT == maphat).FirstOrDefault();
                ph.GHICHU = "1";
                linqToMySQL.SubmitChanges();
                return 1;
            }
            catch { return 0; }
        }

        public List<CHITIETPHAT> loadPhat()
        {
            return linqToMySQL.CHITIETPHATs.Where(t => t.GHICHU == "0").Select(t => t).ToList<CHITIETPHAT>();
        }

        ////XuLy
        //public double tienphat(DateTime ngaydukien,DateTime ngaytra)
        //{
        //    double day = (ngaytra - ngaydukien).TotalDays;
        //    day = (double) Math.Round((decimal)day);
        //    if (day < 1)
        //        return 0;
        //    else
        //    {
        //        return day * 1000;
        //    }
        //}

        public bool ktSVPhat(string masv)
        {
            List<PHAT> phat = linqToMySQL.PHATs.Where(t => t.MADG == masv).Select(t => t).ToList<PHAT>();
            foreach(PHAT item in phat)
            {
                CHITIETPHAT ct = linqToMySQL.CHITIETPHATs.Where(t => t.MAPHAT == item.MAPHAT).Select(t => t).FirstOrDefault();
                if (ct != null && ct.GHICHU == "0")
                {
                    return false;
                }
            }
            return true;
        }

        public string findNV(string username)
        {
            return linqToMySQL.NHANVIENs.Where(t => t.TAIKHOAN == username).Select(t => t.MANV).FirstOrDefault();
        }

        public int ktDangNhap(string username, string pass)
        {
            TAIKHOAN obj = linqToMySQL.TAIKHOANs.Where(t => t.TAIKHOAN1.Trim() == username && t.MATKHAU.Trim() == pass).Select(t => t).FirstOrDefault();
            if (obj != null)
            {
                LOAITAIKHOAN loai = linqToMySQL.LOAITAIKHOANs.Where(t => t.MALOAITK == obj.MALOAITK).Select(t => t).FirstOrDefault();
                if (loai.TENLOAI.Trim() == "2")
                {
                    return 0;
                }
                NHANVIEN nv = linqToMySQL.NHANVIENs.Where(t => t.TAIKHOAN == obj.TAIKHOAN1).Select(t => t).FirstOrDefault();
                CHUCVU cv = linqToMySQL.CHUCVUs.Where(t => t.MACHUCVU == nv.MACHUCVU).Select(t => t).FirstOrDefault();
                if (cv.TENCHUCVU.Trim() == "quản lý")
                {
                    return 1;
                }
                else
                {
                    return 2;
                }

            }
            return -1;  
        }

        public List<DATONLINE> loadDatOnline_DocGia(string maDG)
        {
            return linqToMySQL.DATONLINEs.Where(t => t.MADG == maDG).Select(t => t).ToList<DATONLINE>();
        }

        public int delDatOnline(string maDG, string maSach)
        {
            DATONLINE item = linqToMySQL.DATONLINEs.Where(t => t.MADG == maDG && t.MASACH == maSach).Select(t => t).FirstOrDefault();
            linqToMySQL.DATONLINEs.DeleteOnSubmit(item);
            linqToMySQL.SubmitChanges();
            return 1;
        }
    }
}
