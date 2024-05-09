namespace KINOMAN.form
{
    partial class UserOptionPage
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
            this.iconsTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.loginUserTextBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordUserTextBox = new System.Windows.Forms.TextBox();
            this.editPasswordButton = new System.Windows.Forms.PictureBox();
            this.editLoginButton = new System.Windows.Forms.PictureBox();
            this.userIconPictureBox = new System.Windows.Forms.PictureBox();
            this.BackToFormButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.editPasswordButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editLoginButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // iconsTableLayout
            // 
            this.iconsTableLayout.ColumnCount = 4;
            this.iconsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.iconsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.iconsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.iconsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.iconsTableLayout.Location = new System.Drawing.Point(245, 12);
            this.iconsTableLayout.Name = "iconsTableLayout";
            this.iconsTableLayout.RowCount = 2;
            this.iconsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.iconsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.iconsTableLayout.Size = new System.Drawing.Size(382, 207);
            this.iconsTableLayout.TabIndex = 4;
            // 
            // loginUserTextBox
            // 
            this.loginUserTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(14)))), ((int)(((byte)(25)))));
            this.loginUserTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginUserTextBox.Enabled = false;
            this.loginUserTextBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginUserTextBox.ForeColor = System.Drawing.Color.White;
            this.loginUserTextBox.Location = new System.Drawing.Point(112, 236);
            this.loginUserTextBox.Name = "loginUserTextBox";
            this.loginUserTextBox.ReadOnly = true;
            this.loginUserTextBox.Size = new System.Drawing.Size(267, 36);
            this.loginUserTextBox.TabIndex = 5;
            this.loginUserTextBox.Text = "User Name";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.ForeColor = System.Drawing.Color.White;
            this.loginLabel.Location = new System.Drawing.Point(24, 248);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(69, 25);
            this.loginLabel.TabIndex = 6;
            this.loginLabel.Text = "Логин:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.ForeColor = System.Drawing.Color.White;
            this.passwordLabel.Location = new System.Drawing.Point(11, 309);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(82, 25);
            this.passwordLabel.TabIndex = 7;
            this.passwordLabel.Text = "Пароль:";
            // 
            // passwordUserTextBox
            // 
            this.passwordUserTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(14)))), ((int)(((byte)(25)))));
            this.passwordUserTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordUserTextBox.Enabled = false;
            this.passwordUserTextBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordUserTextBox.ForeColor = System.Drawing.Color.White;
            this.passwordUserTextBox.Location = new System.Drawing.Point(112, 297);
            this.passwordUserTextBox.Name = "passwordUserTextBox";
            this.passwordUserTextBox.ReadOnly = true;
            this.passwordUserTextBox.Size = new System.Drawing.Size(267, 36);
            this.passwordUserTextBox.TabIndex = 8;
            this.passwordUserTextBox.Text = "********";
            // 
            // editPasswordButton
            // 
            this.editPasswordButton.Image = global::KINOMAN.Properties.Resources.edit_icon;
            this.editPasswordButton.Location = new System.Drawing.Point(88, 297);
            this.editPasswordButton.Name = "editPasswordButton";
            this.editPasswordButton.Size = new System.Drawing.Size(18, 18);
            this.editPasswordButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.editPasswordButton.TabIndex = 10;
            this.editPasswordButton.TabStop = false;
            this.editPasswordButton.Click += new System.EventHandler(this.editPasswordButton_Click);
            // 
            // editLoginButton
            // 
            this.editLoginButton.Image = global::KINOMAN.Properties.Resources.edit_icon;
            this.editLoginButton.Location = new System.Drawing.Point(88, 236);
            this.editLoginButton.Name = "editLoginButton";
            this.editLoginButton.Size = new System.Drawing.Size(18, 18);
            this.editLoginButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.editLoginButton.TabIndex = 9;
            this.editLoginButton.TabStop = false;
            this.editLoginButton.Click += new System.EventHandler(this.editLoginButton_Click);
            // 
            // userIconPictureBox
            // 
            this.userIconPictureBox.Location = new System.Drawing.Point(12, 12);
            this.userIconPictureBox.Name = "userIconPictureBox";
            this.userIconPictureBox.Size = new System.Drawing.Size(207, 207);
            this.userIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userIconPictureBox.TabIndex = 2;
            this.userIconPictureBox.TabStop = false;
            // 
            // BackToFormButton
            // 
            this.BackToFormButton.Location = new System.Drawing.Point(525, 322);
            this.BackToFormButton.Name = "BackToFormButton";
            this.BackToFormButton.Size = new System.Drawing.Size(102, 23);
            this.BackToFormButton.TabIndex = 11;
            this.BackToFormButton.Text = "Назад";
            this.BackToFormButton.UseVisualStyleBackColor = true;
            this.BackToFormButton.Click += new System.EventHandler(this.BackToFormButton_Click);
            // 
            // UserOptionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(14)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(639, 357);
            this.Controls.Add(this.BackToFormButton);
            this.Controls.Add(this.editPasswordButton);
            this.Controls.Add(this.editLoginButton);
            this.Controls.Add(this.passwordUserTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.loginUserTextBox);
            this.Controls.Add(this.iconsTableLayout);
            this.Controls.Add(this.userIconPictureBox);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "UserOptionPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки профиля";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserOptionPage_FormClosed);
            this.Load += new System.EventHandler(this.UserOptionPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.editPasswordButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editLoginButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIconPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox userIconPictureBox;
        private System.Windows.Forms.TableLayoutPanel iconsTableLayout;
        private System.Windows.Forms.TextBox loginUserTextBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordUserTextBox;
        private System.Windows.Forms.PictureBox editLoginButton;
        private System.Windows.Forms.PictureBox editPasswordButton;
        private System.Windows.Forms.Button BackToFormButton;
    }
}