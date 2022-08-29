using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CarAudioFilesRename
{
    public partial class MainForm : Form
    {
        private string Separator;
        public MainForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Separator = "" + Path.DirectorySeparatorChar;
        }
        private void ChooseFolderIn(object sender, EventArgs e)
        {
           if (FolderBrowserDialogInput.ShowDialog() == DialogResult.OK)
           {
                textFolderIn.Text = FolderBrowserDialogInput.SelectedPath;
           }
        }
        private void ChooseFolderOut(object sender, EventArgs e)
        {
            if (FolderBrowserDialogInput.ShowDialog() == DialogResult.OK)
            {
                textFolderOut.Text = FolderBrowserDialogInput.SelectedPath;
            }
        }
        private static IEnumerable<HierarchicalItem> SearchDirectory(DirectoryInfo directory, int depth = 0, string fileFilter = "")
        {
            yield return new HierarchicalItem(directory.Name, directory.FullName, depth, HierarchicalItem.Type.Folder);
            foreach (var subdirectory in directory.GetDirectories())
            {
                foreach (var item in SearchDirectory(subdirectory, depth + 1, fileFilter))
                {
                    yield return item;
                }
            }
            foreach (var file in directory.GetFiles(fileFilter))
            {
                yield return new HierarchicalItem(file.Name, directory.FullName, depth + 1, HierarchicalItem.Type.File);
            }
        }
        private string FillZeroes(int counter, int counterMax)
        {
            string prefix = "";
            int digit = counter.ToString().Length;
            int maxDigit = counterMax.ToString().Length;
            if (maxDigit > digit)
            {
                prefix = String.Concat(Enumerable.Repeat("0", maxDigit - digit));
            }
            return prefix;
        }
        private bool IsDirectoriesError()
        {
            string errorText = "";
            bool isError = false;
            if (String.IsNullOrEmpty(textFolderIn.Text))
            {
                errorText += "Folder in not filled" + System.Environment.NewLine;
            }
            else if (!Directory.Exists(textFolderIn.Text))
            {
                errorText += "Folder in \"" + textFolderIn.Text + "\" does not exists" + System.Environment.NewLine;
            }
            if (String.IsNullOrEmpty(textFolderOut.Text))
            {
                errorText += "Folder out not filled" + System.Environment.NewLine;
            }
            else if (!Directory.Exists(textFolderOut.Text))
            {
                errorText += "Folder out \"" + textFolderIn.Text + "\" does not exists" + System.Environment.NewLine;
            }
            if(!String.IsNullOrEmpty(errorText))
            {
                MessageBox.Show(errorText, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isError = true;
            }
            return isError;
        }
        private void RenameAndCopyFiles(object sender, EventArgs e)
        {
            if(IsDirectoriesError())
            {
                return;
            }
            DirectoryInfo directory = new DirectoryInfo(textFolderIn.Text);
            IEnumerable<HierarchicalItem> items = SearchDirectory(directory, 0, textFileTypes.Text);
            IEnumerable<HierarchicalItem> query = items.Where(item => item._Type == HierarchicalItem.Type.File);
            int maxCounter = query.Count();
            int counter = 0;
            if(maxCounter == 0)
            {
                MessageBox.Show("Files of type: " + textFileTypes.Text + " was not found in folder " + textFolderIn.Text, 
                        "Files not found", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error
                );
                return;
            }
            foreach (HierarchicalItem item in query)
            {
                counter++;
                int nameLength = item.Name.Length;
                string newFileName = "";
                if(nameLength > 5)
                {
                    for (int i = 0; i < nameLength-3; i++)
                    {
                        if (char.IsLetter(item.Name[i]))
                        {
                            newFileName = item.Name.Substring(i);
                            break;
                        }
                        else if (char.IsPunctuation(item.Name[i]))
                        {
                            newFileName = item.Name.Substring(i+1);
                            break;
                        }
                    }
                }
                if(newFileName.Length < 4)
                {
                    newFileName=item.Name;
                }
                newFileName = FillZeroes(counter, maxCounter) + counter + "." + newFileName;
                //Console.WriteLine(item.Path + Separator + item.Name);
                //Console.WriteLine(textFolderOut.Text + Separator + newFileName);
                File.Copy(item.Path + Path.DirectorySeparatorChar + item.Name, textFolderOut.Text + Path.DirectorySeparatorChar + newFileName, true);
            }
        }
    }
}
