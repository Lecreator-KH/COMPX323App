using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;


namespace COMPX323Milestone2

{
    class Oracle
    {
        
        public static string oradb = "Data Source=oracle.cms.waikato.ac.nz:1521/teaching;User Id=tk229;Password=;";
        public static  OracleConnection conn = new OracleConnection(oradb);  // C#
        
        public static void selectQuery(string query)
        {
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();
                //label1.Text = dr.GetString(0);
                conn.Dispose();
            }
            catch
            {
                return;
            }
        }
    }
}
