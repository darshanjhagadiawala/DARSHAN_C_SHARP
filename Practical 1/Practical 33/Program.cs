using System;

namespace Practical_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Access Array Elements using Indexes
            int[] array = new int[5];
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            array[3] = 4;
            array[4] = 5;

            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[2]);
            Console.WriteLine(array[3]);
            Console.WriteLine(array[4]);

            //Accessing Array Elements using for Loop
            int[] array1 = { 2, 4, 6, 8, 10 };

            for(int i = 0; i< array1.Length; i++)
                Console.WriteLine(array1[i]);

            for(int i = 0;i< array1.Length; i++)
                array1[i] = array1[i] + 5;

            Console.WriteLine("After increasing value by 5");

            for(int i = 0;i < array1.Length; i++)
                Console.WriteLine(array1[i]);

            //Accessing Array using foreach Loop
            int[] array3 = { 1, 2, 3, 4, 5 };
            string[] departments = {"Frontend", "Backend", "Database", "QA", "Cloud"};

            foreach(var developer in array3)
                Console.WriteLine(developer);

            foreach(var department in departments)
                Console.WriteLine(department);
        }
    }
}