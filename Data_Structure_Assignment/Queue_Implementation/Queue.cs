using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_implmentation
{
    internal class myQueue
    {
        static int front, rear, capacity;
        static int[] arr;

        public myQueue(int cap)
        {
            front = rear = 0;
            capacity = cap;
            arr = new int[capacity];
        }

        //inserting into queue
        internal void Enqueue(int data)
        {
            if (capacity == rear)
            {
                Console.WriteLine("Queue is full");
                return;
            }
            else
            {
                arr[rear] = data;
                rear++;
            }
            return;
        }

        //removing from queue
        internal void Dequeue()
        {
            if (front == rear)
            {
                Console.WriteLine("Queue is empty !!");
                return;
            }
            else
            {
                int val = arr[0];
                for (int i = 0; i < rear - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                if (rear < capacity)
                    arr[rear] = 0;

                rear--;
                Console.WriteLine("dequeued value is: " + val);
                return;
            }

        }

        //printing queue elements
        internal void Print()
        {
            //check for empty
            if (front == rear)
            {
                Console.WriteLine("Queue is Empty");

            }
            else
            {
                Console.WriteLine("Queue items: ");
                for (int i = front; i < rear; i++)
                {
                    Console.Write(arr[i] + " ");
                }

                Console.WriteLine();
            }
        }

        //reverse queue
        internal void ReverseQueue()
        {
            //check for empty
            if (front == rear)
            {
                Console.WriteLine("Queue is Empty");

            }
            else
            {
                Console.WriteLine("Reverse queue: ");
                for (int i = rear - 1; i >= front; i--)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine();
            }
        }

        //size of queue
        internal void Size()
        {
            Console.WriteLine("Size: {0}", rear);
        }

        internal void Iterator()
        {
            Print();
        }

        //queue front
        internal void Peek()
        {
            if (front == rear)
            {
                Console.WriteLine("Queue is Empty");

            }
            else
            {
                Console.WriteLine("front element: {0}", arr[front]);
            }
        }

        internal void Center()
        {
            if (front == rear)
            {
                Console.WriteLine("Queue is Empty !!");
            }
            else
            {
                Console.WriteLine("Center queue: ");
                Console.WriteLine(arr[rear/2]);
                Console.WriteLine();
            }
        }
        //Sorting :

        internal void Sorting()
        {
            if (front == rear)
            {
                Console.WriteLine("Queue is Empty !!");
            }
            else
            {
                Console.WriteLine("Sorted  queue: ");
                for (int i = 0; i <arr.Length; i++)
                {
                    for(int j = 1; j < arr.Length-i; j++)
                    {
                        if(arr[j-1] > arr[j])
                        {
                            int temp = arr[j - 1];
                            arr[j - 1] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }
                for(int i = 0; i < arr.Length; i++)
                {
                    if ( arr[i] == 0)
                    {
                        continue;
                    }
                    Console.Write(arr[i] + " ");
                }
            }
        }

        //contains
        internal void Contains(int data)
        {
            if (front == rear)
            {
                Console.WriteLine("Queue is Empty !!");
                return;
            }
            else
            {
                for (int i = front; i < rear; i++)
                {
                    if (arr[i] == data)
                    {
                        Console.WriteLine("yes found at position: " + i);
                        return;
                    }
                }
                Console.WriteLine("not found");
            }
        }
    }
}

