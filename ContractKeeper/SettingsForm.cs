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
        }

        private void Settings_Shown(object sender, EventArgs e)
        {
            DbConnectionString.Text =  ConfigurationManager.ConnectionStrings["DbConnect"].ConnectionString;
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
    }
}
