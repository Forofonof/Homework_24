using System;

    internal class Program
{
    static void Main(string[] args)
    {
        int[] array = {9, 1, 6, 2, 5, 8, 17, 18, 28, 21};
        int arraySort;

        foreach (int numbers in array)
        {
            Console.Write($" {numbers}");
        }

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (array[i] < array[j])
                {
                    arraySort = array[i];
                    array[i] = array[j];
                    array[j] = arraySort;
                }
            }
        }

        Console.Write(" | ");

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($" {array[i]}");
        }
    }
}