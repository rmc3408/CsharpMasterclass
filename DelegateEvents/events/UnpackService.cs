using System;

namespace events
{
    public class UnpackService
    {
        public void OnFileDownloaded(object source, EventArgs e)
        {
            Console.WriteLine("Unpacking the file...");
        }
    }
}
