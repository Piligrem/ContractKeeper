namespace ContractKeeper
{
    partial class CreateDBForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contractKeeperDataSet = new ContractKeeper.ContractKeeperDataSet();
            this.contractKeeperDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbServerName = new System.Windows.Forms.ComboBox();
            this.tbBaseName = new System.Windows.Forms.TextBox();
            this.btnCreateBase = new System.Windows.Forms.Button();
            this.lServerName = new System.Windows.Forms.Label();
            this.lDbName = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.contractKeeperDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractKeeperDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // contractKeeperDataSet
            // 
            this.contractKeeperDataSet.DataSetName = "ContractKeeperDataSet";
            this.contractKeeperDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contractKeeperDataSetBindingSource
            // 
            this.contractKeeperDataSetBindingSource.DataSource = this.contractKeeperDataSet;
            this.contractKeeperDataSetBindingSource.Position = 0;
            // 
            // cbServerName
            // 
            this.cbServerName.FormattingEnabled = true;
            this.cbServerName.Location = new System.Drawing.Point(110, 7);
            this.cbServerName.Name = "cbServerName";
            this.cbServerName.Size = new System.Drawing.Size(247, 21);
            this.cbServerName.TabIndex = 1;
            // 
            // tbBaseName
            // 
            this.tbBaseName.Location = new System.Drawing.Point(110, 34);
            this.tbBaseName.Name = "tbBaseName";
            this.tbBaseName.Size = new System.Drawing.Size(247, 20);
            this.tbBaseName.TabIndex = 2;
            // 
            // btnCreateBase
            // 
            this.btnCreateBase.Location = new System.Drawing.Point(133, 60);
            this.btnCreateBase.Name = "btnCreateBase";
            this.btnCreateBase.Size = new System.Drawing.Size(149, 21);
            this.btnCreateBase.TabIndex = 3;
            this.btnCreateBase.Text = "Создать базу данных";
            this.btnCreateBase.UseVisualStyleBackColor = true;
            // 
            // lServerName
            // 
            this.lServerName.AutoSize = true;
            this.lServerName.Location = new System.Drawing.Point(6, 7);
            this.lServerName.Name = "lServerName";
            this.lServerName.Size = new System.Drawing.Size(74, 13);
            this.lServerName.TabIndex = 4;
            this.lServerName.Text = "Имя сервера";
            // 
            // lDbName
            // 
            this.lDbName.AutoSize = true;
            this.lDbName.Location = new System.Drawing.Point(6, 34);
            this.lDbName.Name = "lDbName";
            this.lDbName.Size = new System.Drawing.Size(61, 13);
            this.lDbName.TabIndex = 5;
            this.lDbName.Text = "Имя базы:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(288, 60);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(68, 21);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // CreateDBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 87);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lDbName);
            this.Controls.Add(this.lServerName);
            this.Controls.Add(this.btnCreateBase);
            this.Controls.Add(this.tbBaseName);
            this.Controls.Add(this.cbServerName);
            this.Name = "CreateDBForm";
            this.Text = "Создание базы данных";
            this.Load += new System.EventHandler(this.CreateDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contractKeeperDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractKeeperDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private ContractKeeperDataSet contractKeeperDataSet;
        private System.Windows.Forms.BindingSource contractKeeperDataSetBindingSource;
        private System.Windows.Forms.ComboBox cbServerName;
        private System.Windows.Forms.TextBox tbBaseName;
        private System.Windows.Forms.Button btnCreateBase;
        private System.Windows.Forms.Label lServerName;
        private System.Windows.Forms.Label lDbName;
        private System.Windows.Forms.Button btnClose;
    }
}