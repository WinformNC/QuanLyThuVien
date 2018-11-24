using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    public class CreatePrimaryKey
    {
        QUANLYTHUVIENDataContext1 linq = new QUANLYTHUVIENDataContext1();

        public string createKeyMuonSach()
        {
            PHIEUMUONTRA pm = new PHIEUMUONTRA();
            foreach (PHIEUMUONTRA pmt in linq.PHIEUMUONTRAs)
                pm = pmt;
            if (pm.MAPHIEUMUON != null)
                return createAuto3(pm.MAPHIEUMUON);
            else
                return "PM001";
        }

        public string createKeyDatHang()
        {
            DONDATHANG ddh = new DONDATHANG();
            foreach (DONDATHANG dh in linq.DONDATHANGs)
                ddh = dh;
            if (ddh.MADDH != null)
                return createAuto2(ddh.MADDH);
            else
                return "DDH01";
        }

        public string createKeySach()
        {
            SACH s = new SACH();
            foreach (SACH sh in linq.SACHES)
                s = sh;
            if (s.MASACH != null)
                return createAuto3(s.MASACH);
            else
                return "SA001";
        }
        private string createAuto3(string mas)
        {
            string ma = mas.Substring(0, 2);
            int stt = int.Parse(mas.Substring(3));
            stt++;
            return ma + stt.ToString().PadLeft(3, '0');

        }

        private string createAuto2(string mas)
        {
            string ma = mas.Substring(0, 3);
            int stt = int.Parse(mas.Substring(3));
            stt++;
            return ma + stt.ToString().PadLeft(2, '0');

        }
    }
}
