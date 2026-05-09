namespace Model.Core;

public abstract partial class Article
{
    public Publisher? Publisher { get; set; }

    public bool TryAddPublisher(Publisher publisher)
    {
        if (publisher == null) return false;

        if (!publisher.SupportsAnyTopic(KeyWords)) return false;

        Publisher = publisher;
        return true;
    }
}