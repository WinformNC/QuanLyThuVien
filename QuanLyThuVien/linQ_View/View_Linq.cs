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
    }
}
