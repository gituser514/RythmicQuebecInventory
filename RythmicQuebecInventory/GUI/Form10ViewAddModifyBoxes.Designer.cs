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
            this.components = new System.ComponentModel.Container();
            this.labelViewModifBoxes = new System.Windows.Forms.Label();
            this.groupBoxAddModifyBox = new System.Windows.Forms.GroupBox();
            this.buttonModifyCheckedRow = new System.Windows.Forms.Button();
            this.buttonDeleteChosenRow = new System.Windows.Forms.Button();
            this.labelInputAvailableArticles = new System.Windows.Forms.Label();
            this.textBoxInputAvailableItems = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
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
            this.SelectCoach = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.boxNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IS_QRCode_Created = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Items = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Available_Items = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSQRCodeCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalItemsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableItemsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryDBDataSet1 = new RythmicQuebecInventory.InventoryDBDataSet1();
            this.textBoxSearchBox = new System.Windows.Forms.TextBox();
            this.labelSearchBox = new System.Windows.Forms.Label();
            this.labelLogOut = new System.Windows.Forms.Label();
            this.boxTableAdapter = new RythmicQuebecInventory.InventoryDBDataSet1TableAdapters.BoxTableAdapter();
            this.groupBoxAddModifyBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBoxes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelViewModifBoxes
            // 
            this.labelViewModifBoxes.AutoSize = true;
            this.labelViewModifBoxes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelViewModifBoxes.Location = new System.Drawing.Point(50, 30);
            this.labelViewModifBoxes.Name = "labelViewModifBoxes";
            this.labelViewModifBoxes.Size = new System.Drawing.Size(399, 22);
            this.labelViewModifBoxes.TabIndex = 0;
            this.labelViewModifBoxes.Text = "VOIR / MODIFIER / AJOUTER LES BOÎTES";
            // 
            // groupBoxAddModifyBox
            // 
            this.groupBoxAddModifyBox.BackColor = System.Drawing.Color.White;
            this.groupBoxAddModifyBox.Controls.Add(this.buttonModifyCheckedRow);
            this.groupBoxAddModifyBox.Controls.Add(this.buttonDeleteChosenRow);
            this.groupBoxAddModifyBox.Controls.Add(this.labelInputAvailableArticles);
            this.groupBoxAddModifyBox.Controls.Add(this.textBoxInputAvailableItems);
            this.groupBoxAddModifyBox.Controls.Add(this.buttonAdd);
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
            this.groupBoxAddModifyBox.Enter += new System.EventHandler(this.groupBoxAddModifyBox_Enter);
            // 
            // buttonModifyCheckedRow
            // 
            this.buttonModifyCheckedRow.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifyCheckedRow.Location = new System.Drawing.Point(664, 255);
            this.buttonModifyCheckedRow.Name = "buttonModifyCheckedRow";
            this.buttonModifyCheckedRow.Size = new System.Drawing.Size(139, 43);
            this.buttonModifyCheckedRow.TabIndex = 37;
            this.buttonModifyCheckedRow.Text = "MODIFIER LIGNE CHOISIR";
            this.buttonModifyCheckedRow.UseCompatibleTextRendering = true;
            this.buttonModifyCheckedRow.UseVisualStyleBackColor = true;
            this.buttonModifyCheckedRow.Click += new System.EventHandler(this.buttonModifyCheckedRow_Click);
            // 
            // buttonDeleteChosenRow
            // 
            this.buttonDeleteChosenRow.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteChosenRow.Location = new System.Drawing.Point(827, 255);
            this.buttonDeleteChosenRow.Name = "buttonDeleteChosenRow";
            this.buttonDeleteChosenRow.Size = new System.Drawing.Size(133, 43);
            this.buttonDeleteChosenRow.TabIndex = 36;
            this.buttonDeleteChosenRow.Text = "SUPPRIMER LIGNE CHOISIR";
            this.buttonDeleteChosenRow.UseCompatibleTextRendering = true;
            this.buttonDeleteChosenRow.UseVisualStyleBackColor = true;
            this.buttonDeleteChosenRow.Click += new System.EventHandler(this.buttonDeleteChosenRow_Click);
            // 
            // labelInputAvailableArticles
            // 
            this.labelInputAvailableArticles.AutoSize = true;
            this.labelInputAvailableArticles.Location = new System.Drawing.Point(697, 338);
            this.labelInputAvailableArticles.Name = "labelInputAvailableArticles";
            this.labelInputAvailableArticles.Size = new System.Drawing.Size(124, 16);
            this.labelInputAvailableArticles.TabIndex = 29;
            this.labelInputAvailableArticles.Text = "Articles disponibles";
            // 
            // textBoxInputAvailableItems
            // 
            this.textBoxInputAvailableItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInputAvailableItems.Location = new System.Drawing.Point(699, 358);
            this.textBoxInputAvailableItems.Name = "textBoxInputAvailableItems";
            this.textBoxInputAvailableItems.Size = new System.Drawing.Size(110, 22);
            this.textBoxInputAvailableItems.TabIndex = 28;
            this.textBoxInputAvailableItems.Text = "entrez #articles disponibles";
            this.textBoxInputAvailableItems.TextChanged += new System.EventHandler(this.textBoxInputAvailableItems_TextChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(827, 337);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(133, 43);
            this.buttonAdd.TabIndex = 27;
            this.buttonAdd.Text = "AJOUTER";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelTotal_Items
            // 
            this.labelTotal_Items.AutoSize = true;
            this.labelTotal_Items.Location = new System.Drawing.Point(568, 338);
            this.labelTotal_Items.Name = "labelTotal_Items";
            this.labelTotal_Items.Size = new System.Drawing.Size(97, 16);
            this.labelTotal_Items.TabIndex = 26;
            this.labelTotal_Items.Text = "Articles au total";
            // 
            // textBoxInputTotalItems
            // 
            this.textBoxInputTotalItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInputTotalItems.Location = new System.Drawing.Point(570, 358);
            this.textBoxInputTotalItems.Name = "textBoxInputTotalItems";
            this.textBoxInputTotalItems.Size = new System.Drawing.Size(110, 22);
            this.textBoxInputTotalItems.TabIndex = 25;
            this.textBoxInputTotalItems.Text = "entrez #articles au total";
            this.textBoxInputTotalItems.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxInputTotalItems_MouseClick);
            // 
            // labelIsQRCodeCreated
            // 
            this.labelIsQRCodeCreated.AutoSize = true;
            this.labelIsQRCodeCreated.Location = new System.Drawing.Point(445, 338);
            this.labelIsQRCodeCreated.Name = "labelIsQRCodeCreated";
            this.labelIsQRCodeCreated.Size = new System.Drawing.Size(103, 16);
            this.labelIsQRCodeCreated.TabIndex = 24;
            this.labelIsQRCodeCreated.Text = "QR Code créé ?";
            // 
            // textBoxInputIsQRCodeCreated
            // 
            this.textBoxInputIsQRCodeCreated.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInputIsQRCodeCreated.Location = new System.Drawing.Point(447, 358);
            this.textBoxInputIsQRCodeCreated.Name = "textBoxInputIsQRCodeCreated";
            this.textBoxInputIsQRCodeCreated.Size = new System.Drawing.Size(110, 22);
            this.textBoxInputIsQRCodeCreated.TabIndex = 23;
            this.textBoxInputIsQRCodeCreated.Text = "entrez oui / non";
            this.textBoxInputIsQRCodeCreated.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxInputIsQRCodeCreated_MouseClick);
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(321, 338);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(90, 16);
            this.labelLocation.TabIndex = 22;
            this.labelLocation.Text = "Emplacement";
            // 
            // textBoxInputBoxLocation
            // 
            this.textBoxInputBoxLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInputBoxLocation.Location = new System.Drawing.Point(323, 358);
            this.textBoxInputBoxLocation.Name = "textBoxInputBoxLocation";
            this.textBoxInputBoxLocation.Size = new System.Drawing.Size(110, 22);
            this.textBoxInputBoxLocation.TabIndex = 21;
            this.textBoxInputBoxLocation.Text = "entrez l\'emplacement";
            this.textBoxInputBoxLocation.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxInputBoxLocation_MouseClick);
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(141, 338);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(75, 16);
            this.labelFirstName.TabIndex = 20;
            this.labelFirstName.Text = "Description";
            // 
            // textBoxInputBoxDescription
            // 
            this.textBoxInputBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInputBoxDescription.Location = new System.Drawing.Point(143, 358);
            this.textBoxInputBoxDescription.Name = "textBoxInputBoxDescription";
            this.textBoxInputBoxDescription.Size = new System.Drawing.Size(169, 22);
            this.textBoxInputBoxDescription.TabIndex = 19;
            this.textBoxInputBoxDescription.Text = "entrez  la description";
            this.textBoxInputBoxDescription.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxInputBoxDescription_MouseClick);
            // 
            // labelBoxNo
            // 
            this.labelBoxNo.AutoSize = true;
            this.labelBoxNo.Location = new System.Drawing.Point(20, 338);
            this.labelBoxNo.Name = "labelBoxNo";
            this.labelBoxNo.Size = new System.Drawing.Size(48, 16);
            this.labelBoxNo.TabIndex = 18;
            this.labelBoxNo.Text = "Boîte #";
            // 
            // textBoxInputBoxNo
            // 
            this.textBoxInputBoxNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInputBoxNo.Location = new System.Drawing.Point(22, 358);
            this.textBoxInputBoxNo.Name = "textBoxInputBoxNo";
            this.textBoxInputBoxNo.Size = new System.Drawing.Size(110, 22);
            this.textBoxInputBoxNo.TabIndex = 17;
            this.textBoxInputBoxNo.Text = "entrez le #";
            this.textBoxInputBoxNo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxInputBoxNo_MouseClick);
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
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
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
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dataGridViewBoxes
            // 
            this.dataGridViewBoxes.AllowUserToOrderColumns = true;
            this.dataGridViewBoxes.AutoGenerateColumns = false;
            this.dataGridViewBoxes.BackgroundColor = System.Drawing.Color.Cyan;
            this.dataGridViewBoxes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewBoxes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBoxes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectCoach,
            this.boxNoDataGridViewTextBoxColumn,
            this.Location,
            this.locationDataGridViewTextBoxColumn,
            this.Description,
            this.IS_QRCode_Created,
            this.Total_Items,
            this.descriptionDataGridViewTextBoxColumn,
            this.Available_Items,
            this.iSQRCodeCreatedDataGridViewTextBoxColumn,
            this.totalItemsDataGridViewTextBoxColumn,
            this.availableItemsDataGridViewTextBoxColumn});
            this.dataGridViewBoxes.DataSource = this.boxBindingSource;
            this.dataGridViewBoxes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewBoxes.Location = new System.Drawing.Point(6, 12);
            this.dataGridViewBoxes.Name = "dataGridViewBoxes";
            this.dataGridViewBoxes.RowHeadersWidth = 51;
            this.dataGridViewBoxes.RowTemplate.Height = 24;
            this.dataGridViewBoxes.Size = new System.Drawing.Size(968, 237);
            this.dataGridViewBoxes.TabIndex = 1;
            this.dataGridViewBoxes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBoxes_CellContentClick);
            // 
            // SelectCoach
            // 
            this.SelectCoach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SelectCoach.HeaderText = "Choisir";
            this.SelectCoach.MinimumWidth = 6;
            this.SelectCoach.Name = "SelectCoach";
            this.SelectCoach.Width = 54;
            // 
            // boxNoDataGridViewTextBoxColumn
            // 
            this.boxNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.boxNoDataGridViewTextBoxColumn.DataPropertyName = "Box_No";
            this.boxNoDataGridViewTextBoxColumn.HeaderText = "Boîte #";
            this.boxNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.boxNoDataGridViewTextBoxColumn.Name = "boxNoDataGridViewTextBoxColumn";
            this.boxNoDataGridViewTextBoxColumn.Width = 72;
            // 
            // Location
            // 
            this.Location.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Location.HeaderText = "Emplacement";
            this.Location.MinimumWidth = 6;
            this.Location.Name = "Location";
            this.Location.Width = 119;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.Width = 125;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
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
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // Available_Items
            // 
            this.Available_Items.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Available_Items.HeaderText = "Articles disponibles";
            this.Available_Items.MinimumWidth = 6;
            this.Available_Items.Name = "Available_Items";
            this.Available_Items.Width = 140;
            // 
            // iSQRCodeCreatedDataGridViewTextBoxColumn
            // 
            this.iSQRCodeCreatedDataGridViewTextBoxColumn.DataPropertyName = "IS_QRCode_Created";
            this.iSQRCodeCreatedDataGridViewTextBoxColumn.HeaderText = "IS_QRCode_Created";
            this.iSQRCodeCreatedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iSQRCodeCreatedDataGridViewTextBoxColumn.Name = "iSQRCodeCreatedDataGridViewTextBoxColumn";
            this.iSQRCodeCreatedDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalItemsDataGridViewTextBoxColumn
            // 
            this.totalItemsDataGridViewTextBoxColumn.DataPropertyName = "Total_Items";
            this.totalItemsDataGridViewTextBoxColumn.HeaderText = "Total_Items";
            this.totalItemsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalItemsDataGridViewTextBoxColumn.Name = "totalItemsDataGridViewTextBoxColumn";
            this.totalItemsDataGridViewTextBoxColumn.Width = 125;
            // 
            // availableItemsDataGridViewTextBoxColumn
            // 
            this.availableItemsDataGridViewTextBoxColumn.DataPropertyName = "Available_Items";
            this.availableItemsDataGridViewTextBoxColumn.HeaderText = "Available_Items";
            this.availableItemsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.availableItemsDataGridViewTextBoxColumn.Name = "availableItemsDataGridViewTextBoxColumn";
            this.availableItemsDataGridViewTextBoxColumn.Width = 125;
            // 
            // boxBindingSource
            // 
            this.boxBindingSource.DataMember = "Box";
            this.boxBindingSource.DataSource = this.inventoryDBDataSet1;
            // 
            // inventoryDBDataSet1
            // 
            this.inventoryDBDataSet1.DataSetName = "InventoryDBDataSet1";
            this.inventoryDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.labelSearchBox.Click += new System.EventHandler(this.labelSearchBox_Click);
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
            this.labelLogOut.Click += new System.EventHandler(this.labelLogOut_Click);
            // 
            // boxTableAdapter
            // 
            this.boxTableAdapter.ClearBeforeFill = true;
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
            this.Load += new System.EventHandler(this.Form10ViewAddModifyBoxes_Load);
            this.groupBoxAddModifyBox.ResumeLayout(false);
            this.groupBoxAddModifyBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBoxes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelViewModifBoxes;
        private System.Windows.Forms.GroupBox groupBoxAddModifyBox;
        private System.Windows.Forms.Button buttonAdd;
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
        private System.Windows.Forms.Label labelInputAvailableArticles;
        private System.Windows.Forms.TextBox textBoxInputAvailableItems;
        private InventoryDBDataSet1 inventoryDBDataSet1;
        private System.Windows.Forms.BindingSource boxBindingSource;
        private InventoryDBDataSet1TableAdapters.BoxTableAdapter boxTableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelectCoach;
        private System.Windows.Forms.DataGridViewTextBoxColumn boxNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn IS_QRCode_Created;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Items;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Available_Items;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSQRCodeCreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalItemsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableItemsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonModifyCheckedRow;
        private System.Windows.Forms.Button buttonDeleteChosenRow;
    }
}