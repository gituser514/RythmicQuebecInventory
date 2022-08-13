using RythmicQuebecInventory.GUI;
using System.Windows.Forms;

namespace RythmicQuebecInventory
{
    public partial class Form12BackupDatabese : Form
    {
        public Form12BackupDatabese()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }

        private void labelLogOut_Click(object sender, System.EventArgs e)
        {
            Form2MAppWindow f2 = new Form2MAppWindow();
            this.Close();
            f2.Show();
        }

        private void buttonCancel_Click(object sender, System.EventArgs e)
        {
            Form5AdminOptions f5 = new Form5AdminOptions();
            this.Close();
            f5.Show();
        }
    }
}
