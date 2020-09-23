using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePost
{
    class VideoPost : Post
    {
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
        public override string ToString()
        {
            return $"{this.ID} - VIDEO url:{this.VideoURL} : size: {this.Length} - {this.Title} by {this.SendBy}";
        }
    }
}
