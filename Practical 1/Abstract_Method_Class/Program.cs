using System;

namespace Abstract_Method_Class
{
    abstract class A //Abstract Class
    {
        public abstract void print(); //Abstract Method without Body
        public void show()
        {
            Console.WriteLine("This is Abstract Class.\n");
        }
    }
    class B : A
    {
        public override void print() 
        {
            Console.WriteLine("This is Base Class.\n");
        }
    }
    class C : B
    {
        public override void print()
        {
            Console.WriteLine("This is Class C.");
        }
    }
    class D : C
    {
        public override void print()
        {
            Console.WriteLine("This is Class D.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new B();
            a.show();
            a.print();

            B b = new C();
            b.show();
            b.print();

            C d = new D();
            d.show(); 
            d.print();

            A c = new D();
            c.show(); 
            c.print();
        }
    }
}