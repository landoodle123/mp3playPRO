using System;
using System.Windows.Forms;

namespace MP3Player
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // This should match your Form1 class
        }
    }
}
