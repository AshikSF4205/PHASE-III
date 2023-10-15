using System;
using System.Security.Cryptography.X509Certificates;

namespace Question1;

class Program {
    public static void Main(string[] args)
    {
        Multiply(2);
        Multiply(19,3);
        Multiply(150,2,25);
        Multiply(8.0,3);
        Multiply(9,2.0,3000);
    }

    public static void Multiply(int number){
        System.Console.WriteLine(number*number);
    }

    public static void Multiply(int number1,int number2){
        System.Console.WriteLine(number1*number2);
    }

    public static void Multiply(int number1,int number2,int number3){
        System.Console.WriteLine(number1*number2*number3);
    }

    public static void Multiply(double number1,int number2){
        System.Console.WriteLine(number1*number2);
    }

    public static void Multiply(byte number1,double number2,int number3){
        System.Console.WriteLine(number1*number2*number3);
    }
}