using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChucVuBLL
    {
        ChucVuDAL chucvuDAL = new ChucVuDAL();

        public ChucVuBLL() { }

        public DataTable LoadChucVu()
        {
            return chucvuDAL.loadChucVu();
        }

        public int Insert(string ma, string ten)
        {
            return chucvuDAL.Insert(ma, ten);
        }

        public int Update(string ma, string ten)
        {
            return chucvuDAL.Update(ma, ten);
        }

        public int Delete(string ma)
        {
            return chucvuDAL.Delete(ma);
        }
    }
}
