using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iEx
{
    public partial class Form1 : Form
    {
        private int progressValue = 0;
        private string currentUserAgent =
        "Mozilla/5.0 (Windows NT 10.0; Trident/7.0; rv:11.0) like Gecko";

        public Form1()
        {
            InitializeComponent();

            // Progress bar setup
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;

            // Timer setup
            loadTimer.Interval = 1000; // 1 second
            loadTimer.Tick += loadTimer_Tick;

            // Hook up events for existing controls
            webBrowser1.Navigating += webBrowser1_Navigating;
            webBrowser1.DocumentCompleted += webBrowser1_DocumentCompleted;
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            
            webBrowser1.Navigate(siteTxt.Text);
        }

        private void googleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            webBrowser1.Navigate("https://google.com");
        }

        private void bingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            webBrowser1.Navigate("https://bing.com");
        }

        private void yahooToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            webBrowser1.Navigate("https://yahoo.com");
        }

        private void duckDuckGoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            webBrowser1.Navigate("https://duckduckgo.com");
        }

        private void askcomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            webBrowser1.Navigate("https://ask.com");
        }

        private void aOLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            webBrowser1.Navigate("https://aol.com");
        }

        private void duckDuckGoLiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            webBrowser1.Navigate("https://lite.duckduckgo.com/lite");
        }

        private void bBCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            webBrowser1.Navigate("https://bbc.co.uk");
        }

        private void frogFindToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            webBrowser1.Navigate("https://frogfind.com");
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            progressValue = 0;
            progressBar1.Value = 0;
            progressBar1.ForeColor = Color.Blue;
            loadTimer.Start();

            if (webBrowser1.Url != null)
                siteTxt.Text = webBrowser1.Url.ToString();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            loadTimer.Stop();
            progressBar1.Value = 100;
            progressBar1.ForeColor = Color.Green;

            Timer resetTimer = new Timer();
            resetTimer.Interval = 500; // half second
            resetTimer.Tick += (s, ev) =>
            {
                progressBar1.Value = 0;
                resetTimer.Stop();
            };
            resetTimer.Start();

            // Optional: update TextBox with URL
            if (webBrowser1.Url != null)
                siteTxt.Text = webBrowser1.Url.ToString();
        }

        private void loadTimer_Tick(object sender, EventArgs e)
        {
            if (progressValue < 90)
            {
                progressValue += 10;
                progressBar1.Value = progressValue;
            } 
        }

        private void backBtn_MouseEnter(object sender, EventArgs e)
        {
            backBtn.BackColor = Color.DarkBlue;
        }

        private void forwBtn_MouseEnter(object sender, EventArgs e)
        {
            forwBtn.BackColor = Color.DarkBlue;
        }

        private void refreshBtn_MouseEnter(object sender, EventArgs e)
        {
            refreshBtn.BackColor = Color.DarkBlue;
        }

        private void backBtn_MouseLeave(object sender, EventArgs e)
        {
            backBtn.BackColor = SystemColors.Control;
        }

        private void forwBtn_MouseLeave(object sender, EventArgs e)
        {
            forwBtn.BackColor = SystemColors.Control;
        }

        private void refreshBtn_MouseLeave(object sender, EventArgs e)
        {
            refreshBtn.BackColor = SystemColors.Control;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void forwBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("about:blank");
        }

        private void stopBtn_MouseEnter(object sender, EventArgs e)
        {
            stopBtn.BackColor = Color.DarkBlue;
        }

        private void homeBtn_MouseEnter(object sender, EventArgs e)
        {
            homeBtn.BackColor = Color.DarkBlue;
        }

        private void stopBtn_MouseLeave(object sender, EventArgs e)
        {
            stopBtn.BackColor = SystemColors.Control;
        }

        private void homeBtn_MouseLeave(object sender, EventArgs e)
        {
            homeBtn.BackColor = SystemColors.Control;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a free IE based browser by Winverse");
        }
    }
}
