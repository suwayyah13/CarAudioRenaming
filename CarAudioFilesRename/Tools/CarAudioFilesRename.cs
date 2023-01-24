using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace CarAudioFilesRename
{
    internal class CarAudioFilesRename
    {
        private int IdGlobal = 0;
        private string FileFilter;
        private DirectoryInfo DirectoryIn;
        private List<AudioCatalog> AudioCatalog;
        public CarAudioFilesRename(string fileFilter, DirectoryInfo directoryIn) 
        {
            FileFilter = fileFilter;
            DirectoryIn = directoryIn;
        }
        public void FillData()
        {
            IdGlobal = 0;
            AudioCatalog = GetDirectories(DirectoryIn, 0);
            var a = 1;
        }
        public List<AudioCatalog> GetDirectories(DirectoryInfo directory, int parentId)
        {
            int counter = 0;
            List<AudioCatalog> folders = new List<AudioCatalog>();
            foreach (var subdirectory in directory.GetDirectories())
            {
                counter++;
                IdGlobal++;
                int id = IdGlobal;
                var children = GetDirectories(subdirectory, id);
                if(children.Count() == 0)
                {
                    children = GetFiles(subdirectory, id);
                }
                folders.Add(new AudioCatalog(
                    id,
                    subdirectory.Name,
                    subdirectory.FullName,
                    counter,
                    parentId,
                    true,
                    children
                ));
            }
            return folders;
        }
        public List<AudioCatalog> GetFiles(DirectoryInfo directory, int parentId)
        {
            List<AudioCatalog> files = new List<AudioCatalog>();
            int counter = 0;
            foreach (var file in directory.GetFiles(FileFilter))
            {
                counter++;
                IdGlobal++;
                files.Add(new AudioCatalog(
                    IdGlobal,
                    file.Name,
                    file.FullName,
                    counter,
                    parentId,
                    false,
                    new List<AudioCatalog>()
                ));
            }
            return files;
        }

        public void SaveData(List<AudioCatalog> audioCatalog)
        {
            foreach (var catalogRow in AudioCatalog)
            {
                if(catalogRow.IsDirectory == true)
                {
                    SaveDirectory(catalogRow);
                } else
                {
                    SaveFile(catalogRow);
                }
            }
        }
        private void SaveDirectory(AudioCatalog audioCatalog)
        {

        }
        private void SaveFile(AudioCatalog audioCatalog)
        {

        }
    }
}
