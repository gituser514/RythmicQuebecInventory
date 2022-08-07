using System;
using System.Windows.Forms;

namespace RythmicQuebecInventory
{
    public partial class Form10ViewAddModifyBoxes : Form
    {
        public Form10ViewAddModifyBoxes()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form10ViewAddModifyBoxes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryDBDataSet1.Box' table. You can move, or remove it, as needed.
            this.boxTableAdapter.Fill(this.inventoryDBDataSet1.Box);

        }

        private void dataGridViewBoxes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
