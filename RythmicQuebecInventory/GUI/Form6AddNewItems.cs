using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RythmicQuebecInventory
{
    public partial class Form6AddNewItems : Form
    {

        // connection string 

        SqlConnection con = new SqlConnection(@"Data Source=laptop-qtecafmk;Initial Catalog=InventoryDB;Integrated Security=True");

        public int returntCategory()
        {
            int Category_ID = 0;
            SqlCommand command = con.CreateCommand();
            con.Open();
            command.CommandText = "SELECT Category_ID FROM Category WHERE Category = " + comboBoxCategory.SelectedItem.ToString();
            SqlDataReader readCategory = command.ExecuteReader();
            if (readCategory != null)
                Category_ID = (int)readCategory[0];
            MessageBox.Show("Category ID = " + Category_ID);

            return Category_ID;
        }

        public Form6AddNewItems()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form6AddNewItems_Load(object sender, EventArgs e)
        {
            SqlCommand command = con.CreateCommand();
            con.Open();

            command.CommandText = "SELECT Box_no FROM Box";
            SqlDataReader readBox = command.ExecuteReader();
          
            while (readBox.Read())
            {
                comboBoxBOXNO.Items.Add(readBox[0]);
            }
            readBox.Close();


            command.CommandText = "SELECT Color FROM Color";

            SqlDataReader readColor = command.ExecuteReader();

            while (readColor.Read())
            {
                comboBoxColor.Items.Add(readColor[0]);
            }
            readColor.Close();

            command.CommandText = "SELECT Size FROM Size";

            SqlDataReader readSize = command.ExecuteReader();

            while (readSize.Read())
            {
                comboBoxSize.Items.Add(readSize[0]);
            }
            readSize.Close();



            command.CommandText = "SELECT Category FROM Category";
            SqlDataReader readCategory = command.ExecuteReader();

            while (readCategory.Read())
            {
                comboBoxCategory.Items.Add(readCategory[0]);
            }
            readCategory.Close();


            

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=laptop-qtecafmk;Initial Catalog=InventoryDB;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand command = con.CreateCommand();
            //int size_ID = comboBoxSize.SelectedItem().ToInt();



            // we need to find the way to convert the box into box id 

            

            // int size_ID = comboBoxBOXNO.SelectedIndex;

            //int color_ID = returnColor(System.Convert.ToString(comboBoxColor.SelectedItem));


            //int box_ID = returnBox(System.Convert.ToString(comboBoxBOXNO.SelectedItem));
            //  int category_ID = returnCategory(System.Convert.ToString(comboBoxCategory.SelectedItem));
            //   command.Parameters.AddWithValue("@Name", textBoxInputName.Text);
            //  command.Parameters.AddWithValue("@Description", textBoxDescription.Text);

            //   var image = new ImageConverter().ConvertTo(pictureBox1.Image, typeof(Byte[]));
            // command.Parameters.AddWithValue("@Image", image);

            //  command.Parameters.AddWithValue("@Quantity", textBoxInputQuantity.Text);
            //  command.Parameters.AddWithValue("@Color_ID", size_ID);
            //  command.Parameters.AddWithValue("@Size_ID", color_ID);
            //  command.Parameters.AddWithValue("@Box_ID", comboBoxBOXNO.SelectedItem);
            //  command.Parameters.AddWithValue("@Category_ID", category_ID);

            // command.CommandText = "INSERT INTO Inventory (Name,Description,Quantity,Image,Color_ID,Size_ID,Box_ID,Category_ID) VALUES (@Name,@Description,@Quantity,@Image,@Color_ID,@Size_ID,@Box_ID,@Category_ID)";
            if (command.ExecuteNonQuery() > 0)
                MessageBox.Show("Item was added");
            else
                MessageBox.Show("Item was NOT added");
            con.Close();
        }

        private void buttonSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog OD = new OpenFileDialog();
            OD.FileName = "";
            OD.Filter = "Supported Images|*.jpg;*.jpeg;*.png";
            if (OD.ShowDialog() == DialogResult.OK)
                pictureBoxAddItem.Load(OD.FileName);
            pictureBoxAddItem.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void textBoxInputName_Click(object sender, EventArgs e)
        {
            if (textBoxInputName.Text == "entrez le nom")
            {
                textBoxInputName.Text = "";
            }
        }

        private void textBoxInputQuantity_Click(object sender, EventArgs e)
        {

            if (textBoxInputQuantity.Text == "entrez la quantité")
            {
                textBoxInputQuantity.Text = "";
            }
        }

        private void labelLogOut_Click(object sender, EventArgs e)
        {
            Form2MAppWindow f2 = new Form2MAppWindow();
            this.Close();
            f2.Show();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
          /*  int Category_ID = 0;
            SqlCommand command = con.CreateCommand();
            command.CommandType = CommandType.Text;
            // con.Open();
            command.CommandText = "SELECT Category_ID FROM Category WHERE Category = '" + comboBoxCategory.SelectedItem.ToString() + "'";
            command.ExecuteNonQuery();
            SqlDataReader readCategory = command.ExecuteReader();
            Category_ID = (int)readCategory[0];
            
            MessageBox.Show("Category ID = " + Category_ID);
          */
        }
    }
}
