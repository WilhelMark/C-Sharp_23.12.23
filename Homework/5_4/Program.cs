using System;

class Program
{
    static void Main()
    {
        // Получаем размер массива от пользователя
        Console.Write("Введите количество строк: ");
        int rows = int.Parse(Console.ReadLine()!);
        Console.Write("Введите количество столбцов: ");
        int cols = int.Parse(Console.ReadLine()!);

        // Создаем и заполняем массив
        int[,] array = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            Console.WriteLine($"Введите элементы для строки {i + 1}:");
            string[] elements = Console.ReadLine().Split(' ');
            for (int j = 0; j < cols; j++)
            {
                array[i, j] = int.Parse(elements[j]);
            }
        }

        // Находим индексы наименьшего элемента
        int minElement = array[0, 0];
        int minRow = 0, minCol = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (array[i, j] < minElement)
                {
                    minElement = array[i, j];
                    minRow = i;
                    minCol = j;
                }
            }
        }

        // Создаем новый массив без строки и столбца с минимальным элементом
        int[,] newArray = new int[rows - 1, cols - 1];
        for (int i = 0, i2 = 0; i < rows; i++)
        {
            if (i == minRow) continue;
            for (int j = 0, j2 = 0; j < cols; j++)
            {
                if (j == minCol) continue;
                newArray[i2, j2] = array[i, j];
                j2++;
            }
            i2++;
        }

        // Выводим новый массив
        Console.WriteLine("Новый массив:");
        for (int i = 0; i < rows - 1; i++)
        {
            for (int j = 0; j < cols - 1; j++)
            {
                Console.Write(newArray[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}