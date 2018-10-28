using DAL.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TaiKhoanDAL
    {
        TAIKHOANTableAdapter adapter = new TAIKHOANTableAdapter();
        NV_TKTableAdapter adapter1 = new NV_TKTableAdapter();

        public TaiKhoanDAL() { }

        public bool checkPrimary(string username)
        {
            if (adapter.CheckPrimary_ScalarQuery(username) != null)
                return true;
            return false;
        }

        public int Insert(string username, string pass, string loai)
        {
            return adapter.InsertQuery(username, pass, loai);
        }

        public string getLoai(string username)
        {
            return adapter.FindLoaiNV_ScalarQuery(username);
        }

        public string getMaNV(string tenDN)
        {
            return adapter1.FindMaNV_ScalarQuery(tenDN).ToString();
        }
    }
}
