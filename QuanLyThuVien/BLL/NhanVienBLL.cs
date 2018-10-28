using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhanVienBLL
    {
        NhanVienDAL nhanvienDAL = new NhanVienDAL();

        public NhanVienBLL() { }

        public DataTable LoadNhanVien()
        {
            return nhanvienDAL.loadNhanVien();
        }

        public bool CheckPrimary(string ma)
        {
            return nhanvienDAL.checkPrimary(ma);
        }

        public int Insert(string ma, string cv, string username, string ten, string ns, string cmnd, string dc, string dt, string email)
        {
            return nhanvienDAL.Insert(ma, cv, username, ten, ns, cmnd, dc, dt, email);
        }

        public int Update(string ma, string cv, string ten, string ns, string cmnd, string dc, string dt, string email)
        {
            return nhanvienDAL.Update(ma, cv, ten, ns, cmnd, dc, dt, email);
        }

        public string FindTenNV(string ma)
        {
            return nhanvienDAL.FindTenNV(ma);
        }
    }
}
