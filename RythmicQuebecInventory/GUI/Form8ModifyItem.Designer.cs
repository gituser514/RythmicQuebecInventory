namespace RythmicQuebecInventory
{
    partial class Form8ModifyItem
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
            this.labelModifyItem = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.groupBoxModifyItem = new System.Windows.Forms.GroupBox();
            this.textBoxDateTaken = new System.Windows.Forms.TextBox();
            this.textBoxDateReturned = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonSelectImage = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxModifyName = new System.Windows.Forms.TextBox();
            this.labelDateReturned = new System.Windows.Forms.Label();
            this.labelDateTaken = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.textBoxModifyQuantity = new System.Windows.Forms.TextBox();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.comboBoxBOXNO = new System.Windows.Forms.ComboBox();
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.comboBoxSelectCoach = new System.Windows.Forms.ComboBox();
            this.pictureBoxModifyItem = new System.Windows.Forms.PictureBox();
            this.textBoxDescriptionModify = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelLogOut = new System.Windows.Forms.Label();
            this.groupBoxModifyItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxModifyItem)).BeginInit();
            this.SuspendLayout();
            // 
            // labelModifyItem
            // 
            this.labelModifyItem.AutoSize = true;
            this.labelModifyItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModifyItem.Location = new System.Drawing.Point(50, 30);
            this.labelModifyItem.Name = "labelModifyItem";
            this.labelModifyItem.Size = new System.Drawing.Size(527, 22);
            this.labelModifyItem.TabIndex = 0;
            this.labelModifyItem.Text = "MODIFIER L\'ARTICLE ET CONTRÔLE DE L\'INVENTAIRE";
            this.labelModifyItem.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(586, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 1;
            // 
            // groupBoxModifyItem
            // 
            this.groupBoxModifyItem.BackColor = System.Drawing.Color.White;
            this.groupBoxModifyItem.Controls.Add(this.textBoxDateTaken);
            this.groupBoxModifyItem.Controls.Add(this.textBoxDateReturned);
            this.groupBoxModifyItem.Controls.Add(this.buttonCancel);
            this.groupBoxModifyItem.Controls.Add(this.buttonSave);
            this.groupBoxModifyItem.Controls.Add(this.buttonSelectImage);
            this.groupBoxModifyItem.Controls.Add(this.labelName);
            this.groupBoxModifyItem.Controls.Add(this.textBoxModifyName);
            this.groupBoxModifyItem.Controls.Add(this.labelDateReturned);
            this.groupBoxModifyItem.Controls.Add(this.labelDateTaken);
            this.groupBoxModifyItem.Controls.Add(this.labelQuantity);
            this.groupBoxModifyItem.Controls.Add(this.textBoxModifyQuantity);
            this.groupBoxModifyItem.Controls.Add(this.comboBoxColor);
            this.groupBoxModifyItem.Controls.Add(this.comboBoxBOXNO);
            this.groupBoxModifyItem.Controls.Add(this.comboBoxSize);
            this.groupBoxModifyItem.Controls.Add(this.comboBoxCategory);
            this.groupBoxModifyItem.Controls.Add(this.comboBoxSelectCoach);
            this.groupBoxModifyItem.Controls.Add(this.pictureBoxModifyItem);
            this.groupBoxModifyItem.Controls.Add(this.textBoxDescriptionModify);
            this.groupBoxModifyItem.Controls.Add(this.label4);
            this.groupBoxModifyItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBoxModifyItem.Location = new System.Drawing.Point(150, 120);
            this.groupBoxModifyItem.Name = "groupBoxModifyItem";
            this.groupBoxModifyItem.Size = new System.Drawing.Size(980, 449);
            this.groupBoxModifyItem.TabIndex = 3;
            this.groupBoxModifyItem.TabStop = false;
            this.groupBoxModifyItem.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBoxDateTaken
            // 
            this.textBoxDateTaken.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDateTaken.Location = new System.Drawing.Point(423, 173);
            this.textBoxDateTaken.Name = "textBoxDateTaken";
            this.textBoxDateTaken.Size = new System.Drawing.Size(110, 22);
            this.textBoxDateTaken.TabIndex = 35;
            this.textBoxDateTaken.Text = "entrez la date";
            // 
            // textBoxDateReturned
            // 
            this.textBoxDateReturned.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDateReturned.Location = new System.Drawing.Point(585, 173);
            this.textBoxDateReturned.Name = "textBoxDateReturned";
            this.textBoxDateReturned.Size = new System.Drawing.Size(110, 22);
            this.textBoxDateReturned.TabIndex = 34;
            this.textBoxDateReturned.Text = "entrez la date";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(816, 392);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(133, 30);
            this.buttonCancel.TabIndex = 33;
            this.buttonCancel.Text = "ANNULER";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(676, 392);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(133, 30);
            this.buttonSave.TabIndex = 31;
            this.buttonSave.Text = "ENREGISTRER";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonSelectImage
            // 
            this.buttonSelectImage.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSelectImage.Location = new System.Drawing.Point(43, 216);
            this.buttonSelectImage.Name = "buttonSelectImage";
            this.buttonSelectImage.Size = new System.Drawing.Size(110, 47);
            this.buttonSelectImage.TabIndex = 30;
            this.buttonSelectImage.Text = "sélectionnez l\'image";
            this.buttonSelectImage.UseVisualStyleBackColor = true;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(226, 80);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 16);
            this.labelName.TabIndex = 29;
            this.labelName.Text = "NOM";
            // 
            // textBoxModifyName
            // 
            this.textBoxModifyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxModifyName.Location = new System.Drawing.Point(229, 103);
            this.textBoxModifyName.Name = "textBoxModifyName";
            this.textBoxModifyName.Size = new System.Drawing.Size(110, 22);
            this.textBoxModifyName.TabIndex = 28;
            this.textBoxModifyName.Text = "modifiez le nom";
            // 
            // labelDateReturned
            // 
            this.labelDateReturned.AutoSize = true;
            this.labelDateReturned.Location = new System.Drawing.Point(582, 152);
            this.labelDateReturned.Name = "labelDateReturned";
            this.labelDateReturned.Size = new System.Drawing.Size(127, 16);
            this.labelDateReturned.TabIndex = 27;
            this.labelDateReturned.Text = "DATE DE RETOUR";
            // 
            // labelDateTaken
            // 
            this.labelDateTaken.AutoSize = true;
            this.labelDateTaken.Location = new System.Drawing.Point(420, 152);
            this.labelDateTaken.Name = "labelDateTaken";
            this.labelDateTaken.Size = new System.Drawing.Size(109, 16);
            this.labelDateTaken.TabIndex = 27;
            this.labelDateTaken.Text = "DATE DE PRISE";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(347, 80);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(76, 16);
            this.labelQuantity.TabIndex = 27;
            this.labelQuantity.Text = "QUANTITÉ";
            // 
            // textBoxModifyQuantity
            // 
            this.textBoxModifyQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxModifyQuantity.Location = new System.Drawing.Point(350, 103);
            this.textBoxModifyQuantity.Name = "textBoxModifyQuantity";
            this.textBoxModifyQuantity.Size = new System.Drawing.Size(110, 22);
            this.textBoxModifyQuantity.TabIndex = 26;
            this.textBoxModifyQuantity.Text = "modifiez la quantité";
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new System.Drawing.Point(509, 30);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(110, 27);
            this.comboBoxColor.TabIndex = 25;
            this.comboBoxColor.Text = "COULEUR";
            // 
            // comboBoxBOXNO
            // 
            this.comboBoxBOXNO.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBOXNO.FormattingEnabled = true;
            this.comboBoxBOXNO.Location = new System.Drawing.Point(649, 30);
            this.comboBoxBOXNO.Name = "comboBoxBOXNO";
            this.comboBoxBOXNO.Size = new System.Drawing.Size(110, 27);
            this.comboBoxBOXNO.TabIndex = 24;
            this.comboBoxBOXNO.Text = "BOÎTE No";
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Location = new System.Drawing.Point(369, 30);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(110, 27);
            this.comboBoxSize.TabIndex = 23;
            this.comboBoxSize.Text = "TAILLE";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(229, 30);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(110, 27);
            this.comboBoxCategory.TabIndex = 22;
            this.comboBoxCategory.Text = "CATEGORIE";
            // 
            // comboBoxSelectCoach
            // 
            this.comboBoxSelectCoach.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelectCoach.FormattingEnabled = true;
            this.comboBoxSelectCoach.Items.AddRange(new object[] {
            "COACH 1",
            "COACH2"});
            this.comboBoxSelectCoach.Location = new System.Drawing.Point(230, 152);
            this.comboBoxSelectCoach.Name = "comboBoxSelectCoach";
            this.comboBoxSelectCoach.Size = new System.Drawing.Size(160, 27);
            this.comboBoxSelectCoach.TabIndex = 19;
            this.comboBoxSelectCoach.Text = "ARTICLE PRIS PAR";
            // 
            // pictureBoxModifyItem
            // 
            this.pictureBoxModifyItem.Location = new System.Drawing.Point(16, 26);
            this.pictureBoxModifyItem.Name = "pictureBoxModifyItem";
            this.pictureBoxModifyItem.Size = new System.Drawing.Size(177, 169);
            this.pictureBoxModifyItem.TabIndex = 10;
            this.pictureBoxModifyItem.TabStop = false;
            // 
            // textBoxDescriptionModify
            // 
            this.textBoxDescriptionModify.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDescriptionModify.Location = new System.Drawing.Point(229, 246);
            this.textBoxDescriptionModify.Multiline = true;
            this.textBoxDescriptionModify.Name = "textBoxDescriptionModify";
            this.textBoxDescriptionModify.Size = new System.Drawing.Size(720, 117);
            this.textBoxDescriptionModify.TabIndex = 7;
            this.textBoxDescriptionModify.Text = "Existing description loads here for editing. La description existante apparaît ic" +
    "i pour modification.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "DESCRIPTION";
            // 
            // labelLogOut
            // 
            this.labelLogOut.AutoSize = true;
            this.labelLogOut.BackColor = System.Drawing.Color.Black;
            this.labelLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogOut.ForeColor = System.Drawing.Color.Silver;
            this.labelLogOut.Location = new System.Drawing.Point(948, 28);
            this.labelLogOut.Name = "labelLogOut";
            this.labelLogOut.Size = new System.Drawing.Size(182, 25);
            this.labelLogOut.TabIndex = 32;
            this.labelLogOut.Text = "DÉCONNECTER ";
            // 
            // Form8ModifyItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.labelLogOut);
            this.Controls.Add(this.groupBoxModifyItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelModifyItem);
            this.ForeColor = System.Drawing.Color.Silver;
            this.Name = "Form8ModifyItem";
            this.Text = "MODIFIER L\'ARTICLE ET CONTRÔLE DE L\'INVENTAIRE";
            this.Load += new System.EventHandler(this.ModifyWindow_Load);
            this.groupBoxModifyItem.ResumeLayout(false);
            this.groupBoxModifyItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxModifyItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelModifyItem;
        private System.Windows.Forms.Label label2;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.GroupBox groupBoxModifyItem;
        private System.Windows.Forms.PictureBox pictureBoxModifyItem;
        private System.Windows.Forms.TextBox textBoxDescriptionModify;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxSelectCoach;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.ComboBox comboBoxBOXNO;
        private System.Windows.Forms.ComboBox comboBoxSize;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxModifyName;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.TextBox textBoxModifyQuantity;
        private System.Windows.Forms.Button buttonSelectImage;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelLogOut;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelDateReturned;
        private System.Windows.Forms.Label labelDateTaken;
        private System.Windows.Forms.TextBox textBoxDateTaken;
        private System.Windows.Forms.TextBox textBoxDateReturned;
    }
}