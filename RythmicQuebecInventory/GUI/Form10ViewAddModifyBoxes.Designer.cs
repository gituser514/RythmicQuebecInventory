namespace RythmicQuebecInventory
{
    partial class Form10ViewAddModifyBoxes
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
            this.labelViewModifBoxes = new System.Windows.Forms.Label();
            this.groupBoxAddModifyBox = new System.Windows.Forms.GroupBox();
            this.buttonAddModify = new System.Windows.Forms.Button();
            this.labelTotal_Items = new System.Windows.Forms.Label();
            this.textBoxInputTotalItems = new System.Windows.Forms.TextBox();
            this.labelIsQRCodeCreated = new System.Windows.Forms.Label();
            this.textBoxInputIsQRCodeCreated = new System.Windows.Forms.TextBox();
            this.labelLocation = new System.Windows.Forms.Label();
            this.textBoxInputBoxLocation = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxInputBoxDescription = new System.Windows.Forms.TextBox();
            this.labelBoxNo = new System.Windows.Forms.Label();
            this.textBoxInputBoxNo = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridViewBoxes = new System.Windows.Forms.DataGridView();
            this.textBoxSearchBox = new System.Windows.Forms.TextBox();
            this.labelSearchBox = new System.Windows.Forms.Label();
            this.labelLogOut = new System.Windows.Forms.Label();
            this.SelectCoach = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Box_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IS_QRCode_Created = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Items = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Available_Items = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelInputAvailableArticles = new System.Windows.Forms.Label();
            this.textBoxInputAvailableItems = new System.Windows.Forms.TextBox();
            this.groupBoxAddModifyBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBoxes)).BeginInit();
            this.SuspendLayout();
            // 
            // labelViewModifBoxes
            // 
            this.labelViewModifBoxes.AutoSize = true;
            this.labelViewModifBoxes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelViewModifBoxes.Location = new System.Drawing.Point(50, 30);
            this.labelViewModifBoxes.Name = "labelViewModifBoxes";
            this.labelViewModifBoxes.Size = new System.Drawing.Size(499, 28);
            this.labelViewModifBoxes.TabIndex = 0;
            this.labelViewModifBoxes.Text = "VOIR / MODIFIER / AJOUTER LES BOÎTES";
            // 
            // groupBoxAddModifyBox
            // 
            this.groupBoxAddModifyBox.BackColor = System.Drawing.Color.White;
            this.groupBoxAddModifyBox.Controls.Add(this.labelInputAvailableArticles);
            this.groupBoxAddModifyBox.Controls.Add(this.textBoxInputAvailableItems);
            this.groupBoxAddModifyBox.Controls.Add(this.buttonAddModify);
            this.groupBoxAddModifyBox.Controls.Add(this.labelTotal_Items);
            this.groupBoxAddModifyBox.Controls.Add(this.textBoxInputTotalItems);
            this.groupBoxAddModifyBox.Controls.Add(this.labelIsQRCodeCreated);
            this.groupBoxAddModifyBox.Controls.Add(this.textBoxInputIsQRCodeCreated);
            this.groupBoxAddModifyBox.Controls.Add(this.labelLocation);
            this.groupBoxAddModifyBox.Controls.Add(this.textBoxInputBoxLocation);
            this.groupBoxAddModifyBox.Controls.Add(this.labelFirstName);
            this.groupBoxAddModifyBox.Controls.Add(this.textBoxInputBoxDescription);
            this.groupBoxAddModifyBox.Controls.Add(this.labelBoxNo);
            this.groupBoxAddModifyBox.Controls.Add(this.textBoxInputBoxNo);
            this.groupBoxAddModifyBox.Controls.Add(this.buttonCancel);
            this.groupBoxAddModifyBox.Controls.Add(this.buttonDelete);
            this.groupBoxAddModifyBox.Controls.Add(this.dataGridViewBoxes);
            this.groupBoxAddModifyBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBoxAddModifyBox.Location = new System.Drawing.Point(141, 126);
            this.groupBoxAddModifyBox.Name = "groupBoxAddModifyBox";
            this.groupBoxAddModifyBox.Size = new System.Drawing.Size(980, 449);
            this.groupBoxAddModifyBox.TabIndex = 8;
            this.groupBoxAddModifyBox.TabStop = false;
            // 
            // buttonAddModify
            // 
            this.buttonAddModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddModify.Location = new System.Drawing.Point(841, 300);
            this.buttonAddModify.Name = "buttonAddModify";
            this.buttonAddModify.Size = new System.Drawing.Size(133, 43);
            this.buttonAddModify.TabIndex = 27;
            this.buttonAddModify.Text = "AJOUTER / MODIFIER";
            this.buttonAddModify.UseVisualStyleBackColor = true;
            // 
            // labelTotal_Items
            // 
            this.labelTotal_Items.AutoSize = true;
            this.labelTotal_Items.Location = new System.Drawing.Point(567, 301);
            this.labelTotal_Items.Name = "labelTotal_Items";
            this.labelTotal_Items.Size = new System.Drawing.Size(97, 16);
            this.labelTotal_Items.TabIndex = 26;
            this.labelTotal_Items.Text = "Articles au total";
            // 
            // textBoxInputTotalItems
            // 
            this.textBoxInputTotalItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInputTotalItems.Location = new System.Drawing.Point(569, 321);
            this.textBoxInputTotalItems.Name = "textBoxInputTotalItems";
            this.textBoxInputTotalItems.Size = new System.Drawing.Size(110, 22);
            this.textBoxInputTotalItems.TabIndex = 25;
            this.textBoxInputTotalItems.Text = "entrez #articles au total";
            // 
            // labelIsQRCodeCreated
            // 
            this.labelIsQRCodeCreated.AutoSize = true;
            this.labelIsQRCodeCreated.Location = new System.Drawing.Point(444, 301);
            this.labelIsQRCodeCreated.Name = "labelIsQRCodeCreated";
            this.labelIsQRCodeCreated.Size = new System.Drawing.Size(103, 16);
            this.labelIsQRCodeCreated.TabIndex = 24;
            this.labelIsQRCodeCreated.Text = "QR Code créé ?";
            // 
            // textBoxInputIsQRCodeCreated
            // 
            this.textBoxInputIsQRCodeCreated.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInputIsQRCodeCreated.Location = new System.Drawing.Point(446, 321);
            this.textBoxInputIsQRCodeCreated.Name = "textBoxInputIsQRCodeCreated";
            this.textBoxInputIsQRCodeCreated.Size = new System.Drawing.Size(110, 22);
            this.textBoxInputIsQRCodeCreated.TabIndex = 23;
            this.textBoxInputIsQRCodeCreated.Text = "entrez oui / non";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(320, 301);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(90, 16);
            this.labelLocation.TabIndex = 22;
            this.labelLocation.Text = "Emplacement";
            // 
            // textBoxInputBoxLocation
            // 
            this.textBoxInputBoxLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInputBoxLocation.Location = new System.Drawing.Point(322, 321);
            this.textBoxInputBoxLocation.Name = "textBoxInputBoxLocation";
            this.textBoxInputBoxLocation.Size = new System.Drawing.Size(110, 22);
            this.textBoxInputBoxLocation.TabIndex = 21;
            this.textBoxInputBoxLocation.Text = "entrez l\'emplacement";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(140, 301);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(94, 20);
            this.labelFirstName.TabIndex = 20;
            this.labelFirstName.Text = "Description";
            // 
            // textBoxInputBoxDescription
            // 
            this.textBoxInputBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInputBoxDescription.Location = new System.Drawing.Point(142, 321);
            this.textBoxInputBoxDescription.Name = "textBoxInputBoxDescription";
            this.textBoxInputBoxDescription.Size = new System.Drawing.Size(169, 22);
            this.textBoxInputBoxDescription.TabIndex = 19;
            this.textBoxInputBoxDescription.Text = "entrez  la description";
            // 
            // labelBoxNo
            // 
            this.labelBoxNo.AutoSize = true;
            this.labelBoxNo.Location = new System.Drawing.Point(19, 301);
            this.labelBoxNo.Name = "labelBoxNo";
            this.labelBoxNo.Size = new System.Drawing.Size(60, 20);
            this.labelBoxNo.TabIndex = 18;
            this.labelBoxNo.Text = "Boîte #";
            // 
            // textBoxInputBoxNo
            // 
            this.textBoxInputBoxNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInputBoxNo.Location = new System.Drawing.Point(21, 321);
            this.textBoxInputBoxNo.Name = "textBoxInputBoxNo";
            this.textBoxInputBoxNo.Size = new System.Drawing.Size(110, 22);
            this.textBoxInputBoxNo.TabIndex = 17;
            this.textBoxInputBoxNo.Text = "entrez le #";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(807, 396);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(133, 30);
            this.buttonCancel.TabIndex = 16;
            this.buttonCancel.Text = "ANNULER";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(668, 396);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(133, 30);
            this.buttonDelete.TabIndex = 15;
            this.buttonDelete.Text = "SUPPRIMER";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBoxes
            // 
            this.dataGridViewBoxes.BackgroundColor = System.Drawing.Color.Cyan;
            this.dataGridViewBoxes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewBoxes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBoxes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectCoach,
            this.Box_No,
            this.Description,
            this.Location,
            this.IS_QRCode_Created,
            this.Total_Items,
            this.Available_Items});
            this.dataGridViewBoxes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewBoxes.Location = new System.Drawing.Point(6, 12);
            this.dataGridViewBoxes.Name = "dataGridViewBoxes";
            this.dataGridViewBoxes.RowHeadersWidth = 51;
            this.dataGridViewBoxes.RowTemplate.Height = 24;
            this.dataGridViewBoxes.Size = new System.Drawing.Size(968, 286);
            this.dataGridViewBoxes.TabIndex = 1;
            // 
            // textBoxSearchBox
            // 
            this.textBoxSearchBox.Location = new System.Drawing.Point(945, 98);
            this.textBoxSearchBox.Name = "textBoxSearchBox";
            this.textBoxSearchBox.Size = new System.Drawing.Size(176, 22);
            this.textBoxSearchBox.TabIndex = 7;
            // 
            // labelSearchBox
            // 
            this.labelSearchBox.AutoSize = true;
            this.labelSearchBox.Location = new System.Drawing.Point(859, 104);
            this.labelSearchBox.Name = "labelSearchBox";
            this.labelSearchBox.Size = new System.Drawing.Size(83, 16);
            this.labelSearchBox.TabIndex = 6;
            this.labelSearchBox.Text = "CHERCHER";
            // 
            // labelLogOut
            // 
            this.labelLogOut.AutoSize = true;
            this.labelLogOut.BackColor = System.Drawing.Color.Black;
            this.labelLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogOut.ForeColor = System.Drawing.Color.Silver;
            this.labelLogOut.Location = new System.Drawing.Point(943, 28);
            this.labelLogOut.Name = "labelLogOut";
            this.labelLogOut.Size = new System.Drawing.Size(182, 25);
            this.labelLogOut.TabIndex = 28;
            this.labelLogOut.Text = "DÉCONNECTER ";
            // 
            // SelectCoach
            // 
            this.SelectCoach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SelectCoach.HeaderText = "Choisir";
            this.SelectCoach.MinimumWidth = 6;
            this.SelectCoach.Name = "SelectCoach";
            this.SelectCoach.Width = 54;
            // 
            // Box_No
            // 
            this.Box_No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Box_No.HeaderText = "Boîte #";
            this.Box_No.MinimumWidth = 6;
            this.Box_No.Name = "Box_No";
            this.Box_No.Width = 77;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            // 
            // Location
            // 
            this.Location.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Location.HeaderText = "Emplacement";
            this.Location.MinimumWidth = 6;
            this.Location.Name = "Location";
            this.Location.Width = 119;
            // 
            // IS_QRCode_Created
            // 
            this.IS_QRCode_Created.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.IS_QRCode_Created.HeaderText = "QR Code créé ?";
            this.IS_QRCode_Created.MinimumWidth = 6;
            this.IS_QRCode_Created.Name = "IS_QRCode_Created";
            this.IS_QRCode_Created.Width = 121;
            // 
            // Total_Items
            // 
            this.Total_Items.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Total_Items.HeaderText = "Articles au total";
            this.Total_Items.MinimumWidth = 6;
            this.Total_Items.Name = "Total_Items";
            this.Total_Items.Width = 93;
            // 
            // Available_Items
            // 
            this.Available_Items.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Available_Items.HeaderText = "Articles disponibles";
            this.Available_Items.MinimumWidth = 6;
            this.Available_Items.Name = "Available_Items";
            this.Available_Items.Width = 140;
            // 
            // labelInputAvailableArticles
            // 
            this.labelInputAvailableArticles.AutoSize = true;
            this.labelInputAvailableArticles.Location = new System.Drawing.Point(696, 301);
            this.labelInputAvailableArticles.Name = "labelInputAvailableArticles";
            this.labelInputAvailableArticles.Size = new System.Drawing.Size(124, 16);
            this.labelInputAvailableArticles.TabIndex = 29;
            this.labelInputAvailableArticles.Text = "Articles disponibles";
            // 
            // textBoxInputAvailableItems
            // 
            this.textBoxInputAvailableItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInputAvailableItems.Location = new System.Drawing.Point(698, 321);
            this.textBoxInputAvailableItems.Name = "textBoxInputAvailableItems";
            this.textBoxInputAvailableItems.Size = new System.Drawing.Size(110, 22);
            this.textBoxInputAvailableItems.TabIndex = 28;
            this.textBoxInputAvailableItems.Text = "entrez #articles disponibles";
            // 
            // Form10ViewAddModifyBoxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.labelLogOut);
            this.Controls.Add(this.groupBoxAddModifyBox);
            this.Controls.Add(this.textBoxSearchBox);
            this.Controls.Add(this.labelSearchBox);
            this.Controls.Add(this.labelViewModifBoxes);
            this.ForeColor = System.Drawing.Color.Silver;
            this.Name = "Form10ViewAddModifyBoxes";
            this.Text = "VOIR / MODIFIER / AJOUTER LES BOÎTES";
            this.groupBoxAddModifyBox.ResumeLayout(false);
            this.groupBoxAddModifyBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBoxes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelViewModifBoxes;
        private System.Windows.Forms.GroupBox groupBoxAddModifyBox;
        private System.Windows.Forms.Button buttonAddModify;
        private System.Windows.Forms.Label labelTotal_Items;
        private System.Windows.Forms.TextBox textBoxInputTotalItems;
        private System.Windows.Forms.Label labelIsQRCodeCreated;
        private System.Windows.Forms.TextBox textBoxInputIsQRCodeCreated;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.TextBox textBoxInputBoxLocation;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxInputBoxDescription;
        private System.Windows.Forms.Label labelBoxNo;
        private System.Windows.Forms.TextBox textBoxInputBoxNo;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dataGridViewBoxes;
        private System.Windows.Forms.TextBox textBoxSearchBox;
        private System.Windows.Forms.Label labelSearchBox;
        private System.Windows.Forms.Label labelLogOut;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelectCoach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Box_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn IS_QRCode_Created;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Items;
        private System.Windows.Forms.DataGridViewTextBoxColumn Available_Items;
        private System.Windows.Forms.Label labelInputAvailableArticles;
        private System.Windows.Forms.TextBox textBoxInputAvailableItems;
    }
}