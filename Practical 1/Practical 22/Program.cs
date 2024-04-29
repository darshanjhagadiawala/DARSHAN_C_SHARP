//String Operations
using System;
using System.Text;

namespace Practical_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //There are two methods to declare the String.
            //1. Uses String Keyword
            //2. Uses System.String class

            string s1 = "DARSHAN";
            string s2 = "JHAGADIAWALA";

            Console.WriteLine(s1);
            Console.WriteLine(s2);

            //String as an Array
            char[] ch = { 'D', 'A', 'R', 'S', 'H', 'A', 'N' };
            string s3 = new string(ch);
            string s4 = new string(ch);

            //If we want to print all the characters in new line then we have to use foreach loop.
            foreach (char c in s3)
            {
                Console.WriteLine(c);
            }

            //Escape Character
            //If we ant to use any special character in between the string or if want to highlights with double quotation then we use Escape Character.
            string text = "This is a \"string\" in C#".ToLower();
            Console.WriteLine(text);

            //Verbatim Strings
            //Escape Sequence
            //If we want to include every special characters and line brakes then we use Verbatim Strings.
            //For create Verbatim Strings we have to write @ before double quotation.
            string email = @"darshanjhagadiawala58@gmail.com";
            Console.WriteLine(email);

            //Multi-line String
            string s5 = @"My name is
                            Darshan.";
            Console.WriteLine(s5);
            string s6 = @"This is ""Darshan"" from Vadodara.";
            Console.WriteLine(s6);

            //String Concatenation
            string s7 = "Thala" + " " + "for" + " " + "a" + " " + "Reason" + ", CSK: 7";
            string s8 = "M";
            string s9 = "S";
            string s10 = "DHONI";
            string s11 = "7";

            string Concate = s8 + " " + s9 + " " + s10 + " " + ", CSK: " + s11;

            Console.WriteLine(Concate);
            Console.WriteLine(s7);

            //String Interpolation
            //It is a better way to concatenating strings.
            string s12 = "MS";
            string s13 = "DHONI";
            string s14 = "7";

            string fullname = $"{s12} {s13} {s14}";
            Console.WriteLine(fullname);

            //String Builder
            //StringBuilder Iteration
            StringBuilder sb = new StringBuilder("Hi MS!!!");

            for (int a = 0; a < sb.Length; a++)
                Console.Write(sb[a]);

            //Retrieve String From StringBuilder
            StringBuilder sb2 = new StringBuilder("Hello C#!!!");

            var greet = sb2.ToString();

            Console.WriteLine(greet);

            //Add / Append String to String Builder
            StringBuilder sb1 = new StringBuilder("Hello", 50);

            sb1.Append("Darshan!!!");
            sb1.AppendLine("Hello MS!!!");
            sb1.AppendLine("Hello C#!!!");
            sb1.AppendLine("This is my Car.");

            Console.WriteLine(sb1);

            //Append Formated String to StringBuilder
            StringBuilder amt = new StringBuilder("Your total amount is ");
            amt.AppendFormat("{0:C}", 25);

            Console.WriteLine(amt);

            //Insert String into StringBuilder
            StringBuilder sb3 = new StringBuilder("Hello J!!!");
            sb3.Insert(5, " C#");

            Console.WriteLine(sb3);

            //Remove String in StringBuilder
            StringBuilder sb4 = new StringBuilder("Hello C# World", 50);
            sb4.Remove(6, 7);

            Console.WriteLine(sb4);

            //Replace String in StrnigBuilder
            StringBuilder sb5 = new StringBuilder("Hello C#");
            sb5.Replace("C#", "DARSHAN");

            Console.WriteLine(sb5);
            Console.Read();
        }
    }
}