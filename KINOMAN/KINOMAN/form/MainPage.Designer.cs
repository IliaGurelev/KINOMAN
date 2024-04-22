namespace KINOMAN
{
    partial class MainPage
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.LogInButton = new System.Windows.Forms.Button();
            this.npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.paginationBackButton = new System.Windows.Forms.PictureBox();
            this.paginationNextButton = new System.Windows.Forms.PictureBox();
            this.filmContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.AppendMovieButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paginationBackButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paginationNextButton)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(14)))), ((int)(((byte)(25)))));
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
<<<<<<< HEAD
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1619, 903);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
=======
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1214, 734);
>>>>>>> 1f3c3d44a6ff2e1a253510c3a33f02a3f5204fc0
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // SignUpButton
            // 
<<<<<<< HEAD
            this.SignUpButton.Location = new System.Drawing.Point(1445, 5);
            this.SignUpButton.Margin = new System.Windows.Forms.Padding(4);
=======
            this.SignUpButton.Location = new System.Drawing.Point(1084, 4);
>>>>>>> 1f3c3d44a6ff2e1a253510c3a33f02a3f5204fc0
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(138, 23);
            this.SignUpButton.TabIndex = 10;
            this.SignUpButton.Text = "Зарегестрироваться";
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // LogInButton
            // 
<<<<<<< HEAD
            this.LogInButton.Location = new System.Drawing.Point(1244, 4);
            this.LogInButton.Margin = new System.Windows.Forms.Padding(4);
=======
            this.LogInButton.Location = new System.Drawing.Point(933, 3);
>>>>>>> 1f3c3d44a6ff2e1a253510c3a33f02a3f5204fc0
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(145, 24);
            this.LogInButton.TabIndex = 11;
            this.LogInButton.Text = "Войти";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // npgsqlDataAdapter1
            // 
            this.npgsqlDataAdapter1.DeleteCommand = null;
            this.npgsqlDataAdapter1.InsertCommand = null;
            this.npgsqlDataAdapter1.SelectCommand = null;
            this.npgsqlDataAdapter1.UpdateCommand = null;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KINOMAN.Properties.Resources.logo;
<<<<<<< HEAD
            this.pictureBox1.Location = new System.Drawing.Point(16, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
=======
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
>>>>>>> 1f3c3d44a6ff2e1a253510c3a33f02a3f5204fc0
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // paginationBackButton
            // 
            this.paginationBackButton.Image = ((System.Drawing.Image)(resources.GetObject("paginationBackButton.Image")));
<<<<<<< HEAD
            this.paginationBackButton.Location = new System.Drawing.Point(407, 873);
            this.paginationBackButton.Margin = new System.Windows.Forms.Padding(4);
=======
            this.paginationBackButton.Location = new System.Drawing.Point(305, 709);
>>>>>>> 1f3c3d44a6ff2e1a253510c3a33f02a3f5204fc0
            this.paginationBackButton.Name = "paginationBackButton";
            this.paginationBackButton.Size = new System.Drawing.Size(214, 39);
            this.paginationBackButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.paginationBackButton.TabIndex = 8;
            this.paginationBackButton.TabStop = false;
            this.paginationBackButton.Click += new System.EventHandler(this.paginationBackButton_Click);
            // 
            // paginationNextButton
            // 
            this.paginationNextButton.Image = ((System.Drawing.Image)(resources.GetObject("paginationNextButton.Image")));
<<<<<<< HEAD
            this.paginationNextButton.Location = new System.Drawing.Point(955, 873);
            this.paginationNextButton.Margin = new System.Windows.Forms.Padding(4);
=======
            this.paginationNextButton.Location = new System.Drawing.Point(716, 709);
>>>>>>> 1f3c3d44a6ff2e1a253510c3a33f02a3f5204fc0
            this.paginationNextButton.Name = "paginationNextButton";
            this.paginationNextButton.Size = new System.Drawing.Size(214, 39);
            this.paginationNextButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.paginationNextButton.TabIndex = 7;
            this.paginationNextButton.TabStop = false;
            this.paginationNextButton.Click += new System.EventHandler(this.paginationNextButton_Click);
            // 
            // filmContainer
            // 
            this.filmContainer.AutoScroll = true;
<<<<<<< HEAD
            this.filmContainer.Location = new System.Drawing.Point(16, 81);
            this.filmContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.filmContainer.Location = new System.Drawing.Point(12, 66);
            this.filmContainer.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> 1f3c3d44a6ff2e1a253510c3a33f02a3f5204fc0
            this.filmContainer.Name = "filmContainer";
            this.filmContainer.Size = new System.Drawing.Size(1210, 638);
            this.filmContainer.TabIndex = 16;
            // 
            // AppendMovieButton
            // 
<<<<<<< HEAD
            this.AppendMovieButton.Location = new System.Drawing.Point(16, 41);
            this.AppendMovieButton.Margin = new System.Windows.Forms.Padding(4);
            this.AppendMovieButton.Name = "AppendMovieButton";
            this.AppendMovieButton.Size = new System.Drawing.Size(193, 30);
=======
            this.AppendMovieButton.Location = new System.Drawing.Point(12, 33);
            this.AppendMovieButton.Name = "AppendMovieButton";
            this.AppendMovieButton.Size = new System.Drawing.Size(145, 24);
>>>>>>> 1f3c3d44a6ff2e1a253510c3a33f02a3f5204fc0
            this.AppendMovieButton.TabIndex = 17;
            this.AppendMovieButton.Text = "Добавить фильм";
            this.AppendMovieButton.UseVisualStyleBackColor = true;
            this.AppendMovieButton.Click += new System.EventHandler(this.AppendMovieButton_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(14)))), ((int)(((byte)(25)))));
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(1643, 924);
=======
            this.ClientSize = new System.Drawing.Size(1232, 752);
>>>>>>> 1f3c3d44a6ff2e1a253510c3a33f02a3f5204fc0
            this.Controls.Add(this.AppendMovieButton);
            this.Controls.Add(this.filmContainer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.paginationBackButton);
            this.Controls.Add(this.paginationNextButton);
            this.Controls.Add(this.tableLayoutPanel1);
<<<<<<< HEAD
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1661, 971);
            this.MinimumSize = new System.Drawing.Size(1533, 819);
=======
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1250, 798);
            this.MinimumSize = new System.Drawing.Size(1154, 674);
>>>>>>> 1f3c3d44a6ff2e1a253510c3a33f02a3f5204fc0
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            this.Activated += new System.EventHandler(this.MainPage_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paginationBackButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paginationNextButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox paginationNextButton;
        private System.Windows.Forms.PictureBox paginationBackButton;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
        private System.Windows.Forms.FlowLayoutPanel filmContainer;
        private System.Windows.Forms.Button AppendMovieButton;
    }
}

