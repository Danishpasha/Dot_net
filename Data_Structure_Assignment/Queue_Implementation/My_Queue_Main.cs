using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_implmentation
{
    class Program
    {
        static void Main(string[] args)
        {
            myQueue myQueue = new myQueue(1000);
            myQueue q = myQueue;

            Console.WriteLine("-----Queue Operations-----");
            Console.WriteLine("1. Enqueue");
            Console.WriteLine("2. Dequeue");
            Console.WriteLine("3. Peek");
            Console.WriteLine("4. Contains");
            Console.WriteLine("5. Size");
            Console.WriteLine("6. Reverse ");
            Console.WriteLine("7. Print/Traverse ");
            Console.WriteLine("8. Center");
            Console.WriteLine("9. Sorting:");
            Console.WriteLine("10.Iterator");


            Console.WriteLine("0. Exit ");

            //here till the condition is true while loop will run
            while (true)
            {
                Console.WriteLine("\nChoose option :");
                int optionNumber = Convert.ToInt32(Console.ReadLine());
                if (optionNumber == 0) break;

                //switch case used to choose which operation will be performed
                switch (optionNumber)
                {
                    case 1:
                        Console.WriteLine("Enter the number of element you want to insert:");
                        int insert = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < insert; i++)
                        {
                            Console.WriteLine("Enter value :");
                            int data = Convert.ToInt32(Console.ReadLine());
                            q.Enqueue(data);
                            Console.WriteLine("Enqueued succesfully");
                        }
                        break;
                    case 2:
                        q.Dequeue();
                        break;
                    case 3:
                        q.Peek();
                        break;
                    case 4:
                        Console.WriteLine("Enter data to be searched :");
                        int data1 = Convert.ToInt32(Console.ReadLine());
                        q.Contains(data1);
                        break;
                    case 5:
                        q.Size();
                        break;
                    case 6:
                        q.ReverseQueue();
                        break;
                    case 7:
                        q.Print();
                        break;
                    case 8:
                        q.Center();
                        break;
                    case 9:
                        q.Sorting();
                        break;
                    case 10:
                        q.Iterator();
                        break;


                    case 0:
                        Console.WriteLine("finished");
                        Environment.Exit(1);
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
