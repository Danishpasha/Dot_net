using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            myStack st = new myStack();

            Console.WriteLine("-----Stack Operations-----");
            Console.WriteLine("1. Push ");
            Console.WriteLine("2. Pop");
            Console.WriteLine("3. Peek");
            Console.WriteLine("4. Contains");
            Console.WriteLine("5. Center");
            Console.WriteLine("6. Reverse ");
            Console.WriteLine("7. Print/Traverse ");
            Console.WriteLine("8. Size ");
            Console.WriteLine("9. Iterate ");
            Console.WriteLine("10.Sorting ");
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
                        Console.WriteLine("Enter the number of value you want to insert:");
                        int insert = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < insert; i++)
                        {
                            Console.WriteLine("Enter value :");
                            int data = Convert.ToInt32(Console.ReadLine());
                            st.Push(data);
                            Console.WriteLine("pushed succesfully");
                        }
                        break;
                    case 2:
                        st.Pop();
                        Console.WriteLine("popped succesfully");
                        break;
                    case 3:
                        st.Peek();
                        break;
                    case 4:
                        Console.WriteLine("Enter data to be searched :");
                        int data1 = Convert.ToInt32(Console.ReadLine());
                        st.Contains(data1);
                        break;
                    case 5:
                        st.Center();
                        break;
                    case 6:
                        st.Reverse();
                        break;
                    case 7:
                        st.Print();
                        break;

                    case 8:
                        st.Size();
                        break;
                    case 9:
                        st.Iterate();
                        break;
                    case 10:
                        st.Sorting();
                        break;

                    
                    case 0:
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
