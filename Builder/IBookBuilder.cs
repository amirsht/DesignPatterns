namespace BuilderPattern
{
    public interface IBookBuilder
    {
        Book Build();
        IBookBuilder SetName(string name);
        IBookBuilder SetAuthor(string author);
        IBookBuilder SetLanguage(string lang);
        IBookBuilder SetFormat();
        IBookBuilder SetNumOfPages(int pages);
        IBookBuilder SetPublisher(string pub);
        IBookBuilder SetDistributor(string dist);
    }
}
