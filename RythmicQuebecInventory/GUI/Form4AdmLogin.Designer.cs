namespace RythmicQuebecInventory
{
    partial class Form4AdmLogin
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
            this.labelLoginPage = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.passWord = new System.Windows.Forms.TextBox();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLoginPage
            // 
            this.labelLoginPage.AutoSize = true;
            this.labelLoginPage.BackColor = System.Drawing.Color.Black;
            this.labelLoginPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginPage.ForeColor = System.Drawing.Color.Silver;
            this.labelLoginPage.Location = new System.Drawing.Point(165, 90);
            this.labelLoginPage.Name = "labelLoginPage";
            this.labelLoginPage.Size = new System.Drawing.Size(220, 22);
            this.labelLoginPage.TabIndex = 0;
            this.labelLoginPage.Text = "PAGE DE CONNEXION";
            // 
            // userName
            // 
            this.userName.BackColor = System.Drawing.Color.White;
            this.userName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.ForeColor = System.Drawing.Color.Gray;
            this.userName.Location = new System.Drawing.Point(169, 150);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(190, 27);
            this.userName.TabIndex = 2;
            this.userName.Text = "Username";
            this.userName.TextChanged += new System.EventHandler(this.userName_TextChanged);
            // 
            // passWord
            // 
            this.passWord.BackColor = System.Drawing.Color.White;
            this.passWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passWord.ForeColor = System.Drawing.Color.Gray;
            this.passWord.Location = new System.Drawing.Point(169, 184);
            this.passWord.Name = "passWord";
            this.passWord.Size = new System.Drawing.Size(190, 27);
            this.passWord.TabIndex = 0;
            this.passWord.Text = "Password";
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogIn.ForeColor = System.Drawing.Color.Gray;
            this.buttonLogIn.Location = new System.Drawing.Point(219, 250);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(135, 35);
            this.buttonLogIn.TabIndex = 0;
            this.buttonLogIn.Text = "CONNEXION";
            this.buttonLogIn.UseVisualStyleBackColor = true;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // Form4AdmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1099, 582);
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.passWord);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.labelLoginPage);
            this.ForeColor = System.Drawing.Color.Silver;
            this.Name = "Form4AdmLogin";
            this.Text = "PAGE DE CONNEXION";
            this.Load += new System.EventHandler(this.admLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLoginPage;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox passWord;
        private System.Windows.Forms.Button buttonLogIn;
    }
}