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
            this.tb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lServerName = new System.Windows.Forms.Label();
            this.lDbName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lDataSource = new System.Windows.Forms.Label();
            this.btnGetDataSource = new System.Windows.Forms.Button();
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
            this.cbServerName.Location = new System.Drawing.Point(110, 45);
            this.cbServerName.Name = "cbServerName";
            this.cbServerName.Size = new System.Drawing.Size(247, 21);
            this.cbServerName.TabIndex = 1;
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(110, 72);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(247, 20);
            this.tb.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 21);
            this.button1.TabIndex = 3;
            this.button1.Text = "Создать базу данных";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lServerName
            // 
            this.lServerName.AutoSize = true;
            this.lServerName.Location = new System.Drawing.Point(6, 45);
            this.lServerName.Name = "lServerName";
            this.lServerName.Size = new System.Drawing.Size(74, 13);
            this.lServerName.TabIndex = 4;
            this.lServerName.Text = "Имя сервера";
            // 
            // lDbName
            // 
            this.lDbName.AutoSize = true;
            this.lDbName.Location = new System.Drawing.Point(6, 72);
            this.lDbName.Name = "lDbName";
            this.lDbName.Size = new System.Drawing.Size(61, 13);
            this.lDbName.TabIndex = 5;
            this.lDbName.Text = "Имя базы:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 20);
            this.textBox1.TabIndex = 6;
            // 
            // lDataSource
            // 
            this.lDataSource.AutoSize = true;
            this.lDataSource.Location = new System.Drawing.Point(6, 19);
            this.lDataSource.Name = "lDataSource";
            this.lDataSource.Size = new System.Drawing.Size(98, 13);
            this.lDataSource.TabIndex = 7;
            this.lDataSource.Text = "Источник данных:";
            // 
            // btnGetDataSource
            // 
            this.btnGetDataSource.Location = new System.Drawing.Point(330, 19);
            this.btnGetDataSource.Name = "btnGetDataSource";
            this.btnGetDataSource.Size = new System.Drawing.Size(26, 20);
            this.btnGetDataSource.TabIndex = 8;
            this.btnGetDataSource.Text = "...";
            this.btnGetDataSource.UseVisualStyleBackColor = true;
            // 
            // CreateDBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 126);
            this.Controls.Add(this.btnGetDataSource);
            this.Controls.Add(this.lDataSource);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lDbName);
            this.Controls.Add(this.lServerName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb);
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
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lServerName;
        private System.Windows.Forms.Label lDbName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lDataSource;
        private System.Windows.Forms.Button btnGetDataSource;
    }
}