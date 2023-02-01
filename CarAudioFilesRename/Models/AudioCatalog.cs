using System.Collections.Generic;
using System.IO;

namespace CarAudioFilesRename
{
    public interface IAudioCatalog
    {
        int Id { get; set; }
        string Name { get; set; }
        string Path { get; set; }
        int Counter { get; set; }
        int ParentId { get; set; }
        bool IsDirectory { get; set; }
        List<IAudioCatalog> Children { get; set; }
    }
    public class AudioCatalog: IAudioCatalog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public int Counter { get; set; }
        public int ParentId { get; set; }
        public bool IsDirectory { get; set; }
        public List<IAudioCatalog> Children { get; set; }
    }
}
