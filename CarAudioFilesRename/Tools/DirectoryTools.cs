using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;

namespace CarAudioFilesRename
{
    internal class DirectoryTools
    {
        public int Id;
        public string FileFilter;
        public DirectoryTools(int id, string fileFilter) 
        {
            Id = id;
            FileFilter = fileFilter;
        }
        public List<AudioCatalog> GetDirectories(DirectoryInfo directory, int parentId)
        {
            int counter = 0;
            List<AudioCatalog> folders = new List<AudioCatalog>();
            foreach (var subdirectory in directory.GetDirectories())
            {
                counter++;
                Id++;
                var childrenCurrent = GetDirectories(subdirectory, Id);
                if(childrenCurrent.Count() == 0)
                {
                     childrenCurrent = GetFiles(subdirectory, Id);
                }
                folders.Add(new AudioCatalog(
                    Id, 
                    subdirectory.Name,
                    subdirectory.FullName,
                    counter,
                    parentId,
                    true,
                    childrenCurrent
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
                Id++;

                files.Add(new AudioCatalog(
                    Id,
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
    }
}
