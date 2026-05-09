namespace Model.Core
{
    public class Publisher
    {
        public string Name { get; set; }
        public int Rating { get; set; }
        public List<string> Topics { get; set; }

        public Publisher()
        {
            Name = string.Empty;
            Topics = new List<string>();
        }

        public Publisher(string name, int rating, List<string> topics)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException();

            if (rating < 1 || rating > 10) throw new ArgumentException();

            if (topics == null || topics.Count == 0) throw new ArgumentException();

            Name = name;
            Rating = rating;
            Topics = topics;
        }

        public bool SupportsTopic(string Topic)
        {
            return Topics.Any(topic => topic.Equals(Topic, StringComparison.OrdinalIgnoreCase));
        }

        public bool SupportsAnyTopic(IEnumerable<string> topics)
        {
            return topics.Any(SupportsTopic);
        }

        public override string ToString()
        {
            return $"{Name}, rating: {Rating}";
        }
    }
}
