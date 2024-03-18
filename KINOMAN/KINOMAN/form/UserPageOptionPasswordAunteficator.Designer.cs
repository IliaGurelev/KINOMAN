namespace KINOMAN.form
{
    partial class UserPageOptionPasswordAunteficator
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
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.labeltitle = new System.Windows.Forms.Label();
            this.acceptButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.acceptButton)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(14)))), ((int)(((byte)(25)))));
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.passwordTextBox.ForeColor = System.Drawing.Color.White;
            this.passwordTextBox.Location = new System.Drawing.Point(12, 79);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(275, 43);
            this.passwordTextBox.TabIndex = 0;
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labeltitle
            // 
            this.labeltitle.AutoSize = true;
            this.labeltitle.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.labeltitle.ForeColor = System.Drawing.Color.White;
            this.labeltitle.Location = new System.Drawing.Point(32, 28);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(231, 28);
            this.labeltitle.TabIndex = 1;
            this.labeltitle.Text = "Введите старый пароль:";
            // 
            // acceptButton
            // 
            this.acceptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.acceptButton.Image = global::KINOMAN.Properties.Resources.accept_icon;
            this.acceptButton.Location = new System.Drawing.Point(122, 128);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(52, 44);
            this.acceptButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.acceptButton.TabIndex = 2;
            this.acceptButton.TabStop = false;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // UserPageOptionPasswordAunteficator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(14)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(299, 178);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.labeltitle);
            this.Controls.Add(this.passwordTextBox);
            this.Name = "UserPageOptionPasswordAunteficator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение пароля";
            ((System.ComponentModel.ISupportInitialize)(this.acceptButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label labeltitle;
        private System.Windows.Forms.PictureBox acceptButton;
    }
}