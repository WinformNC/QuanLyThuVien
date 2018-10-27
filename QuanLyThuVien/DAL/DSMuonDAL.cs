using DAL.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DSMuonDAL
    {
        DSMUONTableAdapter adapter = new DSMUONTableAdapter();

        public DSMuonDAL() { }

        public DataTable loadDSMuon()
        {
            return adapter.GetData();
        }
    }
}
