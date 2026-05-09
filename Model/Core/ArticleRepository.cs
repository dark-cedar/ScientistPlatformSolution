using Model.Data;

namespace Model.Core;

public class ArticleRepository
{
    private readonly string _dataDirectory;

    private DataFormat _currentFormat;

    private readonly JsonDataSerializer<Article> _jsonSerializer;
    private readonly XmlDataSerializer<Article> _xmlSerializer;

    public List<Article> Articles { get; private set; }
    public List<Publisher> Publishers { get; private set; }

    public ArticleRepository(string dataDirectory)
    {
        if (string.IsNullOrWhiteSpace(dataDirectory))
            throw new ArgumentException("Data directory cannot be empty.");

        _dataDirectory = dataDirectory;
        _currentFormat = DataFormat.Json;

        _jsonSerializer = new JsonDataSerializer<Article>();
        _xmlSerializer = new XmlDataSerializer<Article>();

        Articles = new List<Article>();
        Publishers = new List<Publisher>();

        Directory.CreateDirectory(_dataDirectory);
    }

    public void Initialize()
    {
        CreateDefaultPublishers();

        string articlesPath = GetArticlesPath();

        if (!File.Exists(articlesPath))
        {
            CreateDefaultArticles();
            SaveArticles();
            return;
        }

        LoadArticles();

        if (Articles.Count == 0)
        {
            CreateDefaultArticles();
            SaveArticles();
        }
    }

    public void LoadArticles()
    {
        string path = GetArticlesPath();

        Articles = _currentFormat switch
        {
            DataFormat.Json => _jsonSerializer.Load(path),
            DataFormat.Xml => _xmlSerializer.Load(path),
            _ => new List<Article>()
        };
    }

    public void SaveArticles()
    {
        string path = GetArticlesPath();

        switch (_currentFormat)
        {
            case DataFormat.Json:
                _jsonSerializer.Save(path, Articles);
                break;

            case DataFormat.Xml:
                _xmlSerializer.Save(path, Articles);
                break;

            default:
                throw new InvalidOperationException("Unknown data format.");
        }
    }

    public void ChangeFormat(DataFormat newFormat)
    {
        if (_currentFormat == newFormat)
            return;

        LoadArticles();

        _currentFormat = newFormat;

        SaveArticles();
    }

    public DataFormat GetCurrentFormat()
    {
        return _currentFormat;
    }

    public string GetArticlesPath()
    {
        string extension = _currentFormat == DataFormat.Json ? "json" : "xml";

        return Path.Combine(_dataDirectory, $"articles.{extension}");
    }

    public Article? FindArticleByIssn(string issn)
    {
        if (string.IsNullOrWhiteSpace(issn))
            return null;

        return Articles.FirstOrDefault(article =>
            article.ISSN.Equals(issn, StringComparison.OrdinalIgnoreCase));
    }

    public bool TrySendArticleToPublisher(string issn, Publisher publisher)
    {
        Article? article = FindArticleByIssn(issn);

        if (article == null)
            return false;

        bool result = article.TryAddPublisher(publisher);

        if (result)
            SaveArticles();

        return result;
    }

    public List<IArticle> GetArticlesAsInterface()
    {
        return Articles.Select(article => (IArticle)article).ToList();
    }

    public List<ICitation> GetCitationArticles()
    {
        return Articles.Select(article => (ICitation)article).ToList();
    }

    public List<Article> GetArticlesAsBaseClass()
    {
        return Articles.Select(article => (Article)article).ToList();
    }

    private void CreateDefaultPublishers()
    {
        Publishers = new List<Publisher>
        {
            new Publisher(
                "Science House",
                9,
                new List<string>
                {
                    "AI",
                    "Medicine",
                    "Physics",
                    "Machine Learning"
                }),

            new Publisher(
                "Eco Publishing",
                7,
                new List<string>
                {
                    "Climate",
                    "Ecology",
                    "Statistics"
                }),

            new Publisher(
                "Case Reports Ltd",
                4,
                new List<string>
                {
                    "Case Study",
                    "Treatment",
                    "Medicine"
                }),

            new Publisher(
                "Engineering Press",
                8,
                new List<string>
                {
                    "Engineering",
                    "Materials",
                    "Robotics"
                })
        };
    }

    private void CreateDefaultArticles()
    {
        Author author1 = new Author(
            "0000-0001-1111-1111",
            "Ivan Petrov",
            "MIPT");

        Author author2 = new Author(
            "0000-0002-2222-2222",
            "Anna Smirnova",
            "MSU");

        Author author3 = new Author(
            "0000-0003-3333-3333",
            "John Smith",
            "Oxford");

        Author author4 = new Author(
            "0000-0004-4444-4444",
            "Maria Volkova",
            "Yandex Research");

        Articles = new List<Article>
        {
            new ResearchArticle(
                "1111-1111",
                "Machine Learning in Medicine",
                2022,
                "AI Science Journal",
                new List<string>
                {
                    "AI",
                    "Medicine",
                    "Machine Learning"
                },
                new List<Author>
                {
                    author1,
                    author2
                },
                "Experimental comparison"),

            new ReviewArticle(
                "2222-2222",
                "Modern Climate Models Review",
                2021,
                "Climate Review",
                new List<string>
                {
                    "Climate",
                    "Ecology",
                    "Statistics"
                },
                new List<Author>
                {
                    author2,
                    author3
                },
                42),

            new CaseStudy(
                "3333-3333",
                "Rare Disease Treatment Case",
                2023,
                "Medical Cases",
                new List<string>
                {
                    "Medicine",
                    "Case Study",
                    "Treatment"
                },
                new List<Author>
                {
                    author1,
                    author3
                },
                "Single patient treatment"),

            new ResearchArticle(
                "4444-4444",
                "Robotics in Industrial Engineering",
                2024,
                "Engineering Today",
                new List<string>
                {
                    "Engineering",
                    "Robotics",
                    "Materials"
                },
                new List<Author>
                {
                    author4
                },
                "Industrial prototype testing")
        };
    }
}