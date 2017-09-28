using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractKeeper
{
    public class Person : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public Person()
        {

        }
        public Person (string name, string phone)
        {
            Name = name;
            Phone = phone;
            Email = "";
            Address = "";
        }

        public Person(string name, string phone, string email) : this(name, phone)
        {
            Email = email;
        }

        public Person(string name, string phone, string email, string address) : this(name, phone, email)
        {
            Address = address;
        }

        public override string ToString()
        {
            StringBuilder Data = new StringBuilder();
            Data.AppendLine("Name: " +  this.Name);
            Data.AppendLine("Email: " + this.Email);
            Data.AppendLine("Phone: " + this.Phone);
            Data.AppendLine("Address: " + this.Address);
            return Data.ToString(); 
        }
    }
    
}
