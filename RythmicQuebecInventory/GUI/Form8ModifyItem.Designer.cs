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
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBoxItemID = new System.Windows.Forms.TextBox();
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
            this.groupBoxModifyItem.Controls.Add(this.textBoxItemID);
            this.groupBoxModifyItem.Controls.Add(this.textBox9);
            this.groupBoxModifyItem.Controls.Add(this.textBox8);
            this.groupBoxModifyItem.Controls.Add(this.textBox7);
            this.groupBoxModifyItem.Controls.Add(this.textBox6);
            this.groupBoxModifyItem.Controls.Add(this.textBox5);
            this.groupBoxModifyItem.Controls.Add(this.textBox4);
            this.groupBoxModifyItem.Controls.Add(this.textBox3);
            this.groupBoxModifyItem.Controls.Add(this.textBox2);
            this.groupBoxModifyItem.Controls.Add(this.textBoxCategory);
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
            this.textBoxDateTaken.Location = new System.Drawing.Point(423, 180);
            this.textBoxDateTaken.Name = "textBoxDateTaken";
            this.textBoxDateTaken.Size = new System.Drawing.Size(110, 22);
            this.textBoxDateTaken.TabIndex = 35;
            this.textBoxDateTaken.Text = "entrez la date";
            this.textBoxDateTaken.Click += new System.EventHandler(this.textBoxDateTaken_Click);
            // 
            // textBoxDateReturned
            // 
            this.textBoxDateReturned.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDateReturned.Location = new System.Drawing.Point(585, 180);
            this.textBoxDateReturned.Name = "textBoxDateReturned";
            this.textBoxDateReturned.Size = new System.Drawing.Size(110, 22);
            this.textBoxDateReturned.TabIndex = 34;
            this.textBoxDateReturned.Text = "entrez la date";
            this.textBoxDateReturned.Click += new System.EventHandler(this.textBoxDateReturned_Click);
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
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
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
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
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
            this.buttonSelectImage.Click += new System.EventHandler(this.buttonSelectImage_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(226, 86);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 16);
            this.labelName.TabIndex = 29;
            this.labelName.Text = "NOM";
            // 
            // textBoxModifyName
            // 
            this.textBoxModifyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxModifyName.Location = new System.Drawing.Point(229, 106);
            this.textBoxModifyName.Name = "textBoxModifyName";
            this.textBoxModifyName.Size = new System.Drawing.Size(110, 22);
            this.textBoxModifyName.TabIndex = 28;
            this.textBoxModifyName.Text = "modifiez le nom";
            this.textBoxModifyName.Click += new System.EventHandler(this.textBoxModifyName_Click_1);
            this.textBoxModifyName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxModifyName_MouseClick);
            this.textBoxModifyName.TextChanged += new System.EventHandler(this.textBoxModifyName_TextChanged);
            // 
            // labelDateReturned
            // 
            this.labelDateReturned.AutoSize = true;
            this.labelDateReturned.Location = new System.Drawing.Point(582, 159);
            this.labelDateReturned.Name = "labelDateReturned";
            this.labelDateReturned.Size = new System.Drawing.Size(127, 16);
            this.labelDateReturned.TabIndex = 27;
            this.labelDateReturned.Text = "DATE DE RETOUR";
            // 
            // labelDateTaken
            // 
            this.labelDateTaken.AutoSize = true;
            this.labelDateTaken.Location = new System.Drawing.Point(420, 159);
            this.labelDateTaken.Name = "labelDateTaken";
            this.labelDateTaken.Size = new System.Drawing.Size(109, 16);
            this.labelDateTaken.TabIndex = 27;
            this.labelDateTaken.Text = "DATE DE PRISE";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(347, 86);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(76, 16);
            this.labelQuantity.TabIndex = 27;
            this.labelQuantity.Text = "QUANTITÉ";
            // 
            // textBoxModifyQuantity
            // 
            this.textBoxModifyQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxModifyQuantity.Location = new System.Drawing.Point(350, 106);
            this.textBoxModifyQuantity.Name = "textBoxModifyQuantity";
            this.textBoxModifyQuantity.Size = new System.Drawing.Size(110, 22);
            this.textBoxModifyQuantity.TabIndex = 26;
            this.textBoxModifyQuantity.Text = "modifiez la quantité";
            this.textBoxModifyQuantity.Click += new System.EventHandler(this.textBoxModifyQuantity_Click_1);
            this.textBoxModifyQuantity.TextChanged += new System.EventHandler(this.textBoxModifyQuantity_TextChanged);
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
            this.comboBoxBOXNO.SelectedIndexChanged += new System.EventHandler(this.comboBoxBOXNO_SelectedIndexChanged);
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
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // comboBoxSelectCoach
            // 
            this.comboBoxSelectCoach.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelectCoach.FormattingEnabled = true;
            this.comboBoxSelectCoach.Items.AddRange(new object[] {
            "COACH 1",
            "COACH2"});
            this.comboBoxSelectCoach.Location = new System.Drawing.Point(230, 159);
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
            this.textBoxDescriptionModify.Click += new System.EventHandler(this.textBoxDescriptionModify_Click);
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
            this.labelLogOut.Click += new System.EventHandler(this.labelLogOut_Click);
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCategory.Location = new System.Drawing.Point(229, 12);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(110, 22);
            this.textBoxCategory.TabIndex = 36;
            this.textBoxCategory.Text = "shows existing data ";
            this.textBoxCategory.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(369, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(110, 22);
            this.textBox2.TabIndex = 37;
            this.textBox2.Text = "shows existing data ";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(509, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(110, 22);
            this.textBox3.TabIndex = 38;
            this.textBox3.Text = "shows existing data ";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(649, 12);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(110, 22);
            this.textBox4.TabIndex = 39;
            this.textBox4.Text = "shows existing data ";
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Location = new System.Drawing.Point(229, 63);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(110, 22);
            this.textBox5.TabIndex = 40;
            this.textBox5.Text = "shows existing data ";
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Location = new System.Drawing.Point(350, 63);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(110, 22);
            this.textBox6.TabIndex = 41;
            this.textBox6.Text = "shows existing data ";
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.Location = new System.Drawing.Point(230, 138);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(110, 22);
            this.textBox7.TabIndex = 42;
            this.textBox7.Text = "shows existing data ";
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox8.Location = new System.Drawing.Point(423, 138);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(110, 22);
            this.textBox8.TabIndex = 43;
            this.textBox8.Text = "shows existing data ";
            // 
            // textBox9
            // 
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox9.Location = new System.Drawing.Point(585, 136);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(110, 22);
            this.textBox9.TabIndex = 44;
            this.textBox9.Text = "shows existing data ";
            // 
            // textBoxItemID
            // 
            this.textBoxItemID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxItemID.Location = new System.Drawing.Point(783, 12);
            this.textBoxItemID.Name = "textBoxItemID";
            this.textBoxItemID.Size = new System.Drawing.Size(110, 22);
            this.textBoxItemID.TabIndex = 45;
            this.textBoxItemID.Text = "shows Item ID";
            this.textBoxItemID.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
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
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBoxItemID;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
    }
}