using System;

class Program
{
    static void Main()
    {
        // Исходная строка
        string input = "Задайте строку, состоящую из слов, разделенных пробелами";

        // Разбиение исходной строки на слова
        string[] words = input.Split(' ');

        // Формирование строки в обратном порядке
        Array.Reverse(words);
        string reversedString = string.Join(" ", words);

        // Вывод результата
        Console.WriteLine(reversedString);
    }
}
