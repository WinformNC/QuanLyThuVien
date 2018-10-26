using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class TacGiaBLL
    {
        TacGiaDAL tacgiaDAL = new TacGiaDAL();

        public TacGiaBLL() { }

        public DataTable LoadTacGia()
        {
            return tacgiaDAL.loadTacGia();
        }

        public int Insert(string ma, string ten, string dt, string dc)
        {
            return tacgiaDAL.Insert(ma, ten, dt, dc);
        }

        public int Update(string ma, string ten, string dt, string dc)
        {
            return tacgiaDAL.Update(ma, ten, dt, dc);
        }

        public int Delete(string ma)
        {
            return tacgiaDAL.Delete(ma);
        }
    }
}
