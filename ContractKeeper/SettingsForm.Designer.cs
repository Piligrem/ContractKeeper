namespace ContractKeeper
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.tbConnectionString = new System.Windows.Forms.TextBox();
            this.SetConnectionString = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCreateDB = new System.Windows.Forms.Button();
            this.rbConnect = new System.Windows.Forms.RadioButton();
            this.rbConnect2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // tbConnectionString
            // 
            this.tbConnectionString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbConnectionString.Location = new System.Drawing.Point(13, 87);
            this.tbConnectionString.Name = "tbConnectionString";
            this.tbConnectionString.Size = new System.Drawing.Size(259, 20);
            this.tbConnectionString.TabIndex = 0;
            // 
            // SetConnectionString
            // 
            this.SetConnectionString.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SetConnectionString.Location = new System.Drawing.Point(278, 84);
            this.SetConnectionString.Name = "SetConnectionString";
            this.SetConnectionString.Size = new System.Drawing.Size(27, 23);
            this.SetConnectionString.TabIndex = 1;
            this.SetConnectionString.Text = "...";
            this.SetConnectionString.UseVisualStyleBackColor = true;
            this.SetConnectionString.Click += new System.EventHandler(this.SetConnectionString_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(161, 113);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(69, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(236, 113);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(69, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // btnCreateDB
            // 
            this.btnCreateDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateDB.Location = new System.Drawing.Point(141, 33);
            this.btnCreateDB.Name = "btnCreateDB";
            this.btnCreateDB.Size = new System.Drawing.Size(164, 23);
            this.btnCreateDB.TabIndex = 4;
            this.btnCreateDB.Text = "Создать базу данных";
            this.btnCreateDB.UseVisualStyleBackColor = true;
            // 
            // rbConnect
            // 
            this.rbConnect.AccessibleName = "";
            this.rbConnect.AutoSize = true;
            this.rbConnect.Location = new System.Drawing.Point(13, 13);
            this.rbConnect.Name = "rbConnect";
            this.rbConnect.Size = new System.Drawing.Size(133, 17);
            this.rbConnect.TabIndex = 5;
            this.rbConnect.TabStop = true;
            this.rbConnect.Text = "Создать базу данных";
            this.rbConnect.UseVisualStyleBackColor = true;
            // 
            // rbConnect2
            // 
            this.rbConnect2.AccessibleName = "";
            this.rbConnect2.AutoSize = true;
            this.rbConnect2.Location = new System.Drawing.Point(13, 61);
            this.rbConnect2.Name = "rbConnect2";
            this.rbConnect2.Size = new System.Drawing.Size(153, 17);
            this.rbConnect2.TabIndex = 6;
            this.rbConnect2.TabStop = true;
            this.rbConnect2.Text = "Подключить базу данных";
            this.rbConnect2.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 139);
            this.Controls.Add(this.rbConnect2);
            this.Controls.Add(this.rbConnect);
            this.Controls.Add(this.btnCreateDB);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.SetConnectionString);
            this.Controls.Add(this.tbConnectionString);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.Shown += new System.EventHandler(this.Settings_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbConnectionString;
        private System.Windows.Forms.Button SetConnectionString;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCreateDB;
        private System.Windows.Forms.RadioButton rbConnect;
        private System.Windows.Forms.RadioButton rbConnect2;
    }
}