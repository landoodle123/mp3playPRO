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
        private System.Windows.Forms.Button back;

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
            back = new Button();
            fwd = new Button();
            trackBar1 = new TrackBar();
            volctrl = new Label();
            progress = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)progress).BeginInit();
            SuspendLayout();
            // 
            // btnPause
            // 
            btnPause.Image = (Image)resources.GetObject("btnPause.Image");
            btnPause.Location = new Point(221, 12);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(138, 122);
            btnPause.TabIndex = 2;
            btnPause.UseVisualStyleBackColor = true;
            btnPause.Click += btnPause_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(12, 74);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(56, 27);
            btnStop.TabIndex = 3;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnOpenFile
            // 
            btnOpenFile.Location = new Point(73, 76);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(76, 25);
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
            label1.Location = new Point(73, 119);
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
            button1.Location = new Point(221, 12);
            button1.Name = "button1";
            button1.Size = new Size(137, 122);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += btnResume_Click;
            // 
            // back
            // 
            back.Image = (Image)resources.GetObject("back.Image");
            back.Location = new Point(221, 140);
            back.Name = "back";
            back.Size = new Size(60, 60);
            back.TabIndex = 8;
            back.UseVisualStyleBackColor = true;
            back.Click += btnBack_Click;
            // 
            // fwd
            // 
            fwd.Image = (Image)resources.GetObject("fwd.Image");
            fwd.Location = new Point(298, 140);
            fwd.Name = "fwd";
            fwd.Size = new Size(60, 60);
            fwd.TabIndex = 9;
            fwd.UseVisualStyleBackColor = true;
            fwd.Click += btnFwd_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(155, 74);
            trackBar1.Maximum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(60, 45);
            trackBar1.SmallChange = 5;
            trackBar1.TabIndex = 10;
            trackBar1.TickFrequency = 5;
            trackBar1.Value = 50;
            trackBar1.Scroll += trackBar1_Scroll;
            trackBar1.ValueChanged += trackBar1_ValueChanged;
            // 
            // volctrl
            // 
            volctrl.AutoSize = true;
            volctrl.Font = new Font("Segoe UI", 6F);
            volctrl.Location = new Point(155, 98);
            volctrl.Name = "volctrl";
            volctrl.Size = new Size(62, 11);
            volctrl.TabIndex = 11;
            volctrl.Text = "Volume Control";
            // 
            // progress
            // 
            progress.Location = new Point(10, 12);
            progress.Name = "progress";
            progress.Size = new Size(205, 45);
            progress.TabIndex = 12;
            progress.Scroll += progress_Scroll;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 220);
            Controls.Add(volctrl);
            Controls.Add(trackBar1);
            Controls.Add(fwd);
            Controls.Add(back);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(btnOpenFile);
            Controls.Add(btnStop);
            Controls.Add(btnPause);
            Controls.Add(progress);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "mp3playPRO";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)progress).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button fwd;
        private TrackBar trackBar1;
        private Label volctrl;
        private TrackBar progress;
    }
}
