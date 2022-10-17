using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 Strings:");
            string s1 = "practice";
            string s2 = "practice";
            string s3 = "practice".Substring(0, 4);
            object s4 = s3;
            Console.WriteLine("When we compare 2 strings with same reference and same contant");
            Console.WriteLine(object.ReferenceEquals(s1, s2));
            Console.WriteLine(object.Equals(s1, s2));
            Console.WriteLine(s1 == s2);

            Console.WriteLine("When we compare 2 strings with same reference and different contant");
            Console.WriteLine(object.ReferenceEquals(s1, s3));
            Console.WriteLine(object.Equals(s1, s3));
            Console.WriteLine(s1 == s3);

            Console.WriteLine("When we compare 2 strings with different reference and same contant");
            Console.WriteLine(object.ReferenceEquals(s1, s4));
            Console.WriteLine(object.Equals(s1, s4));
            Console.WriteLine(s1 == s2);
        }
    }
}
