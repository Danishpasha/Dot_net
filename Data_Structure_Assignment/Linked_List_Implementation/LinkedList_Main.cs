using LinkedList_implementation;
using System;
using System.Linq;

namespace LinkedList_Implementation
{
    class Program
    {
        static void Main()
        {
            myLinkedList.List my_linked_list = new myLinkedList.List();

            Console.WriteLine("-----LinkedList Operations-----");
            Console.WriteLine("1. Insert");
            Console.WriteLine("2. Insert at position");
            Console.WriteLine("3. Delete");
            Console.WriteLine("4. Delete at position");
            Console.WriteLine("5. Centre");
            Console.WriteLine("6. Sort");
            Console.WriteLine("7. Reverse ");
            Console.WriteLine("8. Size ");
            Console.WriteLine("9. Print/Traverse ");

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
                        Console.WriteLine("Enter the number of value to be inserted:");
                        int insert = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < insert; i++)
                        {
                            Console.WriteLine("Enter value :");
                            int data = Convert.ToInt32(Console.ReadLine());
                            my_linked_list.Insert(data);
                            
                        }
                        break;
                    case 2:

                        Console.WriteLine("Enter value :");
                        int data1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter position :");
                        int ind = Convert.ToInt32(Console.ReadLine());
                        my_linked_list.InsertAtPosition(data1, ind);
                        
                        break;
                    case 3:

                        my_linked_list.Delete();
                        Console.WriteLine("deleted succesfully");

                        break;
                    case 4:

                        Console.WriteLine("Enter position to be deleted:");
                        int ind1 = Convert.ToInt32(Console.ReadLine());
                        my_linked_list.deleteAtPosition(ind1);
                        Console.WriteLine("deleted succesfully");

                        break;
                    case 5:

                        my_linked_list.CenterElement();
                        break;
                    case 6:

                        my_linked_list.SortList();
                        break;
                    case 7:

                        my_linked_list.ReverseList();
                        break;
                    case 8:

                        my_linked_list.Size();
                        break;
                    case 9:

                        my_linked_list.Print();
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
