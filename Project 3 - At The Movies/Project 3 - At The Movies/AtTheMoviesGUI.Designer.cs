namespace Project_3___At_The_Movies
{
    partial class frmAtTheMovies
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAtTheMovies));
            this.btnOpen = new System.Windows.Forms.Button();
            this.grpMovieSelection = new System.Windows.Forms.GroupBox();
            this.lblMovieTitle = new System.Windows.Forms.Label();
            this.cboInMovieTimes = new System.Windows.Forms.ComboBox();
            this.cboInMovieTitles = new System.Windows.Forms.ComboBox();
            this.lblOutMovieRating = new System.Windows.Forms.Label();
            this.lblOutMovieRuntime = new System.Windows.Forms.Label();
            this.lblMovieTimes = new System.Windows.Forms.Label();
            this.lblMovieRating = new System.Windows.Forms.Label();
            this.lblMovieRuntime = new System.Windows.Forms.Label();
            this.mnuAtTheMovies = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFilePrintGUI = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFilePrintResults = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTransaction = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTransactionCalculate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTransactionClear = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTransactionReset = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpMovieTrailers = new System.Windows.Forms.ToolStripMenuItem();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblOutSubtotal = new System.Windows.Forms.Label();
            this.grpAmountDue = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpTickets = new System.Windows.Forms.GroupBox();
            this.updChildSenior = new System.Windows.Forms.NumericUpDown();
            this.updAdult = new System.Windows.Forms.NumericUpDown();
            this.lblTicketChildSenior = new System.Windows.Forms.Label();
            this.lblTicketAdult = new System.Windows.Forms.Label();
            this.grpTransaction = new System.Windows.Forms.GroupBox();
            this.btnResetList = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblOutTransactionTotal = new System.Windows.Forms.Label();
            this.lstTransactionTotal = new System.Windows.Forms.ListBox();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.tmrAtTheMovies_CurrentTime = new System.Windows.Forms.Timer(this.components);
            this.ttpAtTheMovies = new System.Windows.Forms.ToolTip(this.components);
            this.pdAtTheMovies_Results = new System.Drawing.Printing.PrintDocument();
            this.pdAtTheMovies_GUI = new System.Drawing.Printing.PrintDocument();
            this.ppdAtTheMovies = new System.Windows.Forms.PrintPreviewDialog();
            this.sfdAtTheMovies = new System.Windows.Forms.SaveFileDialog();
            this.ofdAtTheMovies = new System.Windows.Forms.OpenFileDialog();
            this.grpMovieSelection.SuspendLayout();
            this.mnuAtTheMovies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.grpAmountDue.SuspendLayout();
            this.grpTickets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updChildSenior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updAdult)).BeginInit();
            this.grpTransaction.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnOpen.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(221, 25);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(104, 37);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "&Open";
            this.ttpAtTheMovies.SetToolTip(this.btnOpen, "Select a new text file containing movie titles.");
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // grpMovieSelection
            // 
            this.grpMovieSelection.Controls.Add(this.lblMovieTitle);
            this.grpMovieSelection.Controls.Add(this.cboInMovieTimes);
            this.grpMovieSelection.Controls.Add(this.cboInMovieTitles);
            this.grpMovieSelection.Controls.Add(this.lblOutMovieRating);
            this.grpMovieSelection.Controls.Add(this.lblOutMovieRuntime);
            this.grpMovieSelection.Controls.Add(this.lblMovieTimes);
            this.grpMovieSelection.Controls.Add(this.lblMovieRating);
            this.grpMovieSelection.Controls.Add(this.lblMovieRuntime);
            this.grpMovieSelection.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMovieSelection.Location = new System.Drawing.Point(31, 146);
            this.grpMovieSelection.Name = "grpMovieSelection";
            this.grpMovieSelection.Size = new System.Drawing.Size(574, 100);
            this.grpMovieSelection.TabIndex = 0;
            this.grpMovieSelection.TabStop = false;
            this.grpMovieSelection.Text = "Movie Selection:";
            // 
            // lblMovieTitle
            // 
            this.lblMovieTitle.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieTitle.Location = new System.Drawing.Point(6, 25);
            this.lblMovieTitle.Name = "lblMovieTitle";
            this.lblMovieTitle.Size = new System.Drawing.Size(147, 23);
            this.lblMovieTitle.TabIndex = 9;
            this.lblMovieTitle.Text = "Movie Title:";
            this.lblMovieTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboInMovieTimes
            // 
            this.cboInMovieTimes.BackColor = System.Drawing.Color.PaleTurquoise;
            this.cboInMovieTimes.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboInMovieTimes.FormattingEnabled = true;
            this.cboInMovieTimes.Location = new System.Drawing.Point(424, 52);
            this.cboInMovieTimes.MaxDropDownItems = 100;
            this.cboInMovieTimes.Name = "cboInMovieTimes";
            this.cboInMovieTimes.Size = new System.Drawing.Size(144, 29);
            this.cboInMovieTimes.TabIndex = 1;
            this.ttpAtTheMovies.SetToolTip(this.cboInMovieTimes, "Select a movie showtime.");
            this.cboInMovieTimes.SelectedIndexChanged += new System.EventHandler(this.cboInMovieTimes_SelectedIndexChanged);
            this.cboInMovieTimes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboInMovieTimes_KeyPress);
            // 
            // cboInMovieTitles
            // 
            this.cboInMovieTitles.BackColor = System.Drawing.Color.PaleTurquoise;
            this.cboInMovieTitles.DropDownWidth = 160;
            this.cboInMovieTitles.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboInMovieTitles.FormattingEnabled = true;
            this.cboInMovieTitles.Location = new System.Drawing.Point(6, 52);
            this.cboInMovieTitles.MaxDropDownItems = 100;
            this.cboInMovieTitles.Name = "cboInMovieTitles";
            this.cboInMovieTitles.Size = new System.Drawing.Size(147, 29);
            this.cboInMovieTitles.TabIndex = 0;
            this.ttpAtTheMovies.SetToolTip(this.cboInMovieTitles, "Select a movie title.");
            this.cboInMovieTitles.SelectedIndexChanged += new System.EventHandler(this.cboInMovieTitles_SelectedIndexChanged);
            this.cboInMovieTitles.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboInMovieTitles_KeyPress);
            // 
            // lblOutMovieRating
            // 
            this.lblOutMovieRating.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblOutMovieRating.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutMovieRating.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutMovieRating.Location = new System.Drawing.Point(302, 52);
            this.lblOutMovieRating.Name = "lblOutMovieRating";
            this.lblOutMovieRating.Size = new System.Drawing.Size(104, 28);
            this.lblOutMovieRating.TabIndex = 4;
            this.lblOutMovieRating.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutMovieRuntime
            // 
            this.lblOutMovieRuntime.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblOutMovieRuntime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutMovieRuntime.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutMovieRuntime.Location = new System.Drawing.Point(171, 52);
            this.lblOutMovieRuntime.Name = "lblOutMovieRuntime";
            this.lblOutMovieRuntime.Size = new System.Drawing.Size(106, 28);
            this.lblOutMovieRuntime.TabIndex = 3;
            this.lblOutMovieRuntime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMovieTimes
            // 
            this.lblMovieTimes.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieTimes.Location = new System.Drawing.Point(424, 25);
            this.lblMovieTimes.Name = "lblMovieTimes";
            this.lblMovieTimes.Size = new System.Drawing.Size(144, 20);
            this.lblMovieTimes.TabIndex = 2;
            this.lblMovieTimes.Text = "Movie Times:";
            this.lblMovieTimes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMovieRating
            // 
            this.lblMovieRating.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieRating.Location = new System.Drawing.Point(298, 25);
            this.lblMovieRating.Name = "lblMovieRating";
            this.lblMovieRating.Size = new System.Drawing.Size(108, 20);
            this.lblMovieRating.TabIndex = 1;
            this.lblMovieRating.Text = "Rating:";
            this.lblMovieRating.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMovieRuntime
            // 
            this.lblMovieRuntime.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieRuntime.Location = new System.Drawing.Point(171, 25);
            this.lblMovieRuntime.Name = "lblMovieRuntime";
            this.lblMovieRuntime.Size = new System.Drawing.Size(106, 23);
            this.lblMovieRuntime.TabIndex = 0;
            this.lblMovieRuntime.Text = "Runtime:";
            this.lblMovieRuntime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mnuAtTheMovies
            // 
            this.mnuAtTheMovies.BackColor = System.Drawing.Color.Azure;
            this.mnuAtTheMovies.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuTransaction,
            this.mnuHelp});
            this.mnuAtTheMovies.Location = new System.Drawing.Point(0, 0);
            this.mnuAtTheMovies.Name = "mnuAtTheMovies";
            this.mnuAtTheMovies.Size = new System.Drawing.Size(636, 25);
            this.mnuAtTheMovies.TabIndex = 3;
            this.mnuAtTheMovies.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileOpen,
            this.mnuFileSave,
            this.mnuFilePrintGUI,
            this.mnuFilePrintResults,
            this.mnuFileExit});
            this.mnuFile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(39, 21);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuFileOpen.Size = new System.Drawing.Size(225, 22);
            this.mnuFileOpen.Text = "&Open";
            this.mnuFileOpen.ToolTipText = "Select a new text file containing movie titles.";
            this.mnuFileOpen.Click += new System.EventHandler(this.mnuFileOpen_Click);
            // 
            // mnuFileSave
            // 
            this.mnuFileSave.Name = "mnuFileSave";
            this.mnuFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuFileSave.Size = new System.Drawing.Size(225, 22);
            this.mnuFileSave.Text = "&Save";
            this.mnuFileSave.ToolTipText = "Save the transactional history to a new text file.";
            this.mnuFileSave.Click += new System.EventHandler(this.mnuFileSave_Click);
            // 
            // mnuFilePrintGUI
            // 
            this.mnuFilePrintGUI.Name = "mnuFilePrintGUI";
            this.mnuFilePrintGUI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.mnuFilePrintGUI.Size = new System.Drawing.Size(225, 22);
            this.mnuFilePrintGUI.Text = "Print &Form";
            this.mnuFilePrintGUI.ToolTipText = "Print the application\'s GUI.";
            this.mnuFilePrintGUI.Click += new System.EventHandler(this.mnuFilePrintGUI_Click);
            // 
            // mnuFilePrintResults
            // 
            this.mnuFilePrintResults.Name = "mnuFilePrintResults";
            this.mnuFilePrintResults.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.mnuFilePrintResults.Size = new System.Drawing.Size(225, 22);
            this.mnuFilePrintResults.Text = "Print &Results";
            this.mnuFilePrintResults.ToolTipText = "Print the application\'s transactional history.";
            this.mnuFilePrintResults.Click += new System.EventHandler(this.mnuFilePrintResults_Click);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mnuFileExit.Size = new System.Drawing.Size(225, 22);
            this.mnuFileExit.Text = "Exit";
            this.mnuFileExit.ToolTipText = "Exit the application.";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // mnuTransaction
            // 
            this.mnuTransaction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTransactionCalculate,
            this.mnuTransactionClear,
            this.mnuTransactionReset});
            this.mnuTransaction.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuTransaction.Name = "mnuTransaction";
            this.mnuTransaction.Size = new System.Drawing.Size(86, 21);
            this.mnuTransaction.Text = "&Transaction";
            // 
            // mnuTransactionCalculate
            // 
            this.mnuTransactionCalculate.Name = "mnuTransactionCalculate";
            this.mnuTransactionCalculate.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.mnuTransactionCalculate.Size = new System.Drawing.Size(193, 22);
            this.mnuTransactionCalculate.Text = "&Calculate";
            this.mnuTransactionCalculate.ToolTipText = "Calculate the transactional total.";
            this.mnuTransactionCalculate.Click += new System.EventHandler(this.mnuTransactionCalculate_Click);
            // 
            // mnuTransactionClear
            // 
            this.mnuTransactionClear.Name = "mnuTransactionClear";
            this.mnuTransactionClear.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.mnuTransactionClear.Size = new System.Drawing.Size(193, 22);
            this.mnuTransactionClear.Text = "C&lear";
            this.mnuTransactionClear.ToolTipText = "Clears all inputs and outputs in Movie Selection, Select Tickets, and Amount Due." +
    "";
            this.mnuTransactionClear.Click += new System.EventHandler(this.mnuTransactionClear_Click);
            // 
            // mnuTransactionReset
            // 
            this.mnuTransactionReset.Name = "mnuTransactionReset";
            this.mnuTransactionReset.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.mnuTransactionReset.Size = new System.Drawing.Size(193, 22);
            this.mnuTransactionReset.Text = "&Reset History";
            this.mnuTransactionReset.ToolTipText = "Clears all inputs contained in Transaction History and Totals.";
            this.mnuTransactionReset.Click += new System.EventHandler(this.mnuTransactionReset_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpAbout,
            this.mnuHelpMovieTrailers});
            this.mnuHelp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(47, 21);
            this.mnuHelp.Text = "&Help";
            this.mnuHelp.ToolTipText = "Shows the application\'s About form.";
            // 
            // mnuHelpAbout
            // 
            this.mnuHelpAbout.Name = "mnuHelpAbout";
            this.mnuHelpAbout.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.mnuHelpAbout.Size = new System.Drawing.Size(212, 22);
            this.mnuHelpAbout.Text = "&About";
            this.mnuHelpAbout.Click += new System.EventHandler(this.mnuHelpAbout_Click);
            // 
            // mnuHelpMovieTrailers
            // 
            this.mnuHelpMovieTrailers.Name = "mnuHelpMovieTrailers";
            this.mnuHelpMovieTrailers.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.mnuHelpMovieTrailers.Size = new System.Drawing.Size(212, 22);
            this.mnuHelpMovieTrailers.Text = "Featured &Trailers";
            this.mnuHelpMovieTrailers.Click += new System.EventHandler(this.mnuHelpMovieTrailers_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(0, 27);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(630, 113);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 4;
            this.picLogo.TabStop = false;
            // 
            // lblOutSubtotal
            // 
            this.lblOutSubtotal.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblOutSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutSubtotal.Font = new System.Drawing.Font("Franklin Gothic Book", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutSubtotal.ForeColor = System.Drawing.Color.Crimson;
            this.lblOutSubtotal.Location = new System.Drawing.Point(6, 25);
            this.lblOutSubtotal.Name = "lblOutSubtotal";
            this.lblOutSubtotal.Size = new System.Drawing.Size(209, 82);
            this.lblOutSubtotal.TabIndex = 5;
            this.lblOutSubtotal.Text = "$Subtotal";
            this.lblOutSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpAmountDue
            // 
            this.grpAmountDue.Controls.Add(this.btnClear);
            this.grpAmountDue.Controls.Add(this.lblOutSubtotal);
            this.grpAmountDue.Controls.Add(this.btnOpen);
            this.grpAmountDue.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAmountDue.Location = new System.Drawing.Point(274, 252);
            this.grpAmountDue.Name = "grpAmountDue";
            this.grpAmountDue.Size = new System.Drawing.Size(331, 120);
            this.grpAmountDue.TabIndex = 2;
            this.grpAmountDue.TabStop = false;
            this.grpAmountDue.Text = "Amount Due (Including Tax):";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Crimson;
            this.btnClear.Location = new System.Drawing.Point(221, 68);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 39);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "&Clear";
            this.ttpAtTheMovies.SetToolTip(this.btnClear, "Clears all inputs and outputs in Movie Selection, Select Tickets, and Amount Due." +
        "");
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // grpTickets
            // 
            this.grpTickets.Controls.Add(this.updChildSenior);
            this.grpTickets.Controls.Add(this.updAdult);
            this.grpTickets.Controls.Add(this.lblTicketChildSenior);
            this.grpTickets.Controls.Add(this.lblTicketAdult);
            this.grpTickets.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTickets.Location = new System.Drawing.Point(31, 252);
            this.grpTickets.Name = "grpTickets";
            this.grpTickets.Size = new System.Drawing.Size(237, 120);
            this.grpTickets.TabIndex = 1;
            this.grpTickets.TabStop = false;
            this.grpTickets.Text = "Select Tickets:";
            // 
            // updChildSenior
            // 
            this.updChildSenior.BackColor = System.Drawing.Color.PaleTurquoise;
            this.updChildSenior.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updChildSenior.Location = new System.Drawing.Point(32, 68);
            this.updChildSenior.Name = "updChildSenior";
            this.updChildSenior.ReadOnly = true;
            this.updChildSenior.Size = new System.Drawing.Size(50, 26);
            this.updChildSenior.TabIndex = 1;
            this.updChildSenior.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ttpAtTheMovies.SetToolTip(this.updChildSenior, "Select a number of discounted/child and senior tickets.");
            this.updChildSenior.ValueChanged += new System.EventHandler(this.updChildSenior_ValueChanged);
            // 
            // updAdult
            // 
            this.updAdult.BackColor = System.Drawing.Color.PaleTurquoise;
            this.updAdult.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updAdult.Location = new System.Drawing.Point(32, 32);
            this.updAdult.Name = "updAdult";
            this.updAdult.ReadOnly = true;
            this.updAdult.Size = new System.Drawing.Size(50, 26);
            this.updAdult.TabIndex = 0;
            this.updAdult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ttpAtTheMovies.SetToolTip(this.updAdult, "Select a number of standard/adult tickets.");
            this.updAdult.ValueChanged += new System.EventHandler(this.updAdult_ValueChanged);
            // 
            // lblTicketChildSenior
            // 
            this.lblTicketChildSenior.AutoSize = true;
            this.lblTicketChildSenior.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketChildSenior.Location = new System.Drawing.Point(107, 68);
            this.lblTicketChildSenior.Name = "lblTicketChildSenior";
            this.lblTicketChildSenior.Size = new System.Drawing.Size(109, 24);
            this.lblTicketChildSenior.TabIndex = 6;
            this.lblTicketChildSenior.Text = "Child/Senior";
            // 
            // lblTicketAdult
            // 
            this.lblTicketAdult.AutoSize = true;
            this.lblTicketAdult.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketAdult.Location = new System.Drawing.Point(107, 33);
            this.lblTicketAdult.Name = "lblTicketAdult";
            this.lblTicketAdult.Size = new System.Drawing.Size(50, 24);
            this.lblTicketAdult.TabIndex = 5;
            this.lblTicketAdult.Text = "Adult";
            // 
            // grpTransaction
            // 
            this.grpTransaction.Controls.Add(this.btnResetList);
            this.grpTransaction.Controls.Add(this.btnExit);
            this.grpTransaction.Controls.Add(this.btnCalculate);
            this.grpTransaction.Controls.Add(this.lblOutTransactionTotal);
            this.grpTransaction.Controls.Add(this.lstTransactionTotal);
            this.grpTransaction.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTransaction.Location = new System.Drawing.Point(31, 371);
            this.grpTransaction.Name = "grpTransaction";
            this.grpTransaction.Size = new System.Drawing.Size(574, 164);
            this.grpTransaction.TabIndex = 3;
            this.grpTransaction.TabStop = false;
            this.grpTransaction.Text = "Transaction History and Totals:";
            // 
            // btnResetList
            // 
            this.btnResetList.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnResetList.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnResetList.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetList.ForeColor = System.Drawing.Color.Crimson;
            this.btnResetList.Location = new System.Drawing.Point(464, 102);
            this.btnResetList.Name = "btnResetList";
            this.btnResetList.Size = new System.Drawing.Size(104, 26);
            this.btnResetList.TabIndex = 1;
            this.btnResetList.Text = "&Reset";
            this.ttpAtTheMovies.SetToolTip(this.btnResetList, "Clears all inputs contained in Transaction History and Totals.");
            this.btnResetList.UseVisualStyleBackColor = false;
            this.btnResetList.Click += new System.EventHandler(this.btnResetList_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Crimson;
            this.btnExit.Location = new System.Drawing.Point(464, 127);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 26);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.ttpAtTheMovies.SetToolTip(this.btnExit, "Exit the application.");
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCalculate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCalculate.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(359, 102);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(104, 52);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "&Calculate";
            this.ttpAtTheMovies.SetToolTip(this.btnCalculate, "Calculate the transactional total.");
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblOutTransactionTotal
            // 
            this.lblOutTransactionTotal.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblOutTransactionTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutTransactionTotal.Font = new System.Drawing.Font("Franklin Gothic Book", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutTransactionTotal.ForeColor = System.Drawing.Color.Crimson;
            this.lblOutTransactionTotal.Location = new System.Drawing.Point(359, 22);
            this.lblOutTransactionTotal.Name = "lblOutTransactionTotal";
            this.lblOutTransactionTotal.Size = new System.Drawing.Size(209, 77);
            this.lblOutTransactionTotal.TabIndex = 7;
            this.lblOutTransactionTotal.Text = "$Total";
            this.lblOutTransactionTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstTransactionTotal
            // 
            this.lstTransactionTotal.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lstTransactionTotal.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTransactionTotal.FormattingEnabled = true;
            this.lstTransactionTotal.ItemHeight = 17;
            this.lstTransactionTotal.Location = new System.Drawing.Point(10, 22);
            this.lstTransactionTotal.Name = "lstTransactionTotal";
            this.lstTransactionTotal.Size = new System.Drawing.Size(347, 123);
            this.lstTransactionTotal.TabIndex = 6;
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.BackColor = System.Drawing.Color.Azure;
            this.lblCurrentTime.Font = new System.Drawing.Font("Franklin Gothic Heavy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTime.Location = new System.Drawing.Point(180, 0);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(456, 24);
            this.lblCurrentTime.TabIndex = 10;
            this.lblCurrentTime.Text = "dddd MM/dd/yyyy HH:mm:ss tt ";
            this.lblCurrentTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tmrAtTheMovies_CurrentTime
            // 
            this.tmrAtTheMovies_CurrentTime.Enabled = true;
            this.tmrAtTheMovies_CurrentTime.Tick += new System.EventHandler(this.tmrMnuTimer_Tick);
            // 
            // pdAtTheMovies_Results
            // 
            this.pdAtTheMovies_Results.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdAtTheMovies_Results_PrintPage);
            // 
            // pdAtTheMovies_GUI
            // 
            this.pdAtTheMovies_GUI.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdAtTheMovies_GUI_PrintPage);
            // 
            // ppdAtTheMovies
            // 
            this.ppdAtTheMovies.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppdAtTheMovies.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppdAtTheMovies.ClientSize = new System.Drawing.Size(400, 300);
            this.ppdAtTheMovies.Document = this.pdAtTheMovies_Results;
            this.ppdAtTheMovies.Enabled = true;
            this.ppdAtTheMovies.Icon = ((System.Drawing.Icon)(resources.GetObject("ppdAtTheMovies.Icon")));
            this.ppdAtTheMovies.Name = "ppdAtTheMovies";
            this.ppdAtTheMovies.Visible = false;
            // 
            // frmAtTheMovies
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(636, 536);
            this.Controls.Add(this.lblCurrentTime);
            this.Controls.Add(this.grpTransaction);
            this.Controls.Add(this.grpTickets);
            this.Controls.Add(this.grpAmountDue);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.grpMovieSelection);
            this.Controls.Add(this.mnuAtTheMovies);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuAtTheMovies;
            this.MaximizeBox = false;
            this.Name = "frmAtTheMovies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project #3 - At The Movies";
            this.Load += new System.EventHandler(this.frmAtTheMovies_Load);
            this.grpMovieSelection.ResumeLayout(false);
            this.mnuAtTheMovies.ResumeLayout(false);
            this.mnuAtTheMovies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.grpAmountDue.ResumeLayout(false);
            this.grpTickets.ResumeLayout(false);
            this.grpTickets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updChildSenior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updAdult)).EndInit();
            this.grpTransaction.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ToolTip ttpAtTheMovies;
        public System.Drawing.Printing.PrintDocument pdAtTheMovies_Results;
        public System.Drawing.Printing.PrintDocument pdAtTheMovies_GUI;
        public System.Windows.Forms.PrintPreviewDialog ppdAtTheMovies;
        public System.Windows.Forms.SaveFileDialog sfdAtTheMovies;
        public System.Windows.Forms.OpenFileDialog ofdAtTheMovies;
        public System.Windows.Forms.MenuStrip mnuAtTheMovies;
        public System.Windows.Forms.Timer tmrAtTheMovies_CurrentTime;
        public System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
        public System.Windows.Forms.ToolStripMenuItem mnuTransactionCalculate;
        public System.Windows.Forms.ToolStripMenuItem mnuTransactionReset;
        public System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
        public System.Windows.Forms.ToolStripMenuItem mnuFileSave;
        public System.Windows.Forms.ComboBox cboInMovieTitles;
        public System.Windows.Forms.ComboBox cboInMovieTimes;
        public System.Windows.Forms.Button btnOpen;
        public System.Windows.Forms.GroupBox grpMovieSelection;
        public System.Windows.Forms.Label lblMovieTimes;
        public System.Windows.Forms.Label lblMovieRating;
        public System.Windows.Forms.Label lblMovieRuntime;
        public System.Windows.Forms.ToolStripMenuItem mnuFile;
        public System.Windows.Forms.ToolStripMenuItem mnuTransaction;
        public System.Windows.Forms.ToolStripMenuItem mnuHelp;
        public System.Windows.Forms.PictureBox picLogo;
        public System.Windows.Forms.GroupBox grpAmountDue;
        public System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.GroupBox grpTickets;
        public System.Windows.Forms.Label lblTicketAdult;
        public System.Windows.Forms.Label lblTicketChildSenior;
        public System.Windows.Forms.GroupBox grpTransaction;
        public System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Button btnCalculate;
        public System.Windows.Forms.Label lblMovieTitle;
        public System.Windows.Forms.Label lblCurrentTime;
        public System.Windows.Forms.ToolStripMenuItem mnuFilePrintGUI;
        public System.Windows.Forms.ToolStripMenuItem mnuFilePrintResults;
        public System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        public System.Windows.Forms.NumericUpDown updChildSenior;
        public System.Windows.Forms.NumericUpDown updAdult;
        public System.Windows.Forms.ListBox lstTransactionTotal;
        public System.Windows.Forms.Label lblOutMovieRating;
        public System.Windows.Forms.Label lblOutMovieRuntime;
        public System.Windows.Forms.Label lblOutSubtotal;
        public System.Windows.Forms.Label lblOutTransactionTotal;
        public System.Windows.Forms.Button btnResetList;
        public System.Windows.Forms.ToolStripMenuItem mnuTransactionClear;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpMovieTrailers;
    }
}

