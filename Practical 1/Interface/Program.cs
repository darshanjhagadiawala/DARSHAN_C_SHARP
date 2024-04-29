using System;

namespace Interface
{
    interface IA //Simple Interface
    {
        void show(); //Interface Method
    }
    class B : IA
    {
        public void show()
        {
            Console.WriteLine("Hello Unicorn!!!");
        }
    }
    interface IC //Multiple Interface
    {
        void method();
    }
    interface ID //Multiple Interface
    {
        void method1();
    }
    class E : IC, ID
    {
        public void method()
        {
            Console.WriteLine("I'm Multiple Interface 1.");
        }
        public void method1()
        {
            Console.WriteLine("I'm Multiple Interface 2.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            B b = new B(); //Object of the Simple Interface's class
            b.show();
            E e = new E(); //Object of the Multiple Interface's Class
            e.method();    //First method call through object
            e.method1();   //Second method call through object
        }
    }
}