using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    public enum EquipmentType { Mobile, ImMobile }

    public abstract class Equipment
    {
        public EquipmentType equipmentType { get; set; }
        public double distanceMoved { get; set; }
        public string description { get; set; }
        public string name { get; set; }
        public double MaintenanceCost { get; set; }

        virtual public double moveBy(double distanceToMove)
        {
            return distanceMoved += distanceToMove;
        }

    }

    public class Mobile : Equipment
    {
        public Mobile()
        {
            equipmentType = EquipmentType.Mobile;
        }

        public int NumberOfWheels { get; set; }
        public double TotalDistanceMoved { get; set; }

        override public double moveBy(double distanceToMove)
        {
            TotalDistanceMoved = base.moveBy(distanceToMove);
            return MaintenanceCost += (NumberOfWheels * distanceToMove);
        }

    }

    public class ImMobile : Equipment
    {
        public ImMobile()
        {
            equipmentType = EquipmentType.ImMobile;
        }

        public double Weight { get; set; }
        public double TotalDistanceMoved { get; set; }

        override public double moveBy(double distanceToMove)
        {
            TotalDistanceMoved = base.moveBy(distanceToMove);
            return MaintenanceCost += (Weight * distanceToMove);
        }
    }

    class Equipment_Owner_Company
    {
        static dynamic createMobileEquipment(string name, string description, int numberOfWheels, double distanceMoved)
        {
            var mobileEquipment = new Mobile();
            mobileEquipment.name = name;
            mobileEquipment.description = description;
            mobileEquipment.NumberOfWheels = numberOfWheels;
            mobileEquipment.MaintenanceCost = mobileEquipment.moveBy(distanceMoved);
            mobileEquipment.distanceMoved = mobileEquipment.TotalDistanceMoved;
            return mobileEquipment;
        }

        static dynamic createImMobileEquipment(string name, string description, double weight, double distanceMoved)
        {
            var ImmobileEquipment = new ImMobile();
            ImmobileEquipment.name = name;
            ImmobileEquipment.description = description;
            ImmobileEquipment.Weight = weight;
            ImmobileEquipment.MaintenanceCost = ImmobileEquipment.moveBy(distanceMoved);
            ImmobileEquipment.distanceMoved = ImmobileEquipment.TotalDistanceMoved;
            return ImmobileEquipment;
        }

        static void ListEquipments(IEnumerable<Equipment> _name)
        {
            foreach (var s in _name)
                Console.WriteLine("Name :" + s.name + ", Description : " + s.description + "\n");
        }

        static dynamic inputDetails(string equipmentType)
        {
            string name, description;
            double distanceMoved, ImMobileWeight;
            int numberOfWheels;

            Console.WriteLine("Enter name of the " + equipmentType + " Equipment");
            name = Console.ReadLine();
            Console.WriteLine("Enter description of the " + equipmentType + " Equipment");
            description = Console.ReadLine();
            Console.WriteLine("Enter the distance moved by the " + equipmentType + " Equipment");
            distanceMoved = Convert.ToDouble(Console.ReadLine());
            if (equipmentType.Equals("Mobile"))
            {
                Console.WriteLine("Enter number of wheels of the Mobile Equipment");
                numberOfWheels = Convert.ToInt32(Console.ReadLine());
                var mobileEquipment = createMobileEquipment(name, description, numberOfWheels, distanceMoved);
                return mobileEquipment;
            }
            else
            {
                Console.WriteLine("Enter the weight of the ImMobile Equipment");
                ImMobileWeight = Convert.ToDouble(Console.ReadLine());
                var ImmobileEquipment = createImMobileEquipment(name, description, ImMobileWeight, distanceMoved);
                return ImmobileEquipment;
            }
        }

        static void showDetails(IEnumerable<Equipment> _name)
        {
            Console.WriteLine("\nEnter name of the equipment to know details");

            string EquipmentDetailsEnquiry = Console.ReadLine();

            foreach (var i in _name)
                if (i.name.Equals(EquipmentDetailsEnquiry))
                    Console.WriteLine("\nName :" + i.name + "\n" +
                        "Description : " + i.description + "\n" +
                        "Distance Moved : " + i.distanceMoved + "\n" +
                        "Maintenance Cost : " + i.MaintenanceCost + "\n");
        }

        static void Main(string[] args)
        {
            var equipment = new List<Equipment>();


            Console.WriteLine("How many Equipment's information to be Inserted?");
            int numberOfEquipment = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= numberOfEquipment; i++)
            {
                Console.WriteLine("\nInput 1 to create Mobile Equipment and 2 to create ImMobile Equipment");
                int OptionChoosed = Convert.ToInt32(Console.ReadLine());

                if (OptionChoosed == 1)
                {
                    var mobileEquipment = inputDetails("Mobile");
                    equipment.Add(mobileEquipment);
                }
                else if (OptionChoosed == 2)
                {

                    var ImmobileEquipment = inputDetails("ImMobile");
                    equipment.Add(ImmobileEquipment);
                }
                else
                {
                    Console.WriteLine("Please input 1 or 2 only");
                }
            }
            char ch = ' ';
            do
            {
            loop:
                Console.WriteLine("\nInput 1 to List all Equipments \n" +
                        "2 to show details of an Equipment \n" +
                        "3 to List  all equipment that have not been moved till now \n" +
                        "4 to list all ImMobile Equipment \n" +
                        "5 to list all Mobile Equipment \n" +
                        "6 to Delete all ImMobile \n" +
                        "7 to Delete all Mobile \n" +
                        "8 to Delete all equipment \n" +
                        "9 to Delete an equipment\n");

                int OptionChoosed1 = Convert.ToInt32(Console.ReadLine());

                if (OptionChoosed1 == 1)
                {
                    ListEquipments(equipment);
                }
                else if (OptionChoosed1 == 2)
                {
                    showDetails(equipment);
                }
                else if (OptionChoosed1 == 3)
                {
                    var equipmentsNotMoved = equipment.Where(x => x.distanceMoved == 0).Select(x => x.name);
                    foreach (var i in equipmentsNotMoved)
                        Console.WriteLine(i);
                }
                else if (OptionChoosed1 == 4)
                {
                    foreach (var i in equipment.Where(x => x.equipmentType == EquipmentType.ImMobile).Select(x => x.name))
                        Console.WriteLine(i);
                }
                else if (OptionChoosed1 == 5)
                {
                    foreach (var i in equipment.Where(x => x.equipmentType == EquipmentType.Mobile).Select(x => x.name))
                        Console.WriteLine(i);
                }
                else if (OptionChoosed1 == 6)
                {
                    equipment.RemoveAll(x => x.equipmentType == EquipmentType.ImMobile);
                    foreach (var i in equipment)
                        Console.WriteLine(i.name);
                }
                else if (OptionChoosed1 == 7)
                {
                    equipment.RemoveAll(x => x.equipmentType == EquipmentType.Mobile);
                    foreach (var i in equipment)
                        Console.WriteLine(i.name);
                }
                else if (OptionChoosed1 == 8)
                {
                    equipment.RemoveAll(x => true);
                    foreach (var i in equipment)
                        Console.WriteLine(i.name);
                }
                else if (OptionChoosed1 == 9)
                {
                    Console.WriteLine("\nEnter the name of the Equipment to be deleted");
                    string toBeDeleted = Console.ReadLine();
                    equipment.RemoveAll(x => x.name.Equals(toBeDeleted));
                    foreach (var i in equipment)
                        Console.WriteLine(i.name);
                }
                else
                {
                    Console.WriteLine("Incorrect Input, Press valid input");
                    goto loop;
                }
                Console.WriteLine("Do you want to do more?");
                Console.WriteLine("Press 'y' for YES and 'n' for NO : ");
                string s5 = Console.ReadLine();
                ch = Convert.ToChar(s5);
            } while (ch == 'y');

            Console.WriteLine("Exit");
            Console.ReadKey();

        }
    }
}

