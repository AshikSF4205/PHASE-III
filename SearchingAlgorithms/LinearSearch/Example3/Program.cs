using System;

namespace Example3;

class Program{
    public static void Main(string[] args)
    {
        char[] arr = {'c','a','f','b','k','h','j','I','i','z','t','m','p','l','d'};
        char find = 'm';
        bool flag = false;
        for(int i=0;i<arr.Length-1;i++)
        {
            if(find == arr[i])
            {
                System.Console.WriteLine("ELEMENT FOUND AT INDEX: "+i);
                flag=true;
            }
        }
        if(!flag)
        {
            System.Console.WriteLine("ELEMENT NOT FOUND!");
        }
    }
}