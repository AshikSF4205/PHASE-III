using System;

namespace Example4;

class Program{
    public static void Main(string[] args)
    {
        double[] arr = {1.1,65.3,93.9,55.5,3.5,6.9};
        double find = 3.5;
        bool flag = false;

        for(int i=0;i<arr.Length-1;i++)
        {
            if(find == arr[i])
            {
                flag = true;
                System.Console.WriteLine("ELEMENT FOUND AT INDEX: "+i);
            }
        }

        if(!flag)
        {
            System.Console.WriteLine("ELEMENT NOT FOUND");
        }
    }
}