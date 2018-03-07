using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_3___At_The_Movies
{
    static class Program
    {
        /// <summary>
        /// <para>
        /// The main entry point for the application.
        /// A timed splashscreen form is initiated on startup,
        /// and will dispose of itself before running the main Windows Form
        /// containing the main application's GUI.
        /// </para>
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashAtTheMovies());
            Application.Run(new frmAtTheMovies());
        }
    }
}
