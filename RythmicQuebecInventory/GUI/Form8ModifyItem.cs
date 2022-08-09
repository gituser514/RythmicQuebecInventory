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
    public partial class Form8ModifyItem : Form
    {
        public Form8ModifyItem()
        {
            InitializeComponent();
        }

        private void ModifyWindow_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxModifyItem_Click(object sender, EventArgs e)
        {

        }

        private void textBoxModifyName_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxModifyName_Click(object sender, EventArgs e)
        {
            if (textBoxModifyName.Text == "modifiez le nom")
            {
                textBoxModifyName.Text = null;
            }
        }

        private void textBoxModifyQuantity_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxModifyQuantity_Click(object sender, EventArgs e)
        {
            if (textBoxModifyQuantity.Text == "modifiez la quantité")
            {
                textBoxModifyQuantity.Text = "";
            }
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


        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
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
            int coach_ID = returnCoach(System.Convert.ToString(comboBoxSelectCoach.SelectedItem));
            int category_ID = returnCategory(System.Convert.ToString(comboBoxCategory.SelectedItem));
            command.Parameters.AddWithValue("@Name", textBoxModifyName.Text);
            command.Parameters.AddWithValue("@Description", textBoxModifyDescription.Text);
            command.Parameters.AddWithValue("@Quantity", System.Convert.ToInt32(textBoxModifyQuantity.Text));
            command.Parameters.AddWithValue("@Color_ID", size_ID);
            command.Parameters.AddWithValue("@Size_ID", color_ID);
            command.Parameters.AddWithValue("@Box_ID", comboBoxBOXNO.SelectedItem);
            command.Parameters.AddWithValue("@Category_ID", category_ID);
            command.Parameters.AddWithValue("@DateTaken", textBoxDateTaken.Text);
            command.Parameters.AddWithValue("@DateReturn", textBoxDateReturned.Text);
            command.Parameters.AddWithValue("@Item_ID", textBoxItemID.Text);
            command.Parameters.AddWithValue("@Coach_ID", coach_ID);
            command.CommandText ="UPDATE Inventory SET Name = @Name, Description = @Description, Quantity=Quantity-@Quantity,Color_ID=@Color_ID,Size_ID=@Size_ID,Category_ID=@Category_ID,Box_ID=@Box_ID WHERE Item_ID=@Item_ID";
            //command.CommandText = "INSERT INTO Inventory (Name,Description,Quantity,Color_ID,Size_ID,Box_ID,Category_ID) VALUES (@Name,@Description,@Quantity,@Color_ID,@Size_ID,@Box_ID,@Category_ID)";
            //command.CommandText = "INSERT INTO Items_Control(Date_Taken,Date_Return,Item_ID,ID_Coach) VALUES (@DateTaken,@DateReturn,@Item_ID,@coach_ID)";
            if (command.ExecuteNonQuery() > 0)
                MessageBox.Show("Item was modified");
            else
                MessageBox.Show("Item was NOT modified");
            con.Close();
        }

        private void textBoxDescriptionModify_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxDescriptionModify_Click(object sender, EventArgs e)
        {
            if (textBoxModifyDescription.Text == "Existing description loads here for editing. La description existante apparaît ici pour modification.")
                textBoxModifyDescription.Text = "";
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBoxModifyQuantity.Text = "modifiez la quantité";
            textBoxModifyName.Text = "modifiez le nom";
            comboBoxCategory.Text = "CATEGORIE";
            comboBoxBOXNO.Text = "BOX_NO";
            comboBoxColor.Text = "COULEUR";
            comboBoxSize.Text = "TAILLE";
            textBoxModifyDescription.Text = "Existing description loads here for editing. La description existante apparaît ic" +
    "i pour modification.";
            textBoxDateTaken.Text = "entrez la date";
            textBoxDateReturned.Text = "entrez la date";
            buttonSelectImage.Text = "sélectionnez l'image";
            pictureBoxModifyItem.Image = null;
            textBoxItemID.Text = "entrez item id";


        }

        private void textBoxDateTaken_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxDateTaken_Click(object sender, EventArgs e)
        {
            if (textBoxDateTaken.Text == "entrez la date")
            {
                textBoxDateTaken.Text = DateTime.Now.ToShortDateString().ToString();
            }
        }

        private void textBoxDateReturned_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxDateReturned_Click(object sender, EventArgs e)
        {
            if (textBoxDateReturned.Text == "entrez la date")
            {
                textBoxDateReturned.Text = DateTime.Now.AddDays(30).ToShortDateString();
            }
        }

        private void textBoxItemID_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxItemID_Click(object sender, EventArgs e)
        {
            if (textBoxItemID.Text == "entrez item id")
            {
                textBoxItemID.Text = "";
            }
        }

        private void labelLogOut_Click(object sender, EventArgs e)
        {
            Form2MAppWindow f2 = new Form2MAppWindow();
            this.Hide();
            f2.ShowDialog();
        }

        private void comboBoxSelectCoach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
