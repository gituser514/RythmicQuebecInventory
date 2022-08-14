using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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
            // TODO: This line of code loads data into the 'inventoryDBDataSet7.View' table. You can move, or remove it, as needed.
            this.viewTableAdapter2.Fill(this.inventoryDBDataSet7.View);
           
            
            
            /*
            // TODO: This line of code loads data into the 'inventoryDBDataSet4.View' table. You can move, or remove it, as needed.
            this.viewTableAdapter1.Fill(this.inventoryDBDataSet4.View);
            // TODO: This line of code loads data into the 'inventoryDBDataSet3.View' table. You can move, or remove it, as needed.
            this.viewTableAdapter.Fill(this.inventoryDBDataSet3.View);
            // TODO: This line of code loads data into the 'inventoryDBDataSet.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.inventoryDBDataSet.Inventory);
            */
           
            
            
            display_data();
        }

        private void display_data()
        {
            
            //open connection 
            con.Open();
            
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            //the querry

            cmd.CommandText = "SELECT dbo.Inventory.Item_ID, dbo.Inventory.Image, dbo.Inventory.Name, dbo.Inventory.Description, dbo.Inventory.Quantity, dbo.Category.Category, dbo.Color.Color, dbo.Size.Size, dbo.Box.Box_No, dbo.Coach.Last_Name, dbo.Coach.First_Name, dbo.Items_Control.Date_Taken, dbo.Items_Control.Date_Return, dbo.Box.Total_Items, dbo.Box.Available_Items FROM  dbo.Inventory LEFT OUTER JOIN dbo.Category ON dbo.Inventory.Category_ID = dbo.Category.Category_ID LEFT OUTER JOIN dbo.Color ON dbo.Inventory.Color_ID = dbo.Color.Color_ID LEFT OUTER JOIN dbo.Size ON dbo.Inventory.Size_ID = dbo.Size.Size_ID LEFT OUTER JOIN dbo.Box ON dbo.Inventory.Box_ID = dbo.Box.Box_ID LEFT OUTER JOIN dbo.Items_Control ON dbo.Inventory.Item_ID = dbo.Items_Control.Item_ID LEFT OUTER JOIN dbo.Coach ON dbo.Items_Control.ID_Coach = dbo.Coach.ID_Coach";

            cmd.ExecuteNonQuery();

            //creating temorary table 

            DataTable dt = new DataTable();

            // adding attributes from the server db to my pc memory 
            //formatting data into the format that c# understands 

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //converion:
            da.Fill(dt);

           // dataGridViewViewSearch.DataSource = dt;

            con.Close();

            //dataGridViewViewSearch.Rows.Add(null);

            //dataGridViewViewSearch.Rows.Add(dt);

            
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                for (int j = 0; j < dataGridViewViewSearch.Rows.Count; j++)
                {
                    if (dataGridViewViewSearch.Rows[j].Equals(null))
                    {
                        dataGridViewViewSearch.Rows.Add(j, dt.Rows[i]);
                    }
                }


                // DataRow row = dt.Rows[i];
            }
            

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.viewTableAdapter2.Fill(this.inventoryDBDataSet7.View);
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
                this.viewTableAdapter2.Fill(this.inventoryDBDataSet7.View);
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
                //cmd.CommandText = "SELECT * from Inventory";

                cmd.ExecuteNonQuery();

                //creating temorary table 

                DataTable dt = new DataTable();

                // adding attributes from the server db to my pc memory 
                //formatting data into the format that c# understands 

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                //converion:
                da.Fill(dt);

                //dt.Filter()

              //  DataRowView dataRowView = dt.


                DataView dv = dt.DefaultView;
                dv.RowFilter = "Category_ID = 1";

               // dv.FindRows(DataRow.ToString().Equals(1));
               // dataGridViewViewSearch.DataSource.RowFilter("");
                //dataGridViewViewSearch.Filter = 

              //  DataClasses1DataContext dataClasses1DataContext = new DataClasses1DataContext();
              //  var filteredResults = dataClasses1DataContext.Inventories.Where(inv => inv.Category_ID = 1);


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

               // DataGridViewRow dataGridViewRow = new DataGridViewRow();
               // da.Fill(dataGridViewRow);

                for(int i = 0; i < dt.Rows.Count; i++)
                {

                    for(int j = 0; j < dataGridViewViewSearch.Rows.Count; j++)
                    {
                        if (dataGridViewViewSearch.Rows[j].Equals(null))
                        {
                            dataGridViewViewSearch.Rows.Add(j, dt.Rows[i]);
                        }
                    }
                                      

                   // DataRow row = dt.Rows[i];
                }


                /*

                foreach (DataGridViewRow row in dataGridViewViewSearch.Rows)
                {
                    if (row.Equals(null))
                    {
                        dataGridViewViewSearch.Rows.Insert(0, row);
                    }

                }

                */



              //  dataGridViewViewSearch => Rows => Insert(dataGridViewRow);
               // dataGridViewViewSearch.DataSource = dt;

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
                this.viewTableAdapter2.Fill(this.inventoryDBDataSet7.View);
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
