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

namespace File_Renamer_9000
{
    public partial class fileRenamer9000 : Form
    {

        int numStart;
        int numEnd;
        int numCurrent;
        int numOfDigits;
        int numOfHash;
        string newFileNameFormat;

        public fileRenamer9000()
        {
            InitializeComponent();
            numOfHash = 0;
        }

        private void SelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog rootPicker = new FolderBrowserDialog();
            DialogResult result = rootPicker.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(rootPicker.SelectedPath))
            {
                folderPickerTextBox.Text = rootPicker.SelectedPath;
                newFileNameFormat = namingFormatTextBox.Text;
            }
        }

        private string nextTitle(string originalName, string originalPath, string originalExtension)
        {
            bool numProcessed = false;
            StringBuilder sb = new StringBuilder(originalPath);
            sb.Append('\\');
            for (int i = 0; i < newFileNameFormat.Length;)
            {
                if (newFileNameFormat[i] == '#')
                {
                    if (!numProcessed)
                    {
                        string formatString = String.Format("{0:D" + numOfHash + "}", numCurrent);
                        sb.Append(formatString);
                        i += numOfDigits;
                        numProcessed = true;
                    }
                    else
                    {
                        i++;
                    }
                }
                else
                {
                    sb.Append(newFileNameFormat[i]);
                    i++;
                }
            }
            sb.Append(originalExtension);
            string returnString = sb.ToString();
            return returnString;
        }

        private void getHashCount()
        {
            numOfHash = 0;
            foreach (char c in newFileNameFormat)
            {
                if (c == '#')
                {
                    numOfHash++;
                }
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            numCurrent = (int)startNumericUpDown.Value;
            newFileNameFormat = namingFormatTextBox.Text;
            numStart = (int)startNumericUpDown.Value;
            getHashCount();
            if (numOfHash == 0)
            {
                MessageBox.Show("You must have at least one hashtag within your rename format please");
            }
            else
            {
                try
                {
                    string targetDirectoryString = folderPickerTextBox.Text;
                    DirectoryInfo targetDirectoryInfo = new DirectoryInfo(targetDirectoryString);
                    int numberOfNums = targetDirectoryString.Length;
                    Console.WriteLine("numStart " + numStart + " numberOfNums: " + numberOfNums);
                    numOfDigits = (int)Math.Floor(Math.Log10(numStart + numberOfNums) + 1);
                    Console.WriteLine("dig: " + numOfDigits + " hash: " + numOfHash);
                    numOfHash = numOfDigits > numOfHash ? numOfDigits : numOfHash;
                    Console.WriteLine("dig: " + numOfDigits + " hash: " + numOfHash);
                    if (numOfDigits > numOfHash)
                    {
                        numOfHash = numOfDigits;
                    }
                    foreach (FileInfo file in targetDirectoryInfo.GetFiles())
                    {
                        string newFileName = nextTitle(file.Name, file.DirectoryName, file.Extension);
                        numCurrent++;
                        Console.WriteLine(newFileName);
                        file.MoveTo(newFileName);
                    }
                }
                catch (Exception ex)
                {
                    if (ex is DirectoryNotFoundException || ex is System.ArgumentException)
                    {
                        MessageBox.Show("You must select a valid filepath please");
                    }
                    else
                    {
                        throw;
                    }
                }
            }
        }
    }
}
