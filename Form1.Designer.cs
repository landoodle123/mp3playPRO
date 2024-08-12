using System;
using System.Windows.Forms;

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
        private System.Windows.Forms.ProgressBar progressBar1; // Progress bar declaration

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
            btnPause = new Button();
            btnStop = new Button();
            btnOpenFile = new Button();
            openFileDialog1 = new OpenFileDialog();
            label1 = new Label();
            button1 = new Button();
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // btnPause
            // 
            btnPause.Image = (Image)resources.GetObject("btnPause.Image");
            btnPause.Location = new Point(11, 12);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(138, 98);
            btnPause.TabIndex = 2;
            btnPause.UseVisualStyleBackColor = true;
            btnPause.Click += btnPause_Click;
            // 
            // btnStop
            // 
            btnStop.Image = (Image)resources.GetObject("btnStop.Image");
            btnStop.Location = new Point(12, 116);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(137, 60);
            btnStop.TabIndex = 3;
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
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(137, 98);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += btnResume_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 182);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(347, 23);
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 220);
            Controls.Add(progressBar1);
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
