namespace RythmicQuebecInventory
{
    partial class Form2MAppWindow
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
            this.AdmAccess = new System.Windows.Forms.Label();
            this.labelMainWindow = new System.Windows.Forms.Label();
            this.buttonViewAndSch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAdminAccess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AdmAccess
            // 
            this.AdmAccess.AutoSize = true;
            this.AdmAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdmAccess.ForeColor = System.Drawing.Color.Silver;
            this.AdmAccess.Location = new System.Drawing.Point(998, 35);
            this.AdmAccess.Name = "AdmAccess";
            this.AdmAccess.Size = new System.Drawing.Size(0, 25);
            this.AdmAccess.TabIndex = 1;
            this.AdmAccess.Click += new System.EventHandler(this.AdmAccess_Click);
            // 
            // labelMainWindow
            // 
            this.labelMainWindow.AutoSize = true;
            this.labelMainWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainWindow.ForeColor = System.Drawing.Color.Silver;
            this.labelMainWindow.Location = new System.Drawing.Point(169, 90);
            this.labelMainWindow.Name = "labelMainWindow";
            this.labelMainWindow.Size = new System.Drawing.Size(461, 28);
            this.labelMainWindow.TabIndex = 2;
            this.labelMainWindow.Text = "PAGE PRINCIPALE DE L\'APPLICATION";
            this.labelMainWindow.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonViewAndSch
            // 
            this.buttonViewAndSch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewAndSch.Location = new System.Drawing.Point(169, 150);
            this.buttonViewAndSch.Name = "buttonViewAndSch";
            this.buttonViewAndSch.Size = new System.Drawing.Size(250, 50);
            this.buttonViewAndSch.TabIndex = 3;
            this.buttonViewAndSch.Text = "VOIR ET RECHERCHER";
            this.buttonViewAndSch.UseVisualStyleBackColor = true;
            this.buttonViewAndSch.Click += new System.EventHandler(this.buttonViewAndSch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(925, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // labelAdminAccess
            // 
            this.labelAdminAccess.AutoSize = true;
            this.labelAdminAccess.BackColor = System.Drawing.Color.Black;
            this.labelAdminAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminAccess.ForeColor = System.Drawing.Color.Silver;
            this.labelAdminAccess.Location = new System.Drawing.Point(937, 35);
            this.labelAdminAccess.Name = "labelAdminAccess";
            this.labelAdminAccess.Size = new System.Drawing.Size(284, 25);
            this.labelAdminAccess.TabIndex = 6;
            this.labelAdminAccess.Text = "ACCÈS ADMINISTRATEUR";
            this.labelAdminAccess.Click += new System.EventHandler(this.labelAdminAccess_Click);
            // 
            // Form2MAppWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.labelAdminAccess);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonViewAndSch);
            this.Controls.Add(this.labelMainWindow);
            this.Controls.Add(this.AdmAccess);
            this.Name = "Form2MAppWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Main Application Window";
            this.Load += new System.EventHandler(this.MAppWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label AdmAccess;
        private System.Windows.Forms.Label labelMainWindow;
        private System.Windows.Forms.Button buttonViewAndSch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAdminAccess;
    }
}