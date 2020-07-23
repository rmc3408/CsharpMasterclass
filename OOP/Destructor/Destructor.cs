using System;

namespace Destructor
{
    class Destructor
    {
        //fields
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age { get; set; }


        public void Intro()
        {
            Console.WriteLine("top Intro method");
            Details();
        }

        private void Details()
        {
            Console.WriteLine("Within Details method");
        }

        public Destructor()
        {
            Name = "John";
            Age = 30;
            Console.WriteLine("default object created");
        }

        /* 
        * Only create ONE per class, not inialized, only within Class
        * cannot override, overloaded, neither Inherits
        * 
        *      TO CLEAN STATEMENTS
        */

        ~Destructor()
        {
            Console.WriteLine("DESTRUCTOR called");
            System.Diagnostics.Debug.WriteLine("Debug says::");
        }
    }
}
