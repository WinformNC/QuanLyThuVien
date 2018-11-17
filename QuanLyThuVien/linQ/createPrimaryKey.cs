using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linQ
{
   public class createPrimaryKey
    {
       QUANLYTHUVIENDataContext linq = new QUANLYTHUVIENDataContext();

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
       
       private string createAuto(string mas)
       {
           string ma = mas.Substring(0, 2);
           int stt = int.Parse(mas.Substring(3));
           stt++;
           return ma + stt.ToString().PadLeft(3, '0');

       }

    }
}
