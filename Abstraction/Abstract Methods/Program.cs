using System;
using System.ComponentModel;
using Abstract_Methods;
namespace Muk;

class Program
{
    public static void Main(string[] args)
    {
       CustomList<int> custom = new CustomList<int>(2);
       custom.Add(12);
       custom.Add(13);
       custom.Add(14);
       custom.Add(15);
       custom.Add(16);
       custom.Add(17);
       custom.Display();
        foreach(int i in custom){
            System.Console.WriteLine(i);
       }
    }
}