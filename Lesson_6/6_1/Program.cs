/*
using System;

class MainClass {
  public static void Main (string[] args) {
    // Создание массива символов
    char[] charArray = new char[4];
    
    // Запрос элементов массива на ввод от пользователя
    Console.Write("Введите символы массива через пробел: ");
    string input = Console.ReadLine()!;
    
    // Разделение введенных символов на элементы массива
    string[] inputArray = input.Split(' ');
    
    // Проверка на валидность ввода
    if (inputArray.Length != 4) {
      Console.WriteLine("Введите 4 символа массива.");
      return;
    }
    
    // Преобразование введенных символов в массив символов
    for (int i = 0; i < inputArray.Length; i++) {
      charArray[i] = Convert.ToChar(inputArray[i]);
    }
    
    // Инициализация пустой строки
    string result = "";
    
    // Преобразование массива символов в строку
    foreach (char c in charArray) {
      result += c;
    }
    
    // Вывод результата
    Console.WriteLine(result); // "abcd"
  }
}
*/

using System;

class MainClass {
  public static void Main (string[] args) {
    // Запрос элементов массива на ввод от пользователя
    Console.WriteLine("Введите элементы массива через пробел:");
    string input = Console.ReadLine()!;
    
    // Разделение введенных элементов на массив строк
    string[] inputArray = input.Split(' ');
    
    // Создание массива символов на основе введенных элементов
    char[] charArray = new char[inputArray.Length];
    
    // Преобразование введенных элементов в массив символов
    for (int i = 0; i < inputArray.Length; i++) {
      charArray[i] = Convert.ToChar(inputArray[i]);
    }
    
    // Инициализация пустой строки
    string result = "";
    
    // Преобразование массива символов в строку
    foreach (char c in charArray) {
      result += c;
    }
    
    // Вывод результата
    Console.WriteLine(result);
  }
}
