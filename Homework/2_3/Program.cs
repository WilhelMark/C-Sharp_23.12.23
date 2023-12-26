int number = 0;
    bool isValidInput = false;
    while (!isValidInput) {
      Console.WriteLine("Введите целое число от 10 до 99:");
      string input = Console.ReadLine()!;
      if (int.TryParse(input, out number) && number >= 10 && number <= 99) {
        isValidInput = true;
      } else {
        Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число от 10 до 99.");
      }
    }
    int maxDigit = 0;
    while (number > 0) {
      int digit = number % 10;
      maxDigit = Math.Max(digit, maxDigit);
      number = number / 10;
    }
    Console.WriteLine("Наибольшая цифра числа: " + maxDigit);