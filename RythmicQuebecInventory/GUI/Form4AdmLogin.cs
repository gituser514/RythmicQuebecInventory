using RythmicQuebecInventory.GUI;
using System;
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

        private void userName_TextChanged(object sender, EventArgs e)
        {
            
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
                Form5AdminOptions f5 = new Form5AdminOptions();
                f5.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password!");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Form2MAppWindow f2 = new Form2MAppWindow();
            this.Close();
            f2.Show();
        }

        private void passWord_TextChanged(object sender, EventArgs e)
        {

        }

        private void userName_Click(object sender, EventArgs e)
        {
            if (userName.Text == "Username")
            {
                userName.Text = "";
            }
                
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
