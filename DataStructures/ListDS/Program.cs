using System;
using System.Collections.Generic;
namespace ListDS
{
    class Program
    {
        public static void Main(string[] args)
        {

            // CustomList<int> c = new CustomList<int>();
            // c.Add(1);
            // c.Add(2);
            // c.Add(3);
            // System.Console.WriteLine(c.Count);
            // System.Console.WriteLine(c.Capacity);
            // c.RemoveAt(0);
            // for (int i = 0; i < c.Count; i++)
            // {
            //     System.Console.WriteLine(c[i]);
            // }

            List<int> l = new List<int>();
            l.Add(1);
            l.Add(2);
            l.Add(3);
            l.Add(4);
            l.Add(5);
            l.Add(6);
            l.RemoveRange(4, 3);
            for (int i = 0; i < l.Count; i++)
            {
                System.Console.WriteLine(l[i]);
            }

        }
    }
}