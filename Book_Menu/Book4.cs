using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Menu
{
    public partial class Book4 : Form
    {
        public Book4()
        {
            InitializeComponent();
        }

        private async void Book4_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Please Wait for a moment while the book is Downloading.",
                "Downloading", MessageBoxButtons.OK, MessageBoxIcon.Information).ToString();
            bookTextBox.Text = "Please wait just a little bit more...Don't be angry 🥺";
            bookTextBox.Text = await LoadBookDataAsync();
        }

        private async Task<string> LoadBookDataAsync()
        {
            string bookContent = string.Empty;
            try
            {
                // Create an FTP request to download the book.
                FtpWebRequest requestData = (FtpWebRequest)WebRequest.Create("ftp://gutenberg.pglaf.org/5/0/0/0/50000/50000-0.txt");
                requestData.Method = WebRequestMethods.Ftp.DownloadFile;

                // Get the response from the FTP server.
                FtpWebResponse responseData = (FtpWebResponse)await requestData.GetResponseAsync();
                using (Stream responseStream = responseData.GetResponseStream())
                using (StreamReader reader = new StreamReader(responseStream))
                {
                    // Read the book content.
                    bookContent = await reader.ReadToEndAsync();
                }
                // Save the book content to a local file.
                using (StreamWriter file = File.CreateText("John Gutenberg First Master Printer.txt"))
                {
                    await file.WriteAsync(bookContent);
                }
                responseData.Close();
            }
            catch (Exception ex)
            {
                // Display an error message if the book download fails.
                MessageBox.Show($"Oops something went wrong while downloading your book 😓: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return bookContent;
        }
    }
}
