using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
           // Application.Run(new Form6AddNewItems());
           //Application.Run(new Form8ModifyItem());
            //Application.Run(new Form4AdmLogin());
            //Application.Run(new deleteWindow2());
            Application.Run(new Form9ViewAddModifyCoach());


        }
    }
}
