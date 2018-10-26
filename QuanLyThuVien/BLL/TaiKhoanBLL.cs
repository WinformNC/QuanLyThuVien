using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TaiKhoanBLL
    {
        TaiKhoanDAL taikhoanDAL = new TaiKhoanDAL();

        public TaiKhoanBLL() { }

        public bool CheckPrimary(string username)
        {
            return taikhoanDAL.checkPrimary(username);
        }

        public int Insert(string username, string pass, string loai)
        {
            return taikhoanDAL.Insert(username, pass, loai);
        }
    }
}
