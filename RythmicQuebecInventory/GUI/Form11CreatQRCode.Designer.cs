namespace RythmicQuebecInventory
{
    partial class Form11CreatQRCode
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
            this.labelCreateQRCode = new System.Windows.Forms.Label();
            this.cboSelectBoxes = new System.Windows.Forms.ComboBox();
            this.labelLogOut = new System.Windows.Forms.Label();
            this.labelDesc = new System.Windows.Forms.Label();
            this.buttonQRCodeCreateSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCreateQRCode
            // 
            this.labelCreateQRCode.AutoSize = true;
            this.labelCreateQRCode.BackColor = System.Drawing.Color.Black;
            this.labelCreateQRCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateQRCode.ForeColor = System.Drawing.Color.Silver;
            this.labelCreateQRCode.Location = new System.Drawing.Point(165, 33);
            this.labelCreateQRCode.Name = "labelCreateQRCode";
            this.labelCreateQRCode.Size = new System.Drawing.Size(384, 22);
            this.labelCreateQRCode.TabIndex = 1;
            this.labelCreateQRCode.Text = "CRÉER UN QR-CODE POUR UNE BOÎTE";
            // 
            // cboSelectBoxes
            // 
            this.cboSelectBoxes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSelectBoxes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboSelectBoxes.FormattingEnabled = true;
            this.cboSelectBoxes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboSelectBoxes.Items.AddRange(new object[] {
            "Box1",
            "Box2",
            "Box3",
            "Box4",
            "Box5",
            "Box6"});
            this.cboSelectBoxes.Location = new System.Drawing.Point(169, 150);
            this.cboSelectBoxes.Name = "cboSelectBoxes";
            this.cboSelectBoxes.Size = new System.Drawing.Size(261, 37);
            this.cboSelectBoxes.TabIndex = 2;
            this.cboSelectBoxes.Text = "Sélectionnez la boîte";
            // 
            // labelLogOut
            // 
            this.labelLogOut.AutoSize = true;
            this.labelLogOut.BackColor = System.Drawing.Color.Black;
            this.labelLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogOut.ForeColor = System.Drawing.Color.Silver;
            this.labelLogOut.Location = new System.Drawing.Point(1010, 30);
            this.labelLogOut.Name = "labelLogOut";
            this.labelLogOut.Size = new System.Drawing.Size(182, 25);
            this.labelLogOut.TabIndex = 0;
            this.labelLogOut.Text = "DÉCONNECTER ";
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.BackColor = System.Drawing.Color.Black;
            this.labelDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesc.ForeColor = System.Drawing.Color.Silver;
            this.labelDesc.Location = new System.Drawing.Point(168, 262);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(935, 55);
            this.labelDesc.TabIndex = 3;
            this.labelDesc.Text = "Après avoir sélectionné la boîte, cliquez sur le bouton CRÉER ET ENREGISTRER \r\naf" +
    "in que le fichier de sauvegarde soit créé et enregistré dans un dossier local.";
            // 
            // buttonQRCodeCreateSave
            // 
            this.buttonQRCodeCreateSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQRCodeCreateSave.Location = new System.Drawing.Point(170, 334);
            this.buttonQRCodeCreateSave.Name = "buttonQRCodeCreateSave";
            this.buttonQRCodeCreateSave.Size = new System.Drawing.Size(260, 60);
            this.buttonQRCodeCreateSave.TabIndex = 4;
            this.buttonQRCodeCreateSave.Text = "CRÉER ET ENREGISTRER";
            this.buttonQRCodeCreateSave.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(1059, 596);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(133, 30);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "ANNULER";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // Form11CreatQRCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonQRCodeCreateSave);
            this.Controls.Add(this.labelDesc);
            this.Controls.Add(this.cboSelectBoxes);
            this.Controls.Add(this.labelCreateQRCode);
            this.Controls.Add(this.labelLogOut);
            this.ForeColor = System.Drawing.Color.Gray;
            this.Name = "Form11CreatQRCode";
            this.Text = "CRÉER UN QR-CODE";
            this.Load += new System.EventHandler(this.creatQRCode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCreateQRCode;
        private System.Windows.Forms.ComboBox cboSelectBoxes;
        private System.Windows.Forms.Label labelLogOut;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Button buttonQRCodeCreateSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}