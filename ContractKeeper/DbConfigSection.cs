using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ContractKeeper
{
    public class DbConnect : ConfigurationSection
    {
        [ConfigurationProperty("ConnectionString", DefaultValue = false, IsRequired = false)]
        public string ConnectionString
        {
            get
            {
                object o = this["ConnectionString"];
                return o as string;
            }
        }

    }

    public class DbConfigInstanceCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new DbConfigInstanceElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            //set to whatever Element Property you want to use for a key
            return ((DbConfigInstanceElement)element).ConnectionString;
        }
    }

    public class DbConfigInstanceElement : ConfigurationElement
    {
        //Make sure to set IsKey=true for property exposed as the GetElementKey above
        [ConfigurationProperty("connectionstring", IsKey = true, IsRequired = true)]
        public string ConnectionString
        {
            get { return (string)this["connectionstring"]; }
            set { this["connectionstring"] = value; }
        }

    }
}

