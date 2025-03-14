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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Manifest files (*.manifest)|*.manifest";
                openFileDialog.Title = "Select Manifest files";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string sourceFilePath = openFileDialog.FileName;
                    string destinationPath = @"C:\Program Files (x86)\Steam\steamapps";
                    string destinationFilePath = Path.Combine(destinationPath, Path.GetFileName(sourceFilePath));

                    try
                    {
                        await CopyFileWithProgressAsync(sourceFilePath, destinationFilePath);
                        MessageBox.Show("Game Injected", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error :( -- {ex.Message}", "Oh no! fucking error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
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

        private async void button5_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "ACF files (*.acf)|*.acf";
                openFileDialog.Title = "Select ACF files";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string sourceFilePath = openFileDialog.FileName;
                    string destinationPath = @"C:\Program Files (x86)\Steam\steamapps";
                    string destinationFilePath = Path.Combine(destinationPath, Path.GetFileName(sourceFilePath));

                    try
                    {
                        await CopyFileWithProgressAsync(sourceFilePath, destinationFilePath);
                        MessageBox.Show("Game Injected", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error :( -- {ex.Message}", "Oh no! fucking error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
