namespace RythmicQuebecInventory
{
    partial class Form12BackupDatabese
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
            this.labelBackupDB = new System.Windows.Forms.Label();
            this.cboBackupOpt = new System.Windows.Forms.ComboBox();
            this.labelDesc = new System.Windows.Forms.Label();
            this.labelLogOut = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonQRCodeCreateSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelBackupDB
            // 
            this.labelBackupDB.AutoSize = true;
            this.labelBackupDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBackupDB.ForeColor = System.Drawing.Color.Silver;
            this.labelBackupDB.Location = new System.Drawing.Point(165, 40);
            this.labelBackupDB.Name = "labelBackupDB";
            this.labelBackupDB.Size = new System.Drawing.Size(317, 22);
            this.labelBackupDB.TabIndex = 1;
            this.labelBackupDB.Text = "SAUVEGARDE DE L\'INVENTAIRE";
            // 
            // cboBackupOpt
            // 
            this.cboBackupOpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBackupOpt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboBackupOpt.FormattingEnabled = true;
            this.cboBackupOpt.Items.AddRange(new object[] {
            ".SQL",
            ".CSV"});
            this.cboBackupOpt.Location = new System.Drawing.Point(169, 150);
            this.cboBackupOpt.Name = "cboBackupOpt";
            this.cboBackupOpt.Size = new System.Drawing.Size(415, 37);
            this.cboBackupOpt.TabIndex = 2;
            this.cboBackupOpt.Text = "Sélectionnez l\'option de sauvegarde";
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.BackColor = System.Drawing.Color.Black;
            this.labelDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesc.ForeColor = System.Drawing.Color.Silver;
            this.labelDesc.Location = new System.Drawing.Point(167, 270);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(454, 44);
            this.labelDesc.TabIndex = 17;
            this.labelDesc.Text = "Après avoir sélectionné l\'option de sauvegarde, \r\ncliquez sur le bouton CRÉER ET " +
    "ENREGISTRER.";
            // 
            // labelLogOut
            // 
            this.labelLogOut.AutoSize = true;
            this.labelLogOut.BackColor = System.Drawing.Color.Black;
            this.labelLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogOut.ForeColor = System.Drawing.Color.Silver;
            this.labelLogOut.Location = new System.Drawing.Point(961, 38);
            this.labelLogOut.Name = "labelLogOut";
            this.labelLogOut.Size = new System.Drawing.Size(182, 25);
            this.labelLogOut.TabIndex = 16;
            this.labelLogOut.Text = "DÉCONNECTER ";
            this.labelLogOut.Click += new System.EventHandler(this.labelLogOut_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.Gray;
            this.buttonCancel.Location = new System.Drawing.Point(1060, 601);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(133, 30);
            this.buttonCancel.TabIndex = 19;
            this.buttonCancel.Text = "ANNULER";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonQRCodeCreateSave
            // 
            this.buttonQRCodeCreateSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQRCodeCreateSave.ForeColor = System.Drawing.Color.Gray;
            this.buttonQRCodeCreateSave.Location = new System.Drawing.Point(171, 339);
            this.buttonQRCodeCreateSave.Name = "buttonQRCodeCreateSave";
            this.buttonQRCodeCreateSave.Size = new System.Drawing.Size(260, 60);
            this.buttonQRCodeCreateSave.TabIndex = 18;
            this.buttonQRCodeCreateSave.Text = "CRÉER ET ENREGISTRER";
            this.buttonQRCodeCreateSave.UseVisualStyleBackColor = true;
            // 
            // Form12BackupDatabese
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonQRCodeCreateSave);
            this.Controls.Add(this.labelDesc);
            this.Controls.Add(this.labelLogOut);
            this.Controls.Add(this.cboBackupOpt);
            this.Controls.Add(this.labelBackupDB);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form12BackupDatabese";
            this.Text = "SAUVEGARDE DE L\'INVENTAIRE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelBackupDB;
        private System.Windows.Forms.ComboBox cboBackupOpt;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Label labelLogOut;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonQRCodeCreateSave;
    }
}