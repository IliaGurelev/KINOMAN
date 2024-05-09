namespace KINOMAN.form
{
    partial class AppendMoviePage
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
            this.AddMovieButton = new System.Windows.Forms.Button();
            this.LabelNameMovie = new System.Windows.Forms.Label();
            this.AddPictureMovieBox = new System.Windows.Forms.PictureBox();
            this.NameMovieTextBox = new System.Windows.Forms.TextBox();
            this.LabelDescriptionMovie = new System.Windows.Forms.Label();
            this.DescriptionMovieTextBox = new System.Windows.Forms.TextBox();
            this.FileDialogAddImageMovie = new System.Windows.Forms.OpenFileDialog();
            this.watchUrlTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AddPictureMovieBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AddMovieButton
            // 
            this.AddMovieButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddMovieButton.ForeColor = System.Drawing.Color.IndianRed;
            this.AddMovieButton.Location = new System.Drawing.Point(905, 530);
            this.AddMovieButton.Name = "AddMovieButton";
            this.AddMovieButton.Size = new System.Drawing.Size(116, 29);
            this.AddMovieButton.TabIndex = 9;
            this.AddMovieButton.Text = "Добавить фильм";
            this.AddMovieButton.UseVisualStyleBackColor = true;
            this.AddMovieButton.Click += new System.EventHandler(this.AddMovieButton_Click);
            // 
            // LabelNameMovie
            // 
            this.LabelNameMovie.AutoSize = true;
            this.LabelNameMovie.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNameMovie.ForeColor = System.Drawing.Color.White;
            this.LabelNameMovie.Location = new System.Drawing.Point(407, 35);
            this.LabelNameMovie.Name = "LabelNameMovie";
            this.LabelNameMovie.Size = new System.Drawing.Size(145, 37);
            this.LabelNameMovie.TabIndex = 7;
            this.LabelNameMovie.Text = "Название:";
            // 
            // AddPictureMovieBox
            // 
            this.AddPictureMovieBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddPictureMovieBox.Location = new System.Drawing.Point(26, 35);
            this.AddPictureMovieBox.Name = "AddPictureMovieBox";
            this.AddPictureMovieBox.Size = new System.Drawing.Size(369, 496);
            this.AddPictureMovieBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddPictureMovieBox.TabIndex = 6;
            this.AddPictureMovieBox.TabStop = false;
            this.AddPictureMovieBox.Click += new System.EventHandler(this.AddPictureMovieBox_Click);
            // 
            // NameMovieTextBox
            // 
            this.NameMovieTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(14)))), ((int)(((byte)(25)))));
            this.NameMovieTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameMovieTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameMovieTextBox.ForeColor = System.Drawing.Color.White;
            this.NameMovieTextBox.Location = new System.Drawing.Point(545, 39);
            this.NameMovieTextBox.Name = "NameMovieTextBox";
            this.NameMovieTextBox.Size = new System.Drawing.Size(476, 35);
            this.NameMovieTextBox.TabIndex = 11;
            // 
            // LabelDescriptionMovie
            // 
            this.LabelDescriptionMovie.AutoSize = true;
            this.LabelDescriptionMovie.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelDescriptionMovie.ForeColor = System.Drawing.Color.White;
            this.LabelDescriptionMovie.Location = new System.Drawing.Point(407, 93);
            this.LabelDescriptionMovie.Name = "LabelDescriptionMovie";
            this.LabelDescriptionMovie.Size = new System.Drawing.Size(149, 37);
            this.LabelDescriptionMovie.TabIndex = 12;
            this.LabelDescriptionMovie.Text = "Описание:";
            // 
            // DescriptionMovieTextBox
            // 
            this.DescriptionMovieTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(14)))), ((int)(((byte)(25)))));
            this.DescriptionMovieTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescriptionMovieTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionMovieTextBox.ForeColor = System.Drawing.Color.White;
            this.DescriptionMovieTextBox.Location = new System.Drawing.Point(414, 144);
            this.DescriptionMovieTextBox.MaxLength = 1200;
            this.DescriptionMovieTextBox.Multiline = true;
            this.DescriptionMovieTextBox.Name = "DescriptionMovieTextBox";
            this.DescriptionMovieTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DescriptionMovieTextBox.Size = new System.Drawing.Size(607, 323);
            this.DescriptionMovieTextBox.TabIndex = 13;
            // 
            // FileDialogAddImageMovie
            // 
            this.FileDialogAddImageMovie.FileName = "openFileDialog1";
            // 
            // watchUrlTextBox
            // 
            this.watchUrlTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(14)))), ((int)(((byte)(25)))));
            this.watchUrlTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.watchUrlTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.watchUrlTextBox.ForeColor = System.Drawing.Color.White;
            this.watchUrlTextBox.Location = new System.Drawing.Point(684, 489);
            this.watchUrlTextBox.Name = "watchUrlTextBox";
            this.watchUrlTextBox.Size = new System.Drawing.Size(337, 35);
            this.watchUrlTextBox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(407, 485);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 37);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ссылка на просмотр:";
            // 
            // AppendMoviePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(14)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1033, 567);
            this.Controls.Add(this.watchUrlTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DescriptionMovieTextBox);
            this.Controls.Add(this.LabelDescriptionMovie);
            this.Controls.Add(this.NameMovieTextBox);
            this.Controls.Add(this.AddMovieButton);
            this.Controls.Add(this.LabelNameMovie);
            this.Controls.Add(this.AddPictureMovieBox);
            this.Name = "AppendMoviePage";
            this.Text = "Добавить фильм";
            ((System.ComponentModel.ISupportInitialize)(this.AddPictureMovieBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddMovieButton;
        private System.Windows.Forms.Label LabelNameMovie;
        private System.Windows.Forms.PictureBox AddPictureMovieBox;
        private System.Windows.Forms.TextBox NameMovieTextBox;
        private System.Windows.Forms.Label LabelDescriptionMovie;
        private System.Windows.Forms.TextBox DescriptionMovieTextBox;
        private System.Windows.Forms.OpenFileDialog FileDialogAddImageMovie;
        private System.Windows.Forms.TextBox watchUrlTextBox;
        private System.Windows.Forms.Label label1;
    }
}