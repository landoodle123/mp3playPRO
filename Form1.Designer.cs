using System;
using System.Windows.Forms;
using WMPLib;

namespace MP3Player
{
    partial class Form1 : Form
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer stateCheckTimer; // Explicit Timer declaration

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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnPause = new Button();
            btnStop = new Button();
            btnOpenFile = new Button();
            openFileDialog1 = new OpenFileDialog();
            label1 = new Label();
            button1 = new Button();
            stateCheckTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnPause
            // 
            btnPause.Location = new Point(11, 12);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(138, 98);
            btnPause.TabIndex = 2;
            btnPause.Text = "Pause";
            btnPause.UseVisualStyleBackColor = true;
            btnPause.Click += btnPause_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(12, 116);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(137, 60);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(159, 119);
            label1.MaximumSize = new Size(200, 0);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 5;
            label1.Text = "No file loaded";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(137, 98);
            button1.TabIndex = 6;
            button1.Text = "Resume";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += btnResume_Click;
            // 
            // stateCheckTimer
            // 
            stateCheckTimer.Interval = 500;
            stateCheckTimer.Tick += StateCheckTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 188);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(btnOpenFile);
            Controls.Add(btnStop);
            Controls.Add(btnPause);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "mp3playPRO";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
