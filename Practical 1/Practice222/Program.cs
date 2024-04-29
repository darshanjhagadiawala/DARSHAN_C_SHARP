using System;

namespace Practice2
{
    enum CarBrands
    {
        Toyota,
        Tata,
        Honda,
        Skoda,
        VolksWagon=25,
        BMW,
        RangeRover
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Datatypes:");
            Console.WriteLine("");
            int i = 15;
            float f = 1.5f;
            char ch = 'D';
            double d = 15.15D;
            string s = "DARSHAN JHAGADIAWALA!!!!!";

            Console.WriteLine(i);
            Console.WriteLine(f);
            Console.WriteLine(ch);
            Console.WriteLine(d);
            Console.WriteLine(s);

            Console.WriteLine("");
            Console.WriteLine("Enum");
            Console.WriteLine(CarBrands.Toyota);
            int CB = (int)CarBrands.Tata; //Enum to Int Conversion
            Console.WriteLine(CB);

            var cb = (CarBrands)27; //Int to Enum Conversion
            Console.WriteLine(cb);
        }
    }
}