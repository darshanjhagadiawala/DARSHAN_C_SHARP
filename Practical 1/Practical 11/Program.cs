using System;

namespace Practical_1
{
    internal class Program
    {
        enum Departments
        {
            Frontend,
            Backend,
            Database,
            Android,
            DevOps,
            Cloud
        }
        static void Main(string[] args)
        {
            Console.WriteLine("DATATYPES");
            Console.WriteLine("");
            int i = 25;
            float f = 2.5f;
            char c = 'D';
            string s = "DARSHAN JHAGADIAWALA!!!";
            double d = 25.25D;

            Console.WriteLine(i);
            Console.WriteLine(f);
            Console.WriteLine(c);
            Console.WriteLine(s);
            Console.WriteLine(d);
            
            Console.WriteLine("");
            Console.WriteLine("Enum");
            Console.WriteLine(Departments.Android);
            int Dept = (int)Departments.Cloud; // Enum to int conversion
            Console.WriteLine(Dept);

            var dept = (Departments) 1;
            Console.WriteLine(dept);

            Console.WriteLine("");
            Console.WriteLine("Var Keyword");
            var x = 15;
            var y = "DARSHAN";
            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.WriteLine("");
            Console.WriteLine("Dynamic Keyword");
            dynamic z;
            z = 2;
            z = 10;
            Console.WriteLine(z);
            Console.Read();
        }
    }
}