namespace RythmicQuebecInventory.GUI
{
    partial class Form5AdminOptions
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
            this.labelLogOut = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAdminOptions = new System.Windows.Forms.Label();
            this.buttonAddNewItem = new System.Windows.Forms.Button();
            this.buttonModifDeleteItem = new System.Windows.Forms.Button();
            this.buttonModifCoaches = new System.Windows.Forms.Button();
            this.buttonModifyBoxes = new System.Windows.Forms.Button();
            this.buttonCreateQRCode = new System.Windows.Forms.Button();
            this.buttonBackupDB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLogOut
            // 
            this.labelLogOut.AutoSize = true;
            this.labelLogOut.BackColor = System.Drawing.Color.Black;
            this.labelLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogOut.ForeColor = System.Drawing.Color.Silver;
            this.labelLogOut.Location = new System.Drawing.Point(992, 29);
            this.labelLogOut.Name = "labelLogOut";
            this.labelLogOut.Size = new System.Drawing.Size(182, 25);
            this.labelLogOut.TabIndex = 18;
            this.labelLogOut.Text = "DÉCONNECTER ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(72, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 19;
            // 
            // labelAdminOptions
            // 
            this.labelAdminOptions.AutoSize = true;
            this.labelAdminOptions.BackColor = System.Drawing.Color.Black;
            this.labelAdminOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminOptions.ForeColor = System.Drawing.Color.Silver;
            this.labelAdminOptions.Location = new System.Drawing.Point(72, 29);
            this.labelAdminOptions.Name = "labelAdminOptions";
            this.labelAdminOptions.Size = new System.Drawing.Size(321, 25);
            this.labelAdminOptions.TabIndex = 20;
            this.labelAdminOptions.Text = "OPTIONS D\'ADMINISTRATION";
            // 
            // buttonAddNewItem
            // 
            this.buttonAddNewItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNewItem.ForeColor = System.Drawing.Color.Gray;
            this.buttonAddNewItem.Location = new System.Drawing.Point(77, 140);
            this.buttonAddNewItem.Name = "buttonAddNewItem";
            this.buttonAddNewItem.Size = new System.Drawing.Size(500, 41);
            this.buttonAddNewItem.TabIndex = 21;
            this.buttonAddNewItem.Text = "AJOUTER UN NOUVEL ARTICLE";
            this.buttonAddNewItem.UseVisualStyleBackColor = true;
            this.buttonAddNewItem.Click += new System.EventHandler(this.buttonAddNewItem_Click);
            // 
            // buttonModifDeleteItem
            // 
            this.buttonModifDeleteItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifDeleteItem.ForeColor = System.Drawing.Color.Gray;
            this.buttonModifDeleteItem.Location = new System.Drawing.Point(77, 187);
            this.buttonModifDeleteItem.Name = "buttonModifDeleteItem";
            this.buttonModifDeleteItem.Size = new System.Drawing.Size(500, 41);
            this.buttonModifDeleteItem.TabIndex = 22;
            this.buttonModifDeleteItem.Text = "MODIFIER / SUPPRIMER L\'ARTICLE";
            this.buttonModifDeleteItem.UseVisualStyleBackColor = true;
            this.buttonModifDeleteItem.Click += new System.EventHandler(this.buttonModifDeleteItem_Click);
            // 
            // buttonModifCoaches
            // 
            this.buttonModifCoaches.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifCoaches.ForeColor = System.Drawing.Color.Gray;
            this.buttonModifCoaches.Location = new System.Drawing.Point(77, 235);
            this.buttonModifCoaches.Name = "buttonModifCoaches";
            this.buttonModifCoaches.Size = new System.Drawing.Size(500, 41);
            this.buttonModifCoaches.TabIndex = 23;
            this.buttonModifCoaches.Text = "VOIR / MODIFIER / AJOUTER UN ENTRAÎNEUR";
            this.buttonModifCoaches.UseVisualStyleBackColor = true;
            this.buttonModifCoaches.Click += new System.EventHandler(this.buttonModifCoaches_Click);
            // 
            // buttonModifyBoxes
            // 
            this.buttonModifyBoxes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifyBoxes.ForeColor = System.Drawing.Color.Gray;
            this.buttonModifyBoxes.Location = new System.Drawing.Point(77, 282);
            this.buttonModifyBoxes.Name = "buttonModifyBoxes";
            this.buttonModifyBoxes.Size = new System.Drawing.Size(500, 41);
            this.buttonModifyBoxes.TabIndex = 24;
            this.buttonModifyBoxes.Text = "VOIR / MODIFIER LES BOÎTES";
            this.buttonModifyBoxes.UseVisualStyleBackColor = true;
            this.buttonModifyBoxes.Click += new System.EventHandler(this.buttonModifyBoxes_Click);
            // 
            // buttonCreateQRCode
            // 
            this.buttonCreateQRCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateQRCode.ForeColor = System.Drawing.Color.Gray;
            this.buttonCreateQRCode.Location = new System.Drawing.Point(77, 329);
            this.buttonCreateQRCode.Name = "buttonCreateQRCode";
            this.buttonCreateQRCode.Size = new System.Drawing.Size(500, 41);
            this.buttonCreateQRCode.TabIndex = 25;
            this.buttonCreateQRCode.Text = "CRÉER UN QR-CODE POUR UNE BOÎTE";
            this.buttonCreateQRCode.UseVisualStyleBackColor = true;
            this.buttonCreateQRCode.Click += new System.EventHandler(this.buttonCreateQRCode_Click);
            // 
            // buttonBackupDB
            // 
            this.buttonBackupDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackupDB.ForeColor = System.Drawing.Color.Gray;
            this.buttonBackupDB.Location = new System.Drawing.Point(77, 376);
            this.buttonBackupDB.Name = "buttonBackupDB";
            this.buttonBackupDB.Size = new System.Drawing.Size(500, 41);
            this.buttonBackupDB.TabIndex = 26;
            this.buttonBackupDB.Text = "SAUVEGARDE DE L\'INVENTAIRE";
            this.buttonBackupDB.UseVisualStyleBackColor = true;
            this.buttonBackupDB.Click += new System.EventHandler(this.buttonBackupDB_Click);
            // 
            // Form5AdminOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1265, 682);
            this.Controls.Add(this.buttonBackupDB);
            this.Controls.Add(this.buttonCreateQRCode);
            this.Controls.Add(this.buttonModifyBoxes);
            this.Controls.Add(this.buttonModifCoaches);
            this.Controls.Add(this.buttonModifDeleteItem);
            this.Controls.Add(this.buttonAddNewItem);
            this.Controls.Add(this.labelAdminOptions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelLogOut);
            this.Name = "Form5AdminOptions";
            this.Text = "OPTIONS D\'ADMINISTRATION";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAdminOptions;
        private System.Windows.Forms.Button buttonAddNewItem;
        private System.Windows.Forms.Button buttonModifDeleteItem;
        private System.Windows.Forms.Button buttonModifCoaches;
        private System.Windows.Forms.Button buttonModifyBoxes;
        private System.Windows.Forms.Button buttonCreateQRCode;
        private System.Windows.Forms.Button buttonBackupDB;
    }
}