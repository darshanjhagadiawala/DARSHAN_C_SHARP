using System;

namespace OperatorOverloading
{
    class C //Class for Operator Overloading
    {
        private int a;
        private int b;
        public C()
        {
            
        }
        public C(int i, int j)
        {
            a = i; 
            b = j;
        }
        public void ShowAB()
        {
            Console.WriteLine("{0} {1}", a, b);
        }
        //Unary Operator
        public static C operator -(C c)
        {
            C temp = new C(); //Temporary Object
            temp.a = -c.a;
            temp.b = -c.b;
            return temp;
        }
        //Binary Operator
        public static C operator +(C c3 , C c4)
        {
            C temp = new C(); //Temporary Object
            temp.a = c3.a + c4.a;
            temp.b = c3.b + c4.b;
            return temp;
        }
    }
    internal class Program
    {
        static void Main(string[] args) //Main Method for Operator Overloading
        {
            C c1 = new C(15, 20); //Objects for Unary Operator
            c1.ShowAB();
            C c2 = new C();
            c2.ShowAB();
            c2 = -c1;
            c2.ShowAB();
            C c3 = new C(25, 30); //Objects for Binary Operator
            c3.ShowAB();
            C c4 = new C(25, 30);
            c4.ShowAB();
            C c5 = new C();
            c5 = c3 + c4;
            c5.ShowAB();
        }
    }
}