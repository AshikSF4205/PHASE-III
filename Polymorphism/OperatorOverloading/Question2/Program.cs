using System;

namespace Question2;

class Program
{
    public static void Main(string[] args)
    {
        Calculator semester1 = new Calculator(97, 84, 56, 67, 78, 78);
        Calculator semester2 = new Calculator(93, 80, 67, 76, 88, 78);
        Calculator semester3 = new Calculator(89, 84, 65, 67, 78, 90);
        Calculator semester4 = new Calculator(78, 84, 90, 67, 85, 78);

        Calculator total = semester1 + semester2 + semester3 + semester4;

        System.Console.WriteLine("Total marks in Subject 1 : " + total.Subject1);
        System.Console.WriteLine("Total marks in Subject 2 : " + total.Subject2);
        System.Console.WriteLine("Total marks in Subject 3 : " + total.Subject3);
        System.Console.WriteLine("Total marks in Subject 4 : " + total.Subject4);
        System.Console.WriteLine("Total marks in Subject 5 : " + total.Subject5);
        System.Console.WriteLine("Total marks in Subject 6 : " + total.Subject6);

        System.Console.WriteLine("Percentage in Subject 1 : " + total.Subject1 / 4);
        System.Console.WriteLine("Percentage in Subject 2 : " + total.Subject2 / 4);
        System.Console.WriteLine("Percentage in Subject 3 : " + total.Subject3 / 4);
        System.Console.WriteLine("Percentage in Subject 4 : " + total.Subject4 / 4);
        System.Console.WriteLine("Percentage in Subject 5 : " + total.Subject5 / 4);
        System.Console.WriteLine("Percentage in Subject 6 : " + total.Subject6 / 4);
    }
}