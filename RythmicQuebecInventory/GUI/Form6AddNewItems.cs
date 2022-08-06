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
    public partial class Form6AddNewItems : Form
    {
        public Form6AddNewItems()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-8CMJI23P;Initial Catalog=InventoryDB;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand command = con.CreateCommand();
            int size_ID = returnSize(System.Convert.ToString(comboBoxSize.SelectedItem));
            int color_ID = returnColor(System.Convert.ToString(comboBoxColor.SelectedItem));
            //int box_ID = returnBox(System.Convert.ToString(comboBoxBOXNO.SelectedItem));
            int category_ID = returnCategory(System.Convert.ToString(comboBoxCategory.SelectedItem));
            command.Parameters.AddWithValue("@Name", textBoxInputName.Text);
            command.Parameters.AddWithValue("@Description", textBoxDescription.Text);
            command.Parameters.AddWithValue("@Quantity", textBoxInputQuantity.Text);
            command.Parameters.AddWithValue("@Color_ID", size_ID);
            command.Parameters.AddWithValue("@Size_ID", color_ID);
            command.Parameters.AddWithValue("@Box_ID", comboBoxBOXNO.SelectedItem);
            command.Parameters.AddWithValue("@Category_ID", category_ID);

            command.CommandText = "INSERT INTO Inventory (Name,Description,Quantity,Color_ID,Size_ID,Box_ID,Category_ID) VALUES (@Name,@Description,@Quantity,@Color_ID,@Size_ID,@Box_ID,@Category_ID)";
            if (command.ExecuteNonQuery() > 0)
                MessageBox.Show("Item was added");
            else
                MessageBox.Show("I was NOT added"); 
            con.Close();
        }

        private void comboBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog OD = new OpenFileDialog();
            OD.FileName = "";
            OD.Filter = "Supported Images|*.jpg;*.jpeg;*.png";
            if (OD.ShowDialog() == DialogResult.OK)
                pictureBox1.Load(OD.FileName);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void textBoxInputName_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void textBoxInputName_Click(object sender, EventArgs e)
        {
            if (textBoxInputName.Text == "entrez le nom")
            {
                textBoxInputName.Text = "";
            }
        }

        private void textBoxInputQuantity_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxInputQuantity_Click(object sender, EventArgs e)
        {
            if (textBoxInputQuantity.Text == "entrez la quantité")
            {
                textBoxInputQuantity.Text = "";
            }
        }

        public int returnSize(String input)
        {   switch(input)
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
    }
}
