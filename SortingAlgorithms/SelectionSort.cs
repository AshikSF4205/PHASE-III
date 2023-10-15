using System;

namespace SelectionSort;

class Program 
{
    public static void Main(string [] args)
    {
        Console.WriteLine("--------------------------------------------------");

        int [] arrayInt = new int[]{45,33,12,55,77,22,33,14,67,12,35};

        int [] sortedArrayInt = SelectionSortInt(arrayInt);                                // int

        foreach (int i in sortedArrayInt) Console.Write(i + " ");

        Console.WriteLine("--------------------------------------------------");

        double [] arrayDouble = new double[]{1.1,65.3,93.9,55.5,3.5,6.9};

        double [] sortedArrayDouble = SelectionSortDouble(arrayDouble);                    // double

        foreach (double i in sortedArrayDouble) Console.Write(i + " ");

        Console.WriteLine("--------------------------------------------------");

        char [] arrayChar = new char[]{'c','a','f','b','k','h','z','t','m','p','l','d'};

        char [] sortedArrayChar = SelectionSortChar(arrayChar);                            // char

        foreach (char i in sortedArrayChar) Console.Write(i + " ");

        Console.WriteLine("--------------------------------------------------");

        string [] arrayString = new string[]{"SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092"};

        string [] sortedArrayString = SelectionSortString(arrayString);                    // string

        foreach (string i in sortedArrayString) Console.Write(i + " ");

        Console.WriteLine("--------------------------------------------------");

    }

    public static int[] SelectionSortInt(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int min = i;

            for (int j = i+1; j < array.Length; j++)
            {
                if (array[j] < array[min])
                {
                    min = j;
                }
            }

            (array[i], array[min]) = (array[min], array[i]);
        }

        return array;
    }

    public static double[] SelectionSortDouble(double[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int min = i;

            for (int j = i+1; j < array.Length; j++)
            {
                if (array[j] < array[min])
                {
                    min = j;
                }
            }

            (array[i], array[min]) = (array[min], array[i]);
        }

        return array;
    }

    public static char[] SelectionSortChar(char[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int min = i;

            for (int j = i+1; j < array.Length; j++)
            {
                if (array[j] < array[min])
                {
                    min = j;
                }
            }

            (array[i], array[min]) = (array[min], array[i]);
        }

        return array;
    }

    public static string[] SelectionSortString(string[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int min = i;

            for (int j = i+1; j < array.Length; j++)
            {
                if (int.Parse(array[j].Remove(0,2)) < int.Parse(array[min].Remove(0,2)))
                {
                    min = j;
                }
            }

            (array[i], array[min]) = (array[min], array[i]);
        }

        return array;
    }
}