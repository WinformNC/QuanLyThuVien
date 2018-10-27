using DAL.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SinhVienDAL
    {
        SINHVIEN_KHOATableAdapter adapter = new SINHVIEN_KHOATableAdapter();
        SINHVIENTableAdapter adapterSV = new SINHVIENTableAdapter();


        public SinhVienDAL() { }

        public DataTable loadSinhVien()
        {
            return adapter.GetData();
        }

        public DataTable loadMaSinhVien()
        {
            return adapter.GetData();
        }

        public string FindTenSV(string ma)
        {
            return adapterSV.FindTenSV_ScalarQuery(ma).ToString();
        }
    }
}
