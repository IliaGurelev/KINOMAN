namespace KINOMAN
{
    partial class MoviePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoviePage));
            this.pictureBoxFilm = new System.Windows.Forms.PictureBox();
            this.titleMovie = new System.Windows.Forms.Label();
            this.addWatched = new System.Windows.Forms.Button();
            this.addFavorite = new System.Windows.Forms.Button();
            this.descriptionMovie = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilm)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxFilm
            // 
            this.pictureBoxFilm.Location = new System.Drawing.Point(40, 38);
            this.pictureBoxFilm.Name = "pictureBoxFilm";
            this.pictureBoxFilm.Size = new System.Drawing.Size(369, 496);
            this.pictureBoxFilm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFilm.TabIndex = 0;
            this.pictureBoxFilm.TabStop = false;
            // 
            // titleMovie
            // 
            this.titleMovie.AutoSize = true;
            this.titleMovie.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleMovie.ForeColor = System.Drawing.Color.White;
            this.titleMovie.Location = new System.Drawing.Point(699, 38);
            this.titleMovie.Name = "titleMovie";
            this.titleMovie.Size = new System.Drawing.Size(70, 37);
            this.titleMovie.TabIndex = 1;
            this.titleMovie.Text = "Title";
            // 
            // addWatched
            // 
            this.addWatched.Location = new System.Drawing.Point(453, 489);
            this.addWatched.Name = "addWatched";
            this.addWatched.Size = new System.Drawing.Size(277, 45);
            this.addWatched.TabIndex = 3;
            this.addWatched.Text = "Просмотренно";
            this.addWatched.UseVisualStyleBackColor = true;
            // 
            // addFavorite
            // 
            this.addFavorite.Location = new System.Drawing.Point(748, 489);
            this.addFavorite.Name = "addFavorite";
            this.addFavorite.Size = new System.Drawing.Size(273, 45);
            this.addFavorite.TabIndex = 4;
            this.addFavorite.Text = "Добавить в избранное";
            this.addFavorite.UseVisualStyleBackColor = true;
            // 
            // descriptionMovie
            // 
            this.descriptionMovie.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.descriptionMovie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionMovie.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionMovie.ForeColor = System.Drawing.Color.White;
            this.descriptionMovie.Location = new System.Drawing.Point(453, 83);
            this.descriptionMovie.Multiline = true;
            this.descriptionMovie.Name = "descriptionMovie";
            this.descriptionMovie.ReadOnly = true;
            this.descriptionMovie.Size = new System.Drawing.Size(567, 328);
            this.descriptionMovie.TabIndex = 5;
            this.descriptionMovie.Text = resources.GetString("descriptionMovie.Text");
            // 
            // MoviePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1033, 567);
            this.Controls.Add(this.descriptionMovie);
            this.Controls.Add(this.addFavorite);
            this.Controls.Add(this.addWatched);
            this.Controls.Add(this.titleMovie);
            this.Controls.Add(this.pictureBoxFilm);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MoviePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно фильма";
            this.Load += new System.EventHandler(this.MoviePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFilm;
        private System.Windows.Forms.Label titleMovie;
        private System.Windows.Forms.Button addWatched;
        private System.Windows.Forms.Button addFavorite;
        private System.Windows.Forms.TextBox descriptionMovie;
    }
}