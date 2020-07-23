using System;

namespace Destructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Destructor p1 = new Destructor();
            p1.Intro();
            Console.WriteLine(p1.Name + " " + p1.Age);



        }
    }
}
