using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ViTriBLL
    {
        ViTriDAL vitriDAL = new ViTriDAL();

        public ViTriBLL() { }

        public DataTable LoadViTri()
        {
            return vitriDAL.loadViTri();
        }

        public int Insert(string ma, string ten)
        {
            return vitriDAL.Insert(ma, ten);
        }

        public int Update(string ma, string ten)
        {
            return vitriDAL.Update(ma, ten);
        }

        public int Delete(string ma)
        {
            return vitriDAL.Delete(ma);
        }
    }
}
