using System;

namespace stack_implementation
{
    class myStack
    {
        static readonly int MAX = 1000;
        int top;
        int[] arr = new int[MAX];

        public myStack()
        {
            top = -1;
        }
        bool IsEmpty()
        {
            return (top < 0);
        }

        // push implementation
        internal void Push(int data)
        {
            if (top >= MAX)
            {
                Console.WriteLine("Stack overFlow !!");
            }
            else
            {
                arr[++top] = data;
            }
        }

        // pop implementation
        internal void Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack UnderFlow !!");
            }
            else
            {
                int value = arr[top--];
                Console.WriteLine(value);
            }
        }

        // peek implementation
        internal void Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is Empty!!");
                return;

            }
            else
            {
                Console.WriteLine("Peek Element is: {0}", arr[top]);
            }
        }

        //traversing stack
        internal void Print()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty ");
                return;
            }
            else
            {
                Console.WriteLine("Items are: ");
                int i;
                for (i = top; i >= 0; i--)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine();
            }
        }

        // size implementation
        internal void Size()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty !! ");

            }
            else
            {
                Console.WriteLine("Size is: " + (top + 1));
            }
        }


        // contains implementation
        internal void Contains(int data)
        {
            int idx = 0;
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty !! ");
                return;
            }
            else
            {
                for (int i = top; i >= 0; i--)
                {
                    if (arr[i] != data)
                    {
                        ++idx;
                    }
                    else
                    {
                        Console.WriteLine("yes found at position : " + idx);
                        return;
                    }
                }
            }
            Console.WriteLine("not found");
        }

        //Sort
        internal void Sorting()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j =1; j < arr.Length-i; j++)
                {
                    if( arr[j-1] > arr[j])
                    {
                        int temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            for (int i = 0 ;i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    continue;
                }

                Console.Write(arr[i] + " ");
            }
            

        }
        internal void Center()
        {
            Console.WriteLine("The center element of stack is :" + arr[top/2]);
        }
        internal void Iterate()
        {
            Print();
        }

        //reverse implementation
        internal void Reverse()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            else
            {

                Console.WriteLine("Reverse Item: ");

                for (int i = 0; i <= top; i++)
                {
                    Console.Write(arr[i] + " ");
                }

                Console.WriteLine();
            }

        }
    }
}


