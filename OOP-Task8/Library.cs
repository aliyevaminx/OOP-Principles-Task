using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task8
{
    internal class Library
    {
        public Book[] Books { get; set; }
        private int bookCount;

        public Library()
        {
            Books = new Book[10];
        }

        public void AddBook(Book book)
        {
            Books[bookCount++] = book;
        }

        public void GetDetails()
        {
            for (int i = 0; i < bookCount; i++)
            {
                Console.WriteLine($"{i + 1}) Book Name: {Books[i].BookName} - Book Genre: {Books[i].BookGenre} - Writer: {Books[i].BookWriter} ");
            }
        }
    }
}
