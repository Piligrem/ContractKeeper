using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractKeeper
{
   public class Contract : BaseEntity
    {
        /// <summary>
        /// Номер договора
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// Название договора
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Дата контракта
        /// </summary>
        public string Date { get; set; }
        /// <summary>
        /// Дата начала выполнения
        /// </summary>
        public string DateStart { get; set; }
        /// <summary>
        /// Дата окончания выполнения
        /// </summary>
        public string DateEnd { get; set; }

        /// <summary>
        /// Описание деталей договора
        /// </summary>
        public string Details { get; set; }

        private Contract()
        {

        }

        public Contract(string name, string number, string dateStart, string dateEnd)
        {
            Name = name;
            Number = number;
            DateStart = dateStart;
            DateEnd = dateEnd;

        }

        public Contract(string name, string number, string dateStart, string dateEnd, string details) 
                : this(name, number, dateStart, dateEnd)
        {
            Details = details;
        }
    }
}
