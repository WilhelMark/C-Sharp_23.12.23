/*
using System;

public class Program
{
    public static void Main()
    {
        int number = 456; // Замените 456 на входное число
        int[] digitArray = GetDigitArray(number);
        
        // Вывод массива
        foreach (int digit in digitArray)
        {
            Console.Write(digit + " ");
        }
    }
    
    // Функция для создания массива цифр из числа
    public static int[] GetDigitArray(int number)
    {
        int[] digits = new int[3];
        digits[0] = number % 10; // Единицы
        number /= 10;
        digits[1] = number % 10; // Десятки
        number /= 10;
        digits[2] = number; // Сотни
        return digits;
    }
}
*/
using System;

public class Program
{
    public static void Main()
    {
        int number = GetNumberFromUser("Введите трехзначное число: ");
        int[] digitArray = GetDigitArray(number);
        
        // Вывод массива
        foreach (int digit in digitArray)
        {
            Console.Write(digit + " ");
        }
    }
    
    // Функция для создания массива цифр из числа
    public static int[] GetDigitArray(int number)
    {
        int[] digits = new int[3];
        digits[0] = number % 10; // Единицы
        number /= 10;
        digits[1] = number % 10; // Десятки
        number /= 10;
        digits[2] = number; // Сотни
        return digits;
    }

    // Функция для получения числа от пользователя
    public static int GetNumberFromUser(string message)
    {
        bool isValidInput;
        int number;
        do
        {
            Console.Write(message);
            isValidInput = int.TryParse(Console.ReadLine(), out number);
            if (!isValidInput || number < 100 || number > 999)
            {
                Console.WriteLine("Ошибка: Введите корректное трехзначное число.");
                isValidInput = false;
            }
        } while (!isValidInput);
        return number;
    }
}