using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            InputTextbox.Text = InputOpenFileDialog.FileName;
            OutputTextbox.Text = OutputSaveFileDialog.FileName;
        }
        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            InputOpenFileDialog.ShowDialog();
            string new_filename = InputOpenFileDialog.FileName;
            InputTextbox.Text = new_filename;
            new_filename = Path.GetDirectoryName(new_filename);
            new_filename = Path.Combine(new_filename, "output.html");
            OutputTextbox.Text = new_filename;
        }
        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            OutputSaveFileDialog.ShowDialog();
            OutputTextbox.Text = OutputSaveFileDialog.FileName;
        }
        private void ConvertButton_Click(object sender, EventArgs e)
        {
            string exeDir = "C:\\Users\\vitom\\Documents\\programming\\mc vc\\s3\\S3C#Lab2.1\\bin\\Debug\\net6.0\\S3Lab2.exe";
            System.Diagnostics.Process.Start(exeDir, InputTextbox.Text + " " + OutputTextbox.Text);
        }
    }
}
