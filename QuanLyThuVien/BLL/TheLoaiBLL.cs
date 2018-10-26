using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TheLoaiBLL
    {
        TheLoaiDAL theloaiDAL = new TheLoaiDAL();

        public TheLoaiBLL() { }

        public DataTable LoadTheLoai()
        {
            return theloaiDAL.loadTheLoai();
        }

        public int Insert(string ma, string ten)
        {
            return theloaiDAL.Insert(ma, ten);
        }

        public int Update(string ma, string ten)
        {
            return theloaiDAL.Update(ma, ten);
        }

        public int Delete(string ma)
        {
            return theloaiDAL.Delete(ma);
        }
    }
}
