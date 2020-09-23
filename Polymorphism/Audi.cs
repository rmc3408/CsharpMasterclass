using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Audi : Car
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
                brand = "Cheap" + value;
            }
        }

        public Audi(string co, int hp, string br, string mo) : base(co, hp)
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
            Console.WriteLine("The cheap car was repaired");
        }
    }
}
