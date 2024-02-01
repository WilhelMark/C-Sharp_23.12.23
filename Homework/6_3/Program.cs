using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку: ");
        string input = Console.ReadLine()!;

        if (IsPalindrome(input))
        {
            Console.WriteLine("Да, это палиндром.");
        }
        else
        {
            Console.WriteLine("Нет, это не палиндром.");
        }
    }

    static bool IsPalindrome(string str)
    {
        str = str.ToLower().Replace(" ", "");
        for (int i = 0; i < str.Length / 2; i++)
        {
            if (str[i] != str[str.Length - i - 1])
            {
                return false;
            }
        }
        return true;
    }
}