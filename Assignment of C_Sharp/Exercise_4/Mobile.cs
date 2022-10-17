using System;

namespace Exercise4
{
    public class Mobile : Equipment
    {
        public int wheels;
        public override void MoveBy(int distance)
        {
            Console.WriteLine("Enter Wheels");
            string str = Console.ReadLine();
            wheels = Convert.ToInt32(str);

            distance_moved += distance;
            maintainence_cost += wheels * distance;
        }

        public void CreateEquipment()
        {
            Console.WriteLine("Enter Name : ");
            name = Console.ReadLine();

            Console.WriteLine("Enter Desc : ");
            desc = Console.ReadLine();
        }

        public void ShowDetails()
        {
            string details = string.Format("Name : {0}" +
                                           " Description : {1}" +
                                           " Distance Travelled : {2}" +
                                           " Maintainence Cost : {3}", name, desc, distance_moved, maintainence_cost);
            Console.WriteLine(details);
        }

    }
}
