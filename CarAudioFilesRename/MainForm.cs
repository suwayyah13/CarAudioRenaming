using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CarAudioFilesRename
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void ChooseFolderIn(object sender, EventArgs e)
        {
           textFolderIn.Text = ChooseFolder();
        }
        private void ChooseFolderOut(object sender, EventArgs e)
        {
            textFolderOut.Text = ChooseFolder();
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
        private void RenameAndCopyFiles(object sender, EventArgs e)
        {
            string errorText = "";
            if (String.IsNullOrEmpty(textFolderIn.Text))
            {
                errorText += "Please, choose Source folder" + System.Environment.NewLine;
            }
            if (String.IsNullOrEmpty(textFolderOut.Text))
            {
                errorText += "Please, choose Result folder" + System.Environment.NewLine;
            }
            if (String.IsNullOrEmpty(textFileTypes.Text))
            {
                errorText += "Please, fill File types" + System.Environment.NewLine;
            }
            if (String.IsNullOrEmpty(errorText) == false)
            {
                MessageBox.Show(errorText, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var directoryTools = new DirectoryTools(0, textFileTypes.Text);
            var directory = new DirectoryInfo(textFolderIn.Text);
            List<AudioCatalog> audioCatalog = directoryTools.GetDirectories(directory, 0);
            foreach (var catalog in audioCatalog)
            {
                char[] newFileName = catalog.Name.ToArray<char>();
                Debug.WriteLine(catalog);
            }
        }
    }
}
