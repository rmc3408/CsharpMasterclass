using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace events
{
    public class DownloadHelper
    {

        // Step 01 - Create delegate to receive event
        public delegate void FileDownloadedEventHandler(object source, EventArgs args);


        // Step 02 - Create an event based on delegate
        public event FileDownloadedEventHandler FileDownloaded;


        //Step 03 - raise the event and must be virtual because exist on Object.
        //Call the event, if something inside(not null) execute event.
        protected virtual void OnFileDownloaded()
        {
            if(FileDownloaded != null)
            {
                FileDownloaded(this, EventArgs.Empty);
            }
        }


        public void Download(File doc)
        {
            Console.WriteLine("Downloading file....");
            Thread.Sleep(1500);


            OnFileDownloaded();
        }
    }
}
