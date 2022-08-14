using RythmicQuebecInventory.GUI;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace RythmicQuebecInventory
{
    public partial class Form6AddNewItems : Form
    {
       

        // connection string 

        SqlConnection con = new SqlConnection(@"Data Source=laptop-qtecafmk;Initial Catalog=InventoryDB;Integrated Security=True");

       // int itemCategoryID, itemSizeID, itemColorID, itemBoxID;

              

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

            //con.Close();

        }

        public int returntCategoryID()
        {
            int Category_ID = 1;

            /*
             * shows errors no data to read 
             * 
             * 
             * 
             * 
            SqlCommand command = con.CreateCommand();
            //con.Open();
            command.CommandText = "SELECT Category_ID FROM Category WHERE Category = " + comboBoxCategory.SelectedItem.ToString();
            SqlDataReader readCategoryID = command.ExecuteReader();
            if (readCategoryID != null)
                Category_ID = (int)readCategoryID[0];
            //MessageBox.Show("Category ID = " + Category_ID);
            
            //con.Close();

            */

            return Category_ID;
        }

        public int returntSizeID()
        {
            int Size_ID = 0;
            /*
             * shows errors no data to read 
             * 
             * 
             * 
            SqlCommand command = con.CreateCommand();
            //con.Open();
            command.CommandText = "SELECT Size_ID FROM Size WHERE Size = " + comboBoxSize.SelectedItem.ToString();
            SqlDataReader readSizeID = command.ExecuteReader();
            if (readSizeID != null)
                Size_ID = Convert.ToInt32(readSizeID[0]);
           // MessageBox.Show("Size ID = " + Size_ID);
            //con.Close();

            */

            string choice = comboBoxSize.SelectedItem.ToString();

            switch (choice)
            {
                case "<3":

                    Size_ID = 1;
                    break;

                case "3-4":
                        Size_ID = 2;
                    break;

                case "5-6":
                    Size_ID = 3;
                    break;

                case "7-8":
                    Size_ID = 4;
                    break;



                default: Size_ID = 1;
                    break;
            }

                 




            return Size_ID;
        }

        public int returntColorID()
        {
            int Color_ID = 1;

            /*
             * shows errors no data to read 
             * 
             * 
             
            SqlCommand command = con.CreateCommand();
            //con.Open();
            command.CommandText = "SELECT Color_ID FROM Color WHERE Color = " + comboBoxColor.SelectedItem.ToString();
            SqlDataReader readColorID = command.ExecuteReader();
            if (readColorID != null)
                Color_ID = (int)readColorID[0];
            //MessageBox.Show("Color ID = " + Color_ID);
            //con.Close();
            */

            return Color_ID;
        }


        public int returntBoxID()
        {
            int Box_ID = 1;

            /*
             * shows errors no data to read 
             * 
             * 
             
            SqlCommand command = con.CreateCommand();
           // con.Open();
            command.CommandText = "SELECT Box_ID FROM Box WHERE Box_No = " + comboBoxBOXNO.SelectedItem.ToString();
            SqlDataReader readBoxID = command.ExecuteReader();
            if (readBoxID != null)
                Box_ID = (int)readBoxID[0];
           // MessageBox.Show("Box ID = " + Box_ID);
           // con.Close();


            */

            return Box_ID;
        }



        private void buttonSave_Click(object sender, EventArgs e)
        {
           // string connectionString = "Data Source=laptop-qtecafmk;Initial Catalog=InventoryDB;Integrated Security=True";
            //SqlConnection con = new SqlConnection(connectionString);
            // con.Open();
            SqlCommand command = con.CreateCommand();
            //int size_ID = comboBoxSize.SelectedItem().ToInt();



            // we need to find the way to convert the box into box id 

            

            // int size_ID = comboBoxBOXNO.SelectedIndex;

            //int color_ID = returnColor(System.Convert.ToString(comboBoxColor.SelectedItem));


            //int box_ID = returnBox(System.Convert.ToString(comboBoxBOXNO.SelectedItem));
            //  int category_ID = returnCategory(System.Convert.ToString(comboBoxCategory.SelectedItem));
            
              command.Parameters.AddWithValue("@Name", textBoxInputName.Text);
              command.Parameters.AddWithValue("@Description", textBoxDescriptionNewItem.Text);
              command.Parameters.AddWithValue("@Quantity", textBoxInputQuantity.Text);

              var image = new ImageConverter().ConvertTo(pictureBoxAddItem.Image, typeof(Byte[]));
              command.Parameters.AddWithValue("@Image", image);

           
              command.Parameters.AddWithValue("@Color_ID", returntColorID());

            //command.Parameters.AddWithValue("@Color_ID", null);

            command.Parameters.AddWithValue("@Size_ID", returntSizeID());
              command.Parameters.AddWithValue("@Box_ID", returntBoxID());
              command.Parameters.AddWithValue("@Category_ID", returntCategoryID());

             command.CommandText = "INSERT INTO Inventory (Name,Description,Quantity,Image,Color_ID,Size_ID,Box_ID,Category_ID) VALUES (@Name,@Description,@Quantity,@Image,@Color_ID,@Size_ID,@Box_ID,@Category_ID)";
            if (command.ExecuteNonQuery() > 0)
                MessageBox.Show("Item was added");
            else
                MessageBox.Show("Item was NOT added");
            //con.Close();
        }

        public static Image ResizeImagePreserveAspectRatio(Image image)
        {
            int newWidth = 200;
            
            int originalWidth = image.Width; 
            int originalHeight = image.Height;
            int percent = (newWidth * 100) / originalWidth;
            
            int newHeight = Convert.ToInt32(originalHeight * percent / 100);

            Image newImage = new Bitmap(newWidth, newHeight);
            Graphics graphicsHandle = Graphics.FromImage(newImage);
            graphicsHandle.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            graphicsHandle.DrawImage(image, 0, 0, newWidth, newHeight);

            return newImage;

        }

        private void buttonSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog OD = new OpenFileDialog();
            OD.FileName = "";
            OD.Filter = "Supported Images|*.jpg;*.jpeg;*.png";
            if (OD.ShowDialog() == DialogResult.OK)
            {
                Image image = ResizeImagePreserveAspectRatio(Image.FromFile(OD.FileName));
                //pictureBoxAddItem.Load(OD.FileName);
                pictureBoxAddItem.Image = image;
            }
               

            pictureBoxAddItem.SizeMode = PictureBoxSizeMode.StretchImage;
           // pictureBoxAddItem.Resize()  
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
            con.Close();
            Form5AdminOptions f5 = new Form5AdminOptions();
            this.Close();
            f5.Show();

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

        private void pictureBoxAddItem_Click(object sender, EventArgs e)
        {

        }
    }
}
