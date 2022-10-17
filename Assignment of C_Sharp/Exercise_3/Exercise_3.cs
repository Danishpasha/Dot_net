using System;

namespace Exercise_3
{
    class Program
    {
        
        /// Method to Print Prime Numbers within a given range.
        /// </summary>
        /// "range1"
        /// "range2"
        /// "flag"
        public static void Prime(int lower_range, int upper_range, int flag)
        {
            for (int i = lower_range; i <= upper_range; i++)
            {
                flag = 1;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                    }
                }
                if (flag != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void Main(string[] args)
        {
        again:

            int flag = 0;
            Console.WriteLine("Enter First Number: ");
            int start = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Number: ");
            int end = int.Parse(Console.ReadLine());

            if (start > end)
            {
                Console.WriteLine("Please enter the number again , First number cannot be higher then second number\n");
                goto again;
            }
            else
            {
                Prime(start, end, flag);
            }
        }
    }
}
