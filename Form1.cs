using System;
using System.Windows.Forms;
using WMPLib;

namespace MP3Player
{
    public partial class Form1 : Form
    {
        private WindowsMediaPlayer windowsMediaPlayer;
        private System.Windows.Forms.Timer progressBarTimer;

        public Form1()
        {
            InitializeComponent();
            InitializeWindowsMediaPlayer();
            InitializeProgressBarTimer();
        }

        private void InitializeWindowsMediaPlayer()
        {
            windowsMediaPlayer = new WindowsMediaPlayer();
            windowsMediaPlayer.PlayStateChange += WindowsMediaPlayer_PlayStateChange;
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
            if (windowsMediaPlayer != null && windowsMediaPlayer.currentMedia != null)
            {
                // Update the progress bar value
                progressBar1.Maximum = (int)windowsMediaPlayer.currentMedia.duration;
                progressBar1.Value = (int)windowsMediaPlayer.controls.currentPosition;
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
            if (windowsMediaPlayer != null && !string.IsNullOrEmpty(openFileDialog1.FileName))
            {
                windowsMediaPlayer.URL = openFileDialog1.FileName;
                windowsMediaPlayer.controls.play();
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (windowsMediaPlayer != null)
            {
                windowsMediaPlayer.controls.pause();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (windowsMediaPlayer != null)
            {
                windowsMediaPlayer.controls.stop();
                label1.Text = "No file loaded";
                progressBar1.Value = 0; // Reset progress bar
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.Text = openFileDialog1.FileName;
                windowsMediaPlayer.URL = openFileDialog1.FileName;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Handle label click events if needed
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            if (windowsMediaPlayer != null && windowsMediaPlayer.playState == WMPPlayState.wmppsPaused)
            {
                windowsMediaPlayer.controls.play(); // Resume playback from the current position
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (windowsMediaPlayer != null)
            {
                windowsMediaPlayer.controls.currentPosition = 0; // Restart the song from the beginning
            }
        }

        private void btnFwd_Click(object sender, EventArgs e)
        {
            if (windowsMediaPlayer != null && windowsMediaPlayer.currentMedia != null)
            {
                windowsMediaPlayer.controls.currentPosition += 5; // Forward by 5 seconds
            }
        }
    }
}
