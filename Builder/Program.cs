using System;

namespace BuilderPattern
{
    class Program
    {
        const string BOOK_NAME = "Clean Code";
        const string AUTHOR = "Robert Martin";
        const string PUBLISHER = "Pearson Education (US)";
        const string DISTRIBUTOR = "Pearson";
        const int NUM_OF_PAGES = 464;

        static void Main(string[] args)
        {
            EBook eBookBuilder = new EBook();
            Book ebook = eBookBuilder.SetFormat()
                                   .SetName(BOOK_NAME)
                                   .SetAuthor(AUTHOR)
                                   .SetPublisher(PUBLISHER)
                                   .SetLanguage("English")
                                   .SetNumOfPages(NUM_OF_PAGES)
                                   .Build();

            DateTime date = DateTime.Now;

            Console.WriteLine(ebook);
            Console.WriteLine("\n---------------------------------------------\n");

            PrintedBook pBookBuilder = new PrintedBook();
            Book pbook = pBookBuilder.SetFormat()
                                   .SetName(BOOK_NAME)
                                   .SetAuthor(AUTHOR)
                                   .SetPublisher(PUBLISHER)
                                   .SetDistributor(DISTRIBUTOR)
                                   .SetNumOfPages(NUM_OF_PAGES)
                                   .Build();

            Console.WriteLine(pbook);
            Console.In.ReadLine();

        }
    }
}
