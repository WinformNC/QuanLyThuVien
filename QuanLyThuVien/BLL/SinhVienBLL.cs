using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SinhVienBLL
    {
        SinhVienDAL sinhvien = new SinhVienDAL();

        public SinhVienBLL() { }

        public DataTable LoadSinhVien()
        {
            return sinhvien.loadSinhVien();
        }

        public DataTable LoadMaSinhVien()
        {
            return sinhvien.loadMaSinhVien();
        }
    }
}
