using System;

namespace events
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Events and delegates";

            File doc = new File(){ Title = "Dome" };
            
            var downloadhelper = new DownloadHelper(); //publisher
            var unpack = new UnpackService(); //receiver
            var note = new NotificationService();
            
            downloadhelper.FileDownloaded += unpack.OnFileDownloaded;
            downloadhelper.FileDownloaded += note.OnFileDownloaded;

            downloadhelper.Download(doc);
                 
        }
    }
}
