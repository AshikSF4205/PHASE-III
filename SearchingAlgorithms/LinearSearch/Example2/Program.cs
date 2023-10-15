using System;

namespace  Example2;

class Program{
    public static void Main(string[] args)
    {
        string[] arr = {"SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092"};

        string find = "SF3067";
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