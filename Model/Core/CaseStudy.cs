namespace Model.Core
{
    public class CaseStudy : Article
    {
        public string CaseDescription { get; set; }
        public override string ArticleType => "Case Study";

        public CaseStudy()
        {
            CaseDescription = string.Empty;
        }

        public CaseStudy(string issn, string title, int year, string journalname, List<string> keywords, List<Author> authors, string casedescription)
        : base(issn, title, year, journalname, keywords, authors)
        {
            if (string.IsNullOrWhiteSpace(casedescription)) throw new ArgumentException();

            CaseDescription = casedescription;
        }

        public override string GetShortInfo()
        {
            return $"Case study: {Title}, {JournalName}, {Year}, case: {CaseDescription}";
        }
    }
}
