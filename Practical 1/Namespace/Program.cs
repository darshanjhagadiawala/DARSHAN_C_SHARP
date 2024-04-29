using System;
using Practice1;
using Practice2;

namespace Practice1
{
    class A
    {

        public int i = 1;
        private int j = 2;
        protected int k = 3;
        internal int l = 4;
        public static void show()
        {
            Console.WriteLine("This is Class A.");
        }
        public int getj()
        {
            return j;
        }
        public int getk()
        {
            return k;
        }
    }
}
namespace Practice2
{
    class B
    {
        internal protected int x
        {
            get;
            set;
        }
    }
    class C : B
    {
        public C()
        {
            x = 10;
        }
    }
}
namespace Namespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A.show();

            A a = new A();
            Console.WriteLine(a.i);
            Console.WriteLine(a.getj());
            Console.WriteLine(a.getk());
            Console.WriteLine(a.l);

            C c = new C();
            Console.WriteLine("Internal Protected value: " + c.x);
        }
    }
}