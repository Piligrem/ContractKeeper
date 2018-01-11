using System;
using System.Data;
using System.Data.Sql;
using System.Windows.Forms;

namespace ContractKeeper
{
    public partial class CreateDBForm : Form
    {
        public CreateDBForm()
        {
            InitializeComponent();
            cbServerName.DropDown += CbServerName_DropDown;
            btnCreateBase.Click += btnCreateBase_Click;
        }

        private void btnCreateBase_Click(object sender, EventArgs e)
        {
            IDbManagement dbManager = new DbManagementSQL();
            var result = dbManager.CreateDatabase(cbServerName.Text, tbBaseName.Text);
            if (result["result"].Equals("true"))
            {
                MessageBox.Show("Database Created Successfully", "Contract keeper",
                                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(result["ex"], "MyApp", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            }
               
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
