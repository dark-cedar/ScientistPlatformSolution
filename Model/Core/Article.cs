using System.Xml.Serialization;

namespace Model.Core;

[XmlInclude(typeof(ResearchArticle))]
[XmlInclude(typeof(ReviewArticle))]
[XmlInclude(typeof(CaseStudy))]

public abstract partial class Article : IArticle
{
    public string ISSN { get; set; }
    public string Title { get; set; }
    public int Year { get; set; }
    public string JournalName { get; set; }
    public List<string> KeyWords { get; set; }
    public List<Author> Authors { get; set; }

    [XmlIgnore]
    public abstract string ArticleType { get; }

    protected Article()
    {
        ISSN = string.Empty;
        Title = string.Empty;
        Year = 0;
        JournalName = string.Empty;
        KeyWords = new List<string>();
        Authors = new List<Author>();
    }

    protected Article(string issn, string title, int year, string journalname, List<string> keywords, List<Author> authors)
    {
        if (string.IsNullOrWhiteSpace(issn)) throw new ArgumentException();

        if (string.IsNullOrWhiteSpace(title)) throw new ArgumentException();

        if (year <= 0) throw new ArgumentException();

        if (string.IsNullOrWhiteSpace(journalname)) throw new ArgumentException();

        if (keywords == null || keywords.Count == 0) throw new ArgumentException();

        if (authors == null || authors.Count == 0) throw new ArgumentException();

        ISSN = issn;
        Title = title;
        Year = year;
        JournalName = journalname;
        KeyWords = keywords;
        Authors = authors;
    }

    public virtual string GetShortInfo()
    {
        return $"{Title}, {JournalName}, {Year}";
    }

    public virtual bool MatchesKeyword(string keyword)
    {
        return KeyWords.Any(articleKeyword => 
            articleKeyword.Contains(keyword, StringComparison.OrdinalIgnoreCase));
    }

    public virtual bool MatchesKeyword(string keyword, bool strict)
    {
        if (strict) return KeyWords.Any(articleKeyword => 
            articleKeyword.Equals(keyword, StringComparison.OrdinalIgnoreCase));

        return MatchesKeyword(keyword);
    }

    public static bool operator ==(Article? left, Article? right)
    {
        if (ReferenceEquals(left, right)) return true;

        if (left is null || right is null) return false;

        return left.ISSN == right.ISSN;
    }

    public static bool operator !=(Article? left, Article? right)
    {
        return !(left == right);
    }

    public override bool Equals(object? obj)
    {
        if (obj is not Article article) return false;

        return ISSN == article.ISSN;
    }

    public override int GetHashCode()
    {
        return ISSN.GetHashCode();
    }
}