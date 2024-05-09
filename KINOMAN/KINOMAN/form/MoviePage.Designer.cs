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
            this.DeleteButton = new System.Windows.Forms.Button();
            this.watchButton = new System.Windows.Forms.Button();
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
            this.addWatched.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(14)))), ((int)(((byte)(25)))));
            this.addWatched.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addWatched.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addWatched.ForeColor = System.Drawing.Color.IndianRed;
            this.addWatched.Location = new System.Drawing.Point(453, 497);
            this.addWatched.Name = "addWatched";
            this.addWatched.Size = new System.Drawing.Size(279, 37);
            this.addWatched.TabIndex = 3;
            this.addWatched.Text = "Просмотренно";
            this.addWatched.UseVisualStyleBackColor = false;
            this.addWatched.Click += new System.EventHandler(this.addWatched_Click);
            // 
            // addFavorite
            // 
            this.addFavorite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addFavorite.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addFavorite.ForeColor = System.Drawing.Color.IndianRed;
            this.addFavorite.Location = new System.Drawing.Point(741, 497);
            this.addFavorite.Name = "addFavorite";
            this.addFavorite.Size = new System.Drawing.Size(279, 37);
            this.addFavorite.TabIndex = 4;
            this.addFavorite.Text = "Добавить в избранное";
            this.addFavorite.UseVisualStyleBackColor = true;
            this.addFavorite.Click += new System.EventHandler(this.addFavorite_Click);
            // 
            // descriptionMovie
            // 
            this.descriptionMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(14)))), ((int)(((byte)(25)))));
            this.descriptionMovie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionMovie.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionMovie.ForeColor = System.Drawing.Color.White;
            this.descriptionMovie.Location = new System.Drawing.Point(453, 83);
            this.descriptionMovie.MaxLength = 1200;
            this.descriptionMovie.Multiline = true;
            this.descriptionMovie.Name = "descriptionMovie";
            this.descriptionMovie.ReadOnly = true;
            this.descriptionMovie.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionMovie.Size = new System.Drawing.Size(567, 350);
            this.descriptionMovie.TabIndex = 5;
            this.descriptionMovie.Text = resources.GetString("descriptionMovie.Text");
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(922, 12);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(98, 26);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // watchButton
            // 
            this.watchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(14)))), ((int)(((byte)(25)))));
            this.watchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.watchButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.watchButton.ForeColor = System.Drawing.Color.Brown;
            this.watchButton.Location = new System.Drawing.Point(453, 454);
            this.watchButton.Name = "watchButton";
            this.watchButton.Size = new System.Drawing.Size(568, 37);
            this.watchButton.TabIndex = 7;
            this.watchButton.Text = "Смотреть";
            this.watchButton.UseVisualStyleBackColor = false;
            this.watchButton.Click += new System.EventHandler(this.watchButton_Click);
            // 
            // MoviePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(14)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1033, 567);
            this.Controls.Add(this.watchButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.descriptionMovie);
            this.Controls.Add(this.addFavorite);
            this.Controls.Add(this.addWatched);
            this.Controls.Add(this.titleMovie);
            this.Controls.Add(this.pictureBoxFilm);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MoviePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button watchButton;
    }
}