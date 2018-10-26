using DAL.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NXBDAL
    {
        NHAXBTableAdapter adapter = new NHAXBTableAdapter();

        public NXBDAL() { }

        public DataTable loadNXB()
        {
            return adapter.GetData();
        }

        public int Insert(string ma, string ten, string dt, string dc)
        {
            if (adapter.CheckPrimary_ScalarQuery(ma) != null)
            {
                return 2;
            }

            return adapter.InsertQuery(ma, ten, dt, dc);
            
        }

        public int Update(string ma, string ten, string dt, string dc)
        {
            return adapter.UpdateQuery(ten, dt, dc, ma);
        }

        public int Delete(string ma)
        {
            return adapter.DeleteQuery(ma);
        }
    }
}
