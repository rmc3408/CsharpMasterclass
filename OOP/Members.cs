using System;

namespace Destructor
{
    class Members
    {
        //fields
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age { get; set; }

        public Members()
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

        ~Members()
        {
            Console.WriteLine("DESTRUCTOR");
        }
    }
}
