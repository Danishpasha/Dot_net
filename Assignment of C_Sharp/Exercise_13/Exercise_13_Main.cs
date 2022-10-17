using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodSecond
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number of elements you want to enter: ");
            int number = int.Parse(Console.ReadLine());
            int[] numbers = new int[number];
            
           
            

            int numbers_element = 0;
            Console.WriteLine("Enter the value of the element: ");
            for (int j = 0; j < number; j++)
            {
                numbers_element = int.Parse(Console.ReadLine());
                numbers[j] = numbers_element;
            }



            var customAll = numbers.CustomAll(i => i % 2 == 0);
            Console.WriteLine("CustomAll = " + customAll);

           
            var customMin = numbers.CustomMin<int>();
            Console.WriteLine("MIN No.= " + customMin);

           
            var customMax = numbers.CustomMax<int>();
            Console.WriteLine("MAX No.= " + customMax);

           
            var customWhere = numbers.CustomWhere(i => i % 2 == 0);
            foreach(var custom_list in customWhere)

            Console.WriteLine("CustomWhere = " + custom_list);

           
            var customAny = numbers.CustomAny(i => i % 2 == 0);
            Console.WriteLine("CustomAny = " + customAny);

            var customSelect = numbers.CustomSelect(j => j * 0.5);
            foreach (var cs in customSelect)
            {
                Console.WriteLine("CustomSelect : " + cs);
            }

            Console.Read();
            

        }
    }
}
