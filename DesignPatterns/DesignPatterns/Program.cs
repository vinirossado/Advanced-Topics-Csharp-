using DesignPatterns.Delegates;
using DesignPatterns.Generics;
using System;
using DesignPatterns.EventsAndDelegates;

namespace DesignPatterns
{
    internal class Program
    {
        #region Lamba Expression

        //Lamba Expression
        //    static void Main(string[] args)
        //    {
        //        var books = new BookRepository().GetBooks();
        //        Action<Book> del;

        //        var cheapBooks = books.FindAll(x => x.Price <= 10);

        //        foreach (var book in cheapBooks)
        //        {
        //            Console.WriteLine(book.Title);
        //        }
        //    }
        //}
        #endregion Lamba Expression


        #region Events and Delegates

        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder(); //Publisher
            var mailService = new MailService(); //Subscriber
            var messageService = new MessageService(); //Subscriber


            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
            videoEncoder.Encode(video);
        }


        
    }
    #endregion Events and Delegates

}
