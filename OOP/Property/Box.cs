using System;

namespace Property
{
    class Box
    {
        // Unsecured Variables
        //public double height;
        //public double length;
        //public double width;
        //public double volume;


        //data members
        private double height = 4;
        // private double length;
        private double width = 5.0;
        private double volume;



        public double Volume
        {
            get
            {
                return Width * Lenght * this.height;
            }
        }



        /**************************************
         *     Property method 03 
         * ***********************************/

        // dont need to have fields IF Auto-implemented
        public double Lenght { get; set; }







        /**************************************
         *     Property method 02 
         * ***********************************/

        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value < 0)
                {
                    width = -value;
                }
                else
                {
                    width = value;
                }

            }
        }



        /**************************************
         *     Property method 01 
         * ***********************************/

        // This is encapsulation - restriction direct acess to field.

        //Create method to set new value.
        public void SetHeight(double h)
        {
            if (h < 0)
            {
                throw new Exception("number less than zero");
            }
            this.height = h;
        }
        //Create method to get value on field.
        public double GetHeight()
        {
            return height;
        }




        // Control acess to modify volume, but still public acess.
        private void SetVol(double v)
        {
            this.volume = v;
        }
        public double GetVol()
        {
            return volume;
        }

        /**************************************
         *    Method  
         * ***********************************/


        public void CalcVolume()
        {
            SetVol(Lenght * Width * GetHeight());
            Console.WriteLine("Len({0}) x wid({1}) x hei({2}) = vol({3})",
                Lenght, Width, GetHeight(), GetVol());

        }

        /**************************************
         *     Constructor - 3 param
         * ***********************************/

        public Box(double w, double h, double l)
        {
            this.width = w;
            Lenght = l;
            SetHeight(h);
        }

        /**************************************
         *     Constructor - 0 param
         * ***********************************/

        public Box()
        {

        }

    }
}
