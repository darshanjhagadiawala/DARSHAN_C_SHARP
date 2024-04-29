using System;

namespace Delegate
{
    internal class Program
    {
        public delegate void singlecast();
         
        public class P
        {
            public static void display()
            {
                Console.WriteLine("display");
            }
            public static void show()
            {
                Console.WriteLine("Show");
            }
            public void print()
            {
                Console.WriteLine("print");
            }
        }
        static void Main(string[] args)
        {
            singlecast d1 = P.show;
            singlecast d2 = new singlecast(P.display);
            P obj = new P();
            singlecast d3 = obj.print;

            d1();
            d2();
            d3();
            Console.ReadLine();
        }
    }
}