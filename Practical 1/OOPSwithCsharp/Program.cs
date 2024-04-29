using System;

namespace OOPSwithCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> x = null;
            int? s1 = 45;
            int m = s1 ?? 25;
            
            Console.WriteLine(x);
            Console.WriteLine(m);
            Console.Read();
        }
    }
}