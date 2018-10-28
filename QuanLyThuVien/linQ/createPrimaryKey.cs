using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linQ
{
   public class createPrimaryKey
    {
       DataTVDataContext linq = new DataTVDataContext();
       public string createKeyMuonSach()
       {
           PHIEUMUONTRA pm = new PHIEUMUONTRA();
           foreach (PHIEUMUONTRA pmt in linq.PHIEUMUONTRAs)
               pm = pmt;
          if (pm.MAPHIEUMUON != null)
              return createAuto(pm.MAPHIEUMUON);
          else
              return "PM001";
       }
       public string createKeyPhat()
       {
           PHAT ph = new PHAT();
           foreach (PHAT pha in linq.PHATs)
               ph = pha;
           if (ph.MAPHAT != null)
               return createAuto(ph.MAPHAT);
           else
               return "PH001";
       }
       public string createKeySach()
       {
           SACH s = new SACH();
           foreach (SACH sh in linq.SACHes)
               s = sh;
           if (s.MASACH != null)
               return createAuto(s.MASACH);
           else
               return "SA001";
       }
       private string createAuto(string mas)
       {
          string ma = mas.Substring(0, 2);
          int stt = int.Parse(mas.Substring(3));
          stt++;
          if (stt < 10)
              return ma + stt.ToString().PadLeft(3, '0');
          else if (stt < 100)
              return ma + stt.ToString().PadLeft(2, '0');
          else
              return ma + stt.ToString();
       }

    }
}
