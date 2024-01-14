using System;

class Program
{
    static void Main()
    {
        //создаем объект Random для генерации случайных чисел
        Random random = new Random();
        //создаем массив из 10 случайных чисел
        int[] numbers = new int[10];
        for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, 100); //генерация случайного числа от 1 до 100
        }
        //определение кол-во простых чисел в массиве
        int count = 0;
        foreach (var number in numbers)
        {
            if (IsPrime(number))
            {
                Console.WriteLine(number);
                count++;
            }
        }
        //вывод результата
        Console.WriteLine("Количество простых чисел в массиве: "+ count);
    }
    //метод для определения является ли число простым
    static bool IsPrime(int number)
    {
        if (number < 2) return false;

        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}
