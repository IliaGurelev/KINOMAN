namespace KINOMAN.form
{
    partial class UserPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPage));
            this.userLoginElement = new System.Windows.Forms.Label();
            this.openWatchedButton = new System.Windows.Forms.Button();
            this.openFavoriteButton = new System.Windows.Forms.Button();
            this.watchedCountLabel = new System.Windows.Forms.Label();
            this.favoriteCountLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanelMovie = new System.Windows.Forms.TableLayoutPanel();
            this.labelNameList = new System.Windows.Forms.Label();
            this.BackToFormButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.PictureBox();
            this.optionUserButton = new System.Windows.Forms.PictureBox();
            this.userIconElement = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logOutButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionUserButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIconElement)).BeginInit();
            this.SuspendLayout();
            // 
            // userLoginElement
            // 
            this.userLoginElement.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userLoginElement.ForeColor = System.Drawing.Color.White;
            this.userLoginElement.Location = new System.Drawing.Point(5, 9);
            this.userLoginElement.Name = "userLoginElement";
            this.userLoginElement.Size = new System.Drawing.Size(214, 39);
            this.userLoginElement.TabIndex = 1;
            this.userLoginElement.Text = "UserName";
            this.userLoginElement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // openWatchedButton
            // 
            this.openWatchedButton.Location = new System.Drawing.Point(12, 314);
            this.openWatchedButton.Name = "openWatchedButton";
            this.openWatchedButton.Size = new System.Drawing.Size(140, 28);
            this.openWatchedButton.TabIndex = 2;
            this.openWatchedButton.Text = "Просмотренные";
            this.openWatchedButton.UseVisualStyleBackColor = true;
            this.openWatchedButton.Click += new System.EventHandler(this.openWatchedButton_Click);
            // 
            // openFavoriteButton
            // 
            this.openFavoriteButton.Location = new System.Drawing.Point(12, 366);
            this.openFavoriteButton.Name = "openFavoriteButton";
            this.openFavoriteButton.Size = new System.Drawing.Size(140, 27);
            this.openFavoriteButton.TabIndex = 3;
            this.openFavoriteButton.Text = "В избранном";
            this.openFavoriteButton.UseVisualStyleBackColor = true;
            this.openFavoriteButton.Click += new System.EventHandler(this.openFavoriteButton_Click);
            // 
            // watchedCountLabel
            // 
            this.watchedCountLabel.AutoSize = true;
            this.watchedCountLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.watchedCountLabel.ForeColor = System.Drawing.Color.White;
            this.watchedCountLabel.Location = new System.Drawing.Point(158, 316);
            this.watchedCountLabel.Name = "watchedCountLabel";
            this.watchedCountLabel.Size = new System.Drawing.Size(52, 21);
            this.watchedCountLabel.TabIndex = 4;
            this.watchedCountLabel.Text = "Count";
            // 
            // favoriteCountLabel
            // 
            this.favoriteCountLabel.AutoSize = true;
            this.favoriteCountLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.favoriteCountLabel.ForeColor = System.Drawing.Color.White;
            this.favoriteCountLabel.Location = new System.Drawing.Point(158, 367);
            this.favoriteCountLabel.Name = "favoriteCountLabel";
            this.favoriteCountLabel.Size = new System.Drawing.Size(52, 21);
            this.favoriteCountLabel.TabIndex = 5;
            this.favoriteCountLabel.Text = "Count";
            // 
            // tableLayoutPanelMovie
            // 
            this.tableLayoutPanelMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(14)))), ((int)(((byte)(25)))));
            this.tableLayoutPanelMovie.ColumnCount = 4;
            this.tableLayoutPanelMovie.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMovie.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMovie.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMovie.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMovie.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMovie.Location = new System.Drawing.Point(255, 45);
            this.tableLayoutPanelMovie.Name = "tableLayoutPanelMovie";
            this.tableLayoutPanelMovie.RowCount = 4;
            this.tableLayoutPanelMovie.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tableLayoutPanelMovie.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelMovie.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tableLayoutPanelMovie.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMovie.Size = new System.Drawing.Size(766, 490);
            this.tableLayoutPanelMovie.TabIndex = 6;
            // 
            // labelNameList
            // 
            this.labelNameList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameList.ForeColor = System.Drawing.Color.White;
            this.labelNameList.Location = new System.Drawing.Point(836, 18);
            this.labelNameList.Name = "labelNameList";
            this.labelNameList.Size = new System.Drawing.Size(185, 24);
            this.labelNameList.TabIndex = 7;
            this.labelNameList.Text = "Просмотренно";
            this.labelNameList.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BackToFormButton
            // 
            this.BackToFormButton.Location = new System.Drawing.Point(919, 541);
            this.BackToFormButton.Name = "BackToFormButton";
            this.BackToFormButton.Size = new System.Drawing.Size(102, 23);
            this.BackToFormButton.TabIndex = 9;
            this.BackToFormButton.Text = "На главную";
            this.BackToFormButton.UseVisualStyleBackColor = true;
            this.BackToFormButton.Click += new System.EventHandler(this.BackToFormButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOutButton.Image = global::KINOMAN.Properties.Resources.logOut_icon;
            this.logOutButton.InitialImage = global::KINOMAN.Properties.Resources.logOut_icon;
            this.logOutButton.Location = new System.Drawing.Point(214, 18);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(35, 38);
            this.logOutButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logOutButton.TabIndex = 10;
            this.logOutButton.TabStop = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // optionUserButton
            // 
            this.optionUserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optionUserButton.Image = global::KINOMAN.Properties.Resources.setings_icon;
            this.optionUserButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("optionUserButton.InitialImage")));
            this.optionUserButton.Location = new System.Drawing.Point(12, 530);
            this.optionUserButton.Name = "optionUserButton";
            this.optionUserButton.Size = new System.Drawing.Size(34, 32);
            this.optionUserButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.optionUserButton.TabIndex = 8;
            this.optionUserButton.TabStop = false;
            this.optionUserButton.Click += new System.EventHandler(this.optionUserButton_Click);
            // 
            // userIconElement
            // 
            this.userIconElement.Location = new System.Drawing.Point(12, 67);
            this.userIconElement.Name = "userIconElement";
            this.userIconElement.Size = new System.Drawing.Size(207, 207);
            this.userIconElement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userIconElement.TabIndex = 0;
            this.userIconElement.TabStop = false;
            // 
            // UserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(14)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1033, 574);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.BackToFormButton);
            this.Controls.Add(this.optionUserButton);
            this.Controls.Add(this.labelNameList);
            this.Controls.Add(this.tableLayoutPanelMovie);
            this.Controls.Add(this.favoriteCountLabel);
            this.Controls.Add(this.watchedCountLabel);
            this.Controls.Add(this.openFavoriteButton);
            this.Controls.Add(this.openWatchedButton);
            this.Controls.Add(this.userLoginElement);
            this.Controls.Add(this.userIconElement);
            this.Name = "UserPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Профиль";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserPage_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.logOutButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionUserButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIconElement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox userIconElement;
        private System.Windows.Forms.Label userLoginElement;
        private System.Windows.Forms.Button openWatchedButton;
        private System.Windows.Forms.Button openFavoriteButton;
        private System.Windows.Forms.Label watchedCountLabel;
        private System.Windows.Forms.Label favoriteCountLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMovie;
        private System.Windows.Forms.Label labelNameList;
        private System.Windows.Forms.PictureBox optionUserButton;
        private System.Windows.Forms.Button BackToFormButton;
        private System.Windows.Forms.PictureBox logOutButton;
    }
}