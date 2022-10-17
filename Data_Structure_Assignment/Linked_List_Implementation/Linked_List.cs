using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_implementation
{
    class myLinkedList
    {
        class Node
        {
            internal object nodeData;
            internal Node next;

            internal Node(object data)
            {

                this.nodeData = data;
                next = null;
            }

            public Node Next { get; internal set; }
        }


        internal class List
        {
            Node head;
            Node curr;
            int size;
            private Node _head;

            public int count
            {
                get
                {
                    return size;
                }
            }

            public List()
            {
                head = null;
                size = 0;
            }

            //inserting element (by default insert at end)
            internal void Insert(object item)
            {
                size++;

                Node node = new Node(item);
                if (head == null)
                {
                    head = node;
                    return;
                        
                }
                else
                {
                    curr = head;
                    while (curr.next != null)
                    {
                        curr = curr.next;
                    }
                    curr.next = node;
                }


            }

            //inserting element at given position
            internal void InsertAtPosition(object item, int position)
            {
                size++;
                Node node = new Node(item);
                if (head == null)
                {
                    head = node;
                }
                if (position < 1 && position > size + 1)
                {
                    Console.WriteLine("invalid position");
                }
                else if (position == 1)
                {
                    node.next = head;
                    head = node;
                }
                else if (position == size)
                {
                    curr = head;
                    while (curr.next != null)
                    {
                        curr = curr.next;
                    }
                    curr.next = node;
                }
                else
                {
                    curr = head;
                    for (int i = 2; i < position && curr != null; i++)
                    {
                        curr = curr.next;
                    }
                    node.next = curr.next;
                    curr.next = node;
                }

            }

            //delete element (by default is at end)
            internal object Delete()
            {
                object val = 0;
                if (head == null)
                {
                    Console.WriteLine("No Element in LinkedList");
                }
                else
                {
                    curr = head;

                    while (curr.next.next != null)
                    {
                        curr = curr.next;
                    }
                    val = curr.next.nodeData;
                    curr.next = null;
                    size--;

                }
                return val;
            }

            //delete node at given position
            internal object deleteAtPosition(int position)
            {
                object val = 0;
                if (position > count)
                {
                    Console.WriteLine("Beyound size of linkedlist");

                }
                else
                {
                    if (position == 1)
                    {
                        head = head.next;
                    }
                    else if (position == size)
                    {
                        curr = head;
                        while (curr.next.next != null)
                        {
                            curr = curr.next;
                        }
                        val = curr.next.nodeData;
                        curr.next = null;

                    }
                    else
                    {
                        Node curr = head;
                        for (int i = 2; i < position && curr != null; i++)
                        {
                            curr = curr.next;
                        }
                        val = curr.next.nodeData;
                        curr.next = curr.next.next;
                    }
                    size--;
                }
                return val;
            }

            //center element
            internal void CenterElement()
            {
                Node fast = head;
                Node slow = head;
                if (head == null)
                {
                    Console.WriteLine("Linked list is empty");
                    return;
                }
                while (fast != null && fast.next != null)
                {
                    slow = slow.next;
                    fast = fast.next.next;
                }

                Console.WriteLine("Center element: " + slow.nodeData);
            }

            //reverse of linked list
            internal void ReverseList()
            {
                if (head == null)
                {
                    return;
                }

                Node prev = null, nextVal = null;
                curr = head;
                while (curr != null)
                {
                    nextVal = curr.next;
                    curr.next = prev;
                    prev = curr;
                    curr = nextVal;
                }

                while (prev != null)
                {
                    Console.Write(prev.nodeData + "->");
                    prev = prev.next;
                }
                Console.Write("null");


            }

            //return size or count of linkedlist
            internal void Size()
            {
                Console.WriteLine(count);

            }

            // Sorting the Array:-

            internal void SortList()
            {
                if (head == null)
                {
                    return;
                }

                Node prev = null, nextVal = null;
                curr = head;
                while (curr != null)
                {
                    nextVal = curr.next;
                    curr.next = prev;
                    prev = curr;
                    curr = nextVal;
                }

                while (prev != null)
                {
                    Console.Write(prev.nodeData + "->");
                    prev = prev.next;
                }
                Console.Write("null");


            }

        
            //traversing element

            internal void Print()
            {
                curr = head;
                if (head == null)
                {
                    Console.WriteLine("linkedList is empty !!");
                }

                while (curr != null)
                {
                    Console.Write(curr.nodeData + "->");
                    curr = curr.next;

                }
                Console.Write("null");
            }


        }
    }
}
