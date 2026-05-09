namespace Model.Data
{
    public abstract class DataSerializer<T>
    {
        public abstract void Save(string path, List<T> items);

        public abstract List<T> Load(string Path);

        public virtual bool Exists(string path)
        {
            return File.Exists(path);
        }
    }
}
