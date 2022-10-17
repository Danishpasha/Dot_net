namespace Exercise_11
{
    public static class ExtensionMethods
    {
       
        public static bool IsOdd(this int number)
        {
            return (number % 2 == 0) ? false : true;
        }

                public static bool IsEven(this int number)
        {
            return (number % 2 == 0) ? true : false;
        }

       
        public static bool IsPrime(this int number)
        {
            int i;
            for (i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    break;
                }
            }
            return (i == number) ? true : false;
        }

                public static bool IsDivisibleBy(this int number, int divisible)
        {
            return (number % divisible == 0) ? true : false;
        }
    }
}
