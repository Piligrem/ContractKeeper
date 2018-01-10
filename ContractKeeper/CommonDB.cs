using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ContractKeeper
{
    public class DatabaseSQL : IDatabase
    {
        public string ServerName { get; set; }

        public string NameDb { get; set; }

        public string CatalogDB { get; set; }

        public void SaveToDatabase()
        {
          
        }
        public void ReadFromDatabase()
        {
     
        }

        public void CreateDB(string ServerName, string NameDb, string CatalogDb)
        {
            throw new NotImplementedException();
        }
    }
}
