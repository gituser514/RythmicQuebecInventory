using QRCoder;
using RythmicQuebecInventory.GUI;
using System;
using System.Windows.Forms;


namespace RythmicQuebecInventory
{
    public partial class Form11CreatQRCode : Form
    {
        public Form11CreatQRCode()
        {
            InitializeComponent();
            //insertComboItems();

        }

        private void selectBoxies_TextChanged(object sender, EventArgs e)
        {

        }

        private void creatQRCode_Load(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Form5AdminOptions f5 = new Form5AdminOptions();
            this.Close();
            f5.Show();
        }

        private void labelLogOut_Click(object sender, EventArgs e)
        {
            Form2MAppWindow f2 = new Form2MAppWindow();
            this.Close();
            f2.Show();
        }

        private void buttonQRCodeCreateSave_Click(object sender, EventArgs e)
        {
            int boxNO = cboSelectBoxes.SelectedIndex;
            string sqlSelectBox = "SELECT * FORM Inventory WHERE Box = " + boxNO.ToString();

            string forQRCode = "???" + sqlSelectBox;

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
           // QRCodeGenerator.QrCode qrCode = qrGenerator.CreateQrCode(textBoxQRCode.Text, QRCodeGenerator.ECCLevel.Q);
          //  pictureBoxQRCode.BackgroundImage = qrCode.GetGraphic(20);


            // one more version 
            /*
             * https://stackoverflow.com/questions/7020136/free-c-sharp-qr-code-generator
             * 
            var url = string.Format("http://chart.apis.google.com/chart?cht=qr&chs={1}x{2}&chl={0}", txtCode.Text, txtWidth.Text, txtHeight.Text);
            WebResponse response = default(WebResponse);
            Stream remoteStream = default(Stream);
            StreamReader readStream = default(StreamReader);
            WebRequest request = WebRequest.Create(url);
            response = request.GetResponse();
            remoteStream = response.GetResponseStream();
            readStream = new StreamReader(remoteStream);
            System.Drawing.Image img = System.Drawing.Image.FromStream(remoteStream);
            img.Save("D:/QRCode/" + txtCode.Text + ".png");
            response.Close();
            remoteStream.Close();
            readStream.Close();
            txtCode.Text = string.Empty;
            txtWidth.Text = string.Empty;
            txtHeight.Text = string.Empty;
            lblMsg.Text = "The QR Code generated successfully";


            */

            // and one more option

            /*
             * https://www.codeproject.com/Articles/1250071/QR-Code-Encoder-and-Decoder-Csharp-Class-Library-f
             * 
             * 
             */

            
        }
}
}
