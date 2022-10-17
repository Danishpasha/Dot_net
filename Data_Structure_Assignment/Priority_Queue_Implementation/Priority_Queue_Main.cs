using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagarro.DataStructure.Assignment.PriortyQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            PriortyQueue<string> myQueue = new PriortyQueue<string>();

            Console.WriteLine("1.To create a Priorty Queue");
            
            Console.WriteLine("2.To Enqueue a element in a Queue");
            
            Console.WriteLine("3.To Dequeue a element from a Queue");
            
            Console.WriteLine("4.To Peek the  element from the Queue");
            
            Console.WriteLine("5.To Check if the Queue contains a particular element or not");
            
            Console.WriteLine("6.To get the size of the Queue");
            
            Console.WriteLine("7.To Reverse the Queue");

            Console.WriteLine("8.To Iterate the Queue");
            
            Console.WriteLine("9.To Traverse the Queue");
            
            Console.WriteLine("10.Center");
            
            Console.WriteLine("11.To Exit");
            
            Console.WriteLine("-----------------------------------------------------------------");
            while (true)
            {
                Console.WriteLine("Enter one of the choices(1-10) to perform related action:");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 11)
                {
                    break;
                }
                else
                {
                    int priorty;
                    string data;

                    switch (choice)
                    {
                        case 1:
                            int number;
                            Console.WriteLine("Enter the number of elements you want to enter in the Queue:");
                            number = int.Parse(Console.ReadLine());
                            for (int i = 0; i < number; i++)
                            {
                                Console.WriteLine("Enter the data of {0} element", i + 1);
                                data = Console.ReadLine();
                                Console.WriteLine("Enter the Priorty of {0} element", i + 1);
                                priorty = int.Parse(Console.ReadLine());
                                myQueue.Enqueue(priorty, data);
                            }
                            break;

                        case 2:
                            Console.WriteLine("Enter the data of the element you want to Enqueue: ");
                            data = Console.ReadLine();
                            Console.WriteLine("Enter the Priorty of the element: ");
                            priorty = int.Parse(Console.ReadLine());
                            myQueue.Enqueue(priorty, data);
                            break;

                        case 3:
                            myQueue.Dequeue();
                            myQueue.Traverse();
                            break;

                        case 4:
                            Console.WriteLine(myQueue.Peek());

                            break;

                        case 5:
                            Console.WriteLine("Enter the value you want to check:");
                            data = Console.ReadLine();
                            Console.WriteLine(myQueue.Contains(data));
                            break;

                        case 6:
                            Console.WriteLine(myQueue.Size());
                            break;

                        case 7:
                            myQueue.Reverse();
                            myQueue.Traverse();
                            break;

                        case 8:
                            foreach (var item in myQueue)
                            {
                                Console.Write("{0} ", item);
                            }
                            Console.WriteLine();
                            break;

                        case 9:
                            myQueue.Traverse();
                            break;
                        case 10:
                            myQueue.Center();
                            myQueue.Traverse();
                            break;

                        default:
                            Console.WriteLine("Please Enter a valid choice!");
                            break;
                    }
                }
            }
            Console.WriteLine("Thanks!!");
            Console.ReadLine();
        }
    }
}
