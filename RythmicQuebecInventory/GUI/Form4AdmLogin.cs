using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RythmicQuebecInventory
{
    public partial class Form4AdmLogin : Form
    {
        public Form4AdmLogin()
        {
            InitializeComponent();
        }
        
        private void admLogin_Load(object sender, EventArgs e)
        {
            userName.Text = "Username";
        }

        private void admAccessClick_Click(object sender, EventArgs e)
        {
            string username = userName.Text;
            
            string password = passWord.Text;
            
            if (!("Yelena".Equals(username) && "vrateam".Equals(password)))
           // {
                //MessageBox.Show("");
            //}
           // else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            String username = "YelenaFangJuan";
            String password = "vrateam";

            if ((userName.Text == username) && (passWord.Text == password))
            {
                this.Hide();
                Form5AdmOptions f5 = new Form5AdmOptions();
                f5.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password!");
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void userName_Click(object sender, EventArgs e)
        {
            if (userName.Text == "Username")
            {
                userName.Text = "";
            }
        }

        private void passWord_TextChanged(object sender, EventArgs e)
        {

        }
        private void passWord_Click(object sender, EventArgs e)
        {
            if (passWord.Text == "Password")
            {
                passWord.Text = "";
            }
        }
    }
}
