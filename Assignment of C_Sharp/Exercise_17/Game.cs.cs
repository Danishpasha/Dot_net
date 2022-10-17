using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_17
{
    class CustomException : Exception
    {
        public CustomException(string message) : base(string.Format(message))
        {

        }
    }
    class Game
    {
        static void Main(string[] args)
        {
            int count = -1;
            try
            {
                Console.WriteLine("Enter a number between 1-5 ");
                int number = int.Parse(Console.ReadLine());

                switch (number)
                {
                    case 1:
                        Console.WriteLine("Enter Even Number");
                        int even = int.Parse(Console.ReadLine());

                        if (ValidateEven(even))
                        {
                            Console.WriteLine("Success !!");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Enter Odd Number");
                        int odd = int.Parse(Console.ReadLine());

                        if (Validateodd(odd))
                        {
                            Console.WriteLine("Success !!");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Enter a prime number");
                        int prime = int.Parse(Console.ReadLine());
                        Validateprime(prime);
                        break;



                    case 4:
                        Console.WriteLine("Enter a negative number");
                        int nagative = int.Parse(Console.ReadLine());

                        if (Validatenegative(nagative))
                        {
                            Console.WriteLine("Success !!");
                        }
                        break;



                    case 5:
                        Console.WriteLine("Enter Zero");
                        int zero = int.Parse(Console.ReadLine());

                        if (Validatezero(zero))
                        {
                            Console.WriteLine("Success !!");
                        }
                        break;



                    default:
                        Console.WriteLine("Enter Correct Number !!");
                        break;
                }
            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex);
            }
            Console.ReadLine();
        }
        private static bool ValidateEven(int evennumber)
        {
            return (evennumber % 2 == 0) ? true : throw new CustomException("Wrong Input !!");
        }

        private static bool Validateodd(int oddnumber)
        {
            return (oddnumber % 2 != 0) ? true : throw new CustomException("Wrong Input !!");
        }

        private static void Validateprime(int primenumber)
        {
            for (int i = 2; i < primenumber; i++)
            {
                Console.WriteLine((primenumber % i != 0) ? "Success" : throw new CustomException("Wrong Input !!"));
                break;
            }
            
        }

        private static bool Validatenegative(int negativenumber)
        {
            return (negativenumber < 0) ? true : throw new CustomException("Wrong Input !!");
        }

        private static bool Validatezero(int zeronumber)
        {
            return (zeronumber == 0) ? true : throw new CustomException("Wrong Input !!");
        }

    }

}