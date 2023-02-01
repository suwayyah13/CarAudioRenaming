using System;
using System.IO;
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
           textDirectoryIn.Text = ChooseFolder(textDirectoryIn.Text);
        }
        private void ChooseFolderOut(object sender, EventArgs e)
        {
            textDirectoryOut.Text = ChooseFolder(textDirectoryOut.Text);
        }
        private string ChooseFolder(string currentValue)
        {
            if (FolderBrowserDialogInput.ShowDialog() == DialogResult.OK)
            {
                return FolderBrowserDialogInput.SelectedPath;
            }
            else 
            {
                return currentValue;
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
            ICarAudioFilesRename carAudioFilesRename;
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
            if (!System.IO.Directory.Exists(textDirectoryIn.Text))
            {
                ShowErrorText("Folder does not exists: " + textDirectoryIn.Text);
                return;
            }
            if (!System.IO.Directory.Exists(textDirectoryOut.Text))
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
            carAudioFilesRename = new CarAudioFilesRename(textFileTypes.Text, directoryIn);
            carAudioFilesRename.FillData();
        }
    }
}
