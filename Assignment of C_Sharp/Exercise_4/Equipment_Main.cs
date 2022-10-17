using System;


namespace Exercise4
{
    public class Equipment_Main
    {
        static void Main(string[] args)
        {

            var mobile_obj = new Mobile();
            var immobile_obj = new IMobile();
            Console.WriteLine("Select 1 to create Mobile Equipment");
            Console.WriteLine("Select 2 to create Immobile Equipment");
            Console.WriteLine("Select 3 to Exit:-");
            int select;
            do
            {
                string str = Console.ReadLine();
                select = Convert.ToInt32(str);
                switch (select)
                {
                    case 1:
                        mobile_obj.CreateEquipment();

                        Console.WriteLine("Enter Distance travelled : ");
                        string str_mobile = Console.ReadLine();
                        int dist_mobile = Convert.ToInt32(str_mobile);

                        mobile_obj.MoveBy(dist_mobile);
                        mobile_obj.ShowDetails();
                        break;

                    case 2:
                        immobile_obj.CreateEquipment();

                        Console.WriteLine("Enter Distance travelled : ");
                        string str_immobile = Console.ReadLine();
                        int dist_immobile = Convert.ToInt32(str_immobile);

                        immobile_obj.MoveBy(dist_immobile);
                        immobile_obj.ShowDetails();
                        break;

                    default:
                        Console.WriteLine("Thank you");
                        break;
                }
            } while (select!=3);
        }
    }
}
