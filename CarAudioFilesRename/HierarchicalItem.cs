namespace CarAudioFilesRename
{
    class HierarchicalItem
    {
        public string Name;
        public string Path;
        public int Depth;
        public Type _Type;
        public enum Type
        {
            Folder,
            File
        }
        public HierarchicalItem(string name, string path, int depth, Type type)
        {
            this.Name = name;
            this.Depth = depth;
            this.Path = path;
            this._Type=type;
        }
    }
}
