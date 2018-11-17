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
        CHUCVUTableAdapter adapterCV = new CHUCVUTableAdapter();

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
            string tencv = adapterCV.FindTenCV_ScalarQuery(cv);
            string loainv;
            if (tencv == "Thủ kho")
                loainv = "2";
            else
                loainv = "1";
            adapterTK.InsertQuery(email, dt, loainv);
            return adapterNV.InsertQuery(ma, cv, username, ten, DateTime.Parse(ns), cmnd, dc, dt, email);
        }

        public int Update(string ma, string cv, string ten, string ns, string cmnd, string dc, string dt, string email)
        {
            return adapterNV.UpdateQuery(cv, ten, DateTime.Parse(ns), cmnd, dc, dt, email, ma);
        }

        public string FindTenNV(string ma)
        {
            return adapterNV.FindTenNV_ScalarQuery(ma);
        }
    }
}
