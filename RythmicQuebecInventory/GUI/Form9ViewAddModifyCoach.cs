using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace RythmicQuebecInventory
{
    public partial class Form9ViewAddModifyCoach : Form
    {
        public Form9ViewAddModifyCoach()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Form9ViewAddModifyCoach_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryDBDataSet.Coach' table. You can move, or remove it, as needed.
            this.coachTableAdapter.Fill(this.inventoryDBDataSet.Coach);

        }

        private void buttonCancel_Click(object sender, System.EventArgs e)
        {
            Form5AdmOptions f5 = new Form5AdmOptions();
            this.Hide();
            f5.ShowDialog();
            
        }

        private void labelLogOut_Click(object sender, System.EventArgs e)
        {
            Form2MAppWindow f2 = new Form2MAppWindow();
            this.Hide();
            f2.ShowDialog();
        }

        private void textBoxSearchCoachWord_TextChanged(object sender, System.EventArgs e)
        {


        }
        private void textBoxSearchCoachWord_Enter(object sender,System.EventArgs e)

        {  
        }

     

        private void labelSearchCoach_Click(object sender, EventArgs e)
        {

            string strsql = "SELECT * FROM Coach WHERE Last_Name = @Last_Name";
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-8CMJI23P;Initial Catalog=InventoryDB;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand(strsql, conn);
            cmd.Parameters.AddWithValue("@Last_Name", textBoxSearchCoachWord.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewCoaches.DataSource = ds.Tables[0];
           /* if (cmd.ExecuteNonQuery() > 0)
                MessageBox.Show("Item was modified");
            else
                MessageBox.Show("Item was NOT modified");*/
            conn.Close();


        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-8CMJI23P;Initial Catalog=InventoryDB;Integrated Security=True");
            conn.Open(); 

            foreach (DataGridViewRow row in dataGridViewCoaches.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                   // MessageBox.Show("Item was modified");
                    //MessageBox.Show(Convert.ToString(row.Cells[2].Value));

                    string strsql = "DELETE FROM Coach WHERE ID_Coach = " + Convert.ToString(row.Cells[1].Value);
                    dataGridViewCoaches.Rows.Remove(row);
                   // MessageBox.Show(strsql);

                    SqlCommand cmd = new SqlCommand(strsql, conn);

                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Information was deleted");
                    else
                        MessageBox.Show("Information was NOT deleted");

                }
               
            }
            conn.Close();
        }

        private void textBoxInputLastName_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxInputLastName_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(textBoxInputLastName.Text);
            if (textBoxInputLastName.Text == "entrez le nom")
                textBoxInputLastName.Text = "";
        }

        private void textBoxInputFirstName_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxInputFirstName_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(textBoxInputFirstName.Text);
            if (textBoxInputFirstName.Text == "entrez le prenom")
                textBoxInputFirstName.Text = "";
        }

        private void textBoxInputEmail_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxInputEmail_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(textBoxInputEmail.Text);
            if (textBoxInputEmail.Text == "entrez l'email")
                textBoxInputEmail.Text = "";
        }

        private void textBoxInputPhoneNo_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxInputPhoneNo_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(textBoxInputPhoneNo.Text);
            if (textBoxInputPhoneNo.Text == "entrez le numero")
                textBoxInputPhoneNo.Text = "";
        }

        private void textBoxInputAddress_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxInputAddress_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(textBoxInputAddress.Text);
            if (textBoxInputAddress.Text == "entrez l'addresse")
                textBoxInputAddress.Text = "";
        }

        private void buttonAddModify_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-8CMJI23P;Initial Catalog=InventoryDB;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand command = con.CreateCommand();
           // int size_ID = returnSize(System.Convert.ToString(comboBoxSize.SelectedItem));
           // int color_ID = returnColor(System.Convert.ToString(comboBoxColor.SelectedItem));
            //int box_ID = returnBox(System.Convert.ToString(comboBoxBOXNO.SelectedItem));
           // int coach_ID = returnCoach(System.Convert.ToString(comboBoxSelectCoach.SelectedItem));
          //  int category_ID = returnCategory(System.Convert.ToString(comboBoxCategory.SelectedItem));
            command.Parameters.AddWithValue("@LastName", textBoxInputLastName.Text);
            command.Parameters.AddWithValue("@FirstName", textBoxInputFirstName.Text);
           // command.Parameters.AddWithValue("@PhoneNo", System.Convert.ToInt32(textBoxModifyQuantity.Text));
            command.Parameters.AddWithValue("@PhoneNo", textBoxInputPhoneNo.Text);
            command.Parameters.AddWithValue("@Email", textBoxInputEmail.Text);
            command.Parameters.AddWithValue("@Address", textBoxInputAddress.Text);
            /*command.Parameters.AddWithValue("@Category_ID", category_ID);
            command.Parameters.AddWithValue("@DateTaken", textBoxDateTaken.Text);
            command.Parameters.AddWithValue("@DateReturn", textBoxDateReturned.Text);
            command.Parameters.AddWithValue("@Item_ID", textBoxItemID.Text);
            command.Parameters.AddWithValue("@Coach_ID", coach_ID);*/
            //command.CommandText = "UPDATE Inventory SET Name = @Name, Description = @Description, Quantity=Quantity-@Quantity,Color_ID=@Color_ID,Size_ID=@Size_ID,Category_ID=@Category_ID,Box_ID=@Box_ID WHERE Item_ID=@Item_ID";
            command.CommandText = "INSERT INTO Coach (Last_Name,First_Name,Email,Phone_Number,Address) VALUES (@LastName,@FirstName,@Email,@PhoneNo,@Address)";
            //command.CommandText = "INSERT INTO Items_Control(Date_Taken,Date_Return,Item_ID,ID_Coach) VALUES (@DateTaken,@DateReturn,@Item_ID,@coach_ID)";
            if (command.ExecuteNonQuery() > 0)
                MessageBox.Show("Entry was added");
            else
                MessageBox.Show("Entry was NOT added");
            con.Close();
        }

        private void buttonModifyCheckedRow_Click(object sender, EventArgs e)
        {
            
                SqlConnection conn = new SqlConnection("Data Source=LAPTOP-8CMJI23P;Initial Catalog=InventoryDB;Integrated Security=True");
                conn.Open();
                //SqlCommand command = conn.CreateCommand();
            foreach (DataGridViewRow row in dataGridViewCoaches.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {


                    string strsql = "UPDATE Coach SET Last_Name='"+Convert.ToString(row.Cells[2].Value) + "', First_Name='" + Convert.ToString(row.Cells[3].Value) + "',Email='" + Convert.ToString(row.Cells[4].Value) + "',Phone_Number='" + Convert.ToString(row.Cells[5].Value) + "',Address='" + Convert.ToString(row.Cells[6].Value) + "' WHERE ID_Coach=" +
                        Convert.ToString(row.Cells[1].Value);
                        //dataGridViewCoaches.Rows.Remove(row);
                         //MessageBox.Show(strsql);

                        SqlCommand cmd = new SqlCommand(strsql, conn);

                        if (cmd.ExecuteNonQuery() > 0)
                            MessageBox.Show("Entry was updated");
                        else
                            MessageBox.Show("Entry was NOT updated");

                    }
                    
                }
                conn.Close();
            
        }

        private void labelAddress_Click(object sender, EventArgs e)
        {

        }

        private void labelPhone_Click(object sender, EventArgs e)
        {

        }

        private void labelEmail_Click(object sender, EventArgs e)
        {

        }

        private void labelFirstName_Click(object sender, EventArgs e)
        {

        }

        private void labelLastName_Click(object sender, EventArgs e)
        {

        }
    }
}
