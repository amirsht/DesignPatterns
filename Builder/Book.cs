using System.Text;

namespace BuilderPattern
{
    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Language { get; set; }
        public string Format { get; set; }
        public int NumOfPages { get; set; }
        public string Publisher { get; set; }
        public string Distributor { get; set; }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append("{\n");
            stringBuilder.Append($"\tName: {Name}\n");
            stringBuilder.Append($"\tAuthor: {Author}\n");
            stringBuilder.Append($"\tLanguage: {Language}\n");
            stringBuilder.Append($"\tFormat: {Format}\n");
            stringBuilder.Append($"\tNumOfPages: {NumOfPages}\n");
            stringBuilder.Append($"\tPublisher: {Publisher}\n");
            stringBuilder.Append($"\tDistributor: {Distributor}\n");
            stringBuilder.Append("}");
            return stringBuilder.ToString();
        }
    }
}
