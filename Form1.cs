using System;
using System.Windows.Forms;
using WMPLib;

namespace MP3Player
{
    public partial class Form1 : Form
    {
        private WindowsMediaPlayer WindowsMediaPlayer;

        public Form1()
        {
            InitializeComponent();
            InitializeWindowsMediaPlayer();
            InitializeStateCheckTimer();
        }

        private void InitializeWindowsMediaPlayer()
        {
            WindowsMediaPlayer = new WindowsMediaPlayer();
            WindowsMediaPlayer.PlayStateChange += WindowsMediaPlayer_PlayStateChange;
        }

        private void InitializeStateCheckTimer()
        {
            System.Windows.Forms.Timer stateCheckTimer = new System.Windows.Forms.Timer();
            stateCheckTimer.Interval = 5;
            stateCheckTimer.Tick += StateCheckTimer_Tick;
            stateCheckTimer.Start();
        }

        private void StateCheckTimer_Tick(object sender, EventArgs e)
        {
            if (WindowsMediaPlayer != null)
            {
                if (WindowsMediaPlayer.playState == WMPPlayState.wmppsPaused)
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

        private void WindowsMediaPlayer_PlayStateChange(int newState)
        {
            // Optional: Handle play state changes here
        }
    }
}
