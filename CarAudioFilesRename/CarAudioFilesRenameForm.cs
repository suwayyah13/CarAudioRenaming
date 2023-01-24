using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CarAudioFilesRename
{
    public partial class CarAudioFilesRenameForm : Form
    {
        public CarAudioFilesRenameForm()
        {
            InitializeComponent();
        }
        private void ChooseFolderIn(object sender, EventArgs e)
        {
           textDirectoryIn.Text = ChooseFolder();
        }
        private void ChooseFolderOut(object sender, EventArgs e)
        {
            textDirectoryOut.Text = ChooseFolder();
        }
        private string ChooseFolder()
        {
            if (FolderBrowserDialogInput.ShowDialog() == DialogResult.OK)
            {
                return FolderBrowserDialogInput.SelectedPath;
            }
            else 
            {
                return "";
            }
        }
        private void ShowErrorText(string errorText)
        {
            if (String.IsNullOrEmpty(errorText) == false)
            {
                MessageBox.Show(errorText, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private DirectoryInfo GetDirectory(string directoryPath)
        {
            try
            {
                var directory = new DirectoryInfo(directoryPath);
                return directory;
            }
            catch (Exception ex)
            {
                throw new Exception("Error while getting directory info: " + directoryPath);
            }
        }
        private void RenameAndCopyFiles(object sender, EventArgs e)
        {
            DirectoryInfo directoryIn;
            DirectoryInfo directoryOut;
            CarAudioFilesRename directoryTools;
            if (String.IsNullOrEmpty(textDirectoryIn.Text))
            {
                ShowErrorText("Please, choose Source folder");
                return;
            }
            if (String.IsNullOrEmpty(textDirectoryOut.Text))
            {
                ShowErrorText("Please, choose Result folder");
                return;
            }
            if (String.IsNullOrEmpty(textFileTypes.Text))
            {
                ShowErrorText("Please, fill File types");
                return;
            }
            if (!System.IO.File.Exists(textDirectoryIn.Text))
            {
                ShowErrorText("Folder does not exists: " + textDirectoryIn.Text);
                return;
            }
            if (!System.IO.File.Exists(textDirectoryOut.Text))
            {
                ShowErrorText("Folder does not exists: " + textDirectoryOut.Text);
                return;
            }
            try
            {
                directoryIn = GetDirectory(textDirectoryIn.Text);
                directoryOut = GetDirectory(textDirectoryOut.Text);
            }
            catch (Exception ex)
            {
                ShowErrorText(ex.Message);
                return;
            }
            directoryTools = new CarAudioFilesRename(textFileTypes.Text, directoryIn);
            directoryTools.FillData();
        }

    }
}
