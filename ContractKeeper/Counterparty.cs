using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractKeeper
{
    public class Counterparty
    {
        public string Name { get; set; }
        public OwnershipType OwnerType { get; set; }

    }

    public enum OwnershipType
    {
        LLC = 1, //ТОО
        CORP, //АО
        IBC, //Международная коммерческая компания
        Ie //Индивидуальный предприниматель
    }
}
