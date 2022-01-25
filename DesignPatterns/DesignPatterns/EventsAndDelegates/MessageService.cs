using System;

namespace DesignPatterns.EventsAndDelegates

{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MessageService: Sending a text message ...."+ e.Video.Title);
        }
    }
}