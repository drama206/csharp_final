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
    /// The Windows Form contains the application's Movie Trailers form.
    /// This is only visible to the user when they click the menu strip control during runtime.
    /// </para>
    /// </summary>
    public partial class AtTheMoviesFeaturedTrailers : Form
    {
        /// <summary>
        /// <para>
        /// The default constructor for the Movie Trailers Windows Form.
        /// </para>
        /// </summary>
        public AtTheMoviesFeaturedTrailers()
        {
            InitializeComponent();
        }
        /// <summary>
        /// When the user selects a film title from the combobox's drop-down list,
        /// the Flash Player control will fetch the YouTube video from the hyperlink 
        /// corresponding to the SelectedIndex event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboInMovieTrailers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Selecting a movie title will bring up a trailer for that film.
            switch (cboInMovieTrailers.SelectedIndex)
            {
                case 0:
                    axfMoviePlayer.Movie = "https://www.youtube.com/v/Q0CbN8sfihY";
                    break;
                case 1:
                    axfMoviePlayer.Movie = "https://www.youtube.com/v/4qab3TMg42k";
                    break;
                case 2:
                    axfMoviePlayer.Movie = "https://www.youtube.com/v/xjDjIWPwcPU";
                    break;
                default:
                    axfMoviePlayer.Movie = "https://www.youtube.com/v/kg-z8JfOIKw";
                    break;
            }
        }
        /// <summary>
        /// This button closes the Movie Trailers form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            //Closes the Trailer form.
            this.Close();
        }
    }
}
