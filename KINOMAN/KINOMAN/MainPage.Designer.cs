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
            this.paginationNextButton = new System.Windows.Forms.PictureBox();
            this.paginationBackButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.paginationNextButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paginationBackButton)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Silver;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 33);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1009, 490);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // paginationNextButton
            // 
            this.paginationNextButton.Image = ((System.Drawing.Image)(resources.GetObject("paginationNextButton.Image")));
            this.paginationNextButton.Location = new System.Drawing.Point(527, 525);
            this.paginationNextButton.Name = "paginationNextButton";
            this.paginationNextButton.Size = new System.Drawing.Size(214, 39);
            this.paginationNextButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.paginationNextButton.TabIndex = 7;
            this.paginationNextButton.TabStop = false;
            this.paginationNextButton.Click += new System.EventHandler(this.paginationNextButton_Click);
            // 
            // paginationBackButton
            // 
            this.paginationBackButton.Image = ((System.Drawing.Image)(resources.GetObject("paginationBackButton.Image")));
            this.paginationBackButton.Location = new System.Drawing.Point(293, 525);
            this.paginationBackButton.Name = "paginationBackButton";
            this.paginationBackButton.Size = new System.Drawing.Size(214, 39);
            this.paginationBackButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.paginationBackButton.TabIndex = 8;
            this.paginationBackButton.TabStop = false;
            this.paginationBackButton.Click += new System.EventHandler(this.paginationBackButton_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1033, 567);
            this.Controls.Add(this.paginationBackButton);
            this.Controls.Add(this.paginationNextButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное окно";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paginationNextButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paginationBackButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox paginationNextButton;
        private System.Windows.Forms.PictureBox paginationBackButton;
    }
}

