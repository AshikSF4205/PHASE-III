using System;

namespace Question3;

class Program {
    public static void Main(string[] args)
    {
        Square(2);
        Square(56786);
        Square(200);
        Square(200.0);
    }

    public static void Square(int number){
        System.Console.WriteLine(number*number);
    }

    public static void Square(float number){
        System.Console.WriteLine(number*number);
    }

    public static void Square(double number){
        System.Console.WriteLine(number*number);
    }

    public static void Square(long number){
        System.Console.WriteLine(number*number);
    }

}