using System.Collections.Generic;
using System.IO;

namespace CarAudioFilesRename
{
    class AudioCatalog
    {
        public int Id;
        public string Name;
        public string Path;
        public int Counter;
        public int ParentId;
        public bool IsDirectory;
        public List<AudioCatalog> Children;
        public AudioCatalog(int id, string name, string path, int counter, int parentId, bool isDirectory, List<AudioCatalog> children)
        {
            Id = id;
            Name = name;
            Path = path;
            Counter = counter;
            ParentId = parentId;
            IsDirectory = isDirectory;
            Children = children;
        }
    }
}
