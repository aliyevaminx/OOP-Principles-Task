using OOP_Task8;

class Program
{
    public static void Main(string[] args)
    {
        Library library = new Library();

        Book book1 = new Book("Mastery", "Non-Fictional", "Robert Greene");
        Book book2 = new Book("Daily Stoic", "Non-Fictional", "Ryan Holiday");
        Book book3 = new Book("Think and Grow Rich", "Non-Fictional", "Ryan Holiday");
        Book book4 = new Book("48 Laws of Power", "Non-Fictional", "Robert Green");

        library.AddBook(book1);
        library.AddBook(book2);
        library.AddBook(book3);
        library.AddBook(book4);

        library.GetDetails();
    }
}