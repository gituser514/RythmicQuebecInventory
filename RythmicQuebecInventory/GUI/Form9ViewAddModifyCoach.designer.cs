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
            this.buttonAddModify = new System.Windows.Forms.Button();
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridViewCoaches = new System.Windows.Forms.DataGridView();
            this.coachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryDBDataSet = new RythmicQuebecInventory.InventoryDBDataSet();
            this.labelLogOut = new System.Windows.Forms.Label();
            this.textBoxSearchCoachWord = new System.Windows.Forms.TextBox();
            this.labelSearchCoach = new System.Windows.Forms.Label();
            this.coachTableAdapter = new RythmicQuebecInventory.InventoryDBDataSetTableAdapters.CoachTableAdapter();
            this.buttonModifyCheckedRow = new System.Windows.Forms.Button();
            this.SelectCoach = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.iDCoachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxAddCoach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoaches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDBDataSet)).BeginInit();
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
            this.groupBoxAddCoach.Controls.Add(this.label2);
            this.groupBoxAddCoach.Controls.Add(this.label1);
            this.groupBoxAddCoach.Controls.Add(this.buttonModifyCheckedRow);
            this.groupBoxAddCoach.Controls.Add(this.buttonAddModify);
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
            this.groupBoxAddCoach.Controls.Add(this.buttonCancel);
            this.groupBoxAddCoach.Controls.Add(this.buttonDelete);
            this.groupBoxAddCoach.Controls.Add(this.dataGridViewCoaches);
            this.groupBoxAddCoach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBoxAddCoach.Location = new System.Drawing.Point(100, 140);
            this.groupBoxAddCoach.Name = "groupBoxAddCoach";
            this.groupBoxAddCoach.Size = new System.Drawing.Size(1080, 449);
            this.groupBoxAddCoach.TabIndex = 5;
            this.groupBoxAddCoach.TabStop = false;
            // 
            // buttonAddModify
            // 
            this.buttonAddModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddModify.Location = new System.Drawing.Point(720, 399);
            this.buttonAddModify.Name = "buttonAddModify";
            this.buttonAddModify.Size = new System.Drawing.Size(133, 30);
            this.buttonAddModify.TabIndex = 27;
            this.buttonAddModify.Text = "AJOUTER \r\n";
            this.buttonAddModify.UseCompatibleTextRendering = true;
            this.buttonAddModify.UseVisualStyleBackColor = true;
            this.buttonAddModify.Click += new System.EventHandler(this.buttonAddModify_Click);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(574, 392);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(58, 16);
            this.labelAddress.TabIndex = 26;
            this.labelAddress.Text = "Address";
            this.labelAddress.Click += new System.EventHandler(this.labelAddress_Click);
            // 
            // textBoxInputAddress
            // 
            this.textBoxInputAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInputAddress.Location = new System.Drawing.Point(576, 412);
            this.textBoxInputAddress.Name = "textBoxInputAddress";
            this.textBoxInputAddress.Size = new System.Drawing.Size(110, 22);
            this.textBoxInputAddress.TabIndex = 25;
            this.textBoxInputAddress.Text = "entrez l\'addresse";
            this.textBoxInputAddress.Click += new System.EventHandler(this.textBoxInputAddress_Click);
            this.textBoxInputAddress.TextChanged += new System.EventHandler(this.textBoxInputAddress_TextChanged);
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(449, 392);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(73, 16);
            this.labelPhone.TabIndex = 24;
            this.labelPhone.Text = "Téléphone";
            this.labelPhone.Click += new System.EventHandler(this.labelPhone_Click);
            // 
            // textBoxInputPhoneNo
            // 
            this.textBoxInputPhoneNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInputPhoneNo.Location = new System.Drawing.Point(451, 412);
            this.textBoxInputPhoneNo.Name = "textBoxInputPhoneNo";
            this.textBoxInputPhoneNo.Size = new System.Drawing.Size(110, 22);
            this.textBoxInputPhoneNo.TabIndex = 23;
            this.textBoxInputPhoneNo.Text = "entrez le numero";
            this.textBoxInputPhoneNo.Click += new System.EventHandler(this.textBoxInputPhoneNo_Click);
            this.textBoxInputPhoneNo.TextChanged += new System.EventHandler(this.textBoxInputPhoneNo_TextChanged);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(325, 392);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(41, 16);
            this.labelEmail.TabIndex = 22;
            this.labelEmail.Text = "Email";
            this.labelEmail.Click += new System.EventHandler(this.labelEmail_Click);
            // 
            // textBoxInputEmail
            // 
            this.textBoxInputEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInputEmail.Location = new System.Drawing.Point(327, 412);
            this.textBoxInputEmail.Name = "textBoxInputEmail";
            this.textBoxInputEmail.Size = new System.Drawing.Size(110, 22);
            this.textBoxInputEmail.TabIndex = 21;
            this.textBoxInputEmail.Text = "entrez l\'email";
            this.textBoxInputEmail.Click += new System.EventHandler(this.textBoxInputEmail_Click);
            this.textBoxInputEmail.TextChanged += new System.EventHandler(this.textBoxInputEmail_TextChanged);
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(204, 392);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(54, 16);
            this.labelFirstName.TabIndex = 20;
            this.labelFirstName.Text = "Prénom";
            this.labelFirstName.Click += new System.EventHandler(this.labelFirstName_Click);
            // 
            // textBoxInputFirstName
            // 
            this.textBoxInputFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInputFirstName.Location = new System.Drawing.Point(206, 412);
            this.textBoxInputFirstName.Name = "textBoxInputFirstName";
            this.textBoxInputFirstName.Size = new System.Drawing.Size(110, 22);
            this.textBoxInputFirstName.TabIndex = 19;
            this.textBoxInputFirstName.Text = "entrez le prenom";
            this.textBoxInputFirstName.Click += new System.EventHandler(this.textBoxInputFirstName_Click);
            this.textBoxInputFirstName.TextChanged += new System.EventHandler(this.textBoxInputFirstName_TextChanged);
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(83, 392);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(97, 16);
            this.labelLastName.TabIndex = 18;
            this.labelLastName.Text = "Nom de famille";
            this.labelLastName.Click += new System.EventHandler(this.labelLastName_Click);
            // 
            // textBoxInputLastName
            // 
            this.textBoxInputLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInputLastName.Location = new System.Drawing.Point(85, 412);
            this.textBoxInputLastName.Name = "textBoxInputLastName";
            this.textBoxInputLastName.Size = new System.Drawing.Size(110, 22);
            this.textBoxInputLastName.TabIndex = 17;
            this.textBoxInputLastName.Text = "entrez le nom";
            this.textBoxInputLastName.Click += new System.EventHandler(this.textBoxInputLastName_Click);
            this.textBoxInputLastName.TextChanged += new System.EventHandler(this.textBoxInputLastName_TextChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(883, 398);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(133, 30);
            this.buttonCancel.TabIndex = 16;
            this.buttonCancel.Text = "ANNULER";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(877, 304);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(133, 43);
            this.buttonDelete.TabIndex = 15;
            this.buttonDelete.Text = "SUPPRIMER LIGNE CHOISIR";
            this.buttonDelete.UseCompatibleTextRendering = true;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
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
            this.dataGridViewCoaches.Location = new System.Drawing.Point(6, 12);
            this.dataGridViewCoaches.Name = "dataGridViewCoaches";
            this.dataGridViewCoaches.RowHeadersWidth = 51;
            this.dataGridViewCoaches.RowTemplate.Height = 24;
            this.dataGridViewCoaches.Size = new System.Drawing.Size(1070, 286);
            this.dataGridViewCoaches.TabIndex = 1;
            this.dataGridViewCoaches.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // coachBindingSource
            // 
            this.coachBindingSource.DataMember = "Coach";
            this.coachBindingSource.DataSource = this.inventoryDBDataSet;
            // 
            // inventoryDBDataSet
            // 
            this.inventoryDBDataSet.DataSetName = "InventoryDBDataSet";
            this.inventoryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.textBoxSearchCoachWord.Location = new System.Drawing.Point(859, 112);
            this.textBoxSearchCoachWord.Name = "textBoxSearchCoachWord";
            this.textBoxSearchCoachWord.Size = new System.Drawing.Size(176, 22);
            this.textBoxSearchCoachWord.TabIndex = 4;
            this.textBoxSearchCoachWord.TextChanged += new System.EventHandler(this.textBoxSearchCoachWord_TextChanged);
            this.textBoxSearchCoachWord.Enter += new System.EventHandler(this.textBoxSearchCoachWord_Enter);
            // 
            // labelSearchCoach
            // 
            this.labelSearchCoach.AutoSize = true;
            this.labelSearchCoach.Location = new System.Drawing.Point(1041, 112);
            this.labelSearchCoach.Name = "labelSearchCoach";
            this.labelSearchCoach.Size = new System.Drawing.Size(83, 16);
            this.labelSearchCoach.TabIndex = 3;
            this.labelSearchCoach.Text = "CHERCHER";
            this.labelSearchCoach.Click += new System.EventHandler(this.labelSearchCoach_Click);
            // 
            // coachTableAdapter
            // 
            this.coachTableAdapter.ClearBeforeFill = true;
            // 
            // buttonModifyCheckedRow
            // 
            this.buttonModifyCheckedRow.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifyCheckedRow.Location = new System.Drawing.Point(714, 304);
            this.buttonModifyCheckedRow.Name = "buttonModifyCheckedRow";
            this.buttonModifyCheckedRow.Size = new System.Drawing.Size(139, 43);
            this.buttonModifyCheckedRow.TabIndex = 28;
            this.buttonModifyCheckedRow.Text = "MODIFIER LINGNE CHOISIR";
            this.buttonModifyCheckedRow.UseCompatibleTextRendering = true;
            this.buttonModifyCheckedRow.UseVisualStyleBackColor = true;
            this.buttonModifyCheckedRow.Click += new System.EventHandler(this.buttonModifyCheckedRow_Click);
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
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "AJOUTER NOUVEL ENTRAÎNEUR:\r\n";
            // 
            // Form9ViewAddModifyCoach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1262, 673);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoaches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelViewAddCoach;
        private System.Windows.Forms.GroupBox groupBoxAddCoach;
        private System.Windows.Forms.DataGridView dataGridViewCoaches;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonDelete;
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
        private System.Windows.Forms.Button buttonAddModify;
        private InventoryDBDataSet inventoryDBDataSet;
        private System.Windows.Forms.BindingSource coachBindingSource;
        private InventoryDBDataSetTableAdapters.CoachTableAdapter coachTableAdapter;
        private System.Windows.Forms.Button buttonModifyCheckedRow;
        private System.Windows.Forms.Label label2;
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