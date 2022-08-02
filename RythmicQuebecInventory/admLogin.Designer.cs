namespace RythmicQuebecInventory
{
    partial class admLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.admAccessClick = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.passWord = new System.Windows.Forms.TextBox();
            this.logInButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(169, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN PAGE";
            // 
            // admAccessClick
            // 
            this.admAccessClick.AutoSize = true;
            this.admAccessClick.BackColor = System.Drawing.Color.Black;
            this.admAccessClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admAccessClick.ForeColor = System.Drawing.Color.Silver;
            this.admAccessClick.Location = new System.Drawing.Point(1010, 30);
            this.admAccessClick.Name = "admAccessClick";
            this.admAccessClick.Size = new System.Drawing.Size(178, 25);
            this.admAccessClick.TabIndex = 1;
            this.admAccessClick.Text = "ADMIN ACCESS";
            this.admAccessClick.Click += new System.EventHandler(this.admAccessClick_Click);
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
            // logInButton
            // 
            this.logInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInButton.ForeColor = System.Drawing.Color.Gray;
            this.logInButton.Location = new System.Drawing.Point(250, 250);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(104, 35);
            this.logInButton.TabIndex = 0;
            this.logInButton.Text = "LOGIN";
            this.logInButton.UseVisualStyleBackColor = true;
            // 
            // admLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1099, 582);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.passWord);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.admAccessClick);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Silver;
            this.Name = "admLogin";
            this.Text = "admLogin";
            this.Load += new System.EventHandler(this.admLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label admAccessClick;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox passWord;
        private System.Windows.Forms.Button logInButton;
    }
}