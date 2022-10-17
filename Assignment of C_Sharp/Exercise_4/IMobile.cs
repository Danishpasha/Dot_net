using System;

namespace Exercise4
{
    public class IMobile : Equipment
    {
        public int weight;
        public override void MoveBy(int distance)
        {
            Console.WriteLine("Enter Weight");
            string str = Console.ReadLine();
            weight = Convert.ToInt32(str);

            distance_moved += distance;
            maintainence_cost += weight * distance;
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
