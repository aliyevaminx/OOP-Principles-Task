
namespace OOP_Task8
{
    internal class Book
    {
        public string BookName { get; set; }
        public string BookGenre { get; set; }
        public string BookWriter { get; set; }

        public Book(string bookName, string bookGenre, string bookWriter)
        {
            BookName = bookName;
            BookGenre = bookGenre;
            BookWriter = bookWriter;
        }

    }
}
