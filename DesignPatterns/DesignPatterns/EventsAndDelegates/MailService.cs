using System;

namespace DesignPatterns.EventsAndDelegates

{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MailService: Sending an email....." + e.Video.Title);
        }
    }
}