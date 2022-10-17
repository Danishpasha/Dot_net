using PriorityQueue;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace PriorityQueue
{
    interface IPriority
    {
        int priority
        {
            get;
            set;
        }
    }

    class Student : IEquatable<Student>, IPriority
    {
        public int priority { get; set; }
        public String name { get; set; }
        public override string ToString()
        {
            return name;
        }
        public bool Equals([AllowNull] Student otherName)
        {
            if (name == otherName.name)
            {
                return true;
            }
            return false;
        }
    }



    class PriorityQueue2<T> where T : IEquatable<T>, IPriority
    {
        private IDictionary<int, IList<T>> Elements;
        public PriorityQueue2()
        {

            Elements = new Dictionary<int, IList<T>>();
        }
        public PriorityQueue2(IDictionary<int, IList<T>> e)
        {
            Elements = e;
        }
        public void Enqueue(T item)
        {

            if (Elements.ContainsKey(item.priority))
            {
                foreach (KeyValuePair<int, IList<T>> k in Elements)
                {
                    if (k.Key == item.priority)
                    {
                        k.Value.Add(item);
                    }

                }
            }
            else
            {
                IList<T> list = new List<T>();
                list.Add(item);
                Elements.Add(item.priority, list);
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
        Console.WriteLine("\nImplementing priority queue 2:");
        Student s1 = new Student();
        s1.priority = 1;
        s1.name = "S1";
        Student s2 = new Student();
        s2.priority = 2;
        s2.name = "S2";

        Student s3 = new Student();
        s3.priority = 3;
        s3.name = "S3";
        Student s4 = new Student();
        s4.priority = 4;
        s4.name = "S4";

        PriorityQueue2<Student> b = new PriorityQueue2<Student>();
        b.Enqueue(s1);
        b.Enqueue(s2);
        b.Enqueue(s3);
        b.Enqueue(s4);
        Console.WriteLine("\nNumber of elemets :" + b.Count());
        Console.WriteLine("Peek :" + b.Peek());
        Console.WriteLine("Contains student named 'S2'? :" + b.Contains(new Student { name = "S2" }));
        Console.WriteLine("Removed element:" + b.Dequeue());
        Console.WriteLine("Peek again: " + b.Peek());
        Console.WriteLine("Number of elements :" + b.Count());

        Console.ReadLine();
    }
}

