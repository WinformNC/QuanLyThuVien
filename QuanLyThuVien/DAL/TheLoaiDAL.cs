using DAL.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TheLoaiDAL
    {
        THELOAITableAdapter adapter = new THELOAITableAdapter();

        public TheLoaiDAL() { }

        public DataTable loadTheLoai()
        {
            return adapter.GetData();
        }

        public int Insert(string ma, string ten)
        {
            if (adapter.CheckPrimary_ScalarQuery(ma) != null)
            {
                return 2;
            }

            return adapter.InsertQuery(ma, ten);
        }

        public int Update(string ma, string ten)
        {
            return adapter.UpdateQuery(ten, ma);
        }

        public int Delete(string ma)
        {
            return adapter.DeleteQuery(ma);
        }
    }
}
