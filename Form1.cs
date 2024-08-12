using System;
using System.Windows.Forms;
using WMPLib;

namespace MP3Player
{
    public partial class Form1 : Form
    {
        private WindowsMediaPlayer WindowsMediaPlayer;
        private System.Windows.Forms.Timer progressBarTimer;

        public Form1()
        {
            InitializeComponent();
            InitializeWindowsMediaPlayer();
            InitializeProgressBarTimer();
        }

        private void InitializeWindowsMediaPlayer()
        {
            WindowsMediaPlayer = new WindowsMediaPlayer();
            WindowsMediaPlayer.PlayStateChange += WindowsMediaPlayer_PlayStateChange;
        }

        private void InitializeProgressBarTimer()
        {
            progressBarTimer = new System.Windows.Forms.Timer();
            progressBarTimer.Interval = 10;
            progressBarTimer.Tick += ProgressBarTimer_Tick;
            progressBarTimer.Start();
        }

        private void ProgressBarTimer_Tick(object sender, EventArgs e)
        {
            if (WindowsMediaPlayer != null && WindowsMediaPlayer.currentMedia != null)
            {
                // Update the progress bar value
                progressBar1.Maximum = (int)WindowsMediaPlayer.currentMedia.duration;
                progressBar1.Value = (int)WindowsMediaPlayer.controls.currentPosition;
            }
        }

        private void WindowsMediaPlayer_PlayStateChange(int newState)
        {
            if (newState == (int)WMPPlayState.wmppsPaused)
            {
                button1.Visible = true;
                button1.Enabled = true;
            }
            else
            {
                button1.Visible = false;
                button1.Enabled = false;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (WindowsMediaPlayer != null && !string.IsNullOrEmpty(openFileDialog1.FileName))
            {
                WindowsMediaPlayer.URL = openFileDialog1.FileName;
                WindowsMediaPlayer.controls.play();
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (WindowsMediaPlayer != null)
            {
                WindowsMediaPlayer.controls.pause();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (WindowsMediaPlayer != null)
            {
                WindowsMediaPlayer.controls.stop();
                label1.Text = "No file loaded";
                progressBar1.Value = 0; // Reset progress bar
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.Text = openFileDialog1.FileName;
                WindowsMediaPlayer.URL = openFileDialog1.FileName;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Handle label click events if needed
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            if (WindowsMediaPlayer != null && WindowsMediaPlayer.playState == WMPPlayState.wmppsPaused)
            {
                WindowsMediaPlayer.controls.play(); // Resume playback from the current position
            }
        }
    }
}
