namespace RythmicQuebecInventory
{
    partial class Form6AddNewItems
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
            this.labelAddNewItem = new System.Windows.Forms.Label();
            this.groupBoxAddNewItem = new System.Windows.Forms.GroupBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxInputName = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.textBoxInputQuantity = new System.Windows.Forms.TextBox();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.comboBoxBOXNO = new System.Windows.Forms.ComboBox();
            this.textBoxDescriptionNewItem = new System.Windows.Forms.TextBox();
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.pictureBoxAddItem = new System.Windows.Forms.PictureBox();
            this.buttonSelectImage = new System.Windows.Forms.Button();
            this.labelLogOut = new System.Windows.Forms.Label();
            this.groupBoxAddNewItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddItem)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAddNewItem
            // 
            this.labelAddNewItem.AutoSize = true;
            this.labelAddNewItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddNewItem.Location = new System.Drawing.Point(50, 30);
            this.labelAddNewItem.Name = "labelAddNewItem";
            this.labelAddNewItem.Size = new System.Drawing.Size(311, 22);
            this.labelAddNewItem.TabIndex = 1;
            this.labelAddNewItem.Text = "AJOUTER UN NOUVEL ARTICLE";
            // 
            // groupBoxAddNewItem
            // 
            this.groupBoxAddNewItem.BackColor = System.Drawing.Color.White;
            this.groupBoxAddNewItem.Controls.Add(this.buttonCancel);
            this.groupBoxAddNewItem.Controls.Add(this.labelName);
            this.groupBoxAddNewItem.Controls.Add(this.textBoxInputName);
            this.groupBoxAddNewItem.Controls.Add(this.labelQuantity);
            this.groupBoxAddNewItem.Controls.Add(this.textBoxInputQuantity);
            this.groupBoxAddNewItem.Controls.Add(this.comboBoxColor);
            this.groupBoxAddNewItem.Controls.Add(this.buttonSave);
            this.groupBoxAddNewItem.Controls.Add(this.comboBoxBOXNO);
            this.groupBoxAddNewItem.Controls.Add(this.textBoxDescriptionNewItem);
            this.groupBoxAddNewItem.Controls.Add(this.comboBoxSize);
            this.groupBoxAddNewItem.Controls.Add(this.label3);
            this.groupBoxAddNewItem.Controls.Add(this.comboBoxCategory);
            this.groupBoxAddNewItem.Controls.Add(this.pictureBoxAddItem);
            this.groupBoxAddNewItem.Controls.Add(this.buttonSelectImage);
            this.groupBoxAddNewItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBoxAddNewItem.Location = new System.Drawing.Point(150, 120);
            this.groupBoxAddNewItem.Name = "groupBoxAddNewItem";
            this.groupBoxAddNewItem.Size = new System.Drawing.Size(980, 449);
            this.groupBoxAddNewItem.TabIndex = 2;
            this.groupBoxAddNewItem.TabStop = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(814, 387);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(133, 30);
            this.buttonCancel.TabIndex = 14;
            this.buttonCancel.Text = "ANNULER";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(225, 100);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 16);
            this.labelName.TabIndex = 13;
            this.labelName.Text = "NOM";
            // 
            // textBoxInputName
            // 
            this.textBoxInputName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInputName.Location = new System.Drawing.Point(228, 123);
            this.textBoxInputName.Name = "textBoxInputName";
            this.textBoxInputName.Size = new System.Drawing.Size(110, 22);
            this.textBoxInputName.TabIndex = 12;
            this.textBoxInputName.Text = "entrez le nom";
            this.textBoxInputName.Click += new System.EventHandler(this.textBoxInputName_Click);
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(346, 100);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(76, 16);
            this.labelQuantity.TabIndex = 11;
            this.labelQuantity.Text = "QUANTITÉ";
            // 
            // textBoxInputQuantity
            // 
            this.textBoxInputQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInputQuantity.Location = new System.Drawing.Point(349, 123);
            this.textBoxInputQuantity.Name = "textBoxInputQuantity";
            this.textBoxInputQuantity.Size = new System.Drawing.Size(110, 22);
            this.textBoxInputQuantity.TabIndex = 10;
            this.textBoxInputQuantity.Text = "entrez la quantité";
            this.textBoxInputQuantity.Click += new System.EventHandler(this.textBoxInputQuantity_Click);
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new System.Drawing.Point(504, 33);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(110, 27);
            this.comboBoxColor.TabIndex = 7;
            this.comboBoxColor.Text = "COULEUR";
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(675, 387);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(133, 30);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "ENREGISTRER";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // comboBoxBOXNO
            // 
            this.comboBoxBOXNO.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBOXNO.FormattingEnabled = true;
            this.comboBoxBOXNO.Location = new System.Drawing.Point(644, 33);
            this.comboBoxBOXNO.Name = "comboBoxBOXNO";
            this.comboBoxBOXNO.Size = new System.Drawing.Size(110, 27);
            this.comboBoxBOXNO.TabIndex = 6;
            this.comboBoxBOXNO.Text = "BOÎTE No";
            // 
            // textBoxDescriptionNewItem
            // 
            this.textBoxDescriptionNewItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDescriptionNewItem.Location = new System.Drawing.Point(227, 235);
            this.textBoxDescriptionNewItem.Multiline = true;
            this.textBoxDescriptionNewItem.Name = "textBoxDescriptionNewItem";
            this.textBoxDescriptionNewItem.Size = new System.Drawing.Size(720, 117);
            this.textBoxDescriptionNewItem.TabIndex = 8;
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Location = new System.Drawing.Point(364, 33);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(110, 27);
            this.comboBoxSize.TabIndex = 5;
            this.comboBoxSize.Text = "TAILLE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "DESCRIPTION";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(224, 33);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(110, 27);
            this.comboBoxCategory.TabIndex = 4;
            this.comboBoxCategory.Text = "CATEGORIE";
            // 
            // pictureBoxAddItem
            // 
            this.pictureBoxAddItem.Location = new System.Drawing.Point(12, 26);
            this.pictureBoxAddItem.Name = "pictureBoxAddItem";
            this.pictureBoxAddItem.Size = new System.Drawing.Size(177, 169);
            this.pictureBoxAddItem.TabIndex = 6;
            this.pictureBoxAddItem.TabStop = false;
            // 
            // buttonSelectImage
            // 
            this.buttonSelectImage.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSelectImage.Location = new System.Drawing.Point(47, 209);
            this.buttonSelectImage.Name = "buttonSelectImage";
            this.buttonSelectImage.Size = new System.Drawing.Size(110, 47);
            this.buttonSelectImage.TabIndex = 5;
            this.buttonSelectImage.Text = "sélectionnez l\'image";
            this.buttonSelectImage.UseVisualStyleBackColor = true;
            this.buttonSelectImage.Click += new System.EventHandler(this.buttonSelectImage_Click);
            // 
            // labelLogOut
            // 
            this.labelLogOut.AutoSize = true;
            this.labelLogOut.BackColor = System.Drawing.Color.Black;
            this.labelLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogOut.ForeColor = System.Drawing.Color.Silver;
            this.labelLogOut.Location = new System.Drawing.Point(959, 27);
            this.labelLogOut.Name = "labelLogOut";
            this.labelLogOut.Size = new System.Drawing.Size(182, 25);
            this.labelLogOut.TabIndex = 16;
            this.labelLogOut.Text = "DÉCONNECTER ";
            this.labelLogOut.Click += new System.EventHandler(this.labelLogOut_Click);
            // 
            // Form6AddNewItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1265, 682);
            this.Controls.Add(this.labelLogOut);
            this.Controls.Add(this.groupBoxAddNewItem);
            this.Controls.Add(this.labelAddNewItem);
            this.ForeColor = System.Drawing.Color.Silver;
            this.Name = "Form6AddNewItems";
            this.Text = "AJOUTER UN NOUVEL ARTICLE";
            this.Load += new System.EventHandler(this.Form6AddNewItems_Load);
            this.groupBoxAddNewItem.ResumeLayout(false);
            this.groupBoxAddNewItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelAddNewItem;
        private System.Windows.Forms.GroupBox groupBoxAddNewItem;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxDescriptionNewItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxAddItem;
        private System.Windows.Forms.Button buttonSelectImage;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.ComboBox comboBoxBOXNO;
        private System.Windows.Forms.ComboBox comboBoxSize;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.TextBox textBoxInputQuantity;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxInputName;
        private System.Windows.Forms.Label labelLogOut;
        private System.Windows.Forms.Button buttonCancel;
    }
}