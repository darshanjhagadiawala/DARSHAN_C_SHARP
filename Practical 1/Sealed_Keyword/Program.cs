using System;

namespace Sealed_Keyword
{
    class A
    {
        public virtual void show() 
        {
            Console.WriteLine("A is Base Show.");
        }
        public virtual void print()
        {
            Console.WriteLine("A is Base Print.\n");
        }
    }
    class B : A
    {
        sealed override public void show()
        {
            Console.WriteLine("B is Derived Sealed.");
        }
        override public void print()
        {
            Console.WriteLine("B is Derived Override.\n");
        }
    }
    class C : B
    {
        override public void print()
        {
            Console.WriteLine("C is Derived Override.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.show();
            a.print();

            A b = new B();
            b.show();
            b.print();

            A c = new C();
            c.show();
            c.print();
        }
    }
}