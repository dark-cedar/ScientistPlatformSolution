namespace Model.Core
{
    public class ResearchArticle : Article
    {
        public string Methodology { get; set; }
        public override string ArticleType => "Research Article";

        public ResearchArticle()
        {
            Methodology = string.Empty;
        }

        public ResearchArticle(string issn, string title, int year, string journalname, List<string> keywords, List<Author> authors, string methodology)
        : base(issn, title, year, journalname, keywords, authors)
        {
            if (string.IsNullOrWhiteSpace(methodology)) throw new ArgumentException();

            Methodology = methodology;
        }

        public override string GetShortInfo()
        {
            return $"Research article: {Title}, {JournalName}, {Year}, methodology: {Methodology}";
        }
    }
}
