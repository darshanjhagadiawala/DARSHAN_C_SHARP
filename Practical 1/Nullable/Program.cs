using System;

namespace Nullable1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> x;
            
            int ? s1 = null;
            int m = s1 ?? 25;
            int f = s1.GetValueOrDefault();

            int? a = 15;
            int b = 20;

            if (Nullable.Compare<int>(a, b) < 0) 
            {
                Console.WriteLine("Less");
            }
            else if (Nullable.Compare<int>(a, b) > 0)
            {
                Console.WriteLine("More");
            }
            else 
            {
                Console.WriteLine("Equal");
            }

            Console.WriteLine(m);
            Console.WriteLine(f);
            Console.Read();
        }
    }
}
