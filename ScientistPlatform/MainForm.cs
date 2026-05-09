using Model.Core;
using Model.Data;

namespace ScientistPlatform;

public partial class MainForm : Form
{
    private ArticleRepository _repository;
    private SearchService _searchService;
    private bool _isFormLoaded;

    public MainForm()
    {
        InitializeComponent();

        _repository = new ArticleRepository("Data");
        _searchService = new SearchService();
        _isFormLoaded = false;
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        try
        {
            _repository.Initialize();

            comboSearchCriterion.DataSource = _searchService.GetSearchCriteria();

            comboDataFormat.DataSource = Enum.GetValues(typeof(DataFormat));
            comboDataFormat.SelectedItem = _repository.GetCurrentFormat();

            listPublishers.DataSource = _repository.Publishers;

            buttonFindArticles.Enabled = false;

            ShowArticles(_repository.Articles);

            labelStatus.Text = $"Loaded articles: {_repository.Articles.Count}";

            _isFormLoaded = true;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Startup error");
        }
    }

    private void textSearchValue_TextChanged(object sender, EventArgs e)
    {
        UpdateFindButtonState();
    }

    private void comboSearchCriterion_SelectedIndexChanged(object sender, EventArgs e)
    {
        UpdateFindButtonState();
    }

    private void UpdateFindButtonState()
    {
        buttonFindArticles.Enabled =
            comboSearchCriterion.SelectedItem != null &&
            !string.IsNullOrWhiteSpace(textSearchValue.Text);
    }

    private void buttonFindArticles_Click(object sender, EventArgs e)
    {
        try
        {
            string criterion = comboSearchCriterion.SelectedItem?.ToString() ?? "";
            string value = textSearchValue.Text.Trim();

            List<Article> foundArticles = _searchService.Search(
                _repository.Articles,
                criterion,
                value);

            ShowArticles(foundArticles);

            labelStatus.Text = $"Found articles: {foundArticles.Count}";
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Search error");
        }
    }

    private void buttonSendToPublisher_Click(object sender, EventArgs e)
    {
        try
        {
            string issn = textIssnForPublisher.Text.Trim();

            if (string.IsNullOrWhiteSpace(issn))
            {
                MessageBox.Show("Enter article ISSN.");
                return;
            }

            if (listPublishers.SelectedItem is not Publisher publisher)
            {
                MessageBox.Show("Select publisher.");
                return;
            }

            bool result = _repository.TrySendArticleToPublisher(issn, publisher);

            if (!result)
            {
                MessageBox.Show("Article was not found or does not match publisher topics.");
                return;
            }

            ShowArticles(_repository.Articles);

            labelStatus.Text = "Article was sent to publisher.";
            MessageBox.Show("Article was sent to publisher.");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Publisher error");
        }
    }

    private void comboDataFormat_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (!_isFormLoaded)
            return;

        try
        {
            if (comboDataFormat.SelectedItem is DataFormat format)
            {
                _repository.ChangeFormat(format);
                labelStatus.Text = $"Data format changed to {format}";
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Format error");
        }
    }

    private void buttonOpenCitationWindow_Click(object sender, EventArgs e)
    {
        try
        {
            CitationForm citationForm = new CitationForm(
                _repository.Articles,
                _repository.Publishers);

            citationForm.ShowDialog();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Citation window error");
        }
    }

    private void ShowArticles(List<Article> articles)
    {
        var tableData = articles.Select(article => new
        {
            article.ISSN,
            article.Title,
            article.Year,
            article.JournalName,
            Type = article.ArticleType,
            KeyWords = string.Join(", ", article.KeyWords),
            Authors = string.Join(", ", article.Authors.Select(author => author.FullName)),
            Publisher = article.Publisher?.Name ?? "-"
        }).ToList();

        dataGridArticles.DataSource = tableData;
    }
}