using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoChan
{
    public partial class Main : Form
    {
        // initializing, ignore this
        public Main() { InitializeComponent(); }

        // ### moving window with mouse
        // importing win libraries
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        // function launched when picture box or form is clicked on
        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            // if left button pressed and held
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x02, 0);
            }
        }

        // starting different thread so you could move the window while it's doing its thing
        private void Main_Load(object sender, EventArgs e) { backgroundWorker.RunWorkerAsync(); }

        // full thread that was mentioned above
        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // getting all files from the .exe location
            string exeLocation = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string[] foundFiles = Directory.GetFiles(exeLocation);

            // looking for exp files until the exp + (matchesCounter+1) + .txt is not there
            int matchesCounter = 0;
            while (true)
            {
                // going through files array
                bool foundMatch = false;
                foreach (string filePath in foundFiles)
                {
                    if (Path.GetFileName(filePath) == "exp" + (matchesCounter + 1) + ".txt")
                    {
                        matchesCounter += 1;
                        foundMatch = true;
                    }
                }

                // stop loop if found nothing
                if (!foundMatch) break;
            }

            // making sure if at least one file found
            if (matchesCounter > 0)
            {
                // load exp file directories into string array
                string[] exportFilesPath = new string[matchesCounter];

                for (int i = 0; i < exportFilesPath.Length; i++)
                    exportFilesPath[i] = Path.Combine(exeLocation, "exp" + (i + 1 + ".txt"));

                // connecting all lines from all files
                string allLines = "";
                foreach (string expPath in exportFilesPath)
                    allLines += File.ReadAllText(expPath);

                // splitting into array with lines
                string[] allLinesSplit = allLines.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

                // converting all lines to just get the channel links
                for (int i = 0; i < allLinesSplit.Length; i++)
                {
                    // checks to make sure line has all we need
                    if (allLinesSplit[i].Contains("\"channel\": \"") && allLinesSplit[i].Contains(", \"votes\":"))
                    {
                        // converting line to just channel link
                        string channelLink = allLinesSplit[i].Remove(0, allLinesSplit[i].IndexOf("\"channel\": \"") + 12);
                        channelLink = channelLink.Remove(channelLink.IndexOf(", \"votes\":") - 1);
                        channelLink = "https://www.youtube.com/channel/" + channelLink;

                        // saving in the array index
                        allLinesSplit[i] = channelLink;
                    }
                }

                // writing all channel links to txt file
                File.WriteAllLines("once upon a time.txt", allLinesSplit);
            }
            else MessageBox.Show("Couldn't find any \"exp\" files..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // closing after exporting or after an error
            Application.Exit();
        }
    }
}
