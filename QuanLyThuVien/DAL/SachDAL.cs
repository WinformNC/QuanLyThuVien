using DAL.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SachDAL
    {
        SACHTableAdapter adapter = new SACHTableAdapter();

        public SachDAL() { }


        public int Insert(string ma, string ten, string nxb, string namxb, string tacgia, string theloai, string vitri, string mota)
        {
            return 1;
        }
    }
}
