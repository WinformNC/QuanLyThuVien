using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class DSMuonBLL
    {
        DSMuonDAL dsMuon = new DSMuonDAL();

        public DSMuonBLL() { }

        public DataTable LoadDSMuon()
        {
            return dsMuon.loadDSMuon();
        }
    }
}
