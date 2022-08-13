using RythmicQuebecInventory.GUI;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RythmicQuebecInventory
{
    public partial class Form10ViewAddModifyBoxes : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=laptop-qtecafmk;Initial Catalog=InventoryDB;Integrated Security=True");



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

       /* private void dataGridViewBoxes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewBoxes.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                textBoxInputBoxNo.Text = dataGridViewBoxes.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            textBoxInputBoxDescription.Text = dataGridViewBoxes.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxInputBoxLocation.Text = dataGridViewBoxes.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxInputIsQRCodeCreated.Text = dataGridViewBoxes.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxInputTotalItems.Text = dataGridViewBoxes.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBoxInputAvailableItems.Text = dataGridViewBoxes.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
       */


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Form5AdminOptions f5 = new Form5AdminOptions();
            this.Close();
            f5.ShowDialog();
        }

        private void labelLogOut_Click(object sender, EventArgs e)
        {
            Form2MAppWindow f2 = new Form2MAppWindow();
            this.Close();
            f2.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            con.Open();



            foreach (DataGridViewRow row in dataGridViewBoxes.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {

                    string strsql = "DELETE FROM Box WHERE Box_No = " + Convert.ToString(row.Cells[1].Value);
                    dataGridViewBoxes.Rows.Remove(row);

                    SqlCommand cmd = new SqlCommand(strsql, con);



                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Item was deleted");
                    else
                        MessageBox.Show("Item was NOT deleted");
                    con.Close();

                }
            }
        }

        private void groupBoxAddModifyBox_Enter(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = con.CreateCommand();

            command.Parameters.AddWithValue("@Box_No", int.Parse(textBoxInputBoxNo.Text));
            command.Parameters.AddWithValue("@Description", textBoxInputBoxDescription.Text);

            command.Parameters.AddWithValue("@Location", textBoxInputBoxLocation.Text);
            command.Parameters.AddWithValue("@Is_QRCode_Created", textBoxInputIsQRCodeCreated.Text);
            command.Parameters.AddWithValue("@Total_Items", textBoxInputTotalItems.Text);
            command.Parameters.AddWithValue("@Available_Items", textBoxInputAvailableItems.Text);

            command.CommandText = "INSERT INTO Box (Box_No,Description,Location,Is_QRCode_Created,Total_Items,Available_Items)" +
                " VALUES (@Box_NO,@Description,@Location,@Is_QRCode_Created,@Total_Items,Available_Items)";

            if (command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Entry was added");
            }
            else
                MessageBox.Show("Entry was NOT added");
            con.Close();

            this.boxTableAdapter.Fill(this.inventoryDBDataSet1.Box);


        }

        private void buttonModifyCheckedRow_Click(object sender, EventArgs e)
        {
            con.Open();

            foreach (DataGridViewRow row in dataGridViewBoxes.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {


                    string strsql = "UPDATE Box SET Box_Nom ='" + Convert.ToString(row.Cells[1].Value) + "', Description ='" + Convert.ToString(row.Cells[2].Value) + "',Location ='" + Convert.ToString(row.Cells[3].Value) + "',Is_QRCode_Created='" + Convert.ToString(row.Cells[5].Value) + "',Total_Items='" + Convert.ToString(row.Cells[6].Value) + "', WHERE Box_No = " +
                        Convert.ToString(row.Cells[1].Value);


                    SqlCommand cmd = new SqlCommand(strsql, con);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Entry was updated");
                    }
                    else
                        MessageBox.Show("Entry was NOT updated");
                    con.Close();

                }
            }
            this.boxTableAdapter.Fill(this.inventoryDBDataSet1.Box);

        }

        private void buttonDeleteChosenRow_Click(object sender, EventArgs e)
        {
            con.Open();



            foreach (DataGridViewRow row in dataGridViewBoxes.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {

                    string strsql = "DELETE FROM Box WHERE Box_No = " + Convert.ToString(row.Cells[1].Value);
                    dataGridViewBoxes.Rows.Remove(row);

                    SqlCommand cmd = new SqlCommand(strsql, con);



                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Item was deleted");
                    else
                        MessageBox.Show("Item was NOT deleted");
                    con.Close();

                }
            }
        }

        private void textBoxInputBoxNo_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxInputBoxNo.Text = "";
        }

        private void textBoxInputBoxDescription_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxInputBoxDescription.Text = "";
        }

        private void textBoxInputBoxLocation_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxInputBoxLocation.Text = "";
        }

        private void textBoxInputIsQRCodeCreated_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxInputIsQRCodeCreated.Text = "";
        }

        private void textBoxInputTotalItems_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxInputTotalItems.Text = "";
        }

        private void textBoxInputAvailableItems_TextChanged(object sender, EventArgs e)
        {
            textBoxInputAvailableItems.Text = "";
        }

        private void labelSearchBox_Click(object sender, EventArgs e)
        {
            string strsql = "SELECT * FROM Box WHERE Box_No = @Box_No";

            con.Open();
            SqlCommand cmd = new SqlCommand(strsql, con);
            cmd.Parameters.AddWithValue("@Box_No", int.Parse(textBoxInputBoxNo.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewBoxes.DataSource = ds.Tables[0];

            con.Close();
        }
    }
}
