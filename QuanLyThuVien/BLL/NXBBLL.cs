using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class NXBBLL
    {
        NXBDAL nxbDAL = new NXBDAL();

        public NXBBLL() { }

        public DataTable LoadNXB()
        {
            return nxbDAL.loadNXB();
        }

        public int Insert(string ma, string ten, string dt, string dc)
        {
            return nxbDAL.Insert(ma, ten, dt, dc);
        }

        public int Update(string ma, string ten, string dt, string dc)
        {
            return nxbDAL.Update(ma, ten, dt, dc);
        }

        public int Delete(string ma)
        {
            return nxbDAL.Delete(ma);
        }
    }
}
