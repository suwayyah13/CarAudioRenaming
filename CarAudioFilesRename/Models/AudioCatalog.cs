using System.Collections.Generic;

namespace CarAudioFilesRename
{
    class AudioCatalog
    {
        public int Id;
        public string Name;
        public string Path;
        public int Counter;
        public int ParentId;
        public bool IsFolder;
        public List<AudioCatalog> Children;
        public AudioCatalog(int id, string name, string path, int counter, int parentId, bool isFolder, List<AudioCatalog> children)
        {
            Id = id;
            Name = name;
            Path = path;
            Counter = counter;
            ParentId = parentId;
            IsFolder = isFolder;
            Children = children;
        }
    }
}
