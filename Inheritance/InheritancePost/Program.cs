using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePost
{
    class Program
    {
        static void Main(string[] args)
        {
            Post p1 = new Post("first title book", true, "Raphael");
            Console.WriteLine(p1.ToString());

            ImagePost img1 = new ImagePost("my github", true, "Raph",
                "https://github.com/rmc3408");
            Console.WriteLine(img1.ToString());

            VideoPost vid1 = new VideoPost("my youtube", true, "Raphael",
                "https://youtube.ca", 14);
            Console.WriteLine(vid1.ToString());

            Console.ReadKey();
            vid1.Play();
            Console.WriteLine("press any key to stop");
            Console.ReadKey();
            vid1.Stop();
            Console.ReadKey();
        }
    }
}
