using System;
using System.Windows.Forms;

namespace RythmicQuebecInventory
{
    public partial class Form2MAppWindow : Form
    {
        public Form2MAppWindow()
        {
            InitializeComponent();
        }

        private void MAppWindow_Load(object sender, EventArgs e)
        {

        }

        private void AdmAccess_Click(object sender, EventArgs e)
        {
            Console.WriteLine("----");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void admAccessLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Run(new Form4AdmLogin());
        }

        private void buttonViewAndSch_Click(object sender, EventArgs e)
        {

        }

        private void labelAdminAccess_Click(object sender, EventArgs e)
        {

        }
    }
}
