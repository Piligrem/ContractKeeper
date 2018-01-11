using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractKeeper
{
    interface IDbManagement
    {
        Dictionary<string, string> CreateDatabase(string ServerName, string BaseName);
    }
}
