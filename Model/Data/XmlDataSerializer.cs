using System.Xml.Serialization;

namespace Model.Data
{
    public class XmlDataSerializer<T> : DataSerializer<T>
    {
        public override void Save(string path, List<T> items)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));

            using FileStream stream = new FileStream(path, FileMode.Create);

            serializer.Serialize(stream, items);
        }

        public override List<T> Load(string path)
        {
            if (!File.Exists(path)) return new List<T>();

            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));

            using FileStream stream = new FileStream(path, FileMode.Open);

            object? result = serializer.Deserialize(stream);

            return result as List<T> ?? new List<T>();
        }
    }
}
