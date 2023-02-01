using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace CarAudioFilesRename
{
    public interface ICarAudioFilesRename
    {
        int IdGlobal { get; set; }
        string FileFilter { get; set; }
        DirectoryInfo DirectoryIn { get; set; }
        List<IAudioCatalog> AudioCatalog { get; set; }
        void FillData();
        List<IAudioCatalog> GetDirectories(DirectoryInfo directory, int parentId);
        List<IAudioCatalog> GetFiles(DirectoryInfo directory, int parentId);
    }
    internal class CarAudioFilesRename : ICarAudioFilesRename
    {
        public int IdGlobal { get; set; }
        public string FileFilter { get; set; }
        public DirectoryInfo DirectoryIn { get; set; }
        public List<IAudioCatalog> AudioCatalog { get; set; }
        public CarAudioFilesRename(string fileFilter, DirectoryInfo directoryIn)
        {
            FileFilter = fileFilter;
            DirectoryIn = directoryIn;
        }
        public void FillData()
        {
            IdGlobal = 0;
            AudioCatalog = GetDirectories(DirectoryIn, 0);
        }
        public List<IAudioCatalog> GetDirectories(DirectoryInfo directory, int parentId)
        {
            int counter = 0;
            List<IAudioCatalog> folders = new List<IAudioCatalog>();
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
                var currentRow = new AudioCatalog
                {
                    Id = id,
                    Name = subdirectory.Name,
                    Path = subdirectory.FullName,
                    Counter = counter,
                    ParentId = parentId,
                    IsDirectory = true,
                    Children = children
                };
                folders.Add(currentRow);
            }
            return folders;
        }
        public List<IAudioCatalog> GetFiles(DirectoryInfo directory, int parentId)
        {
            List<IAudioCatalog> files = new List<IAudioCatalog>();
            int counter = 0;
            foreach (var file in directory.GetFiles(FileFilter))
            {
                counter++;
                IdGlobal++;
                var currentRow = new AudioCatalog
                {
                    Id = IdGlobal,
                    Name = file.Name,
                    Path = file.FullName,
                    Counter = counter,
                    ParentId = parentId,
                    IsDirectory = false,
                    Children = new List<IAudioCatalog>()
                };
                files.Add(currentRow);
            }
            return files;
        }
        public void SaveData(List<IAudioCatalog> audioCatalog)
        {
            foreach (var catalogRow in audioCatalog)
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
        private void SaveDirectory(IAudioCatalog audioCatalog)
        {

        }
        private void SaveFile(IAudioCatalog audioCatalog)
        {

        }
    }
}
