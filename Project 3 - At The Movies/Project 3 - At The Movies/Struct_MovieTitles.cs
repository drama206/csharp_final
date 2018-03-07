using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_3___At_The_Movies
{
    /// <summary>
    /// <para>
    /// This structure helps load the text properties from an external text file,
    /// which contain a unique character-delimiter that is used to split the text into arrays,
    /// in order to load them into their specific output controls in the AtTheMoviesGUI From.
    /// </para>
    /// </summary>
    struct MovieTitleProperties
    {
        //Holds all movie title properties contained in external text file, located in the solution's /bin/ folder.
        public string title;
        public string rating;
        public string runtime;
    }
    public class Struct_MovieTitles
    {      

    }
}