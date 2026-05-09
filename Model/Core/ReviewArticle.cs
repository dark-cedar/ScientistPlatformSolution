namespace Model.Core
{
    public class ReviewArticle : Article
    {
        public int ReviewedSourcesCount { get; set; }
        public override string ArticleType => "Review Article";

        public ReviewArticle()
        {
            ReviewedSourcesCount = 0;
        }

        public ReviewArticle(string issn, string title, int year, string journalname, List<string> keywords, List<Author> authors, int reviewedSourcesCount)
        : base(issn, title, year, journalname, keywords, authors)
        {
            if (reviewedSourcesCount <= 0) throw new ArgumentException();

            ReviewedSourcesCount = reviewedSourcesCount;
        }

        public override string GetShortInfo()
        {
            return $"Review article: {Title}, {JournalName}, {Year}, sources: {ReviewedSourcesCount}";
        }
    }
}
