using System;
using System.Windows.Forms;

namespace RythmicQuebecInventory
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormViewSearch());
            //Application.Run(new MAppWindow());
             Application.Run(new Form2MAppWindow());
            //Application.Run(new Form3ViewSearch());
            // Application.Run(new Form7ModifyDelete());
             //Application.Run(new Form8ModifyItem());
            //Application.Run(new Form6AddNewItems());
        }
    }
}
