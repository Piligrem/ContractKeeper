using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContractKeeper
{
    public partial class CreateDBForm : Form
    {
        public CreateDBForm()
        {
            InitializeComponent();
            cbServerName.DropDown += CbServerName_DropDown;
        }

        private void CbServerName_DropDown(object sender, EventArgs e)
        {
            if (cbServerName.Items.Count == 0)
                LoadServerList();
        }

        public void LoadServerList()
        {
            string myServer = Environment.MachineName;

            DataTable servers = SqlDataSourceEnumerator.Instance.GetDataSources();
            for (int i = 0; i < servers.Rows.Count; i++)
            {
                if (myServer == servers.Rows[i]["ServerName"].ToString()) ///// used to get the servers in the local machine////
                {
                    if ((servers.Rows[i]["InstanceName"] as string) != null)
                        cbServerName.Items.Add(servers.Rows[i]["ServerName"] + "\\" + servers.Rows[i]["InstanceName"]);
                    else
                        cbServerName.Items.Add(servers.Rows[i]["ServerName"]);
                }
            }
        }

        private void CreateDB_Load(object sender, EventArgs e)
        {

        }
    }
}
