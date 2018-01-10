using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContractKeeper
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            AddAlarmColumn();
        }

        private void AddAlarmColumn()
        {

            DataGridViewImageColumn icoColumn = new DataGridViewImageColumn();
            icoColumn.Name = "Alarm";
            icoColumn.HeaderText = "Оповещение";
            icoColumn.Icon = Properties.Resources.Custom_Icon_Design_Pretty_Office_8_Flag_green;// Properties.Resources.flag1rightgreen2_6776;
            dataGVContracts.Columns.Add(icoColumn);

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contractKeeperDataSet.Contracts' table. You can move, or remove it, as needed.
            this.contractsTableAdapter.Fill(this.contractKeeperDataSet.Contracts);
        }
    }
}
