using System;
using System.Collections.Generic;

namespace Workshop2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int value = 5;
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            Func<int, int, bool> function = MoreThanX;
            Func<int, bool> part_test = ApplyPartial(function, value);
            Predicate<int> predicate = new Predicate<int>(part_test);
            list.RemoveAll(predicate);
        }


        static Func<T2, TResult> ApplyPartial<T1, T2, TResult>(Func<T1, T2, TResult> function, T1 arg1)
        {
            return (b) => function(arg1, b);
        }

        static bool MoreThanX(int value, int num)
        {
            return num > value;
        }
    }
}
