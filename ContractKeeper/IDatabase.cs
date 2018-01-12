using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractKeeper
{
    public interface IDatabase
    {
        Dictionary<string, string> CreateDatabase();

        void SaveToDatabase();
        void ReadFromDatabase();
    }
}
