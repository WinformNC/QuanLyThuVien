using DAL.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhanVienDAL
    {
        NHANVIEN_CVTableAdapter adapter = new NHANVIEN_CVTableAdapter();
        NHANVIENTableAdapter adapterNV = new NHANVIENTableAdapter();
        TAIKHOANTableAdapter adapterTK = new TAIKHOANTableAdapter();

        public NhanVienDAL() { }

        public DataTable loadNhanVien()
        {
            return adapter.GetData();
        }

        public bool checkPrimary(string ma)
        {
            if (adapterNV.CheckPrimary_ScalarQuery(ma) != null)
                return true;
            return false;
        }

        public int Insert(string ma, string cv, string username, string ten, string ns, string cmnd, string dc, string dt, string email)
        {
            adapterTK.InsertQuery(email, dt, "NV");
            return adapterNV.InsertQuery(ma, cv, username, ten, DateTime.Parse(ns), cmnd, dc, dt, email);
        }

        public int Update(string ma, string cv, string ten, string ns, string cmnd, string dc, string dt, string email)
        {
            return adapterNV.UpdateQuery(cv, ten, DateTime.Parse(ns), cmnd, dc, dt, email, ma);
        }
    }
}
