using System;

namespace Property
{
    class Program
    {
        static void Main(string[] args)
        {
            Box mypack = new Box();

            Console.WriteLine("--------Set new value-----");
            // mypack.heigth = 5;                              // Cannot write
            mypack.Width = 8;
            mypack.Lenght = 3;
            mypack.SetHeight(4.5);

            Console.WriteLine("----Get existing value----");
            //Console.WriteLine("Box length is "+ mypack.heigth); // Cannot read;
            Console.WriteLine("Box length is " + mypack.GetHeight());
            Console.WriteLine("Box width is " + mypack.Width);


            Console.WriteLine("--------");

            Box mini = new Box(10, 5, 3);
            mini.CalcVolume();
            Console.WriteLine("The volume is " + mini.GetVol());
        }
    }
}
