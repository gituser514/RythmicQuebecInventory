﻿using System;
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
    public partial class admLogin : Form
    {
        public admLogin()
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
    }
}