using System;
using System.Data;
using System.Data.Sql;
using System.Windows.Forms;

namespace ContractKeeper
{
    public partial class CreateDBForm : Form
    {
        public string ConnectionString { get; set; }
        public CreateDBForm()
        {
            InitializeComponent();
            cbServerName.DropDown += CbServerName_DropDown;
            btnCreateBase.Click += btnCreateBase_Click;
            btnClose.Click += btnClose_Click;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateBase_Click(object sender, EventArgs e)
        {
            var dbManager        = new DatabaseSQL();
            dbManager.BaseName   = tbBaseName.Text;
            dbManager.ServerName = cbServerName.Text;

            var result = dbManager.CreateDatabase();
            if (result["result"].Equals("true"))
            {
                MessageBox.Show("Database Created Successfully", "Contract keeper",
                                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ConnectionString = "Data Source =" + cbServerName.Text + "\\SQLEXPRESS; Initial Catalog = " + tbBaseName.Text + "; Integrated Security = True";
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(result["ex"], "Contract keeper", MessageBoxButtons.OK,
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
