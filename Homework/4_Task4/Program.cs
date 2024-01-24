using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите строку: "); // Выводим приглашение для ввода строки
                string input = Console.ReadLine()!; // Считываем введенную строку

                if (IsValidInput(input)) // Проверяем валидность введенной строки
                {
                    int[] numbers = GetNumbersFromString(input); // Получаем массив из строки
                    Console.WriteLine("Массив: " + string.Join(", ", numbers)); // Выводим массив на консоль
                }
                else
                {
                    Console.WriteLine("Ошибка: строка должна состоять только из цифр и латинских букв."); // Выводим сообщение об ошибке
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message); // Выводим сообщение об ошибке, если что-то пошло не так
            }
        }

        // Метод проверяет, является ли строка цифрами и латинскими буквами
        static bool IsValidInput(string input)
        {
            foreach (char c in input) // Проходим по каждому символу в строке
            {
                if (!Char.IsDigit(c) && !Char.IsLetter(c)) // Если символ не является цифрой или латинской буквой
                {
                    return false; // Возвращаем false
                }
            }
            return true; // Если все символы валидны, возвращаем true
        }

        // Метод получает массив из строки
        static int[] GetNumbersFromString(string input)
        {
            int[] numbers = new int[CountNumbersInString(input)]; // Создаем массив, размер которого равен количеству цифр в строке

            int index = 0; // Индекс текущей ячейки в массиве numbers

            foreach (char c in input) // Проходим по каждому символу в строке
            {
                if (Char.IsDigit(c)) // Если символ является цифрой
                {
                    numbers[index] = int.Parse(c.ToString()); // Преобразуем символ в число и записываем в массив
                    index++; // Увеличиваем индекс текущей ячейки в массиве
                }
            }

            return numbers; // Возвращаем полученный массив
        }

        // Метод считает количество цифр в строке
        static int CountNumbersInString(string input)
        {
            int count = 0; // Счетчик цифр в строке

            foreach (char c in input) // Проходим по каждому символу в строке
            {
                if (Char.IsDigit(c)) // Если символ является цифрой
                {
                    count++; // Увеличиваем счетчик цифр
                }
            }

            return count; // Возвращаем количество цифр в строке
        }
    }
}