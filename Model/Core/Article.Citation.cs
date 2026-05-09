using System.Xml.Serialization;

namespace Model.Core;

public abstract partial class Article : ICitation 
{
    [XmlIgnore]
    public string Citation
    {
        get 
        {
            if (Publisher == null) return CreateDefaultCitation();

            return CreateCitation(Publisher);
        }
    }

    public string CreateCitation(Publisher publisher)
    {
        if (publisher == null) return CreateDefaultCitation();

        string authors = string.Join(", ", Authors.Select(author => author.FullName));

        if (publisher.Rating >= 8) 
            return $"{authors}. {Title}. {JournalName}. {Year}. ISSN: {ISSN}. Published by {publisher.Name}.";

        if (publisher.Rating >= 5)
            return $"{Title} / {authors} // {JournalName}. — {Year}. — ISSN {ISSN}.";

        return $"{authors} ({Year}). \"{Title}\". {JournalName}, ISSN {ISSN}."; 
    }

    public string CreateDefaultCitation()
    {
        string authors = string.Join(", ", Authors.Select(author => author.FullName));

        return $"{authors}. {Title}. {JournalName}. {Year}. ISSN: {ISSN}.";
    }
}