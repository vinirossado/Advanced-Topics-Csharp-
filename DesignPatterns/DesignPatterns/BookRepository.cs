using DesignPatterns.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "Book 1", Price = 5},
                new Book() {Title = "Book 2", Price = 7},
                new Book() {Title = "Book 3", Price = 19}
            };
        }

    }
}
