using System;
using System.Windows.Forms;

namespace CodingTests
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var dt = Convert.ToDateTime("Wed, 07 October 2015 10:00:00 +0900");
            dt = dt.ToUniversalTime();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CodingTests());
        }
    }
}
