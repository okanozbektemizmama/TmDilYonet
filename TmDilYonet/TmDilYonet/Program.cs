using System;
using System.Windows.Forms;
using TmDilYonet;

namespace TmDilYonet
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Form1 form1 = new Form1();
                Application.Run(form1);

            }
            catch (Exception ex)
            {

            }
        }
    }
}
