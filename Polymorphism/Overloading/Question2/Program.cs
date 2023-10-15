using System;
using System.Security.Cryptography.X509Certificates;

namespace Question2;

class Program {
    public static void Main(string[] args)
    {
        Display(2);
        Display(19,3);
        Display(150,2,25);
        Display(8.0,3);
        Display(9,2.0,3000);
    }

    public static void Display(double number){
        System.Console.WriteLine(number);
    }

    public static void Display(double number1,double number2){
        System.Console.WriteLine($"{number1}, {number2}");
    }

    public static void Display(double number1,double number2,double number3){
        System.Console.WriteLine($"{number1},{number2},{number3}");
    }

    public static void Display(int number1,double number2){
        System.Console.WriteLine($"{number1}, {number2}");
    }

    public static void Display(int number1,string number2,double number3){
        System.Console.WriteLine($"{number1},{number2},{number3}");
    }
}