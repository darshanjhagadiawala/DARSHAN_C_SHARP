using System;
using System.Collections;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Adding elements using ArrayList.Add() method
            var a1 = new ArrayList();
            a1.Add(1);
            a1.Add("Bill");
            a1.Add(" ");
            a1.Add(true);
            a1.Add(4.5);
            a1.Add(null);


            //Adding elements using Object Initializer
            var a2 = new ArrayList();
            {
                2, "Steve", true, 4.5, null
            }

            Console.WriteLine("ArrayList1");

            for (int i = 0; i < a1.Count; i++) 
            {
                Console.WriteLine(a1[i]);
            }

            Console.WriteLine("ArrayList2");

            for(int i = 0; i < a2.Count; i++)
            {
                Console.WriteLine(a2[i]);
            }
        }
    }
}