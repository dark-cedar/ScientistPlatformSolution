namespace Model.Core
{
    public class Author
    {
        public string ORCID { get; set; }
        public string FullName { get; set; }
        public string Affiliation { get; set; }

        public Author()
        {
            ORCID = string.Empty;
            FullName = string.Empty;
            Affiliation = string.Empty;
        }

        public Author(string orcid, string fullname, string affiliation)
        {
            if (string.IsNullOrWhiteSpace(orcid) || string.IsNullOrWhiteSpace(fullname)) 
                throw new ArgumentException();

            ORCID = orcid;
            FullName = fullname;
            Affiliation = affiliation;
        }

        public override string ToString()
        {
            return $"{FullName} ({ORCID})";
        }

        public override bool Equals(object? obj)
        {
            return obj is Author author && ORCID == author.ORCID;
        }

        public override int GetHashCode()
        {
            return ORCID.GetHashCode();
        }
    }
}
