using System;
using System.Windows.Forms;
using WMPLib;

namespace MP3Player
{
    partial class Form1 : Form
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private WindowsMediaPlayer windowsMediaPlayer1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnPlay = new Button();
            btnPause = new Button();
            btnStop = new Button();
            btnOpenFile = new Button();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // btnPlay
            // 
            btnPlay.Location = new Point(12, 12);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(137, 98);
            btnPlay.TabIndex = 1;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnPause
            // 
            btnPause.Location = new Point(83, 116);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(66, 22);
            btnPause.TabIndex = 2;
            btnPause.Text = "Pause";
            btnPause.UseVisualStyleBackColor = true;
            btnPause.Click += btnPause_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(12, 116);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(66, 22);
            btnStop.TabIndex = 3;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnOpenFile
            // 
            btnOpenFile.Location = new Point(155, 12);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(204, 98);
            btnOpenFile.TabIndex = 4;
            btnOpenFile.Text = "Open File";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.Filter = "MP3 Files|*.mp3";
            openFileDialog1.Title = "Select an MP3 File";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 333);
            Controls.Add(btnOpenFile);
            Controls.Add(btnStop);
            Controls.Add(btnPause);
            Controls.Add(btnPlay);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "mp3playPRO";
            ResumeLayout(false);
        }
    }
}