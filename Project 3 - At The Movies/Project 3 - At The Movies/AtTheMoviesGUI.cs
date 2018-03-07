/*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
*Comments by the prof:
*
*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
*Project #3--At The Movies
*Created by Kevin Kwok
*Date: 11/27/2017
*Project Name: At The Movies
*Time: 30 hours+
*Platform: C#, PC, Window 10, Visual Studio 2017, .NET Framework 4.5.2
*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
* Description:
*  This application was created to allow users to select from an external text file’s list of movie titles, 
*  and another external text file containing that theater’s showtimes, 
*  in order to calculate the ticket price for the selected movie and showtime based on pre-determined rates. 
*  
*  The user must select a movie to watch and a showtime before being allowed to select their tickets. 
*  
*  The prices are controlled using two numeric up-down controls, 
*  both representing the following ticket types: 
*     1.  Standard (Adult)
*     2.  Discounted (Child/Senior)
*  and are used to dynamically calculate the estimated subtotal (Amount Due). 
*  Once user is ready to finalize the transaction, they can click the Calculate button
*  to output all of the inputs into the bottom listbox control.
*  
*  The base rate for adult or standard movie tickets cost $9.00 before tax, 
*  and the base rate for discounted movie tickets, which apply to children and seniors, are $5.50 before tax,
*  and a flat-tax of 8.90% is levied against both ticket types. 
*  
*  For standard tickets, there is a special condition that allows moviegoers 
*  to purchase these tickets at a discounted rate of $5.50, 
*  and that is when the user selects any showtime before 5:00 PM, and after 12:00 AM. 
*  If the user selects a standard movie ticket between 5:00 PM and 11:00 PM,
*  they will be charged the standard ticket rate.
*  
*  For discounted tickets, children and seniors are charged the discounted rate
*  of $5.50 with tax for all showtimes.
*  
*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
*Comments by the student:
*
*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Project_3___At_The_Movies
{
    /// <summary>
    /// <para>
    /// The Windows Form containing the visual elements of the application.
    /// Ideally contains all of the control elements and fewer methods.
    /// </para>
    /// </summary>
    public partial class frmAtTheMovies : Form
    {
        // Class-level constant variables.
        const decimal REGULAR_TICKET_PRICE = 9.00m; //For regular show times: $9.00.
        const decimal DISCOUNT_TICKET_PRICE = 5.50m; //For matinee/early show times: $5.50.
        const double SALES_TAX_RATE = 0.089; //For 8.9% sales tax applied against all ticket sales.
        const string ERROR_MESSAGE_BOTH = "Please select a movie and showtime!";
        const string ERROR_MESSAGE_SHOWTIME = "Please select a showtime!";
        const string ERROR_MESSAGE_MOVIE = "Please select a movie!";
        const string ERROR_MESSAGE_PRINTING = "Please process at least one transaction!";
        const string ERROR_MESSAGE_TEXTFILE = "Please select an appropriate text file!";
        const string INVOICE_STRING_FORMAT = "{0, 0} {1, 24} {2, 48:C}";
        //Create a Structure List to get MovieTitles.txt to send array elements to different control outputs.
        List<MovieTitleProperties> movieElements = new List<MovieTitleProperties>();
        //Create a Structure List to get MovieTimes.txt to send array element to showtime combobox.
        List<MovieShowTimes> timeIndices = new List<MovieShowTimes>();
        //Declare new bitmap for CaptureScreen().
        Bitmap memoryImage;
        /// <summary>
        /// <para>
        /// The default constructor for the Windows Form application.
        /// </para>
        /// </summary>
        public frmAtTheMovies()
        {
            InitializeComponent();
        }
        /// <summary>
        /// <para>
        /// When the application boots, several actions shown below take place,
        /// in order to format the visual elements and controls for an ideal user experience.
        /// </para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAtTheMovies_Load(object sender, EventArgs e)
        {
            //TEST           

            //Clear the items from the combo boxes, and load new items from MovieTitles.txt and MovieTimes.txt.
            cboInMovieTitles.Items.Clear();
            cboInMovieTimes.Items.Clear();
            lstTransactionTotal.Items.Clear();
            //Clears transactional output labels.
            lblOutSubtotal.Text = "";
            lblOutTransactionTotal.Text = "";
            //Timer begins for dynamically displaying seconds, minutes, and hours while the application runs. 
            tmrAtTheMovies_CurrentTime.Start();
            //Text file version of reading MovieTitles and MovieTimes.
            ReadTextMovieTitles();
            DisplayMovieTitleProperties();
            ReadTextMovieTimes();
            DisplayMovieShowtimes();
            ////The application select a default choices.
            cboInMovieTitles.SelectedIndex = 0;
            cboInMovieTimes.SelectedIndex = 0;
            //Disable numericupdown controls until a showtime is selected.           
            updAdult.Value = 0;
            updChildSenior.Value = 0;
            updAdult.Enabled = false;
            updChildSenior.Enabled = false;
        }
        /// <summary>
        /// <para>
        /// This controls the output of the computer system's current clock while the application is running.
        /// </para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void tmrMnuTimer_Tick(object sender, EventArgs e)
        {
            //Creates a dynanic timer for lblCurrentTime
            DateTime currentTime = DateTime.Now;
            lblCurrentTime.Text = currentTime.ToString("dddd - MM/dd/yyyy - hh:mm:ss tt");
        }
        /// <summary>
        /// <para>
        /// This method uses the structure list that was used to extract elements from MovieTitles.txt, 
        /// which is called on startup in order to initialize the application's environment.
        /// The method searches for the tilde (~) character in MovieTitles.txt as the delimiter,
        /// and splits up/tokenizes the text elements into separate arrays.
        /// </para>
        /// </summary>
        private void ReadTextMovieTitles()
        {
            try
            {
                StreamReader inputFile; //Reads from the text file.
                string line; //Holds a line from the text file.
                //Create an instance of the MovieTitleProperties structure.
                MovieTitleProperties entry = new MovieTitleProperties();
                //Create a delimiter array.
                char[] delim = { '~' };
                //Open the MovieTitles file.
                inputFile = File.OpenText("MovieTitles.txt");
                //Read the lines from the file.
                while (!inputFile.EndOfStream)
                {
                    //Read a line fom the file.
                    line = inputFile.ReadLine();
                    //Tokenize the line.
                    string[] tokens = line.Split(delim);
                    //Store the tokens in the entry object.
                    entry.title = tokens[0];
                    entry.rating = tokens[1];
                    entry.runtime = tokens[2];
                    //Add the entry object to the list.
                    movieElements.Add(entry);
                }
            } //end of try
            catch (Exception ex)
            {
                //When the text file fails to load.
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// <para>
        /// When the user clicks btnOpen, they will be allowed to select a new text file,
        /// containing the word "Titles" somewhere in the filename, and also the tilde (~) delimitter,
        /// which will then be used to replace the existing list of films and their respective properties.
        /// The effect is intended to be the same as the method, ReadTextMovieTitles(), which cannot be used
        /// because it is designed to call the file, MoviesTitles.txt, every time.
        /// </para>
        /// </summary>
        private void OpenText_ReadTextMovieFiles()
        {
            //Variables.
            string textPath = Application.StartupPath;
            StreamReader inputFile; //Reads the text file.
            string line; //Holds a line from the text file.
            //Create an instance of the MovieTitleProperties structure.
            MovieTitleProperties entry = new MovieTitleProperties();
            //Create a delimiter array.
            char[] delim = { '~' };
            try
            {
                //Opening and selecting a new textfile to fill in the combobox and appropriate labels.
                ofdAtTheMovies.FileName = "*Titles*";
                ofdAtTheMovies.Filter = "Text File (.txt)|*.txt|All Files (*.*)|*.*"; //Gives filetype options.
                ofdAtTheMovies.InitialDirectory = textPath;
                if (ofdAtTheMovies.ShowDialog() == DialogResult.OK)
                {
                    //Call button controls to clear all inputs and outputs before loading new text file.                                          
                    cboInMovieTitles.Items.Clear();
                    movieElements.Clear();
                    lblOutSubtotal.Text = "";
                    //Open the MovieTitles file.
                    inputFile = File.OpenText(ofdAtTheMovies.FileName);
                    //Read the lines from the file.
                    while (!inputFile.EndOfStream)
                    {
                        //Read a line fom the file.
                        line = inputFile.ReadLine();
                        //Tokenize the line.
                        string[] tokens = line.Split(delim);
                        //Store the tokens in the entry object.
                        entry.title = tokens[0];
                        entry.rating = tokens[1];
                        entry.runtime = tokens[2];
                        //Add the entry object to the list.
                        movieElements.Add(entry);
                    }
                }
                else
                {
                    //When the user does not select a text file.
                    MessageBox.Show(ERROR_MESSAGE_TEXTFILE, "Text File Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboInMovieTitles.Items.Clear();
                }
            } //end of try
            catch (Exception ex)
            {
                //When the text file fails to load.
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// <para>
        /// This method now displays the tokenized string array elements created from ReadTextMovieTitles(),
        /// and outputs them to their respective controls.
        /// Now, when the user selects the combobox containing the movie title,
        /// that film's respective runtime and rating will also appear in the GUI.
        /// This dynamic functionality is controlled with the combobox's SelectedIndex_Changed event handler.
        /// </para>
        /// </summary>
        private void DisplayMovieTitleProperties()
        {
            //The DisplayNames method displays the list of names in the selected controls.
            foreach (MovieTitleProperties entry in movieElements)
            {
                cboInMovieTitles.Items.Add(entry.title);
                lblOutMovieRating.Text = entry.rating;
                lblOutMovieRuntime.Text = entry.runtime;
            }
        }
        /// <summary>
        /// <para>
        /// This method uses the structure list that was used to extract elements from MovieTimes.txt, 
        /// which is called on startup in order to initialize the application's environment.
        /// The method searches for the return-key (\r) character in MovieTimes.txt as the delimiter,
        /// and splits up/tokenizes the text element into a single array.
        /// </para>
        /// </summary>
        private void ReadTextMovieTimes()
        {
            try
            {
                //Variables.
                StreamReader inputFile; //to read the file
                string line; //to hold a line from the file
                //Create an instance of the MovieTitleProperties structure
                MovieShowTimes entry = new MovieShowTimes();
                //Open the MovieTitles file
                char[] delim = { '\r' };
                inputFile = File.OpenText("MovieTimes.txt");
                //Read the lines from the file
                while (!inputFile.EndOfStream)
                {
                    //Read a line fom the file
                    line = inputFile.ReadLine();
                    //Tokenize the line
                    string[] tokens = line.Split(delim);
                    //Store the tokens in the entry object
                    entry.showtimes = tokens[0];
                    //Add the entry object to the list
                    timeIndices.Add(entry);
                }
            } //end of try
            catch (Exception ex)
            {
                //When the text file fails to load.
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// <para>
        /// This method now displays the tokenized string array element created from ReadTextMovieTimes(),
        /// and outputs it to a combobox control.
        /// Now, the user will be able to select the combobox containing the movie's showtimes.
        /// </para>
        /// </summary>
        private void DisplayMovieShowtimes()
        {
            //Add text file showtimes into the combobox.
            foreach (MovieShowTimes entry in timeIndices)
            {
                cboInMovieTimes.Items.Add(entry.showtimes);
            }
        }
        /// <summary>
        /// <para>
        /// This method is called to establish the price of the standard movie ticket selected by the user.
        /// The number of tickets calculated depend on the value in the numericupdown control for Adult.
        /// First, its price is defined class-leve constants to establish the base price,
        /// followed by the cboInMovieTimes.SelectedIndex event handler,
        /// which is needed to determine if the user will receive the standard ticket price or discounted price
        /// for their selected showtime.
        /// After both price and showtime are selected, the class-level varaible for sales tax is applied.
        /// </para>
        /// </summary>
        /// <returns>Price of standard ticket(s).</returns>
        public decimal GetPricePerTicket()
        {
            //Variables.
            decimal decTicketPrice = 0.0m;
            decimal decTotal = 0.0m;
            //Assignement.    
            switch (cboInMovieTimes.SelectedIndex)
            {
                case 1: //9:00 AM
                case 2: //10:00 AM
                case 3: //11:00 AM
                case 4: //12:00 PM
                case 5: //1:00 PM
                case 6: //2:00 PM
                case 7: //3:00 PM
                case 8: //4:00 PM
                case 16: //12:00 AM
                    decTicketPrice = DISCOUNT_TICKET_PRICE;
                    break;
                default: //5:00 PM - 11:00 PM
                    decTicketPrice = REGULAR_TICKET_PRICE;
                    break;
            }
            //Calculation
            decTotal += decTicketPrice + (decTicketPrice * (decimal)SALES_TAX_RATE);
            //Return value
            return decTotal;
        }
        /// <summary>
        /// <para>
        /// This method is called to establish the price of the discounted movie ticket selected by the user.
        /// The number of tickets calculated depend on the value in the numericupdown control for Child/Senior.
        /// First, its price is defined class-leve constants to establish the base price,
        /// followed by the cboInMovieTimes.SelectedIndex event handler,
        /// which is not as essential in this method because the user 
        /// will always receive the discounted rate for their selected showtime.
        /// After both price and showtime are selected, the class-level varaible for sales tax is applied.
        /// </para>
        /// </summary>
        /// <returns>Price of discounted ticket(s).</returns>
        public decimal GetPricePerDiscountTicket()
        {
            //Variables.
            decimal decTicketPrice = 0.0m;
            decimal decTotal = 0.0m;
            //Assignement.
            switch (cboInMovieTimes.SelectedIndex)
            {
                default:
                    decTicketPrice = DISCOUNT_TICKET_PRICE;
                    break;
            }
            //Calculation.
            decTotal += decTicketPrice + (decTicketPrice * (decimal)SALES_TAX_RATE);
            //Return value.
            return decTotal;
        }
        /// <summary>
        /// <para>
        /// This method will output the subtotal with taxes for each standard movie ticket selected via 
        /// the Adult (byte) numericupdown control, and will recalculate dynamically if the value is changed.
        /// The label control will display the total amount owed when this method is called,
        /// but it will not be added to the listbox control until the user clicks btnCalculate.
        /// </para>
        /// </summary>
        /// <param name="bytAdult"></param>
        /// <returns>Subtotal for the price of selected standard ticket(s).</returns>
        public decimal GetSubtotalAdult(byte bytAdult)
        {
            //Variables.
            decimal decPriceStandard = 0.0m, decPriceAdult = 0.0m, decTotalCost = 0.0m;
            //Assignment.
            decPriceStandard = GetPricePerTicket(); //Call a method to determine cost of a standard ticket. 
            decPriceAdult = bytAdult * decPriceStandard;
            decTotalCost += decPriceAdult;
            //Return value.
            return decTotalCost;
        }
        /// <summary>
        /// <para>
        /// This method will output the subtotal with taxes for each standard movie ticket selected via 
        /// the Child/Senior (byte) numericupdown control, and will recalculate dynamically if the value is changed.
        /// The label control will display the total amount owed when this method is called,
        /// but it will not be added to the listbox control until the user clicks btnCalculate.
        /// </para>
        /// </summary>
        /// <param name="bytChildSenior"></param>
        /// <returns>Subtotal for the price of selected discounted ticket(s).</returns>
        public decimal GetSubtotalChildSenior(byte bytChildSenior)
        {
            //Variables.
            decimal decPriceDiscount = 0.0m, decPriceChildSenior = 0.0m, decTotalCost = 0.0m;
            //Assignment.
            decPriceDiscount = GetPricePerDiscountTicket(); //Call a method to determine cost of a discounted ticket. 
            decPriceChildSenior = bytChildSenior * decPriceDiscount;
            decTotalCost += decPriceChildSenior;
            //Return value.
            return decTotalCost;
        }
        /// <summary>
        /// <para>
        /// This method displays the amount due by the user, after the user has selected their ticket types.
        /// If the user selects a standard movie ticket, the price for one standard ticket will be displayed
        /// in the respective quadrant of the output label control, and show the total amount due.
        /// If the user also selects a discounted movie ticket, the price for one discounted ticket 
        /// will be displayed in the respective quadrant of the output label control, appended to the price
        /// of the standard ticket, and recalculate the total amount due.
        /// </para>
        /// </summary>
        public void PrintSubtotal()
        {
            //For dynamically calculating the amount due when both numericupdown controls are clicked.
            decimal decTicketSoldTotal = updAdult.Value + updChildSenior.Value;
            decimal decStandardTicketPriceTotal = GetPricePerTicket() * updAdult.Value;
            decimal decDiscountTicketPriceTotal = GetPricePerDiscountTicket() * updChildSenior.Value;
            decimal decTransactionalTotal = decStandardTicketPriceTotal + decDiscountTicketPriceTotal;
            //Output to two decimal places, because the sum of the methods will not appear to add up at first glance.
            lblOutSubtotal.Text = String.Format("A: {0:C2} +\nC/S: {1:C2} =\nSub: {2:C2}", 
                decStandardTicketPriceTotal, decDiscountTicketPriceTotal, decTransactionalTotal);
        }
        /// <summary>
        /// <para>
        /// This method is dependant on the numericupdown control values to calculate the total cost 
        /// of the users's selected tickets. This method calls out to other methods necessary for determining
        /// the price of a standard ticket, the price of a discounted ticket, whether or not those tickets are
        /// further discounted due to the user's selected showtime, and then calculates the total amount due.
        /// </para>
        /// </summary>
        /// <param name="bytAdult"></param>
        /// <param name="bytChildSenior"></param>
        /// <returns>The total cost of the transaction.</returns>
        public decimal GetTotalCost(byte bytAdult, byte bytChildSenior)
        {
            //Variables.
            decimal decPriceStandard = 0.0m, decPriceAdult = 0.0m, decPriceDiscount = 0.0m,
                decPriceChildSenior = 0.0m, decTotalCost = 0.0m;
            //Assignment.
            decPriceStandard = GetPricePerTicket();
            decPriceAdult = bytAdult * decPriceStandard;
            decPriceDiscount = GetPricePerDiscountTicket();
            decPriceChildSenior = bytChildSenior * decPriceDiscount;
            decTotalCost = decPriceAdult + decPriceChildSenior;
            //Return value.
            return decTotalCost;
        }
        /// <summary>
        /// <para>
        /// This method displays the user's total transaction, after the user has selected their ticket types
        /// and clicked the button control for calculating, committing, and outputing the transaction to a listbox.
        /// The listbox is preformatted using a class-level string variable,
        /// and will continually append each transaction to the control's bottom-most area,
        /// as the user continues to finalize each transaction with btnCalculate.
        /// </para>
        /// </summary>
        public void PrintTransaction()
        {
            //Variables used for printing the entire transactional history.
            decimal decTicketSoldTotal = updAdult.Value + updChildSenior.Value;
            decimal decStandardTicketPriceTotal = GetPricePerTicket() * updAdult.Value;
            decimal decDiscountTicketPriceTotal = GetPricePerDiscountTicket() * updChildSenior.Value;
            decimal decTransactionalTotal = decStandardTicketPriceTotal + decDiscountTicketPriceTotal;
            //If the values in either or both numericupdowns are > 0, the output label forecolor becomes green.
            if ((updAdult.Value > 0 && updChildSenior.Value > 0) || (updAdult.Value > 0 || updChildSenior.Value > 0))
            {
                lstTransactionTotal.Items.Add("Transaction Date and Time: " + DateTime.Now.ToString());
                lstTransactionTotal.Items.Add(cboInMovieTitles.Text + " || " + lblOutMovieRuntime.Text + " || Rated: " + lblOutMovieRating.Text + " || " + cboInMovieTimes.Text + ".");
                lstTransactionTotal.Items.Add("-------------------------------------------------------------------------------------------------------------");
                lstTransactionTotal.Items.Add(String.Format(INVOICE_STRING_FORMAT, "Ticket", "#", "Price"));
                lstTransactionTotal.Items.Add("-------------------------------------------------------------------------------------------------------------");
                lstTransactionTotal.Items.Add(String.Format(INVOICE_STRING_FORMAT, "Adult", updAdult.Value, decStandardTicketPriceTotal));
                lstTransactionTotal.Items.Add(String.Format(INVOICE_STRING_FORMAT, "Child", updChildSenior.Value, decDiscountTicketPriceTotal));
                lstTransactionTotal.Items.Add("-------------------------------------------------------------------------------------------------------------");
                lstTransactionTotal.Items.Add(String.Format(INVOICE_STRING_FORMAT, "Total", decTicketSoldTotal, decTransactionalTotal));
                lstTransactionTotal.Items.Add("|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
                //Output the transactional total to the respective label.
                lblOutTransactionTotal.ForeColor = Color.Green;
                lblOutTransactionTotal.Text = decTransactionalTotal.ToString("c");
            }
            //If the values in either or both numericupdowns are both 0, the output label forecolor becomes red.
            else
            {
                lstTransactionTotal.Items.Add("Transaction Date and Time: " + DateTime.Now.ToString());
                lstTransactionTotal.Items.Add(cboInMovieTitles.Text + " || " + lblOutMovieRuntime.Text + " || Rated: " + lblOutMovieRating.Text + " || " + cboInMovieTimes.Text + ".");
                lstTransactionTotal.Items.Add("-------------------------------------------------------------------------------------------------------------");
                lstTransactionTotal.Items.Add(String.Format(INVOICE_STRING_FORMAT, "Ticket", "#", "Price"));
                lstTransactionTotal.Items.Add("-------------------------------------------------------------------------------------------------------------");
                lstTransactionTotal.Items.Add(String.Format(INVOICE_STRING_FORMAT, "Adult", updAdult.Value, decStandardTicketPriceTotal));
                lstTransactionTotal.Items.Add(String.Format(INVOICE_STRING_FORMAT, "Child", updChildSenior.Value, decDiscountTicketPriceTotal));
                lstTransactionTotal.Items.Add("-------------------------------------------------------------------------------------------------------------");
                lstTransactionTotal.Items.Add(String.Format(INVOICE_STRING_FORMAT, "Total", decTicketSoldTotal, decTransactionalTotal));
                lstTransactionTotal.Items.Add("|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
                //Output the transactional total to the respective label.
                lblOutTransactionTotal.ForeColor = Color.Crimson;
                lblOutTransactionTotal.Text = decTransactionalTotal.ToString("c");
            }
        }
        /// <summary>
        /// <para>
        /// When the user clicks btnOpen, they will be allowed to select a new text file,
        /// containing the word "Titles" somewhere in the filename, and also the tilde (~) delimitter,
        /// which will then be used to replace the existing list of films and their respective properties.
        /// </para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpen_Click(object sender, EventArgs e)
        {
            //Calls methods to display new movie titles from user's selected external text file.
            OpenText_ReadTextMovieFiles();
            DisplayMovieTitleProperties();           
            cboInMovieTitles.SelectedIndex = 0;
        }
        /// <summary>
        /// <para>
        /// When the user clicks btnClear, several actions will take place to initialize or clear 
        /// the inputs and outputs dealing with movie titles, runtimes, ratings, showtimes, numericupdowns,
        /// and the amount due.
        /// </para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnClear_Click(object sender, EventArgs e)
        {
            //Clear all outputs and resets indicies on comboboxes.
            cboInMovieTitles.SelectedIndex = 0;
            cboInMovieTimes.SelectedIndex = 0;
            updAdult.Value = 0;
            updChildSenior.Value = 0;
            lblOutSubtotal.Text = "";
            lblTicketAdult.ForeColor = Color.Black;
            lblTicketChildSenior.ForeColor = Color.Black;
            cboInMovieTitles.Focus();
        }
        /// <summary>
        /// <para>
        /// When btnCalculate is clicked, the user's movie title and showtime combobox selections
        /// and numericupdown control values are used to call several methods for calculating
        /// the total price of the transaction.
        /// After determining the total transcation's movie title, runtime, rating, showtime, 
        /// number of tickets and each type sold, and the subtotal of each, the control will output all of that data
        /// into the program's only listbox for recording the transaction's history.
        /// Every subsequent click of this control will add more transcation entries to the bottom of the listbox.
        /// The time each transaction was finalized will also be present in the history.
        /// The ability to print the transaction history will only be activated 
        /// once the user has made valid selections.
        /// </para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Variable declaration for calculating the total transaction price, and then outputting it to a listbox.
            byte bytAdult = 0, bytChildSenior = 0;
            decimal decTotalCost = 0.0m;
            //If the comboboxes are defaulted to "(Select)", the application prompts the user to select a valid title and showtime.
            if (cboInMovieTitles.SelectedIndex == 0 && cboInMovieTimes.SelectedIndex == 0)
            {
                MessageBox.Show(ERROR_MESSAGE_BOTH, "Select a movie and showtime!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (cboInMovieTitles.SelectedIndex == 0)
                {
                    MessageBox.Show(ERROR_MESSAGE_MOVIE, "Select a movie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (cboInMovieTimes.SelectedIndex == 0)
                {
                    MessageBox.Show(ERROR_MESSAGE_SHOWTIME, "Select a showtime!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    //Assignment.      
                    bytAdult = (byte)updAdult.Value;
                    bytChildSenior = (byte)updChildSenior.Value;
                    //Calculation.
                    decTotalCost = GetTotalCost(bytAdult, bytChildSenior);
                    //Output.
                    PrintTransaction();
                }
            }
        }
        /// <summary>
        /// <para>
        /// Clicking btnExit will terminate the application.
        /// </para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            //Terminates application.
            Application.Exit();
        }
        /// <summary>
        /// <para>
        /// Clicking btnResetList will clear the listbox's contents,
        /// as well as the output label for the finalized transaction total (for that transaction).
        /// </para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResetList_Click(object sender, EventArgs e)
        {
            //Resets transactional history.
            lblOutTransactionTotal.Text = "";
            lstTransactionTotal.Items.Clear();
        }
        /// <summary>
        /// <para>
        /// Clicking the updAdult numericupdown control's event handler will make several changes.
        /// If the control's value has been changed, a condition will activate, and 
        /// the static label for the control will change its forecolor to indicate that its been selected. 
        /// However, in addition to its forecolor changing, another condition exists that dictates
        /// the forecolor can be further altered if the selected movie showtime is outside of a specified range,
        /// which indicates that the user will receive a discount on their standard tickets.
        ///     If the selected showtime in cboInMovieTimes is outside of the 5:00 PM - 11:00 PM range,
        ///the user will receive a discount, denoted by changing the static label's forecolor to Purple.
        ///     If the selected showtime in cboInMovieTimes is within the 5:00 PM - 11:00 PM range,
        ///the user will receive the standard ticket rate, and the static label's forecolor to becomes Blue.
        ///     If the selected showtime is valud, but the value in the updAdult control is 0,
        ///the static label's forecolor changes to Red to indicate a zero value.
        /// </para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updAdult_ValueChanged(object sender, EventArgs e)
        {
            //Variables for determining standard ticket price.
            byte value = 0;
            decimal decSubtotal = 0.0m;
            if (updAdult.Value > 0)
            {
                updAdult.Enabled = true;
                lblTicketAdult.ForeColor = Color.Blue;
                //If the selected movie time is before 1:00 PM, the label for adult ticket will turn purple to indicate a discount.
                switch (cboInMovieTimes.SelectedIndex)
                {
                    case 1: //9:00 AM
                    case 2: //10:00 AM
                    case 3: //11:00 AM
                    case 4: //12:00 PM
                    case 5: //1:00 PM
                    case 6: //2:00 PM
                    case 7: //3:00 PM
                    case 8: //4:00 PM
                    case 16: //12:00 AM
                        lblTicketAdult.ForeColor = Color.Purple;
                        break;
                    default: //5:00 PM - 11:00 PM
                        lblTicketAdult.ForeColor = Color.Blue;
                        break;
                }
                value = (byte)updAdult.Value;
                decSubtotal = GetSubtotalAdult(value);
                //Output.
                PrintSubtotal();
            }
            else
            {
                lblTicketAdult.ForeColor = Color.Crimson;
                lblOutSubtotal.ForeColor = Color.Crimson;
                lblOutSubtotal.Text = updAdult.Value.ToString("c");
            }
        }
        /// <summary>
        /// <para>
        /// Clicking the updChildSenior numericupdown control's event handler will make several changes.
        /// If the control's value has been changed, a condition will activate, and 
        /// the static label for the control will change its forecolor to indicate that its been selected.
        ///     Regardless of showtime selected, the user will receive a discounted rate for their movie,
        ///and the forecolor will be Purple by default to denote that discounted rate.
        ///     If the selected showtime is valud, but the value in the updChildSenior control is 0,
        ///the static label's forecolor changes to Red to indicate a zero value.
        /// </para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updChildSenior_ValueChanged(object sender, EventArgs e)
        {
            //Variables for determining discounted ticket price.
            byte value = 0;
            decimal decSubtotal = 0.0m;
            //The price of the discounted ticket is not time-bound, and will always receive the discounted price.
            if (updChildSenior.Value > 0 && !(cboInMovieTimes.SelectedIndex == 0))
            {
                lblTicketChildSenior.ForeColor = Color.Purple;
                value = (byte)updChildSenior.Value;
                decSubtotal = GetSubtotalChildSenior(value);
                //Output.
                PrintSubtotal();
            }
            else
            {
                lblTicketChildSenior.ForeColor = Color.Crimson;
                lblOutSubtotal.ForeColor = Color.Crimson;
                lblOutSubtotal.Text = updChildSenior.Value.ToString("c");
            }
        }
        /// <summary>
        /// <para>
        /// This combobox's KeyPress event handler prevents the user from typing anything into the text field.
        /// It makes sure that the movie titles cannot be altered.
        /// </para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboInMovieTitles_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Prevent any characters from being typed into comboboxes.
            e.Handled = true;
        }
        /// <summary>
        /// <para>
        /// This combobox's KeyPress event handler prevents the user from typing anything into the text field.
        /// It makes sure that the movie's showtimes cannot be altered.
        /// </para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboInMovieTimes_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Prevent any characters from being typed into comboboxes.
            e.Handled = true;
        }
        /// <summary>
        /// <para>
        /// This combobox's SelectedIndexChanged event handler utilizes the delimited arrays
        /// from the DisplayMovieTitleProperties() method, allowing the user to dynamically view
        /// any movie title's associated properties, such as runtime and rating.
        /// This event handler is designed to handle other text files containing movie titles as well.
        /// </para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboInMovieTitles_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get the index of the selected item
            int index = cboInMovieTitles.SelectedIndex;

            //display the corresponding movie title, and duplicates every title selected as a new index entry 
            lblOutMovieRating.Text = movieElements[index].rating;
            lblOutMovieRuntime.Text = movieElements[index].runtime;
        }
        /// <summary>
        /// <para>
        /// This combobox's SelectedIndexChangedevent handler will not allow the user to proceed any transaction,
        /// unless they have selected a valid showtime, because the numericupdown controls will be disabled.
        /// This is done to prevent any exceptions from arising, because the entirety of the application's 
        /// formula-based methods heavily depend on whether a showtime has been selected or not.
        /// If the user selects a valid showtime, the numericupdown controls will be enabled.
        /// </para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboInMovieTimes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Only allows the user to proceed with selecting number of tickets when a time has been selected.
            if (cboInMovieTimes.SelectedIndex > 0)
            {
                updAdult.Enabled = true;
                updChildSenior.Enabled = true;
            }
            else
            {
                updAdult.Enabled = false;
                updChildSenior.Enabled = false;
            }
        }
        /// <summary>
        /// <para>
        /// This menu strip control calls btnOpen, and performs the same action as that control.
        /// </para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuFileOpen_Click(object sender, EventArgs e)
        {
            //Menu Strip - Open text file and load new movie list.
            btnOpen_Click(sender, e);
        }
        /// <summary>
        /// <para>
        /// This menu strip control will save the application's listbox contents to a new text file
        /// to the application's default directory, and the filename will be specified by the user.
        /// Conditionally, if the listbox is empty, as in btnCalculate has not been clicked,
        /// then the user will be prompted to enter at least one transaction before attempting to save
        /// the listbox's contents.
        /// Every transaction present in the listbox will be saved in the format determined by the 
        /// class-level string variable.
        /// </para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuFileSave_Click(object sender, EventArgs e)
        {
            //Variables.
            string textPath = Application.StartupPath;
            //Saves transactional history in listbox with loop.
            if (lstTransactionTotal.Items.Count > 0)
            {
                var saveFile = new SaveFileDialog();
                saveFile.Filter = "Text (*.txt)|*.txt";
                saveFile.InitialDirectory = textPath;
                if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    using (var sw = new StreamWriter(saveFile.FileName, false))
                    {
                        foreach (var item in lstTransactionTotal.Items)
                        {
                            sw.Write(item.ToString() + Environment.NewLine);
                        }
                    }
                }
            }
            else
            {
                //If the listbox is empty, the user will not be allowed to save the results.     
                MessageBox.Show(ERROR_MESSAGE_PRINTING, "File Save Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ppdAtTheMovies.Close();
            }
        }
        /// <summary>
        /// <para>
        /// This menu strip control calls the CaptureScreen() method to capture a screenshot of the application's GUI,
        /// while the application is running.
        /// The print preview dialog will also be formatted to specification.
        /// </para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuFilePrintGUI_Click(object sender, EventArgs e)
        {
            //Takes a screenshot of the application's GUI form while it's running.
            CaptureScreen();
            ppdAtTheMovies.Document = pdAtTheMovies_GUI;
            ppdAtTheMovies.Size = new System.Drawing.Size(565, 548);
            ppdAtTheMovies.PrintPreviewControl.Zoom = 80 / 100f; //80% zoom.
            ppdAtTheMovies.ShowDialog();
        }
        /// <summary>
        /// <para>
        /// This method uses a class-level variable to take a screenshot of the application,
        /// while the application is running.
        /// </para>
        /// </summary>
        private void CaptureScreen()
        {
            /** 
             * The Graphics class constructs and defines the visual properties of the GUI to be printed.
             * memoryImage holds the form's print preview data, and is pushed to memoryGraphics 
             * to be represented within a ShowDialog property.
            */
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }
        /// <summary>
        /// <para>
        /// This print document contrl is bound to the GUI printing menu strip control.
        /// Draws out the image of the GUI to be represented and printed in the ShowDialog property.
        /// </para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pdAtTheMovies_GUI_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Trigger event for pdAtTheMovies_GUI control.
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
        /// <summary>
        /// <para>
        /// This menu strip control calls the event handler that will utilize the listbox contents
        /// and feed it through a pre-formatted print preview dialog.
        /// </para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuFilePrintResults_Click(object sender, EventArgs e)
        {
            //Shows the ShowDialog box for printing the results.
            ppdAtTheMovies.Document = pdAtTheMovies_Results;
            ppdAtTheMovies.ShowDialog();
        }
        /// <summary>
        /// <para>
        /// This event handler conditionally prints the listbox contents after btnCalculate has been clicked.
        /// If the listbox is empty, the handler will throw an exception and ask the user to commit at least
        /// one transaction before trying to print the listbox's contents.
        /// </para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pdAtTheMovies_Results_PrintPage(object sender, PrintPageEventArgs e)
        {
            //If the listbox is not empty, the results will be displayed in a print preview dialog box.
            if (!(lstTransactionTotal.Items.Count == 0))
            {
                e.Graphics.PageUnit = GraphicsUnit.Millimeter;
                int leading = 3;
                int leftMargin = 180;
                int topMargin = 3;
                //Designing the print output.
                StringFormat FmtRight = new StringFormat() { Alignment = StringAlignment.Far };
                StringFormat FmtLeft = new StringFormat() { Alignment = StringAlignment.Near };
                StringFormat FmtCenter = new StringFormat() { Alignment = StringAlignment.Near };
                StringFormat fmt = FmtRight;
                using (Font font = new Font("Arial Narrow", 18f))
                {
                    SizeF sz = e.Graphics.MeasureString("_|", Font);
                    float h = sz.Height + leading;
                    //Takes all content from the listbox and formats for printing.
                    for (int i = 0; i < lstTransactionTotal.Items.Count; i++)
                    {
                        e.Graphics.DrawString(lstTransactionTotal.Items[i].ToString(), font, Brushes.Black,
                                              leftMargin, topMargin + h * i, fmt);
                    }
                }
                ppdAtTheMovies.Size = new System.Drawing.Size(600, 775);
                ppdAtTheMovies.PrintPreviewControl.Zoom = 70 / 100f; //%70 zoom
            }
            else
            {
                //If the listbox is empty, the user will not be allowed to print the results.     
                MessageBox.Show(ERROR_MESSAGE_PRINTING, "Printing Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ppdAtTheMovies.Close();
            }
        }
        /// <summary>
        /// <para>
        /// This menu strip control calls the btnExit control to terminate the application. 
        /// </para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            //Menu strip - terminates application.
            btnExit_Click(sender, e);
        }
        /// <summary>
        /// <para>
        /// This menu strip control calls the btnCalculate control to process the transactional total. 
        /// </para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuTransactionCalculate_Click(object sender, EventArgs e)
        {
            //Menu strip - Calculates current transaction.
            btnCalculate_Click(sender, e);
        }
        /// <summary>
        /// <para>
        /// This menu strip control calls the btnClear control to clear all inputs an outputs,
        /// except for the ones involved with finalizing the transaction total.
        /// </para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuTransactionClear_Click(object sender, EventArgs e)
        {
            //Menu strip - Clears all inputs and outputs regarding current transaction.
            btnClear_Click(sender, e);
        }
        /// <summary>
        /// <para>
        /// This menu strip control calls the btnResetList control to clear all inputs and outputs
        /// involved with finalizing the transactional total. 
        /// </para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuTransactionReset_Click(object sender, EventArgs e)
        {
            //Menu strip - Clears all outputs to listbox containing transactional history.
            btnResetList_Click(sender, e);
        }
        /// <summary>
        /// <para>
        /// This menu strip control calls up a new instance of the AboutAtTheMovies Windows Form,
        /// which will call a ShowDialog box with the application's About form.
        /// </para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuHelpAbout_Click(object sender, EventArgs e)
        {
            /** 
             * Menu Strip - Creates a new instance of the AboutAtTheMovies() form.
             * When clicked, the application's About Form will appear.
            */
            using (AboutAtTheMovies box = new AboutAtTheMovies())
            {
                box.ShowDialog(this);
            }
        }
        /// <summary>
        /// This menu strip control calls up a new instance of the AtTheMoviesFeaturedTrailers Windows Form,
        /// which will call a ShowDialogBox with the application's Shockwave Flash media player.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuHelpMovieTrailers_Click(object sender, EventArgs e)
        {
            using (AtTheMoviesFeaturedTrailers box = new AtTheMoviesFeaturedTrailers())
            {
                box.ShowDialog(this);
            }
        }
    }
}