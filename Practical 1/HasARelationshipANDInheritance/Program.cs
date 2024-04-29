using System;

namespace HasARelationshipANDInheritance
{
    class D //Simaple Inheritance
    {
        public D()
        {
            Console.WriteLine("D is a Base Class.");
        }
    }
    class P : D //Multilevel Inheritance
    {
        public P()
        {
            Console.WriteLine("P is a Derived Class.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            P p = new P();
        }
    }
}