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
            this.userIconElement = new System.Windows.Forms.PictureBox();
            this.userLoginElement = new System.Windows.Forms.Label();
            this.openWatchedButton = new System.Windows.Forms.Button();
            this.openFavoriteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanelMovie = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.userIconElement)).BeginInit();
            this.SuspendLayout();
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
            // userLoginElement
            // 
            this.userLoginElement.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userLoginElement.ForeColor = System.Drawing.Color.White;
            this.userLoginElement.Location = new System.Drawing.Point(5, 9);
            this.userLoginElement.Name = "userLoginElement";
            this.userLoginElement.Size = new System.Drawing.Size(244, 39);
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(158, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Count";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(158, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Count";
            // 
            // tableLayoutPanelMovie
            // 
            this.tableLayoutPanelMovie.BackColor = System.Drawing.Color.Silver;
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
            // UserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1033, 574);
            this.Controls.Add(this.tableLayoutPanelMovie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openFavoriteButton);
            this.Controls.Add(this.openWatchedButton);
            this.Controls.Add(this.userLoginElement);
            this.Controls.Add(this.userIconElement);
            this.Name = "UserPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserPage";
            this.Load += new System.EventHandler(this.UserPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userIconElement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox userIconElement;
        private System.Windows.Forms.Label userLoginElement;
        private System.Windows.Forms.Button openWatchedButton;
        private System.Windows.Forms.Button openFavoriteButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMovie;
    }
}