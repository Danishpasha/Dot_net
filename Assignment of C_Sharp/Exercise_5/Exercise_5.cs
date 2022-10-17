using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5

{
    public interface IDuck
    {
        void fly();
        void quack();


    }
    public class Duck : IDuck
    {
        protected int weight;
        protected int number_Of_Wings;
        public enum TypeOfDucks
        {
            Rubber = 1,
            Mallard = 2,
            Redhead = 3
        }

        public virtual void fly()
        {
        }


        public virtual void quack()
        {

        }

    }

    class Rubber : Duck
    {
        public Rubber(int w, int n)
        {
            weight = w;
            number_Of_Wings = n;
        }
        public override void fly()
        {
            Console.WriteLine("It doesn't fly.");
        }
        public override void quack()
        {
            Console.WriteLine("It doesn't quack, it squeaks.");
        }
        public void ShowDetails()
        {
            Console.WriteLine("\nRubber duck's weight is {0} kg.\nIt has {1} wings.", weight, number_Of_Wings);
            fly();
            quack();
        }
    }

    class Mallard : Duck
    {
        public Mallard(int w, int n)
        {
            weight = w;
            number_Of_Wings = n;
        }
        public override void fly()
        {
            Console.WriteLine("It fly fast.");

        }
        public override void quack()
        {
            Console.WriteLine("It quacks loud.");

        }
        public void ShowDetails()
        {
            Console.WriteLine("\nMallard duck's weight is {0} kg.\nIt has {1} wings.", weight, number_Of_Wings);
            fly();
            quack();
        }
    }

    class Redhead : Duck
    {
        public Redhead(int w, int n)
        {
            weight = w;
            number_Of_Wings = n;
        }

        public override void fly()
        {
            Console.WriteLine("It fly slow.");

        }
        public override void quack()
        {
            Console.WriteLine("It quacks mild.");

        }
        public void ShowDetails()
        {
            Console.WriteLine("\nRedhead duck's weight is {0} kg.\nIt has {1} wings.", weight, number_Of_Wings);
            fly();
            quack();

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for Rubber Duck\n2 for Mallard Duck \n3 for Readhead Duck.");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == (int)Duck.TypeOfDucks.Rubber)
            {
                Rubber obj = new Rubber(80, 2);
                obj.ShowDetails();
            }
            else if (input == (int)Duck.TypeOfDucks.Mallard)
            {
                Mallard obj = new Mallard(45, 4);
                obj.ShowDetails();
            }
            else if (input == (int)Duck.TypeOfDucks.Redhead)
            {
                Redhead obj = new Redhead(56, 2);
                obj.ShowDetails();
            }
            else
            {
                Console.WriteLine("\nInvalid Input");
            }
            Console.ReadLine();
            

        }
    }
}
