using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 3, 2, 4, 2, 3 };
        int[] result = new int[arr.Length / 2 + arr.Length % 2]; // создаем новый массив для записи результатов
        int j = 0;
        for (int i = 0; i < arr.Length - 1; i += 2) // проходим по исходному массиву с шагом 2
        {
            result[j] = arr[i] * arr[i + 1]; // вычисляем произведение текущего элемента и следующего элемента
            j++; // увеличиваем индекс нового массива
        }
        if (arr.Length % 2 != 0) // если длина исходного массива нечетная, то последний элемент не имеет пары
        {
            result[j] = arr[arr.Length - 1]; // записываем последний элемент в новый массив
        }
        Console.WriteLine(string.Join(" ", result)); // выводим результат в консоль
    }
}