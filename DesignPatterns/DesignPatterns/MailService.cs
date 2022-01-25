using System;
using DesignPatterns.EventsAndDelegates;

namespace DesignPatterns
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MailService: Sending an email....." + e.Video.Title);
        }
    }
}