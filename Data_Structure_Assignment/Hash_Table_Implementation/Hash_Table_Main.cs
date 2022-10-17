using System;

namespace hashmap_implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            myHashTable my_table = new myHashTable();

            Console.WriteLine("-----Hash Table Operations-----");
            Console.WriteLine("1. Insert ");
            Console.WriteLine("2. Delete ");
            Console.WriteLine("3. Contains");
            Console.WriteLine("4. Iterate");
            Console.WriteLine("5. Size");
            Console.WriteLine("6. Print ");
            Console.WriteLine("7. Get value by key");

            Console.WriteLine("0. Exit ");

            //here till the condition is true while loop will run
            while (true)
            {
                Console.WriteLine("\nChoose option :");
                int optionNumber = Convert.ToInt32(Console.ReadLine());
                if (optionNumber == 0)
                {
                    break;
                }
                //switch case used to choose which operation will be performed
                switch (optionNumber)
                {
                    case 1:
                        Console.WriteLine("The the number of key and value to be inserted :");
                        int insert = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < insert; i++)
                        {
                            Console.WriteLine("Enter key :");
                            int key = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter value :");
                            string val = Console.ReadLine();
                            my_table.Insert(key, val);
                        }
                        break;

                    case 2:
                        Console.WriteLine("Enter key :");
                        int key2 = Convert.ToInt32(Console.ReadLine());
                        my_table.Delete(key2);
                        break;

                    case 3:
                        Console.WriteLine("Enter key :");
                        int key3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter value :");
                        string val1 = Console.ReadLine();
                        my_table.contains(key3, val1);
                        break;

                    case 4:
                        my_table.Iterate();
                        break;

                    case 5:
                        int ans1 = my_table.Size1();
                        Console.WriteLine("size of this hashtable is :" + ans1);
                        break;

                    case 6:
                        my_table.print();
                        break;

                    case 7:
                        Console.WriteLine("Enter Key :");
                        int key4 = Convert.ToInt32(Console.ReadLine());
                        string ans = my_table.Get(key4);
                        Console.WriteLine("Value for this key is: " + ans);
                        break;

                    case 0:
                        Environment.Exit(0);
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}



