using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Windows.Forms;
using Microsoft.Data.ConnectionUI;


namespace ContractKeeper
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            rbConnect.Click += RbConnect_Click;
            rbConnect2.Click += RbConnect2_Click;
            btnCreateDB.Click += BtnCreateDB_Click;
        }

        private void BtnCreateDB_Click(object sender, EventArgs e)
        {
            CreateDBForm createDBForm = new CreateDBForm();
            createDBForm.ShowDialog();
        }

        private void RbConnect2_Click(object sender, EventArgs e)
        {
            ActivateChooseBD();
        }

        private void RbConnect_Click(object sender, EventArgs e)
        {
            ActivateCreateBD();
        }

        private void Settings_Shown(object sender, EventArgs e)
        {
            DbConnectionString.Text = ContractContext.GetConnectionString();
        }

        private void SetConnectionString_Click(object sender, EventArgs e)
        {
            DbConnectionString.Text = GetConnectionString();
        }

        private string GetConnectionString()
        {
            string connectionString = null;
            DataConnectionDialog dcd = new DataConnectionDialog();
            DataConnectionConfiguration dcs = new DataConnectionConfiguration(null);
            dcs.LoadConfiguration(dcd);
            if (DataConnectionDialog.Show(dcd) == DialogResult.OK)
                connectionString = dcd.ConnectionString;
            dcs.SaveConfiguration(dcd);
            return connectionString;
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            if (connectionStringsSection == null)
            {

            }
            connectionStringsSection.ConnectionStrings["DbConnect"].ConnectionString = DbConnectionString.Text;
            config.Save();
            ConfigurationManager.RefreshSection("connectionStrings");
            Close();
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void ActivateCreateBD()
        {
            btnCreateDB.Enabled = true;

            btnSave.Enabled = false;
            DbConnectionString.Enabled = false;
            SetConnectionString.Enabled = false;
        }

        private void ActivateChooseBD()
        {
            btnCreateDB.Enabled = false;

            btnSave.Enabled = true;
            DbConnectionString.Enabled = true;
            SetConnectionString.Enabled = true;
        }
        private void SettingsForm_Load(object sender, EventArgs e)
        {
            rbConnect.Checked = true;
            if (rbConnect.Checked)
            {
                ActivateCreateBD();
            }
            else
            {
                ActivateChooseBD();
             }
        }
    }
}
