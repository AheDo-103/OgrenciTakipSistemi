using AhdYazilim.OgrenciTakip.UI.Win.Forms.GenelForms;
using System;
using System.Windows.Forms;

namespace AhdYazilim.OgrenciTakip.UI.Win
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AnaForm());
        }
    }
}
 