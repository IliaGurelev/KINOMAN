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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.paginationBackButton = new System.Windows.Forms.PictureBox();
            this.paginationNextButton = new System.Windows.Forms.PictureBox();
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 214);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1210, 490);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // SignUpButton
            // 
            this.SignUpButton.Location = new System.Drawing.Point(1084, 4);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(138, 23);
            this.SignUpButton.TabIndex = 10;
            this.SignUpButton.Text = "Зарегестрироваться";
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // LogInButton
            // 
            this.LogInButton.Location = new System.Drawing.Point(933, 3);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(145, 24);
            this.LogInButton.TabIndex = 11;
            this.LogInButton.Text = "Войти";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KINOMAN.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // paginationBackButton
            // 
            this.paginationBackButton.Image = ((System.Drawing.Image)(resources.GetObject("paginationBackButton.Image")));
            this.paginationBackButton.Location = new System.Drawing.Point(403, 710);
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
            this.paginationNextButton.Location = new System.Drawing.Point(637, 710);
            this.paginationNextButton.Name = "paginationNextButton";
            this.paginationNextButton.Size = new System.Drawing.Size(214, 39);
            this.paginationNextButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.paginationNextButton.TabIndex = 7;
            this.paginationNextButton.TabStop = false;
            this.paginationNextButton.Click += new System.EventHandler(this.paginationNextButton_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(14)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1234, 761);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.paginationBackButton);
            this.Controls.Add(this.paginationNextButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1250, 800);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

