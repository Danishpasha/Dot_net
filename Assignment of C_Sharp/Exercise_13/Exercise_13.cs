using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodSecond
{
    public delegate bool LinqExtension<T>(T num);

    public static class ExtensionMethodSecond
    {

        public static bool CustomAll<T>(this IEnumerable<T> listFirst, LinqExtension<T> func)
        {
            foreach (T num in listFirst)
            {
                if (!func(num))
                    return false;
            }
            return true;
        }


        public static bool CustomAny<T>(this IEnumerable<T> list, LinqExtension<T> func)
        {
            List<T> li = new List<T>();
            foreach (T num in list)
            {
                if (func(num))
                    return true;
            }
            return false;
        }


        public static int CustomMin<T>(this IEnumerable<int> numbers)
        {
            int min = 0;
            foreach (var num in numbers)
            {
                if (min == 0 || min > num)
                {
                    min = num;
                }
            }
            return min;
        }


        public static int CustomMax<T>(this IEnumerable<int> numbers)
        {
            int max = 0;
            foreach (var num in numbers)
            {
                if (max == 0 || max < num)
                {
                    max = num;
                }
            }
            return max;
        }


        public static IEnumerable<T> CustomWhere<T>(this IEnumerable<T> listSecond, LinqExtension<T> func)
        {
            List<T> list = new List<T>();
            foreach (T num in listSecond)
            {
                if (func(num))
                    list.Add(num);
            }
            return list;
            }
        public static IEnumerable<TResult> CustomSelect<T, TResult>(this IEnumerable<T> list, Func<T, TResult> func)
        {
            return list.Select(func);
        }
    }
}
