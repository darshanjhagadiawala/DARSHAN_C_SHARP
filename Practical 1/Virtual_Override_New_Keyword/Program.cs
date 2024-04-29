using System;

namespace Virtual_Override_New_Keyword
{
    class A
    {
        public A() 
        {
            
        }
        public virtual void show()
        {
            Console.WriteLine("A is Base Class.");
        }
    }
    class B : A 
    {
        public B()
        {

        }
        public override void show()
        {
            Console.WriteLine("B is Derived Class.");
        }
    }
    class C : B
    {
        public C()
        {

        }
        public new void show()
        {
            Console.WriteLine("C is Derived Class");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            C c = new C();

            A d = a;
            d.show();

            d = b;
            d.show();

            d = c;
            d.show();
        }
    }
}