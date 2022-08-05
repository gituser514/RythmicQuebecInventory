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
            this.labelViewAddCoach = new System.Windows.Forms.Label();
            this.groupBoxAddCoach = new System.Windows.Forms.GroupBox();
            this.buttonAddModify = new System.Windows.Forms.Button();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxInputEmail = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxInputFirstName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxInputLastName = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridViewCoaches = new System.Windows.Forms.DataGridView();
            this.labelLogOut = new System.Windows.Forms.Label();
            this.textBoxSearchCoachWord = new System.Windows.Forms.TextBox();
            this.labelSearchCoach = new System.Windows.Forms.Label();
            this.SelectCoach = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Last_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.First_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxAddCoach.SuspendLayout();
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
            this.groupBoxAddCoach.Controls.Add(this.buttonAddModify);
            this.groupBoxAddCoach.Controls.Add(this.labelAddress);
            this.groupBoxAddCoach.Controls.Add(this.textBox4);
            this.groupBoxAddCoach.Controls.Add(this.labelPhone);
            this.groupBoxAddCoach.Controls.Add(this.textBox3);
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
            this.groupBoxAddCoach.Location = new System.Drawing.Point(150, 140);
            this.groupBoxAddCoach.Name = "groupBoxAddCoach";
            this.groupBoxAddCoach.Size = new System.Drawing.Size(980, 449);
            this.groupBoxAddCoach.TabIndex = 5;
            this.groupBoxAddCoach.TabStop = false;
            // 
            // buttonAddModify
            // 
            this.buttonAddModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddModify.Location = new System.Drawing.Point(668, 313);
            this.buttonAddModify.Name = "buttonAddModify";
            this.buttonAddModify.Size = new System.Drawing.Size(133, 43);
            this.buttonAddModify.TabIndex = 27;
            this.buttonAddModify.Text = "AJOUTER / MODIFIER";
            this.buttonAddModify.UseVisualStyleBackColor = true;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(510, 301);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(58, 16);
            this.labelAddress.TabIndex = 26;
            this.labelAddress.Text = "Address";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(512, 321);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(110, 22);
            this.textBox4.TabIndex = 25;
            this.textBox4.Text = "entrez l\'address";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(385, 301);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(73, 16);
            this.labelPhone.TabIndex = 24;
            this.labelPhone.Text = "Téléphone";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(387, 321);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(110, 22);
            this.textBox3.TabIndex = 23;
            this.textBox3.Text = "entrez le numéro de téléphone";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(261, 301);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(41, 16);
            this.labelEmail.TabIndex = 22;
            this.labelEmail.Text = "Email";
            // 
            // textBoxInputEmail
            // 
            this.textBoxInputEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInputEmail.Location = new System.Drawing.Point(263, 321);
            this.textBoxInputEmail.Name = "textBoxInputEmail";
            this.textBoxInputEmail.Size = new System.Drawing.Size(110, 22);
            this.textBoxInputEmail.TabIndex = 21;
            this.textBoxInputEmail.Text = "entrez l\'email";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(140, 301);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(54, 16);
            this.labelFirstName.TabIndex = 20;
            this.labelFirstName.Text = "Prénom";
            // 
            // textBoxInputFirstName
            // 
            this.textBoxInputFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInputFirstName.Location = new System.Drawing.Point(142, 321);
            this.textBoxInputFirstName.Name = "textBoxInputFirstName";
            this.textBoxInputFirstName.Size = new System.Drawing.Size(110, 22);
            this.textBoxInputFirstName.TabIndex = 19;
            this.textBoxInputFirstName.Text = "entrez le prenom";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(19, 301);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(97, 16);
            this.labelLastName.TabIndex = 18;
            this.labelLastName.Text = "Nom de famille";
            // 
            // textBoxInputLastName
            // 
            this.textBoxInputLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInputLastName.Location = new System.Drawing.Point(21, 321);
            this.textBoxInputLastName.Name = "textBoxInputLastName";
            this.textBoxInputLastName.Size = new System.Drawing.Size(110, 22);
            this.textBoxInputLastName.TabIndex = 17;
            this.textBoxInputLastName.Text = "entrez le nom";
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
            // dataGridViewCoaches
            // 
            this.dataGridViewCoaches.BackgroundColor = System.Drawing.Color.Cyan;
            this.dataGridViewCoaches.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCoaches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCoaches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectCoach,
            this.Last_Name,
            this.First_Name,
            this.Email,
            this.Phone_Number,
            this.Address});
            this.dataGridViewCoaches.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewCoaches.Location = new System.Drawing.Point(6, 12);
            this.dataGridViewCoaches.Name = "dataGridViewCoaches";
            this.dataGridViewCoaches.RowHeadersWidth = 51;
            this.dataGridViewCoaches.RowTemplate.Height = 24;
            this.dataGridViewCoaches.Size = new System.Drawing.Size(968, 286);
            this.dataGridViewCoaches.TabIndex = 1;
            this.dataGridViewCoaches.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // 
            // textBoxSearchCoachWord
            // 
            this.textBoxSearchCoachWord.Location = new System.Drawing.Point(954, 112);
            this.textBoxSearchCoachWord.Name = "textBoxSearchCoachWord";
            this.textBoxSearchCoachWord.Size = new System.Drawing.Size(176, 22);
            this.textBoxSearchCoachWord.TabIndex = 4;
            // 
            // labelSearchCoach
            // 
            this.labelSearchCoach.AutoSize = true;
            this.labelSearchCoach.Location = new System.Drawing.Point(868, 118);
            this.labelSearchCoach.Name = "labelSearchCoach";
            this.labelSearchCoach.Size = new System.Drawing.Size(83, 16);
            this.labelSearchCoach.TabIndex = 3;
            this.labelSearchCoach.Text = "CHERCHER";
            // 
            // SelectCoach
            // 
            this.SelectCoach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SelectCoach.HeaderText = "Choisir";
            this.SelectCoach.MinimumWidth = 6;
            this.SelectCoach.Name = "SelectCoach";
            this.SelectCoach.Width = 54;
            // 
            // Last_Name
            // 
            this.Last_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Last_Name.HeaderText = "Nom de famille";
            this.Last_Name.MinimumWidth = 6;
            this.Last_Name.Name = "Last_Name";
            this.Last_Name.Width = 116;
            // 
            // First_Name
            // 
            this.First_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.First_Name.HeaderText = "Prénom";
            this.First_Name.MinimumWidth = 6;
            this.First_Name.Name = "First_Name";
            this.First_Name.Width = 83;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 70;
            // 
            // Phone_Number
            // 
            this.Phone_Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Phone_Number.HeaderText = "Numéro de téléphone";
            this.Phone_Number.MinimumWidth = 6;
            this.Phone_Number.Name = "Phone_Number";
            this.Phone_Number.Width = 152;
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
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
            this.groupBoxAddCoach.ResumeLayout(false);
            this.groupBoxAddCoach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoaches)).EndInit();
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
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxInputEmail;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxInputFirstName;
        private System.Windows.Forms.Button buttonAddModify;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelectCoach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn First_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
    }
}