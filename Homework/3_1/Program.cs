using System;
using System.Linq;

class UserInputToCompileForTest
{ 
    // Метод для подсчета количества элементов массива, попадающих в заданный диапазон
    // numbers - массив, в котором ведется подсчет
    // minRange - минимальная граница диапазона
    // maxRange - максимальная граница диапазона
    public static int CountItemsRange(int[] numbers, int minRange, int maxRange)
    {
        int count = 0;
        foreach (int number in numbers)
        {
            if (number >= minRange && number <= maxRange)
            {
                count++;
            }
        }
        return count;
    }
    
    // Метод для вывода результата на экран
    // count - количество элементов массива, попадающих в заданный диапазон
    public static void PrintResult(int count)
    {
        Console.WriteLine(count);
    }
}

class Answer
{
    public static void Main(string[] args)
    {
        int[] array;

        if (args.Length >= 1) {
            // Объединяем все аргументы командной строки в одну строку
            string joinedArgs = string.Join(" ", args);

            // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
            array = joinedArgs.Split(", ")
                                  .Select(int.Parse)
                                  .ToArray();
            
            // Теперь arr содержит преобразованные в целые числа из командной строки
        
        } else {
           // Если аргументов на входе нет
            array = new int[] {1, 5, 10, 20, 30, 40, 99, 4, 90, 3}; // Создание массива
        }

        int count = UserInputToCompileForTest.CountItemsRange(array, 10, 90);
        UserInputToCompileForTest.PrintResult(count);
    }
}

