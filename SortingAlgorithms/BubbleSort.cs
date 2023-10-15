using System;

namespace BubbleSort;

class Program 
{
    public static void Main(string [] args)
    {
        Console.WriteLine("--------------------------------------------------");

        int [] arrayInt = new int[]{45,33,12,55,77,22,33,14,67,12,35};

        int [] sortedArrayInt = BubbleSortInt(arrayInt);                                // int

        foreach (int i in sortedArrayInt) Console.Write(i + " ");

        Console.WriteLine("--------------------------------------------------");

        double [] arrayDouble = new double[]{1.1,65.3,93.9,55.5,3.5,6.9};

        double [] sortedArrayDouble = BubbleSortDouble(arrayDouble);                    // double

        foreach (double i in sortedArrayDouble) Console.Write(i + " ");

        Console.WriteLine("--------------------------------------------------");

        char [] arrayChar = new char[]{'c','a','f','b','k','h','z','t','m','p','l','d'};

        char [] sortedArrayChar = BubbleSortChar(arrayChar);                            // char

        foreach (char i in sortedArrayChar) Console.Write(i + " ");

        Console.WriteLine("--------------------------------------------------");

        string [] arrayString = new string[]{"SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092"};

        string [] sortedArrayString = BubbleSortString(arrayString);                    // string

        foreach (string i in sortedArrayString) Console.Write(i + " ");

        Console.WriteLine("--------------------------------------------------");

    }

    public static int[] BubbleSortInt(int[] array)
    {
        bool sort = true;

        for (int i=1; i < array.Length; i++)
        {
            if (array[i] < array[i-1])
            {
                sort = false;

                (array[i-1], array[i]) = (array[i], array[i-1]);
            }
        }
        if (sort) return array;
        else return BubbleSortInt(array);
    }

    public static double[] BubbleSortDouble(double[] array)
    {
        bool sort = true;

        for (int i=1; i < array.Length; i++)
        {
            if (array[i] < array[i-1])
            {
                sort = false;

                (array[i-1], array[i]) = (array[i], array[i-1]);
            }
        }
        if (sort) return array;
        else return BubbleSortDouble(array);
    }

    public static char[] BubbleSortChar(char[] array)
    {
        bool sort = true;

        for (int i=1; i < array.Length; i++)
        {
            if (array[i] < array[i-1])
            {
                sort = false;

                (array[i-1], array[i]) = (array[i], array[i-1]);
            }
        }
        if (sort) return array;
        else return BubbleSortChar(array);
    }

    public static string[] BubbleSortString(string[] array)
    {
        bool sort = true;

        for (int i=1; i < array.Length; i++)
        {
            if (int.Parse(array[i].Remove(0,2)) < int.Parse(array[i-1].Remove(0,2)))
            {
                sort = false;

                (array[i-1], array[i]) = (array[i], array[i-1]);
            }
        }
        if (sort) return array;
        else return BubbleSortString(array);
    }
}