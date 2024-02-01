using System;

class Program
{
    static void Main()
    {
        // Создаем двумерный массив символов
        char[,] charArray = new char[,]
        {
            { 'a', 'b', 'c' },
            { 'd', 'e', 'f' }
        };

        // Создаем строку из символов массива
        string result = CreateStringFromCharArray(charArray);

        // Выводим результат
        Console.WriteLine("Результат: " + result);
    }

    // Функция для создания строки из символов массива
    static string CreateStringFromCharArray(char[,] array)
    {
        int rows = array.GetLength(0); // Получаем количество строк
        int cols = array.GetLength(1); // Получаем количество столбцов

        string result = "";

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result += array[i, j]; // Добавляем символ к строке
            }
        }

        return result;
    }
}
