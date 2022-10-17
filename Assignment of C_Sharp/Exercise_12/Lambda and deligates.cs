using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_12
{
   class Program

    {
        public static bool GreaterThanFive(int x)
        {
            return x > 5;
        }

        public static bool LessThanFive(int x)
        {
            return x < 5;
        }
        public static bool AnythingMethod(int x)
        {
            return x != 0;
        }
        public static void Print(string input, IEnumerable<int> list)
        {
            Console.Write(input + " :   ");
            foreach (int num in list)
                Console.Write(num + "  ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Console.WriteLine("Enter the number of elements you want to enter: ");
            int number = int.Parse(Console.ReadLine());

            int list_element =0;
            Console.WriteLine("Enter the value of the element: ");
            for (int j = 0; j <number; j++)
            {             
                list_element = int.Parse(Console.ReadLine());
                list.Add(list_element);
            }



            IEnumerable<int> odd = list.Where(x => x % 2 == 1);
            Print("Odd Values are", odd);


            IEnumerable<int> even = list.Where(x => { return x % 2 == 0; });
            Print("Even Values are", even);
            IEnumerable<int> primenumber = list.Where(delegate (int x) {
                if (x <= 1)
                    return false;
                for (int i = 2; i <= x / 2; i++)
                    if (x % i == 0)
                        return false;
                return true;
            });

            //Prime Number:
            Print("Prime Number are", primenumber);
            IEnumerable<int> primeAnother = list.Where(x => {
                if (x <= 1)
                    return false;
                for (int i = 2; i <= x / 2; i++)
                    if (x % i == 0)
                        return false;
                return true;
            });


            //Another Number:
            Print("Primes Another are", primeAnother);
            Func<int, bool> MoreCondition = GreaterThanFive;
            IEnumerable<int> greaterThanFive = list.Where(MoreCondition);

            //Greater then five:
            Print("Greater Than Five Values are", greaterThanFive);
            Func<int, bool> LessCondition = new Func<int, bool>(LessThanFive);
            IEnumerable<int> lessThanFive = list.Where(LessCondition);

            //Less then five
            Print("Less Than Five Values are", lessThanFive);
            Func<int, bool> Condition3k = new Func<int, bool>(x => x % 3 == 0);
            IEnumerable<int> list3k = list.Where(Condition3k);

            //3k Values:
            Print("3k Values are", list3k);
            Func<int, bool> Condition3kplus1 = new Func<int, bool>(delegate (int x) {
                return x % 3 == 1;
            });

            // 3k+1 Values:
            IEnumerable<int> list3kplus1 = list.Where(Condition3kplus1);
            Print("3k + 1 Values are", list3kplus1);
            Func<int, bool> Condition3kplus2 = x => x % 3 == 2;
            IEnumerable<int> list3kplus2 = list.Where(Condition3kplus2);

            // 3k+2 Vaules:
            Print("3k + 2 Values are", list3kplus2);
            Func<int, bool> Anything = delegate (int x) {
                return x != 0;
            };

            //Printing Anything :
            IEnumerable<int> anything = list.Where(Anything);
            Print("Anything", anything);
            Func<int, bool> AnythingAnother = AnythingMethod;
            IEnumerable<int> anythingAnother = list.Where(AnythingAnother);
            Print("Anything", anythingAnother);
            Console.ReadLine();
        }
    }

}

