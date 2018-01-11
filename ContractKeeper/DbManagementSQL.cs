using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ContractKeeper
{
    public class DbManagementSQL : IDbManagement
    {
        public Dictionary<string,string> CreateDatabase(string ServerName, string BaseName)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            String str;
            SqlConnection myConn = new SqlConnection
                ("Server=" + ServerName + ";Integrated security=SSPI ;database=master");
            str = "CREATE DATABASE " + BaseName + "";
            SqlCommand myCommand = new SqlCommand(str, myConn);
            try
            {
                myConn.Open();
                myCommand.ExecuteNonQuery();

                result.Add("result", "true");
                return result;
            }
            catch (System.Exception ex)
            {
                result.Add("result", "false");
                result.Add("ex", ex.Message);
                return result;
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }
        }
    }
}
