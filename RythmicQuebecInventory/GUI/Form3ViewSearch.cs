using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace RythmicQuebecInventory
{
    public partial class Form3ViewSearch : Form             
    {

        // connection string 

        SqlConnection con = new SqlConnection(@"Data Source=laptop-qtecafmk;Initial Catalog=InventoryDB;Integrated Security=True");

       


        public Form3ViewSearch()
        {
            InitializeComponent();
        }

        private void dataGridViewViewSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form3ViewSearch_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryDBDataSet4.View' table. You can move, or remove it, as needed.
            this.viewTableAdapter1.Fill(this.inventoryDBDataSet4.View);
            // TODO: This line of code loads data into the 'inventoryDBDataSet3.View' table. You can move, or remove it, as needed.
            this.viewTableAdapter.Fill(this.inventoryDBDataSet3.View);
            // TODO: This line of code loads data into the 'inventoryDBDataSet.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.inventoryDBDataSet.Inventory);
            display_data();
        }

        private void display_data()
        {
            //open connection 
            con.Open();
            
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            //the querry

            cmd.CommandText = "SELECT * from Inventory";

            cmd.ExecuteNonQuery();

            //creating temorary table 

            DataTable dt = new DataTable();

            // adding attributes from the server db to my pc memory 
            //formatting data into the format that c# understands 

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //converion:
            da.Fill(dt);

            dataGridViewViewSearch.DataSource = dt;

            con.Close();




        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.inventoryTableAdapter.FillBy(this.inventoryDBDataSet.Inventory);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.inventoryTableAdapter.FillBy1(this.inventoryDBDataSet.Inventory);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void checkBoxMailotsLeotards_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMailotsLeotards.Checked)
            {
               // da.Clear();

                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                //the querry

                cmd.CommandText = "SELECT * from Inventory WHERE Category_ID = 1";

                cmd.ExecuteNonQuery();

                //creating temorary table 

                DataTable dt = new DataTable();

                // adding attributes from the server db to my pc memory 
                //formatting data into the format that c# understands 

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                //converion:
                da.Fill(dt);

                dataGridViewViewSearch.DataSource = dt;

                con.Close();

             //   dataGridViewViewSearch.add.
            }

            
        }

        private void checkBoxJupesSkirts_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxShorts_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShorts.Checked)
            {
               
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                //the querry

                cmd.CommandText = "SELECT * from Inventory WHERE Category_ID = 2";

                cmd.ExecuteNonQuery();

                //creating temorary table 

                DataTable dt = new DataTable();

                // adding attributes from the server db to my pc memory 
                //formatting data into the format that c# understands 

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                //converion:
                da.Fill(dt);

                dataGridViewViewSearch.DataSource = dt;

                con.Close();
            }
        }

        private void checkBoxBas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBas.Checked)
            {
              
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                //the querry

                cmd.CommandText = "SELECT * from Inventory WHERE Category_ID = 3";

                cmd.ExecuteNonQuery();

                //creating temorary table 

                DataTable dt = new DataTable();

                // adding attributes from the server db to my pc memory 
                //formatting data into the format that c# understands 

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                //converion:
                da.Fill(dt);

                dataGridViewViewSearch.DataSource = dt;

                con.Close();
            }
        }

        private void checkBoxHeadGear_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHeadGear.Checked)
            {
               
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                //the querry

                cmd.CommandText = "SELECT * from Inventory WHERE Category_ID = 7";

                cmd.ExecuteNonQuery();

                //creating temorary table 

                DataTable dt = new DataTable();

                // adding attributes from the server db to my pc memory 
                //formatting data into the format that c# understands 

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                //converion:
                da.Fill(dt);

                dataGridViewViewSearch.DataSource = dt;

                con.Close();
            }
        }

        private void checkBoxDecor_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDecor.Checked)
            {
                
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                //the querry

                cmd.CommandText = "SELECT * from Inventory WHERE Category_ID = 8";

                cmd.ExecuteNonQuery();

                //creating temorary table 

                DataTable dt = new DataTable();

                // adding attributes from the server db to my pc memory 
                //formatting data into the format that c# understands 

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                //converion:
                da.Fill(dt);

                dataGridViewViewSearch.DataSource = dt;

                con.Close();
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.inventoryTableAdapter.Fill(this.inventoryDBDataSet.Inventory);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void checkBoxTShirts_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxNoirBlack_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void admAccessClick_Click(object sender, EventArgs e)
        {
            Form4AdmLogin f4 = new Form4AdmLogin();
            this.Hide();
            f4.ShowDialog();
        }
    }
}
