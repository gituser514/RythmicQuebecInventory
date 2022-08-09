namespace RythmicQuebecInventory
{
    partial class Form9ViewAddModifyCoach
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
            this.labelViewAddCoach = new System.Windows.Forms.Label();
            this.groupBoxAddCoach = new System.Windows.Forms.GroupBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxInputAddress = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxInputPhoneNo = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxInputEmail = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxInputFirstName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxInputLastName = new System.Windows.Forms.TextBox();
            this.labelLogOut = new System.Windows.Forms.Label();
            this.textBoxSearchCoachWord = new System.Windows.Forms.TextBox();
            this.labelSearchCoach = new System.Windows.Forms.Label();
            this.labelAddNewCoach = new System.Windows.Forms.Label();
            this.buttonModifyCheckedRow = new System.Windows.Forms.Button();
            this.buttonAddModify = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonDeleteChosenRow = new System.Windows.Forms.Button();
            this.inventoryDBDataSet6 = new RythmicQuebecInventory.InventoryDBDataSet6();
            this.coachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coachTableAdapter = new RythmicQuebecInventory.InventoryDBDataSet6TableAdapters.CoachTableAdapter();
            this.dataGridViewCoaches = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectCoach = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.iDCoachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxAddCoach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDBDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoaches)).BeginInit();
            this.SuspendLayout();
            // 
            // labelViewAddCoach
            // 
            this.labelViewAddCoach.AutoSize = true;
            this.labelViewAddCoach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelViewAddCoach.Location = new System.Drawing.Point(50, 30);
            this.labelViewAddCoach.Name = "labelViewAddCoach";
            this.labelViewAddCoach.Size = new System.Drawing.Size(445, 22);
            this.labelViewAddCoach.TabIndex = 0;
            this.labelViewAddCoach.Text = "VOIR / MODIFIER / AJOUTER UN ENTRAÎNEUR";
            // 
            // groupBoxAddCoach
            // 
            this.groupBoxAddCoach.BackColor = System.Drawing.Color.White;
            this.groupBoxAddCoach.Controls.Add(this.dataGridViewCoaches);
            this.groupBoxAddCoach.Controls.Add(this.buttonModifyCheckedRow);
            this.groupBoxAddCoach.Controls.Add(this.buttonAddModify);
            this.groupBoxAddCoach.Controls.Add(this.buttonCancel);
            this.groupBoxAddCoach.Controls.Add(this.buttonDeleteChosenRow);
            this.groupBoxAddCoach.Controls.Add(this.labelAddNewCoach);
            this.groupBoxAddCoach.Controls.Add(this.labelAddress);
            this.groupBoxAddCoach.Controls.Add(this.textBoxInputAddress);
            this.groupBoxAddCoach.Controls.Add(this.labelPhone);
            this.groupBoxAddCoach.Controls.Add(this.textBoxInputPhoneNo);
            this.groupBoxAddCoach.Controls.Add(this.labelEmail);
            this.groupBoxAddCoach.Controls.Add(this.textBoxInputEmail);
            this.groupBoxAddCoach.Controls.Add(this.labelFirstName);
            this.groupBoxAddCoach.Controls.Add(this.textBoxInputFirstName);
            this.groupBoxAddCoach.Controls.Add(this.labelLastName);
            this.groupBoxAddCoach.Controls.Add(this.textBoxInputLastName);
            this.groupBoxAddCoach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBoxAddCoach.Location = new System.Drawing.Point(150, 140);
            this.groupBoxAddCoach.Name = "groupBoxAddCoach";
            this.groupBoxAddCoach.Size = new System.Drawing.Size(980, 449);
            this.groupBoxAddCoach.TabIndex = 5;
            this.groupBoxAddCoach.TabStop = false;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(511, 384);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(58, 16);
            this.labelAddress.TabIndex = 26;
            this.labelAddress.Text = "Adresse";
            // 
            // textBoxInputAddress
            // 
            this.textBoxInputAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInputAddress.Location = new System.Drawing.Point(513, 404);
            this.textBoxInputAddress.Name = "textBoxInputAddress";
            this.textBoxInputAddress.Size = new System.Drawing.Size(110, 22);
            this.textBoxInputAddress.TabIndex = 25;
            this.textBoxInputAddress.Text = "entrez l\'address";
            this.textBoxInputAddress.Click += new System.EventHandler(this.textBoxInputAddress_Click);
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(386, 384);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(73, 16);
            this.labelPhone.TabIndex = 24;
            this.labelPhone.Text = "Téléphone";
            // 
            // textBoxInputPhoneNo
            // 
            this.textBoxInputPhoneNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInputPhoneNo.Location = new System.Drawing.Point(388, 404);
            this.textBoxInputPhoneNo.Name = "textBoxInputPhoneNo";
            this.textBoxInputPhoneNo.Size = new System.Drawing.Size(110, 22);
            this.textBoxInputPhoneNo.TabIndex = 23;
            this.textBoxInputPhoneNo.Text = "entrez le numéro de téléphone";
            this.textBoxInputPhoneNo.Click += new System.EventHandler(this.textBox3_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(262, 384);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(41, 16);
            this.labelEmail.TabIndex = 22;
            this.labelEmail.Text = "Email";
            // 
            // textBoxInputEmail
            // 
            this.textBoxInputEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInputEmail.Location = new System.Drawing.Point(264, 404);
            this.textBoxInputEmail.Name = "textBoxInputEmail";
            this.textBoxInputEmail.Size = new System.Drawing.Size(110, 22);
            this.textBoxInputEmail.TabIndex = 21;
            this.textBoxInputEmail.Text = "entrez l\'email";
            this.textBoxInputEmail.Click += new System.EventHandler(this.textBoxInputEmail_Click);
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(141, 384);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(54, 16);
            this.labelFirstName.TabIndex = 20;
            this.labelFirstName.Text = "Prénom";
            // 
            // textBoxInputFirstName
            // 
            this.textBoxInputFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInputFirstName.Location = new System.Drawing.Point(143, 404);
            this.textBoxInputFirstName.Name = "textBoxInputFirstName";
            this.textBoxInputFirstName.Size = new System.Drawing.Size(110, 22);
            this.textBoxInputFirstName.TabIndex = 19;
            this.textBoxInputFirstName.Text = "entrez le prenom";
            this.textBoxInputFirstName.Click += new System.EventHandler(this.textBoxInputFirstName_Click);
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(20, 384);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(97, 16);
            this.labelLastName.TabIndex = 18;
            this.labelLastName.Text = "Nom de famille";
            // 
            // textBoxInputLastName
            // 
            this.textBoxInputLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInputLastName.Location = new System.Drawing.Point(22, 404);
            this.textBoxInputLastName.Name = "textBoxInputLastName";
            this.textBoxInputLastName.Size = new System.Drawing.Size(110, 22);
            this.textBoxInputLastName.TabIndex = 17;
            this.textBoxInputLastName.Text = "entrez le nom";
            this.textBoxInputLastName.Click += new System.EventHandler(this.textBoxInputLastName_Click);
            // 
            // labelLogOut
            // 
            this.labelLogOut.AutoSize = true;
            this.labelLogOut.BackColor = System.Drawing.Color.Black;
            this.labelLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogOut.ForeColor = System.Drawing.Color.Silver;
            this.labelLogOut.Location = new System.Drawing.Point(952, 33);
            this.labelLogOut.Name = "labelLogOut";
            this.labelLogOut.Size = new System.Drawing.Size(182, 25);
            this.labelLogOut.TabIndex = 17;
            this.labelLogOut.Text = "DÉCONNECTER ";
            this.labelLogOut.Click += new System.EventHandler(this.labelLogOut_Click);
            // 
            // textBoxSearchCoachWord
            // 
            this.textBoxSearchCoachWord.Location = new System.Drawing.Point(867, 114);
            this.textBoxSearchCoachWord.Name = "textBoxSearchCoachWord";
            this.textBoxSearchCoachWord.Size = new System.Drawing.Size(176, 22);
            this.textBoxSearchCoachWord.TabIndex = 4;
            // 
            // labelSearchCoach
            // 
            this.labelSearchCoach.AutoSize = true;
            this.labelSearchCoach.Location = new System.Drawing.Point(1047, 118);
            this.labelSearchCoach.Name = "labelSearchCoach";
            this.labelSearchCoach.Size = new System.Drawing.Size(83, 16);
            this.labelSearchCoach.TabIndex = 3;
            this.labelSearchCoach.Text = "CHERCHER";
            this.labelSearchCoach.Click += new System.EventHandler(this.labelSearchCoach_Click);
            // 
            // labelAddNewCoach
            // 
            this.labelAddNewCoach.AutoSize = true;
            this.labelAddNewCoach.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddNewCoach.Location = new System.Drawing.Point(20, 363);
            this.labelAddNewCoach.Name = "labelAddNewCoach";
            this.labelAddNewCoach.Size = new System.Drawing.Size(250, 16);
            this.labelAddNewCoach.TabIndex = 31;
            this.labelAddNewCoach.Text = "AJOUTER NOUVEL ENTRAÎNEUR:\r\n";
            // 
            // buttonModifyCheckedRow
            // 
            this.buttonModifyCheckedRow.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifyCheckedRow.Location = new System.Drawing.Point(668, 321);
            this.buttonModifyCheckedRow.Name = "buttonModifyCheckedRow";
            this.buttonModifyCheckedRow.Size = new System.Drawing.Size(139, 43);
            this.buttonModifyCheckedRow.TabIndex = 35;
            this.buttonModifyCheckedRow.Text = "MODIFIER LIGNE CHOISIR";
            this.buttonModifyCheckedRow.UseCompatibleTextRendering = true;
            this.buttonModifyCheckedRow.UseVisualStyleBackColor = true;
            this.buttonModifyCheckedRow.Click += new System.EventHandler(this.buttonModifyCheckedRow_Click);
            // 
            // buttonAddModify
            // 
            this.buttonAddModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddModify.Location = new System.Drawing.Point(629, 399);
            this.buttonAddModify.Name = "buttonAddModify";
            this.buttonAddModify.Size = new System.Drawing.Size(133, 30);
            this.buttonAddModify.TabIndex = 34;
            this.buttonAddModify.Text = "AJOUTER \r\n";
            this.buttonAddModify.UseCompatibleTextRendering = true;
            this.buttonAddModify.UseVisualStyleBackColor = true;
            this.buttonAddModify.Click += new System.EventHandler(this.buttonAddModify_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(831, 399);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(133, 30);
            this.buttonCancel.TabIndex = 33;
            this.buttonCancel.Text = "ANNULER";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonDeleteChosenRow
            // 
            this.buttonDeleteChosenRow.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteChosenRow.Location = new System.Drawing.Point(831, 321);
            this.buttonDeleteChosenRow.Name = "buttonDeleteChosenRow";
            this.buttonDeleteChosenRow.Size = new System.Drawing.Size(133, 43);
            this.buttonDeleteChosenRow.TabIndex = 32;
            this.buttonDeleteChosenRow.Text = "SUPPRIMER LIGNE CHOISIR";
            this.buttonDeleteChosenRow.UseCompatibleTextRendering = true;
            this.buttonDeleteChosenRow.UseVisualStyleBackColor = true;
            this.buttonDeleteChosenRow.Click += new System.EventHandler(this.buttonDeleteChosenRow_Click);
            // 
            // inventoryDBDataSet6
            // 
            this.inventoryDBDataSet6.DataSetName = "InventoryDBDataSet6";
            this.inventoryDBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coachBindingSource
            // 
            this.coachBindingSource.DataMember = "Coach";
            this.coachBindingSource.DataSource = this.inventoryDBDataSet6;
            // 
            // coachTableAdapter
            // 
            this.coachTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewCoaches
            // 
            this.dataGridViewCoaches.AutoGenerateColumns = false;
            this.dataGridViewCoaches.BackgroundColor = System.Drawing.Color.Cyan;
            this.dataGridViewCoaches.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCoaches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCoaches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectCoach,
            this.iDCoachDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dataGridViewCoaches.DataSource = this.coachBindingSource;
            this.dataGridViewCoaches.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewCoaches.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewCoaches.Name = "dataGridViewCoaches";
            this.dataGridViewCoaches.RowHeadersWidth = 51;
            this.dataGridViewCoaches.RowTemplate.Height = 24;
            this.dataGridViewCoaches.Size = new System.Drawing.Size(972, 314);
            this.dataGridViewCoaches.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(669, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "ENTREZ LE NOM DE FAMILLE";
            // 
            // SelectCoach
            // 
            this.SelectCoach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SelectCoach.HeaderText = "Choisir";
            this.SelectCoach.MinimumWidth = 6;
            this.SelectCoach.Name = "SelectCoach";
            this.SelectCoach.Width = 54;
            // 
            // iDCoachDataGridViewTextBoxColumn
            // 
            this.iDCoachDataGridViewTextBoxColumn.DataPropertyName = "ID_Coach";
            this.iDCoachDataGridViewTextBoxColumn.HeaderText = "ID_Coach";
            this.iDCoachDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDCoachDataGridViewTextBoxColumn.Name = "iDCoachDataGridViewTextBoxColumn";
            this.iDCoachDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDCoachDataGridViewTextBoxColumn.Width = 70;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "Last_Name";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Nom de famille";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 116;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First_Name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "Prénom";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 83;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Phone_Number";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Numéro de téléphone";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 152;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 87;
            // 
            // Form9ViewAddModifyCoach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelLogOut);
            this.Controls.Add(this.groupBoxAddCoach);
            this.Controls.Add(this.textBoxSearchCoachWord);
            this.Controls.Add(this.labelSearchCoach);
            this.Controls.Add(this.labelViewAddCoach);
            this.ForeColor = System.Drawing.Color.Silver;
            this.Name = "Form9ViewAddModifyCoach";
            this.Text = "VOIR / MODIFIER / AJOUTER UN ENTRAÎNEUR";
            this.Load += new System.EventHandler(this.Form9ViewAddModifyCoach_Load);
            this.groupBoxAddCoach.ResumeLayout(false);
            this.groupBoxAddCoach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDBDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoaches)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelViewAddCoach;
        private System.Windows.Forms.GroupBox groupBoxAddCoach;
        private System.Windows.Forms.Label labelLogOut;
        private System.Windows.Forms.TextBox textBoxSearchCoachWord;
        private System.Windows.Forms.Label labelSearchCoach;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxInputLastName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxInputAddress;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxInputPhoneNo;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxInputEmail;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxInputFirstName;
        private System.Windows.Forms.Button buttonModifyCheckedRow;
        private System.Windows.Forms.Button buttonAddModify;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonDeleteChosenRow;
        private System.Windows.Forms.Label labelAddNewCoach;
        private InventoryDBDataSet6 inventoryDBDataSet6;
        private System.Windows.Forms.BindingSource coachBindingSource;
        private InventoryDBDataSet6TableAdapters.CoachTableAdapter coachTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewCoaches;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelectCoach;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCoachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
    }
}