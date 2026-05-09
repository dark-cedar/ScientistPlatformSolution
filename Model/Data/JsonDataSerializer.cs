using Newtonsoft.Json;

namespace Model.Data
{
    public class JsonDataSerializer<T> : DataSerializer<T>
    {
        public override void Save(string path, List<T> items)
        {
            string json = JsonConvert.SerializeObject(
                items,
                Formatting.Indented,
                new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.Auto
                }
            );

            File.WriteAllText(path, json);
        }

        public override List<T> Load(string path)
        {
            if (!File.Exists(path)) return new List<T>();

            string json = File.ReadAllText(path);

            List<T>? items = JsonConvert.DeserializeObject<List<T>>(
                json,
                new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.Auto
                });

            return items ?? new List<T>();
        }
    }
}
