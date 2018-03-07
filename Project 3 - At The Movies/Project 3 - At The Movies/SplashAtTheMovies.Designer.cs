namespace Project_3___At_The_Movies
{
    partial class SplashAtTheMovies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashAtTheMovies));
            this.pgbAtTheMovies = new System.Windows.Forms.ProgressBar();
            this.tmrAtTheMovies = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pgbAtTheMovies
            // 
            this.pgbAtTheMovies.ForeColor = System.Drawing.Color.Lime;
            this.pgbAtTheMovies.Location = new System.Drawing.Point(12, 238);
            this.pgbAtTheMovies.Name = "pgbAtTheMovies";
            this.pgbAtTheMovies.Size = new System.Drawing.Size(563, 36);
            this.pgbAtTheMovies.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbAtTheMovies.TabIndex = 0;
            // 
            // tmrAtTheMovies
            // 
            this.tmrAtTheMovies.Enabled = true;
            this.tmrAtTheMovies.Interval = 1;
            this.tmrAtTheMovies.Tick += new System.EventHandler(this.tmrAtTheMovies_Tick);
            // 
            // SplashAtTheMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(587, 508);
            this.Controls.Add(this.pgbAtTheMovies);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashAtTheMovies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashAtTheMovies";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgbAtTheMovies;
        private System.Windows.Forms.Timer tmrAtTheMovies;
    }
}