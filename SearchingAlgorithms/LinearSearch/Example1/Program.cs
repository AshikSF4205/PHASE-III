using System;

namespace Example1;

class Program
{
    public static void Main(string[] args)
    {
        int[] arr = {45,33,12,55,77,22,33,14,67,78,22,11,44,66,88,12,35,84,93,77};
        int find = 66;
        bool flag = false;
        for(int i=0;i<arr.Length;i++)
        {
            if(arr[i] == find)
            {
                flag = true;
                System.Console.WriteLine("ELEMENT FOUND!");
            }

        }
        if(!flag)
        {
            System.Console.WriteLine("ELEMENT NOT FOUND!");
        }
    }
}