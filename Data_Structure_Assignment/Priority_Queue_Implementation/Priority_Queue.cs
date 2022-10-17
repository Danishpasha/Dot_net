using System;
using System.Collections;
using System.Collections.Generic;

namespace Nagarro.DataStructure.Assignment.PriortyQueue
{
   

    class PriortyQueue<T> : IEnumerable<T>
    {
        public class Node
        {
            public int priorty;
            public T info;
            public Node link;
            

            public Node(int priorty, T info)
            {
                this.priorty = priorty;
                this.info = info;
            }

        }

        Node start;
        int count;

        public PriortyQueue()
        {
            start = null;
        }
        

        public void Enqueue(int priorty, T data)
        {
            Node temp = new Node(priorty, data);
            if (start == null || temp.priorty < start.priorty)
            {
                temp.link = start;
                start = temp;
            }

            else
            {
                Node pointer = start;
                while (pointer.link != null && temp.priorty >= pointer.link.priorty)
                {
                    pointer = pointer.link;
                }
                temp.link = pointer.link;
                pointer.link = temp;
            }
            count++;
        }
        

        public T Dequeue()
        {

            if (start == null)
            {
                int invalid = -1;
                
                return (T)Convert.ChangeType(invalid, typeof(T));
            }

            else
            {
                T dequeuedItem = start.info;
                start = start.link;
                count--;
                return dequeuedItem;
            }
        }
        

        public T Peek()
        {
            if (start == null)
            {
                int invalid = -1;

                return (T)Convert.ChangeType(invalid, typeof(T));
            }

            else
            {
                return start.info;
            }
        }
        

        public bool Contains(T data)
        {
            if (start == null)
            {
                
                return false;
            }

            else
            {
                Node pointer = start;
                while (pointer != null)
                {
                    if (data.Equals(pointer.info))
                    {
                        return true;
                    }
                    pointer = pointer.link;
                }

                return false;
            }
        }

       

        public int Size()
        {
            return count;
        }


        public void Center()
        {
            Node fast = start;
            Node slow = start;

            if (start == null)
            {
                Console.WriteLine(" invalid Input :");
                return;
            }
            else
            {
                while (fast!= null && fast.link != null)
                {
                    slow = slow.link;

                    fast = fast.link.link;
                }

                Console.WriteLine("Center element: " +slow.info);
            }
           
        }
        
        // Reverse

        public void Reverse()
        {
            
                if (start == null)
                {
                    return;
                }               
                    Node pointer = start;
                    Node next = null;
                    Node previous = null;
                    while (pointer != null)
                    {
                        next = pointer.link;
                        pointer.link = previous;
                        previous = pointer;
                        pointer = next;
                    }
                    start = previous;
                }
            
        
        //  Traverse

        public void Traverse()
        {
            if (start == null)
            {
                
            }

            else
            {
                Node pointer = start;
                while (pointer != null)
                {
                    Console.Write("[{0}:{1}] ", pointer.priorty, pointer.info);
                    pointer = pointer.link;
                }
                Console.WriteLine();
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node pointer = start;
            while (pointer != null)
            {
                yield return pointer.info;
                pointer = pointer.link;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
