using System;

namespace events
{
    public class NotificationService
    {
        public void OnFileDownloaded(object source, EventArgs e)
        {
            Console.WriteLine("Notifying the file is done.");
        }
    }
}
