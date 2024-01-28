using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите строку:");
        string inputString = Console.ReadLine()!; // ввод строки с клавиатуры

        char[] charArray = new char[inputString.Length]; // создание массива символов

        for (int i = 0; i < inputString.Length; i++)
        {
            charArray[i] = inputString[i]; // заполнение массива символами строки
        }

        Console.WriteLine("Массив символов:");
        foreach (char ch in charArray)
        {
            Console.Write(ch + " "); // вывод массива символов на экран
        }
    }
}
