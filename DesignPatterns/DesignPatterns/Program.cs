using DesignPatterns.Generics;
using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var book = new Book { Isbn = "12345", Title = "Book" };

            //Criando 2 listas para 2 ctxs
            //var numbers = new List();
            //numbers.Add(10);

            //var books = new BookList();
            //books.Add(book);


            //Com Generics eu vou ter somente a instancia de uma mesma classe para gerar as 2 listas

            var numbers = new GenericList<int>();
            numbers.Add(1);

            var books = new GenericList<Book>();
            books.Add(book);


            var dictionary = new GenericDictionary<string, Book>();
            dictionary.Add("1234", new Book());


        }
    }
}
