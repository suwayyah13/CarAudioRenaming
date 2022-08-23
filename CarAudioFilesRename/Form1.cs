using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CarAudioFilesRename
{
    public partial class MainForm : Form
    {
        private int Counter = 0;
        public MainForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

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
        private IEnumerable<HierarchicalItem> SearchDirectory(DirectoryInfo directory, int depth = 0, string fileFilter = "")
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
                Counter++;
                yield return new HierarchicalItem(file.Name, directory.FullName, depth + 1, HierarchicalItem.Type.File, Counter);
            }
        }
        private void RenameAndCopyFiles(object sender, EventArgs e)
        {
            var directory = new DirectoryInfo(textFolderIn.Text);
            var items = SearchDirectory(directory, 0, textFileTypes.Text);
            /*
                foreach (var item in items)
                {
                    Console.WriteLine(string.Concat(Enumerable.Repeat('\t', item.Depth)) + item.Name + " - " + item._Type + " - " + item.Counter);
                }
            */
            var query = items.Where(item => item._Type == HierarchicalItem.Type.File);
            foreach (var item in query)
            {
                char[] newFileName = item.Name.ToArray<char>();
                //Console.WriteLine("" + item.Name + " - " + item.Path);
            }
        }
    }
}
