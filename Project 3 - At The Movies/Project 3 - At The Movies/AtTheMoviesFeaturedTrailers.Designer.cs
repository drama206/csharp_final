namespace Project_3___At_The_Movies
{
    partial class AtTheMoviesFeaturedTrailers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AtTheMoviesFeaturedTrailers));
            this.axfMoviePlayer = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.lblSelectFeaturedTrailer = new System.Windows.Forms.Label();
            this.cboInMovieTrailers = new System.Windows.Forms.ComboBox();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.ttpAtTheMoviesFeaturedTrailers = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.axfMoviePlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // axfMoviePlayer
            // 
            resources.ApplyResources(this.axfMoviePlayer, "axfMoviePlayer");
            this.axfMoviePlayer.Name = "axfMoviePlayer";
            //this.axfMoviePlayer.ClientSize = new System.Drawing.Size(530, 300);
            this.axfMoviePlayer.ClientSize = new System.Drawing.Size(530, 300);
            this.axfMoviePlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axfMoviePlayer.OcxState")));
            this.ttpAtTheMoviesFeaturedTrailers.SetToolTip(this.axfMoviePlayer, resources.GetString("axfMoviePlayer.ToolTip"));
            // 
            // lblSelectFeaturedTrailer
            // 
            resources.ApplyResources(this.lblSelectFeaturedTrailer, "lblSelectFeaturedTrailer");
            this.lblSelectFeaturedTrailer.Name = "lblSelectFeaturedTrailer";
            this.ttpAtTheMoviesFeaturedTrailers.SetToolTip(this.lblSelectFeaturedTrailer, resources.GetString("lblSelectFeaturedTrailer.ToolTip"));
            // 
            // cboInMovieTrailers
            // 
            resources.ApplyResources(this.cboInMovieTrailers, "cboInMovieTrailers");
            this.cboInMovieTrailers.BackColor = System.Drawing.Color.PaleTurquoise;
            this.cboInMovieTrailers.DropDownWidth = 160;
            this.cboInMovieTrailers.FormattingEnabled = true;
            this.cboInMovieTrailers.Items.AddRange(new object[] {
            resources.GetString("cboInMovieTrailers.Items"),
            resources.GetString("cboInMovieTrailers.Items1"),
            resources.GetString("cboInMovieTrailers.Items2")});
            this.cboInMovieTrailers.Name = "cboInMovieTrailers";
            this.ttpAtTheMoviesFeaturedTrailers.SetToolTip(this.cboInMovieTrailers, resources.GetString("cboInMovieTrailers.ToolTip"));
            this.cboInMovieTrailers.SelectedIndexChanged += new System.EventHandler(this.cboInMovieTrailers_SelectedIndexChanged);
            // 
            // btnCloseForm
            // 
            resources.ApplyResources(this.btnCloseForm, "btnCloseForm");
            this.btnCloseForm.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCloseForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloseForm.ForeColor = System.Drawing.Color.Black;
            this.btnCloseForm.Name = "btnCloseForm";
            this.ttpAtTheMoviesFeaturedTrailers.SetToolTip(this.btnCloseForm, resources.GetString("btnCloseForm.ToolTip"));
            this.btnCloseForm.UseVisualStyleBackColor = false;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // AtTheMoviesFeaturedTrailers
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCloseForm;
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.cboInMovieTrailers);
            this.Controls.Add(this.lblSelectFeaturedTrailer);
            this.Controls.Add(this.axfMoviePlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AtTheMoviesFeaturedTrailers";
            this.ShowIcon = false;
            this.ttpAtTheMoviesFeaturedTrailers.SetToolTip(this, resources.GetString("$this.ToolTip"));
            ((System.ComponentModel.ISupportInitialize)(this.axfMoviePlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxShockwaveFlashObjects.AxShockwaveFlash axfMoviePlayer;
        private System.Windows.Forms.Label lblSelectFeaturedTrailer;
        public System.Windows.Forms.ComboBox cboInMovieTrailers;
        public System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.ToolTip ttpAtTheMoviesFeaturedTrailers;
    }
}