using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class SachBLL
    {
        SachDAL sachDAL = new SachDAL();

        public SachBLL() { }

        public DataTable LoadSach()
        {
            return sachDAL.loadSach();
        }
    }
}
