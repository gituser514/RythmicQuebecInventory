﻿using System;
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

        }

        private void userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void admAccessClick_Click(object sender, EventArgs e)
        {
            string username = userName.Text;

            string password = passWord.Text;

            if (!("Yelena".Equals(username) && "123456".Equals(password)))
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

        }
    }
}
