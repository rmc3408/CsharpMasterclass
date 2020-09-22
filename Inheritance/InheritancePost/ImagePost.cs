using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePost
{
    class ImagePost : Post
    {
        public string ImageURL { get; set; }

        public ImagePost() {}

        public ImagePost(string tit, bool isP, string send, string url)
        {
            this.ID = GetNextID();
            this.Title = tit;
            this.SendBy = send;
            this.IsPublic = isP;

            this.ImageURL = url;

        }
        public override string ToString()
        {
            return $"{this.ID} - url:{this.ImageURL} - {this.Title} by {this.SendBy}";
        }
    }
}
