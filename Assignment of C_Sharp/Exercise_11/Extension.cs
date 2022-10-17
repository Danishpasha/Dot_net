using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_11
{
    class Extension
    {
        
        public static void OddNum(int number)
        {
            bool oddnum = number.IsOdd();
            Console.WriteLine("Odd Number - " + oddnum);
        }

        
        public static void EvenNum(int number)
        {
            bool evennum = number.IsEven();
            Console.WriteLine("Even Number - " + evennum);
        }

        
        public static void PrimeNum(int number)
        {
            bool primenum = number.IsPrime();
            Console.WriteLine("Prime Number - " + primenum);
        }

             public static void IsDivisibleBy(int number)
        {

            int divisible = int.Parse(Console.ReadLine());
            bool divisiblenum = number.IsDivisibleBy(divisible);
            Console.WriteLine("Is Divisible By " + divisible + " : " + divisiblenum);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a number :-  ");
            var number = int.Parse(Console.ReadLine());

            OddNum(number);

            EvenNum(number);

            PrimeNum(number);
            Console.Write("Enter a number to be divided :-  ");

            IsDivisibleBy(number);
        }
    }
}
