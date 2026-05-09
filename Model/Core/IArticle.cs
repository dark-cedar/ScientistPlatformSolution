namespace Model.Core
{
    public interface IArticle
    {
        string ISSN { get; }
        string Title { get; set; }
        int Year { get; set; }
        string JournalName { get; set; }
        List<string> KeyWords { get; set; }
        List<Author> Authors { get; set; }

        string ArticleType { get; }
        string GetShortInfo();
    }
}
