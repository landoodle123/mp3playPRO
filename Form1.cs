using System;
using System.Windows.Forms;
using WMPLib;

namespace MP3Player
{
    public partial class Form1 : Form
    {
        private WindowsMediaPlayer WindowsMediaPlayer; // Declare once at the class level

        public Form1()
        {
            InitializeComponent();
            InitializeWindowsMediaPlayer();
        }

        private void InitializeWindowsMediaPlayer()
        {
            WindowsMediaPlayer = new WindowsMediaPlayer(); // Initialize here
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
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Optionally update the UI with the selected file name
            }
        }
    }
}
