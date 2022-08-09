using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Threading;

namespace RythmicQuebecInventory
{
    public partial class Form8ModifyItem : Form
    {

        // connection string 

        SqlConnection con = new SqlConnection(@"Data Source=laptop-qtecafmk;Initial Catalog=InventoryDB;Integrated Security=True");

        BindingSource form8bindingSource = new BindingSource();

        ListBindingConverter listBindingConverter = new ListBindingConverter();

        List<String> categoriesDropDownList = new List<string>();
        List<String> colorsDropDownList = new List<string>();
        List<String> sizesDropDownList = new List<string>();
        List<String> boxesDropDownList = new List<string>();
        List<String> coachesDropDownList = new List<string>();

        List<String> selectedRow = new List<string>();




        public Form8ModifyItem()
        {
            InitializeComponent();
        }


        public void receiveData(string selectedItemID)
        {
            //selected item ID transmited 
            textBoxItemID.Text = selectedItemID;

            string itemID = selectedItemID;


        }

        internal void receiveData(List<string> selectedRow)
        {
           

            //textBoxModifyName.Text = listBindingConverter.ConvertToString(selectedRow[3]);
            // textBoxDescriptionModify.Text = listBindingConverter.ConvertToString(selectedRow[4]);

           // pictureBoxModifyItem.Image = Image.FromStream(ImageListStreamer);
        }



        private void ModifyWindow_Load(object sender, EventArgs e)
        {
            // display_data();
            //textBoxModifyName.Text = 

            //  form8bindingSource.DataSource = listBindingConverter;

          //  string itemID = receiveData(selectedItemID);

            SqlCommand command = con.CreateCommand();
            con.Open();

            command.CommandText = "SELECT Box_no FROM Box";
            SqlDataReader readBox = command.ExecuteReader();
            //comboBoxBOXNO.DataSource = readBox;
            // comboBoxBOXNO.DataValueField = "Box_No";

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



            //command.CommandText = "SELECT Category FROM Categoty";
            //SqlDataReader readCategory = command.ExecuteReader();

            //while (readCategory.Read())
            //{
            //    comboBoxCategory.Items.Add(readCategory[0]);
            //}
            //readCategory.Close();


            command.CommandText = "SELECT Last_Name FROM Coach";

            SqlDataReader readCoach = command.ExecuteReader();

            while(readCoach.Read())
            {
                comboBoxSelectCoach.Items.Add(readCoach[0]);
            }
            readCoach.Close();



            command.Parameters.Clear();
            command.Parameters.AddWithValue("@Item_ID", textBoxItemID.Text);
            command.CommandText = "SELECT Image FROM Inventory WHERE Item_ID = @Item_ID";

            SqlDataReader readImage = command.ExecuteReader();

            if(readImage.Read())
            {
               // MemoryStream imageStream = new MemoryStream(readImage.GetSqlBytes(4).Buffer);
               //MemoryStream memoryStream = new MemoryStream(readImage.GetSqlBytes(1).Buffer);

               // pictureBoxModifyItem.Image = Image.FromStream(memoryStream); 

            }


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxModifyName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxModifyName_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBoxModifyQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxModifyQuantity_Click(object sender, EventArgs e)
        {
          
        }

       

        public int returnSize(String input)
        {
            switch (input)
            {
                case "<3":
                    return 1;
                case "3-4":
                    return 2;

                case "5-6":
                    return 3;

                case "7-8":
                    return 5;

                case "9-10":
                    return 6;

                case "11-12":
                    return 7;

                case "13-14":
                    return 8;

                case "15-16":
                    return 9;

                case "16>":
                    return 10;

                case "S":
                    return 11;
                case "M":
                    return 12;

                case "L":
                    return 13;
                default:
                    return 0;

            }

        }
        public int returnColor(string input)
        {
            switch (input)
            {
                case "Rouge":
                    return 1;

                case "Noire":
                    return 2;

                case "Orange":
                    return 3;

                case "Corail":
                    return 4;

                case "Vert":
                    return 5;
                    ;
                case "Bleu pâle":
                    return 6;

                case "Brun":
                    return 7;
                    ;
                case "Jaune":
                    return 8;

                case "Rose":
                    return 9;

                case "Mauve":
                    return 10;

                case "Or":
                    return 11;

                case "Agent":
                    return 12;

                case "Bleu foncé":
                    return 13;

                case "Vert foncé":
                    return 14;
                case "Beige":
                    return 15;

                case "Blanc":
                    return 16;

                case "Ivoire":
                    return 17;
                case "Gris":
                    return 18;

                case "Autre":
                    return 19;
                default:
                    return 0;
            }
        }
        /* public int returnBox(string input)
         {
             if (input == "<3")
             {
                 return 1;
             }
             else if (input == "3-4")
             {
                 return 2;
             }

             return 0;
         }*/
        public int returnCategory(String input)
        {
            switch (input)
            {
                case "Maillots":
                    return 1;

                case "Shorts":
                    return 2;

                case "Bas":
                    return 3;

                case "Pièces de tête":
                    return 7;
                case "Décor":
                    return 8;

                case "Accessoire":
                    return 9;

                case "Varia":
                    return 10;
                default:
                    return 0;

            }
        }

        //needs to be redone to retreive the info from the Database and show the current list of coacjes 
        public int returnCoach(String input)
        {
            switch (input)
            {
                case "Coach1":
                    return 1;

                case "Coach2":
                    return 2;

                case "Coach3":
                    return 3;

                case "Coach4":
                    return 4;
                case "Coach5":
                    return 5;

                case "Coach6":
                    return 6;

                case "Coach7":
                    return 7;
                case "Coach8":
                    return 8;

                case "Coach9":
                    return 9;

                case "Coach10":
                    return 10;
                default:
                    return 0;

            }
        }

        private void comboBoxBOXNO_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxModifyName_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void textBoxModifyName_Click_1(object sender, EventArgs e)
        {

            if (textBoxModifyName.Text == "modifiez le nom")
            {
                textBoxModifyName.Text = null;
            }
        }

        private void textBoxModifyQuantity_Click_1(object sender, EventArgs e)
        {
            if (textBoxModifyQuantity.Text == "modifiez la quantité")
            {
                textBoxModifyQuantity.Text = "";
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //string connectionString = "Data Source=LAPTOP-8CMJI23P;Initial Catalog=InventoryDB;Integrated Security=True";
            //SqlConnection con = new SqlConnection(connectionString);
            //con.Open();
            SqlCommand command = con.CreateCommand();
            int size_ID = returnSize(System.Convert.ToString(comboBoxSize.SelectedItem));
            int color_ID = returnColor(System.Convert.ToString(comboBoxColor.SelectedItem));
            //int box_ID = returnBox(System.Convert.ToString(comboBoxBOXNO.SelectedItem));
            int coach_ID = returnCoach(System.Convert.ToString(comboBoxSelectCoach.SelectedItem));
            int category_ID = returnCategory(System.Convert.ToString(comboBoxCategory.SelectedItem));

            var image = new ImageConverter().ConvertTo(pictureBoxModifyItem.Image, typeof(Byte[]));
         
            command.Parameters.AddWithValue("@Name", textBoxModifyName.Text);
            command.Parameters.AddWithValue("@Description", textBoxDescriptionModify.Text);
            command.Parameters.AddWithValue("@Quantity", System.Convert.ToInt32(textBoxModifyQuantity.Text));
            
            command.Parameters.AddWithValue("@Image", image);

            command.Parameters.AddWithValue("@Color_ID", color_ID);
            command.Parameters.AddWithValue("@Size_ID", size_ID);
            command.Parameters.AddWithValue("@Box_ID", comboBoxBOXNO.SelectedItem);
            command.Parameters.AddWithValue("@Category_ID", category_ID);
            command.Parameters.AddWithValue("@DateTaken", textBoxDateTaken.Text);
            command.Parameters.AddWithValue("@DateReturn", textBoxDateReturned.Text);
            command.Parameters.AddWithValue("@Item_ID", textBoxItemID.Text);
            command.Parameters.AddWithValue("@Coach_ID", coach_ID);
            command.CommandText = "UPDATE Inventory SET Name = @Name, Description = @Description, Quantity=Quantity-@Quantity,Color_ID=@Color_ID,Size_ID=@Size_ID,Category_ID=@Category_ID,Box_ID=@Box_ID WHERE Item_ID=@Item_ID";
            //command.CommandText = "INSERT INTO Inventory (Name,Description,Quantity,Color_ID,Size_ID,Box_ID,Category_ID) VALUES (@Name,@Description,@Quantity,@Color_ID,@Size_ID,@Box_ID,@Category_ID)";
            //command.CommandText = "INSERT INTO Items_Control(Date_Taken,Date_Return,Item_ID,ID_Coach) VALUES (@DateTaken,@DateReturn,@Item_ID,@coach_ID)";
            if (command.ExecuteNonQuery() > 0)
                MessageBox.Show("Item was modified");
            else
                MessageBox.Show("Item was NOT modified");
            con.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxDescriptionModify_Click(object sender, EventArgs e)
        {

        }

        private void buttonSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog OD = new OpenFileDialog();
            OD.FileName = "";
            OD.Filter = "Supported Images|*.jpg;*.jpeg;*.png";
            if (OD.ShowDialog() == DialogResult.OK)
                pictureBoxModifyItem.Load(OD.FileName);
            pictureBoxModifyItem.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void labelLogOut_Click(object sender, EventArgs e)
        {
            Form2MAppWindow f2 = new Form2MAppWindow();
            this.Close();
            f2.Show();
        }

        private void textBoxDateTaken_Click(object sender, EventArgs e)
        {
            if (textBoxDateTaken.Text == "entrez la date")
            {
                textBoxDateTaken.Text = DateTime.Now.ToShortDateString().ToString();
            }
        }

        private void textBoxDateReturned_Click(object sender, EventArgs e)
        {
            if (textBoxDateReturned.Text == "entrez la date")
            {
                textBoxDateReturned.Text = DateTime.Now.AddDays(30).ToShortDateString();
            }
        }
    }
}
