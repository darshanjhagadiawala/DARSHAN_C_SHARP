using System;

namespace Virtual_and_Override_Keyword
{
    class A //Base Class
    {
        public virtual void show() //Virtual Keyword Always used in Base Class 
        {
            Console.WriteLine("Hello: Base Class!");
            Console.ReadLine();
        }
    }
    class B : A //Derived Class
    {
        public override void show() //Override Keyword Always used in Derived Class
        {
            Console.WriteLine("Hello: Derived Class!");
            Console.ReadLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A a1 = new A(); //Object of Class A
            a1.show();
            B b1 = new B(); //Object of Class B
            b1.show();
            A a2 = new B(); //Object of A in the Reference of B
            a2.show();
        }
    }
}