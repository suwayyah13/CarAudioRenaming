namespace CarAudioFilesRename
{
    class HierarchicalItem
    {
        public string Name;
        public string Path;
        public int Depth;
        public int Counter;
        public Type _Type;
        public enum Type
        {
            Folder,
            File
        }
        public HierarchicalItem(string name, string path, int depth, Type type, int counter)
        {
            this.Name = name;
            this.Path = path;
            this.Depth = depth;
            this._Type=type;
            this.Counter = counter;
        }
        public HierarchicalItem(string name, string path, int depth, Type type)
        {
            this.Name = name;
            this.Depth = depth;
            this._Type=type;
        }
    }
}
