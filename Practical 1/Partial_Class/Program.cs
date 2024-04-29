using System;

namespace Partial_Class
{
    partial class A
    {
        public void show()
        {
            Console.WriteLine("This is Class A.");
        }
    }
    partial class A
    {
        public void print()
        {
            Console.WriteLine("This is Class A1.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.show();
            a.print();
        }
    }
}