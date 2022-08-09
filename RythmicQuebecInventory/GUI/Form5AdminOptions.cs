using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RythmicQuebecInventory.GUI
{
    public partial class Form5AdminOptions : Form
    {
        public Form5AdminOptions()
        {
            InitializeComponent();
        }

        private void buttonAddNewItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form6AddNewItems f6 = new Form6AddNewItems();
            f6.ShowDialog();
        }

        private void buttonModifDeleteItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7ModifyDelete f7 = new Form7ModifyDelete();
            f7.Show();
        }

        private void buttonModifCoaches_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9ViewAddModifyCoach f9 = new Form9ViewAddModifyCoach();
            f9.ShowDialog();

        }

        private void buttonModifyBoxes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10ViewAddModifyBoxes f10 = new Form10ViewAddModifyBoxes();
            f10.ShowDialog();

        }

        private void buttonCreateQRCode_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11CreatQRCode f11 = new Form11CreatQRCode();
            f11.ShowDialog();
        }

        private void buttonBackupDB_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form12BackupDatabese f12 = new Form12BackupDatabese();
            f12.ShowDialog();
        }
    }
}
