using PriorityQueues;
using System;
using System.Collections.Generic;
using System.Text;

namespace PriorityQueues
{
    class PriorityQueue3<T> where T : IEquatable<T>
    {
        private class PriorityNode
        {
            public int priority { get; private set; }
            public T data { get; private set; }
            public PriorityNode(int p, T d)
            {
                priority = p;
                data = d;
            }
        }
        private IList<PriorityNode> Elements;
        public PriorityQueue3()
        {
            Elements = new List<PriorityNode>();
        }

        public PriorityQueue3(IDictionary<int, IList<T>> ele)
        {
            foreach (KeyValuePair<int, IList<T>> i in ele)
            {
                foreach (T d in i.Value)
                {
                    PriorityNode p = new PriorityNode(i.Key, d);
                    Elements.Add(p);

                }
            }
        }
        public int Count()
        {
            return Elements.Count;
        }
        public bool Contains(T item)
        {
            foreach (PriorityNode p in Elements)
            {
                if (p.data.Equals(item))
                {
                    return true;
                }
            }
            return false;
        }
        public T Dequeue()
        {
            PriorityNode last = null;
            foreach (PriorityNode p in Elements)
            {
                last = p;
            }
            Elements.Remove(last);
            return last.data;
        }
        public void Enqueue(int prio, T item)
        {
            PriorityNode x = new PriorityNode(prio, item);
            Elements.Add(x);
        }
        public T Peek()
        {
            int h = GethighestPriority();
            T d;
            foreach (PriorityNode p in Elements)
            {
                if (p.priority.Equals(h))
                {
                    d = p.data;
                }
            }
            return default(T);
        }
        private int GethighestPriority()
        {
            int h = 0;
            foreach (PriorityNode p in Elements)
            {
                if (p.priority > h)
                {
                    h = p.priority;
                }
            }
            return h;
        }

    }
}

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("\nImplementing priority queue 3:");

        PriorityQueue3<int> c = new PriorityQueue3<int>();
        c.Enqueue(1, 10);
        c.Enqueue(2, 20);
        c.Enqueue(3, 30);
        c.Enqueue(4, 40);
        Console.WriteLine("\nNumber of elemets :" + c.Count());
        Console.WriteLine("Peek :" + c.Peek());
        Console.WriteLine("Contains 10? :" + c.Contains(10));
        Console.WriteLine("Removed element:" + c.Dequeue());
        Console.WriteLine("Peek again: " + c.Peek());
        Console.WriteLine("Number of elements :" + c.Count());

        Console.ReadLine();
    }
       
}
