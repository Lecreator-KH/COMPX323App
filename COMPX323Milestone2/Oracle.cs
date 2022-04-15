using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace COMPX323Milestone2
{
    class Oracle
    {
        string oradb = "Data Source=ORCL;User Id=hr;Password=hr;";
        OracleConnection conn = new OracleConnection(oradb);  // C#
        conn.Open();
    }
}
