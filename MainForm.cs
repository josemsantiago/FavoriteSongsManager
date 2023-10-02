using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace SantiagoEchevarria_CourseProject
{
    public partial class MainForm : Form
    {
        string[] titleArray = new string[5];
        string[] artistArray = new string[5];
        string[] genreArray = new string[5];
        int[] yearArray = new int[5];
        string[] urlArray = new string[5];
        int songCount = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private bool ValidInput()
        {
            bool isValid = true;
            if (string.IsNullOrEmpty(titleText.Text))
            {
                MessageBox.Show("The song title cannot be blank");
                isValid = false;
            }
            else if (string.IsNullOrEmpty(artistText.Text))
            {
                MessageBox.Show("The artist cannot be blank");
                isValid = false;
            }
            else if (string.IsNullOrEmpty(genreText.Text))
            {
                MessageBox.Show("The genre cannot be blank");
                isValid = false;
            }
            else if (string.IsNullOrEmpty(yearText.Text))
            {
                MessageBox.Show("The year cannot be blank");
                isValid = false;
            }
            else if (string.IsNullOrEmpty(urlText.Text))
            {
                MessageBox.Show("The URL cannot be blank");
                isValid = false;
            }
            return isValid;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(outputText.Text);
            string n1 = "\r\n";

            if (ValidInput())
            {
                songList.Items.Add(titleText.Text);
                titleArray[songCount] = titleText.Text.Trim();
                artistArray[songCount] = artistText.Text.Trim();
                genreArray[songCount] = genreText.Text.Trim();
                yearArray[songCount] = int.Parse(yearText.Text.Trim());
                urlArray[songCount] = urlText.Text.Trim();

                songCount++;
                sb.Append(titleText.Text);
                sb.Append(n1);
                sb.Append(artistText.Text);
                sb.Append(n1);
                sb.Append(genreText.Text);
                sb.Append(n1);
                sb.Append(yearText.Text);
                sb.Append(n1);
                sb.Append(urlText.Text);
                sb.Append(n1);
                sb.Append(n1);

                outputText.Text = sb.ToString();
            }
        }

        private int GetSongIndex(string songTitle)
        {
            int songIndex = songList.Items.IndexOf(songTitle);
            return songIndex;
        }

        private bool SongInList(string songTitle)
        {
            bool found = false;
            foreach (var item in songList.Items)
            {
                string currentSong = item as string;
                if (currentSong.ToLower() == songTitle.ToLower())
                {
                    found = true;
                }
            }
            return found;
        }

        private void MainForm_Load(object sender, EventArgs e) { }

        private void allSongsButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(string.Empty);
            string n1 = "\r\n";

            foreach (var item in songList.Items)
            {
                sb.Append(item.ToString());
                sb.Append(n1);
            }

            outputText.Text = sb.ToString();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            if (SongInList(titleText.Text))
            {
                StringBuilder sb = new StringBuilder(string.Empty);
                string n1 = "\r\n";

                int songIndex = GetSongIndex(titleText.Text);

                sb.Append(titleArray[songIndex]);
                sb.Append(n1);
                sb.Append(artistArray[songIndex]);
                sb.Append(n1);
                sb.Append(genreArray[songIndex]);
                sb.Append(n1);
                sb.Append(yearArray[songIndex]);
                sb.Append(n1);
                sb.Append(urlArray[songIndex]);
                sb.Append(n1);

                outputText.Text = sb.ToString();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            titleText.Clear();
            artistText.Clear();
            genreText.Clear();
            yearText.Clear();
            urlText.Clear();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            int songIndex = songList.SelectedIndex;
            string url = urlArray[songIndex];
            webViewDisplay.CoreWebView2.Navigate(url);
        }

        private void songList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int songIndex = songList.SelectedIndex;
            if (songIndex > -1)
            {
                StringBuilder sb = new StringBuilder(string.Empty);
                string n1 = "\r\n";

                sb.Append(titleArray[songIndex]);
                sb.Append(n1);
                sb.Append(artistArray[songIndex]);
                sb.Append(n1);
                sb.Append(genreArray[songIndex]);
                sb.Append(n1);
                sb.Append(yearArray[songIndex]);
                sb.Append(n1);
                sb.Append(urlArray[songIndex]);
                sb.Append(n1);

                outputText.Text = sb.ToString();
            }
        }
    }
}
