using System;

namespace Practice1
{
    enum departments //Enum Declaration
    {
        Data_Analytics,
        Data_Science,
        Data_Engineering,
        Frontend,
        Backend,
        DataBase = 25,
        Cloud,
        DevOps,
        Android,
        QA,
    }
    internal class Program
    {
        class T
        {
            private string[] names = new string[10];
            public string this[int z] //Indexers
            {
                get
                {
                    return names[z];
                }
                set
                {
                    names[z] = value;
                }
            }
        }
        class A  //Simple Inheritance
        { 
            public A()
            {
                Console.WriteLine("Hello! I'm Simple inheritance.");
            }
        }
        class B : A //Multilevel Inheritance
        {
            public B()
            {
                Console.WriteLine("Hello! I'm Multilevel Inheritance.");
            }
        }
        public class parent
        {
            string parentString;
            public parent()
            {
                Console.WriteLine("Parent Constructor.");
            }
            public parent(string myString)
            {
                parentString = myString;
                Console.WriteLine(parentString);
            }
            public void print()
            {
                Console.WriteLine("I'm a Parent Class.");
            }
        }

        public class child: parent
        {
            public child() : base("From Derived.") 
            {
                Console.WriteLine("Child Constructor.");
            }
            public new void print()
            {
                Console.WriteLine("I'm a Child Class.");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("DATATYPES"); // DataTypes
            int i = 25;
            float f = 2.5f;
            char c = 'D';
            string s = "DB W M TN";
            double d = 25.25D;

            Console.WriteLine(i);
            Console.WriteLine(f);
            Console.WriteLine(c);
            Console.WriteLine(s);
            Console.WriteLine(d);

            Console.WriteLine(departments.DataBase); //Enum to Int
            int dept = (int)departments.DevOps;
            Console.WriteLine(dept);

            var Dept = (departments)26; //Int to Enum
            Console.WriteLine(Dept);

            Nullable<int> x; //Nullable

            int? s1 = null;
            int b = s1 ?? 25;
            int k = s1.GetValueOrDefault(); //Nullable using GetValueOrDefault

            int? m = 36;
            int p = 37;

            if(Nullable.Compare<int>(m, p) < 0) //Nullable with .Compare Method
            {
                Console.WriteLine("Less");
            }
            else if(Nullable.Compare<int>(m, p) > 0)
            {
                Console.WriteLine("More");
            }
            else
            {
                Console.WriteLine("Equals");
            }

            Console.WriteLine(b);
            Console.WriteLine(k);
            Console.Read();

            T Team = new T(); //Indexers
            Team[0] = "DARSHAN";
            Team[1] = "PAVAN";
            Team[2] = "BHOOMI";
            Team[3] = "HITIXA";
            Team[4] = "HARSHIL";
            Team[5] = "MANAV";
            for(int z = 0; z < 6; z++)
            {
                Console.WriteLine(Team[z]);
            }

            B h = new B(); //Object of Inheritance
            child c1 = new child();
            c1.print();
            ((parent)c1).print();
        }
    }
}