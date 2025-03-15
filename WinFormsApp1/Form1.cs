using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(Form1_DragEnter);
            this.DragDrop += new DragEventHandler(Form1_DragDrop_Handler);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async Task CopyFileWithProgressAsync(string sourceFilePath, string destinationFilePath)
        {
            const int bufferSize = 1024 * 1024;
            byte[] buffer = new byte[bufferSize];
            long totalBytes = new FileInfo(sourceFilePath).Length;
            long totalBytesCopied = 0;

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;

            using (FileStream sourceStream = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read))
            using (FileStream destinationStream = new FileStream(destinationFilePath, FileMode.Create, FileAccess.Write))
            {
                int bytesRead;
                while ((bytesRead = await sourceStream.ReadAsync(buffer, 0, bufferSize)) > 0)
                {
                    await destinationStream.WriteAsync(buffer, 0, bytesRead);
                    totalBytesCopied += bytesRead;
                    int progressPercentage = (int)((totalBytesCopied * 100) / totalBytes);
                    progressBar1.Value = progressPercentage;
                }
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string steam_program = "C:\\Program Files (x86)\\Steam\\steam.exe";
            Process.Start(new ProcessStartInfo(steam_program) { UseShellExecute = true });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var process in Process.GetProcessesByName("steam"))
            {
                process.Kill();
            }
        }

        private async void Form1_DragDrop_Handler(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                string extension = Path.GetExtension(file).ToLower();
                string destinationPath = @"C:\Program Files (x86)\Steam\steamapps";
                string destinationFilePath = Path.Combine(destinationPath, Path.GetFileName(file));

                if (extension == ".acf" || extension == ".manifest")
                {
                    try
                    {
                        await CopyFileWithProgressAsync(file, destinationFilePath);
                        MessageBox.Show("File Injected", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error :( -- {ex.Message}", "Oh no! fucking error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("The dropped file type is not supported.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
