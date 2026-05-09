using Model.Core;

namespace ScientistPlatform;

public partial class CitationForm : Form
{
    private readonly List<Article> _articles;
    private readonly List<Publisher> _publishers;

    public CitationForm(List<Article> articles, List<Publisher> publishers)
    {
        InitializeComponent();

        _articles = articles;
        _publishers = publishers;

        Load += CitationForm_Load;
    }

    private void CitationForm_Load(object? sender, EventArgs e)
    {
        comboArticles.DataSource = _articles;
        comboArticles.DisplayMember = "Title";

        comboPublishers.DataSource = _publishers;
        comboPublishers.DisplayMember = "Name";

        textCitation.Text = "";
    }

    private void buttonCreateCitation_Click(object sender, EventArgs e)
    {
        try
        {
            if (comboArticles.SelectedItem is not Article article)
            {
                MessageBox.Show("Select article.");
                return;
            }

            if (comboPublishers.SelectedItem is not Publisher publisher)
            {
                MessageBox.Show("Select publisher.");
                return;
            }

            ICitation citationArticle = (ICitation)article;

            textCitation.Text = citationArticle.CreateCitation(publisher);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Citation error");
        }
    }

    private void buttonSaveCitation_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(textCitation.Text))
            {
                MessageBox.Show("Create citation first.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Text files (*.txt)|*.txt",
                FileName = "citation.txt"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, textCitation.Text);

                MessageBox.Show("Citation was saved.");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Save error");
        }
    }
}