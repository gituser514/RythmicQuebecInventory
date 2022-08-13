using RythmicQuebecInventory.GUI;
using System;
using System.Windows.Forms;

namespace RythmicQuebecInventory
{
    public partial class Form11CreatQRCode : Form
    {
        public Form11CreatQRCode()
        {
            InitializeComponent();
            //insertComboItems();

        }

        private void selectBoxies_TextChanged(object sender, EventArgs e)
        {

        }

        private void creatQRCode_Load(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Form5AdminOptions f5 = new Form5AdminOptions();
            this.Close();
            f5.Show();
        }

        private void labelLogOut_Click(object sender, EventArgs e)
        {
            Form2MAppWindow f2 = new Form2MAppWindow();
            this.Close();
            f2.Show();
        }
    }
}
