﻿namespace Book_Menu
{
    partial class Book3
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
            this.bookTextBox = new System.Windows.Forms.RichTextBox();
            this.bookTitle1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bookTextBox
            // 
            this.bookTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.bookTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.bookTextBox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTextBox.Location = new System.Drawing.Point(0, 0);
            this.bookTextBox.Name = "bookTextBox";
            this.bookTextBox.ReadOnly = true;
            this.bookTextBox.Size = new System.Drawing.Size(694, 861);
            this.bookTextBox.TabIndex = 1;
            this.bookTextBox.Text = "";
            // 
            // bookTitle1
            // 
            this.bookTitle1.BackColor = System.Drawing.Color.Transparent;
            this.bookTitle1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookTitle1.Font = new System.Drawing.Font("Book Antiqua", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTitle1.ForeColor = System.Drawing.Color.White;
            this.bookTitle1.Location = new System.Drawing.Point(707, 370);
            this.bookTitle1.Name = "bookTitle1";
            this.bookTitle1.Size = new System.Drawing.Size(243, 93);
            this.bookTitle1.TabIndex = 8;
            this.bookTitle1.Text = "A Doctor of\r\nthe Old School,\r\nPart 1";
            this.bookTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Book_Menu.Properties.Resources.A_Doctor_of_the_old_school;
            this.pictureBox1.Location = new System.Drawing.Point(707, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 355);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Book3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(6)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(962, 861);
            this.Controls.Add(this.bookTitle1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bookTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Book3";
            this.Text = "Book3";
            this.Load += new System.EventHandler(this.Book3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox bookTextBox;
        private System.Windows.Forms.Label bookTitle1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}