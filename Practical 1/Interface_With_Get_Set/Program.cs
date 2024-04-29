using System;

namespace Interface_With_Get_Set
{
    interface Product //Interface
    {
        string Name 
        { 
            get;
            set;
        }
    }
    class Amazon : Product //Class of the Interface
    {
        private string name //Private String With Get Set
        {
            get;
            set;
        }
        public string Name //Public String With Get Set and Return Value
        { 
            get 
            { 
                return name; 
            }
            set 
            {
                name = value;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
                var Product = new Amazon();
                Product.Name = "Nike Slides";

                Console.WriteLine(Product.Name);
                Console.ReadKey();
        }
    }
}