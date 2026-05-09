namespace Model.Core
{
    public interface ICitation
    {
        string Citation { get; }

        string CreateCitation(Publisher publisher);
    }
}