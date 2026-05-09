namespace Model.Core
{
    public class SearchService
    {
        public List<string> GetSearchCriteria()
        {
            return new List<string>
            {
                "ISSN",
                "Title",
                "Year",
                "JournalName",
                "KeyWords",
                "ArticleType",
                "Authors",
                "Publisher"
            };
        }

        public List<Article> Search(IEnumerable<Article> articles, string criterion, string value)
        {
            if (articles == null) return new List<Article>();

            if (string.IsNullOrWhiteSpace(criterion)) return new List<Article>();

            if (string.IsNullOrWhiteSpace(value)) return new List<Article>();

            Predicate<Article> predicate = criterion switch
            {
                "ISSN" => article =>
                    article.ISSN.Contains(value, StringComparison.OrdinalIgnoreCase),

                "Title" => article =>
                    article.Title.Contains(value, StringComparison.OrdinalIgnoreCase),

                "Year" => article =>
                    article.Year.ToString() == value,

                "JournalName" => article =>
                    article.JournalName.Contains(value, StringComparison.OrdinalIgnoreCase),

                "KeyWords" => article =>
                    article.KeyWords.Any(keyword =>
                        keyword.Contains(value, StringComparison.OrdinalIgnoreCase)),

                "ArticleType" => article =>
                    article.ArticleType.Contains(value, StringComparison.OrdinalIgnoreCase),

                "Authors" => article =>
                    article.Authors.Any(author =>
                        author.FullName.Contains(value, StringComparison.OrdinalIgnoreCase)),

                "Publisher" => article =>
                    article.Publisher != null &&
                    article.Publisher.Name.Contains(value, StringComparison.OrdinalIgnoreCase),

                _ => article => false
            };

            return articles.Where(article => predicate(article)).ToList();
        }

        public List<Article> Search(IEnumerable<Article> articles, string value)
        {
            if (articles == null)
                return new List<Article>();

            if (string.IsNullOrWhiteSpace(value))
                return new List<Article>();

            return articles
                .Where(article =>
                    article.ISSN.Contains(value, StringComparison.OrdinalIgnoreCase) ||
                    article.Title.Contains(value, StringComparison.OrdinalIgnoreCase) ||
                    article.JournalName.Contains(value, StringComparison.OrdinalIgnoreCase) ||
                    article.ArticleType.Contains(value, StringComparison.OrdinalIgnoreCase) ||
                    article.KeyWords.Any(keyword =>
                        keyword.Contains(value, StringComparison.OrdinalIgnoreCase)) ||
                    article.Authors.Any(author =>
                        author.FullName.Contains(value, StringComparison.OrdinalIgnoreCase)))
                .ToList();
        }
    }
}
