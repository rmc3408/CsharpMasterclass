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
        }
    }
}
