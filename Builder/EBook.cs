namespace BuilderPattern
{
    public class EBook : IBookBuilder
    {
        Book _book = new Book();
        public Book Build() => _book;

        public IBookBuilder SetName(string name)
        {
            _book.Name = name;
            return this;
        }
        public IBookBuilder SetAuthor(string author)
        {
            _book.Author = author;
            return this;
        }
        public IBookBuilder SetLanguage(string lang)
        {
            _book.Language = lang;
            return this;
        }
        public IBookBuilder SetFormat()
        {
            _book.Format = "Electronic";
            return this;
        }
        public IBookBuilder SetNumOfPages(int pages)
        {
            _book.NumOfPages = pages;
            return this;
        }
        public IBookBuilder SetPublisher(string pub)
        {
            _book.Publisher = pub;
            return this;
        }
        public IBookBuilder SetDistributor(string dist)
        {
            _book.Distributor = dist;
            return this;
        }
    }
}
