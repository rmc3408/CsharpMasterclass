using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePost
{
    class Post
    {
        private static int currentPostId { get; set; }

        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendBy { get; set; }
        protected bool IsPublic { get; set; }

        public Post()
        {
            ID = 0;
            Title = "My first post";
            IsPublic = true;
            SendBy = "Denis";

        }
        public Post(string tit, bool isP, string send)
        {
            this.ID = GetNextID();
            this.Title = tit;
            this.IsPublic = isP;
            this.SendBy = send;
        }
        protected int GetNextID()
        {
            return ++currentPostId;
        }
        public void updateTitle(string tit, bool isP)
        {
            this.Title = tit;
            this.IsPublic = isP;


        }
        public override string ToString()
        {
            return $"{this.ID} - {this.Title} by {this.SendBy}";
        }
    }
}
