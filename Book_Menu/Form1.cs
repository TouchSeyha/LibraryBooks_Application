using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Book_Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitlogo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void githublogo_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/TouchSeyha/Reading_Books_Application");
        }

        private void bookCover1_Click(object sender, EventArgs e)
        {
            Book1 book1 = new Book1();
            book1.Show();
        }

        private void bookCover2_Click(object sender, EventArgs e)
        {
            Book2 book2 = new Book2();
            book2.Show();
        }

        private void bookCover3_Click(object sender, EventArgs e)
        {
            Book3 book3 = new Book3();
            book3.Show();
        }

        private void bookCover4_Click(object sender, EventArgs e)
        {
            Book4 book4 = new Book4();
            book4.Show();
        }

        private void bookCover5_Click(object sender, EventArgs e)
        {
            Book5 book5 = new Book5();
            book5.Show();
        }

        private void bookTitle1_MouseHover(object sender, EventArgs e)
        {
            bookTitle1.BackColor = Color.FromArgb(24, 6, 46);

        }

        private void bookCover1_MouseLeave(object sender, EventArgs e)
        {
            bookTitle1.BackColor = Color.Transparent;
        }

        private void bookTitle2_MouseHover(object sender, EventArgs e)
        {
            bookTitle2.BackColor = Color.FromArgb(24, 6, 46);
        }

        private void bookTitle2_MouseLeave(object sender, EventArgs e)
        {
            bookTitle2.BackColor = Color.Transparent;
        }

        private void bookCover3_MouseHover(object sender, EventArgs e)
        {
            bookTitle3.BackColor = Color.FromArgb(24, 6, 46);
        }

        private void bookCover3_MouseLeave(object sender, EventArgs e)
        {
            bookTitle3.BackColor = Color.Transparent;
        }

        private void bookCover4_MouseHover(object sender, EventArgs e)
        {
            bookTitle4.BackColor = Color.FromArgb(24, 6, 46);
        }

        private void bookTitle4_MouseLeave(object sender, EventArgs e)
        {
            bookTitle4.BackColor = Color.Transparent;
        }

        private void bookCover5_MouseHover(object sender, EventArgs e)
        {
            bookTitle5.BackColor = Color.FromArgb(24, 6, 46);
        }

        private void bookCover5_MouseLeave(object sender, EventArgs e)
        {
            bookTitle5.BackColor = Color.Transparent;
        }
    }
}
