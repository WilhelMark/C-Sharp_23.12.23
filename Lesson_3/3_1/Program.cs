using System;

public class Program
{
    public static void Main()
    {
        int[] array = {1, 3, 4, 19, 3};
        int numberToFind = 8;

        bool isPresent = IsNumberPresent(array, numberToFind);

        Console.WriteLine(isPresent ? "Да" : "Нет");
    }

    public static bool IsNumberPresent(int[] array, int number)
    {
        foreach (int element in array)
        {
            if (element == number)
            {
                return true;
            }
        }
        return false;
    }
}