/*
string inputString = "LaTiN StRiNg";
string outputString = "";

foreach (char c in inputString)
{
    if (Char.IsUpper(c))
    {
        outputString += Char.ToLower(c);
    }
    else
    {
        outputString += c;
    }
}

Console.WriteLine(outputString);
*/

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку:"); // Просим пользователя ввести строку
        string inputString = Console.ReadLine()!; // Читаем введенную пользователем строку
        string outputString = "";

        foreach (char c in inputString)
        {
            if (Char.IsUpper(c))
            {
                outputString += Char.ToLower(c);
            }
            else
            {
                outputString += c;
            }
        }

        Console.WriteLine("Результат: " + outputString); // Выводим результат
    }
}