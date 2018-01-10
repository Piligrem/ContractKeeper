using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractKeeper
{
    public interface IDatabase
    {
        void CreateDB(string ServerName, string NameDb, string CatalogDb);

        void SaveToDatabase();
        void ReadFromDatabase();
    }
}
