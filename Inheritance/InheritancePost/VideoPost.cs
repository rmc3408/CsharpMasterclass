using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InheritancePost
{
    class VideoPost : Post
    {
        private int currentTime = 0;
        Timer crono;
        private bool isPlaying = false;

        public string VideoURL { get; set; }
        public int Length { get; set; }

        public VideoPost() { }

        public VideoPost(string tit, bool isP, string send, string url, int len)
        {
            this.ID = GetNextID();
            this.Title = tit;
            this.SendBy = send;
            this.IsPublic = isP;

            this.VideoURL = url; 
            this.Length = len;

        }
        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Start Playing");
                crono = new Timer(TimerCallback, null, 0, 1000);
                //Continue to TimerCallback funtion
                GC.Collect();

            }
        }
        private void TimerCallback(Object runningTime)
        {
            if (currentTime < Length)
            {
                currentTime++;
                Console.WriteLine($"Video at {currentTime} sec");
            }
            else
            {
                Stop();
            }
            
        }
        public void Stop()
        {
            if (isPlaying)
            {
                Console.WriteLine($"Video Stopped!!");
                currentTime = 0;
                isPlaying = false;
                crono.Dispose();
            }

        }
        public override string ToString()
        {
            return $"{this.ID} - VIDEO url:{this.VideoURL} : size: {this.Length} - {this.Title} by {this.SendBy}";
        }
    }
}
