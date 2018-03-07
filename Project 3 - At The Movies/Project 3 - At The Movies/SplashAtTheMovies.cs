using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_3___At_The_Movies
{
    /// <summary>
    /// <para>
    /// The Windows Form contains the application's splashscreen.
    /// It will be the first part of the application that the user sees on startup.
    /// </para>
    /// </summary>
    public partial class SplashAtTheMovies : Form
    {
        /// <summary>
        /// <para>
        /// The default constructor for the splashscreen Windows Form.
        /// </para>
        /// </summary>
        public SplashAtTheMovies()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Contains the timer for controlling how long the splashscreen Windows Form is visible.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrAtTheMovies_Tick(object sender, EventArgs e)
        {
            //Timer controls how long the user sees the splashscreen.
            this.pgbAtTheMovies.Increment(1);
            if (pgbAtTheMovies.Value == 100)
            {
                this.tmrAtTheMovies.Stop();
                this.tmrAtTheMovies.Dispose();
                this.Dispose();
            }
        }
    }
}
