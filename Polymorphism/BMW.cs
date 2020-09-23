using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    // Create two deriving classes, BMW and Audi, which have their own constructor and have an aditional property
    // called Model. Also a private member called brand. Brand should be different in each of the two classes.
    // Create the two methods ShowDetails() and Repair in them as well. Adjust those methods accordingly.

    class BMW : Car
    {
        private string brand;

        public string Model { get; set; }
        public string Brand
        {
            get
            {
                return brand;
            }
            set
            {
                brand = "Expensive" + value;
            }
        }

        public BMW(string co, int hp, string br, string mo): base(co, hp)
        {
            Brand = br;
            Model = mo;
        }
        public void ShowDetails()
        {
            Console.WriteLine("The color is {0}, speed force is {1}, brand is {2} and model {3}", Color, HP, Brand, Model);
        }
        public void Repair()
        {
            Console.WriteLine("The expensive car was repaired");
        }


    }
}
