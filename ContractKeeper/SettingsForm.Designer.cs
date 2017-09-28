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
            this.DbConnectionString = new System.Windows.Forms.TextBox();
            this.SetConnectionString = new System.Windows.Forms.Button();
            this.butSave = new System.Windows.Forms.Button();
            this.butClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DbConnectionString
            // 
            this.DbConnectionString.Location = new System.Drawing.Point(12, 15);
            this.DbConnectionString.Name = "DbConnectionString";
            this.DbConnectionString.Size = new System.Drawing.Size(260, 20);
            this.DbConnectionString.TabIndex = 0;
            // 
            // SetConnectionString
            // 
            this.SetConnectionString.Location = new System.Drawing.Point(278, 12);
            this.SetConnectionString.Name = "SetConnectionString";
            this.SetConnectionString.Size = new System.Drawing.Size(27, 23);
            this.SetConnectionString.TabIndex = 1;
            this.SetConnectionString.Text = "...";
            this.SetConnectionString.UseVisualStyleBackColor = true;
            this.SetConnectionString.Click += new System.EventHandler(this.SetConnectionString_Click);
            // 
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(161, 41);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(69, 23);
            this.butSave.TabIndex = 2;
            this.butSave.Text = "Сохранить";
            this.butSave.UseVisualStyleBackColor = true;
            // 
            // butClose
            // 
            this.butClose.Location = new System.Drawing.Point(236, 41);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(69, 23);
            this.butClose.TabIndex = 3;
            this.butClose.Text = "Закрыть";
            this.butClose.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 71);
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.SetConnectionString);
            this.Controls.Add(this.DbConnectionString);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "Настройки";
            this.Shown += new System.EventHandler(this.Settings_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DbConnectionString;
        private System.Windows.Forms.Button SetConnectionString;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Button butClose;
    }
}