using System;
using System.Collections.Generic;
using System.Text;
using PriorityQueue;

namespace PriorityQueue
{
    class PriorityQueue<T> where T : IEquatable<T>
    {
        private IDictionary<int, IList<T>> Elements;
        public PriorityQueue()
        {
            Elements = new Dictionary<int, IList<T>>();
        }
        public PriorityQueue(IDictionary<int, IList<T>> e)
        {
            Elements = e;
        }
        public void Enqueue(int priority, T n)
        {
            if (Elements.ContainsKey(priority))
            {
                foreach (KeyValuePair<int, IList<T>> k in Elements)
                {
                    if (k.Key == priority)
                    {
                        k.Value.Add(n);
                    }

                }
            }
            else
            {
                IList<T> list = new List<T>();
                list.Add(n);
                Elements.Add(priority, list);
            }
        }
        public int Count()
        {
            int count = 0;
            foreach (KeyValuePair<int, IList<T>> k in Elements)
            {
                count += k.Value.Count;
            }
            return count;
        }
        public bool Contains(T item)
        {
            foreach (KeyValuePair<int, IList<T>> k in Elements)
            {
                if (k.Value.Contains(item))
                {
                    return true;
                }
            }
            return false;
        }
        public T Dequeue()
        {
            T item;
            int p = 0;
            IList<T> k = new List<T>();
            foreach (KeyValuePair<int, IList<T>> z in Elements)
            {
                k = z.Value;
                p = z.Key;
            }
            item = k[0];
            Elements.Remove(p);

            return item;
        }
        public T Peek()
        {
            int h = GetHighestPriority();
            return Elements[h][0];
        }
        public int GetHighestPriority()
        {
            int h = 0;
            foreach (KeyValuePair<int, IList<T>> z in Elements)
            {
                if (z.Key > h)
                {
                    h = z.Key;
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
        Console.WriteLine("This project depicts three ways of implementing priority queues:\n");
        Console.WriteLine("\nImplementing priority queue 1:");
        PriorityQueue<int> a = new PriorityQueue<int>();
        a.Enqueue(1, 10);
        a.Enqueue(2, 20);
        a.Enqueue(3, 30);
        a.Enqueue(4, 40);
        Console.WriteLine("\nNumber of elemets :" + a.Count());
        Console.WriteLine("Peek :" + a.Peek());
        Console.WriteLine("Contains 10? :" + a.Contains(10));
        Console.WriteLine("Removed element:" + a.Dequeue());
        Console.WriteLine("Peek again: " + a.Peek());
        Console.WriteLine("Number of elements :" + a.Count());

        Console.ReadLine();
    }
}