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
        /// 

        // fang chen test commit
        // more random stuff
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormViewSearch());
        }
    }
}
