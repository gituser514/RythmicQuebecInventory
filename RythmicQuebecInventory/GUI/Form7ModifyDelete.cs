using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RythmicQuebecInventory
{
    public partial class Form7ModifyDelete : Form
    {
        // connection string 

        SqlConnection con = new SqlConnection(@"Data Source=laptop-qtecafmk;Initial Catalog=InventoryDB;Integrated Security=True");

        List<String> selectedRow = new List<string>();


        public Form7ModifyDelete()
        {
            InitializeComponent();
        }

        private void Form7ModifyDelete_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryDBDataSet5.View' table. You can move, or remove it, as needed.
            this.viewTableAdapter.Fill(this.inventoryDBDataSet5.View);

        }

        private void dataGridViewViewSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewModifyDelete.CurrentRow.Selected = true;



        }

        private void dataGridViewViewSearch_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void buttonModify_Click(object sender, System.EventArgs e)
        {
            string selectedItemID = null;

            // single out the item id to pass to form 8 

            foreach (DataGridViewRow row in dataGridViewModifyDelete.Rows)
            {
                //if(Convert.ToBoolean(row.Cells[0].Value))
                if(row.Cells[0].Selected)
                {
                    //selectedItemID =  (string)row.Cells[2].Value;
                    selectedItemID = Convert.ToString(row.Cells[2].Value);
                    //foreach (DataGridViewCell cell in row.Cells)
                    //{
                    //    selectedRow.Add((string)cell.Value);
                    //}
                    
                   // for (int i = 1; i < row.Cells.Count; i++)
                   // {
                   //     selectedRow.Add((string)row.Cells[i].Value);
                   // }
                }
            }

            // open Form8

            Form8ModifyItem form8ModifyItem = new Form8ModifyItem();
            form8ModifyItem.receiveData(selectedItemID);
           // form8ModifyItem.receiveData(selectedRow);

            form8ModifyItem.ShowDialog();


        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dataGridViewModifyDelete.Rows)
            {
                if (row.Cells[0].Selected)
                {
                    string sqlDelete = "DELETE FROM Inventory WHERE Item_ID = " + row.Cells[2].Value;
                    dataGridViewModifyDelete.Rows.Remove(row);
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sqlDelete, con);

                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Item was deleted");
                    else
                        MessageBox.Show("Item ws NOT deleted");
                    con.Close();

                }
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
