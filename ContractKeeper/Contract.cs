using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractKeeper
{
   public class Contract : BaseEntity
    {
        public string Name { get; set; }
        public string DateStart { get; set; }
        public string DateEnd { get; set; }
        public string Details { get; set; }

        Contract()
        {

        }

        public Contract(string name, string dateStart, string dateEnd)
        {
            Name = name;
            DateStart = dateStart;
            DateEnd = dateEnd;

        }

        public Contract(string name, string dateStart, string dateEnd, string details) : this(name, dateStart, dateEnd)
        {
            Details = details;
        }
    }
}
