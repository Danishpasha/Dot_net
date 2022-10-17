using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            String convert_to_int1, convert_to_int2, convert_to_int3;
            convert_to_int1 = Console.ReadLine();
            convert_to_int2 = Console.ReadLine();
            convert_to_int3 = Console.ReadLine();

            ConvertToInt(convert_to_int1);
            ConvertToFloat(convert_to_int2);
            ConvertToBoolean(convert_to_int3);



        }
        // Method to convert String to Integer:
        static void ConvertToInt(String number)
        {
            int convert_to_int1 = int.Parse(number);
            int convert_to_int2 = Convert.ToInt32(number);
            Boolean convert_to_int3 = int.TryParse(number, out Int32 i);
            Console.WriteLine(convert_to_int1 + " " + convert_to_int2 + " " + convert_to_int3);
        }

        //Method to Convert String to Float:
        static void ConvertToFloat(String number)
        {
            float convert_to_int1 = float.Parse(number);
            float convert_to_int2 = Convert.ToSingle(number);
            Boolean convert_to_int3 = float.TryParse(number, out Single i);
            Console.WriteLine(convert_to_int1 + " " + convert_to_int2 + " " + convert_to_int3);

        }

        //Method to convert String to Boolean:

        static void ConvertToBoolean(String number)
        {
            Boolean convert_to_int = bool.TryParse(number, out bool i);
            Console.WriteLine(convert_to_int);

        }

    }
}
