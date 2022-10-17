using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace hashmap_implementation
{
    class myHashTable
    {
        class Node
        {
            int key;
            string data;
            Node next;
            public Node(int key, string data)
            {
                this.key = key;
                this.data = data;
                next = null;
            }
            public int Getkey()
            {
                return key;
            }
            public string Getdata()
            {
                return data;
            }
            public void SetNextNode(Node obj)
            {
                next = obj;
            }
            public Node GetNextNode()
            {
                return this.next;
            }
        }

        Node[] table;
        const int size = 10;
        private const string Value = "The Iteration is :";
        int size_var = 0;

        //made a table of node and intialised it to null
        public myHashTable()
        {
            table = new Node[size];
            for (int i = 0; i < size; i++)
            {
                table[i] = null;
            }
        }

        // Insert
        public void Insert(int key, string data)
        {
            Node nObj = new Node(key, data);
            int hash = key % size;
            while (table[hash] != null && table[hash].Getkey() % size != key % size)
            {
                hash = (hash + 1) % size;
            }
            if (table[hash] != null && hash == table[hash].Getkey() % size)
            {
                nObj.SetNextNode(table[hash].GetNextNode());
                table[hash].SetNextNode(nObj);
                return;
            }
            else
            {
                table[hash] = nObj;
                Console.WriteLine("Entry added succesfully");
                size_var++;
                return;
            }

        }

        // Get Value
        public string Get(int key)
        {
            int hash = key % size;
            while (table[hash] != null && table[hash].Getkey() % size != key % size)
            {
                hash = (hash + 1) % size;
            }
            Node current = table[hash];
            while (current.Getkey() != key && current.GetNextNode() != null)
            {
                current = current.GetNextNode();
            }
            if (current.Getkey() == key)
            {
                return current.Getdata();
            }
            else
            {
                return "Nothing found!";
            }
        }

        // Delete
        public void Delete(int key)
        {
            int hash = key % size;
            while (table[hash] != null && table[hash].Getkey() % size != key % size)
            {
                hash = (hash + 1) % size;
            }
            //a current node pointer used for traversal, currently points to the head
            Node current = table[hash];
            bool isRemoved = false;
            while (current != null)
            {
                if (current.Getkey() == key)
                {
                    table[hash] = current.GetNextNode();
                    Console.WriteLine("Entry removed successfully!");
                    size_var--;
                    isRemoved = true;
                    break;
                }

                if (current.GetNextNode() != null)
                {
                    if (current.GetNextNode().Getkey() == key)
                    {
                        Node newNext = current.GetNextNode().GetNextNode();
                        current.SetNextNode(newNext);
                        Console.WriteLine("Entry removed successfully!");
                        size_var--;
                        isRemoved = true;
                        break;
                    }
                    else
                    {
                        current = current.GetNextNode();
                    }
                }

            }

            if (!isRemoved)
            {
                Console.WriteLine("Nothing found to delete!");
                return;
            }
        }

        //Print /Traverse.
        public void print()
        {
            if (size_var == 0)
            {
                Console.WriteLine("Hashtable is empty. Insert elements first!!");
            }
            Node current = null;
            for (int i = 0; i < size; i++)
            {
                current = table[i];

                while (current != null)
                {
                    Console.Write(current.Getkey() + ":" + current.Getdata() + " , ");
                    current = current.GetNextNode();
                }
            }


            
        }//contains 

        public void contains(int key, string val)
        {
            Node current = null;
            for (int i = 0; i < size; i++)
            {
                current = table[i];
                while (current != null)
                {
                    if (current.Getdata() == val && current.Getkey() == key)
                    {
                        Console.WriteLine("Yes, hashtable contains this key-value pair");
                        return;
                    }
                    current = current.GetNextNode();
                }
            }
            Console.Write("No, hashtable doesnot contains this key-value pair");
            Console.WriteLine();

        }
        //Iterate

        public void Iterate()
        {
            for (int i =0; i <size; i++)
            {
               
               
            }
            Console.WriteLine("The iterated value is : ");
            print();
             }

        // Size 
        public int Size1()
        {
            return size_var;
        }
    }
}


