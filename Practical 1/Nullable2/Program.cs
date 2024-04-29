using System;

namespace Nullable2
{
    internal class Program
    {
        class A
        {
            private string[] names = new string[10];
            public string this[int k]
            {
                get
                {
                    return names[k];
                }
                set
                {
                    names[k] = value;
                }
            }
        }

        class B
        {
            private string[] departments = new string[10];
            public string this[int p] 
            {
                get 
                {
                    return departments[p]; 
                }
                set
                {   
                    departments[p] = value;
                }
            }
        }
        static void Main(string[] args)
        {
            Nullable<int> x;
            int ? s1 = null;
            int d = s1 ?? 45;
            int f = s1.GetValueOrDefault();

            int? i = 5;
            int j = 10;

            if (Nullable.Compare<int>(i, j) < 0) 
            {
                Console.WriteLine("Less");
            }
            else if (Nullable.Compare<int>(i,j) > 0) 
            {
                Console.WriteLine("More");
            }
            else
            {
                Console.WriteLine("Equal");
            }

            A Team  = new A();
            Team[0] = "DARSHAN";
            Team[1] = "PAVAN";
            Team[2] = "HARSHIL";
            Team[3] = "MANAV";
            Team[4] = "MIHIR";
            Team[5] = "MEET";
            for(int k = 0; k < 6; k++)
            {
                Console.WriteLine(Team[k]);
            }
            
            B dept = new B();
            dept[0] = "FRONTEND";
            dept[1] = "BACKEND";
            dept[2] = "QA";
            dept[3] = "CLOUD";
            dept[4] = "DATABASE";
            for(int p = 0; p < 10; p++)
            {
                Console.WriteLine(dept[p]);
            }

            Console.WriteLine(d);
            Console.WriteLine(f);
            Console.Read();
        }
    }
}