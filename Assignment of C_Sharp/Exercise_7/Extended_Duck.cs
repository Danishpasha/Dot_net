using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckExtended
{
    class Ducks
    {
        public string Name;

        public int Feathers { get; set; }
        public float Weight { get; set; }
        public Ducks(string name, int feathers, float weight)
        {
            Name = name;
            Feathers = feathers;
            Weight = weight;
        }
        interface IInterface
        {
            void Fly();
            void Quack();
        }
        public virtual void PrintDetails()
        {
            Console.WriteLine("No Details, Please select the Correect option 1 , 2 or 3 \n-------------------------------------------------------------------");
        }
    }

    class RubberDucks : Ducks
    {
        public RubberDucks(string name, int feathers, float weight) : base(name, feathers, weight)
        {
            Feathers = feathers;
            Weight = weight;
        }
        new public int Feathers = 30;
        new public float Weight = 5.5f;
        public string flyy = "";
        public string quacks = "";

        public void Fly()
        {
            flyy = "The Rubber Duck Does'nt fly";
        }
        public void Quack()
        {
            quacks = "The Rubber Duck does'nt quack";
        }
        public override void PrintDetails()
        {
            Console.WriteLine("The number of feathers in Rubber Duck is {0}", Feathers);
            Console.WriteLine("The weight of Rubber Duck is {0}", Weight);
            Console.WriteLine(flyy);
            Console.WriteLine(quacks);
            Console.WriteLine("\n-------------------------------------------------------------------");
        }
    }

    class Mallard : Ducks
    {
        public Mallard(string name, int feathers, float weight) : base(name, feathers, weight)
        {

        }
        new public int Feathers = 10;
        new public float Weight = 10.5f;
        public string flyy = "";
        public string quacks = "";

        public void Fly()
        {
            flyy = "The Mallard Duck fly fast";
        }
        public void Quack()
        {
            quacks = "The Mallard Duck quack loud";
        }
        public override void PrintDetails()
        {
            Console.WriteLine("The number of feathers in Mallard Duck is {0}", Feathers);
            Console.WriteLine("The weight of Mallard Duck is {0}", Weight);
            Console.WriteLine(flyy);
            Console.WriteLine(quacks);
            Console.WriteLine("\n-------------------------------------------------------------------");
        }
    }

    class RedHead : Ducks
    {
        new public int Feathers;
        new public float Weight;
        public string flyy = "";
        public string quacks = "";
        public RedHead(string name, int feathers, float weight) : base(name, feathers, weight)
        {
            Feathers = feathers;
            Weight = weight;
        }

        public void Fly()
        {
            flyy = "The RedHead Duck fly slow";
        }
        public void Quack()
        {
            quacks = "The RedHead Duck quack mild";
        }
        public override void PrintDetails()
        {
            Console.WriteLine("The number of feathers in Redhead Duck is {0}", Feathers);
            Console.WriteLine("The weight of RedHead Duck is {0}", Weight);
            Console.WriteLine(flyy);
            Console.WriteLine(quacks);
            Console.WriteLine("\n-------------------------------------------------------------------");

        }
    }

    public class DuckLists
    {
        RedHead RedHeadDuck = new RedHead("redhead", 24, 25.5f);
        Mallard MallardDuck = new Mallard("mallard", 10, 10.5f);
        RubberDucks RubberDuck = new RubberDucks("rubberduck", 30, 5.5f);


        List<Ducks> Ducky = new List<Ducks>();
        public void AddDucky()
        {
            Console.WriteLine("Enter key for Duck name to be added: ");
            Console.WriteLine("1.RedHead Duck    2.Mallard Duck    3.Rubber Duck");
            string k = Console.ReadLine();
            if (k == "1")
            {
                Ducky.Add(RedHeadDuck);
                Console.WriteLine("Items successfully added to the list! \n");
            }
            else if (k == "2")
            {
                Ducky.Add(MallardDuck);
                Console.WriteLine("Items successfully added to the list! \n");
            }
            else if (k == "3")
            {
                Ducky.Add(RubberDuck);
                Console.WriteLine("Items successfully added to the list! \n");
            }
            else
            {
                Console.WriteLine("Invalid key");
            }

        }

        public void ListAllDucks()
        {
            Console.WriteLine("All ducks in list:");
            foreach (Ducks item in Ducky)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("\n");
        }
        public void OrderDucksByWeight()
        {
            var ordered = Ducky.OrderBy(x => x.Weight);
            Console.WriteLine("Ordered List (By weight):");
            foreach (var item in ordered)
            {
                Console.WriteLine(item.Name + " : " + item.Weight);

            }
            Console.WriteLine("\n");

        }
        public void OrderDuckByFeatherCount()
        {
            var ordered2 = Ducky.OrderBy(x => x.Feathers);
            Console.WriteLine("\nOrdered List (By no. of Feathers):");
            foreach (var item in ordered2)
            {
                Console.WriteLine(item.Name + " : " + item.Feathers);

            }
            Console.WriteLine("\n");
        }

        public void RemoveDuck()
        {
            Console.WriteLine("Enter name of the duck you want to remove:(redhead     Mallard    rubberduck) ");
            string userInput = Console.ReadLine();
            userInput = userInput.ToLower();
            Ducky.RemoveAll(x => x.Name == userInput);
            Console.WriteLine("\nDucks Left:");
            foreach (Ducks item in Ducky)
            {
                Console.WriteLine(item.Name);
            }
            Console.ReadKey();
        }
        public void RemoveAll()
        {
            Ducky.RemoveAll(x => x.Weight >= -1);
            Console.WriteLine("\n List is empty now ! All items removed");
        }


    }

    class Program
    {
        enum DuckType
        {
            RedHead = 1,
            Mallard = 2,
            RubberDucks = 3,
        }
        static void Main(string[] args)
        {
            List<Ducks> Ducky = new List<Ducks>();
            DuckLists ListOperations = new DuckLists();
            int ch = 0;
            do
            {
                Console.WriteLine("Press Key according to your choice (1-7): ");
                Console.WriteLine("1.Add a duck");
                Console.WriteLine("2.Remove a duck");
                Console.WriteLine("3.Remove all ducks");
                Console.WriteLine("4.List all Ducks:");
                Console.WriteLine("5.Iterate the duck collection in increasing order of their weights.");
                Console.WriteLine("6.Iterate the duck collection in increasing order of number of wings");
                Console.WriteLine("7.EXIT");
                ch = int.Parse(Console.ReadLine());

                if (ch == 1)
                {
                    ListOperations.AddDucky();
                }
                else if (ch == 2)
                {
                    ListOperations.RemoveDuck();
                }
                else if (ch == 3)
                {
                    ListOperations.RemoveAll();
                }
                else if (ch == 4)
                {
                    ListOperations.ListAllDucks();
                }
                else if (ch == 5)
                {
                    ListOperations.OrderDucksByWeight();
                }
                else if (ch == 6)
                {
                    ListOperations.OrderDuckByFeatherCount();
                }
                else if (ch == 7)
                {
                    ch = -1;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Key Entered");
                }
            } while (ch != -1);

        }
    }
}
