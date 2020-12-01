using System;
using System.Collections.Generic;
using System.Linq;

namespace Workshop2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<int> list = new List<int>();
            for (int i = 0; i < 10000; i++)
            {
                list.Add(i);
            }
            list.RemoveAll(x => x % 3 == 0);
        }
    }
}
