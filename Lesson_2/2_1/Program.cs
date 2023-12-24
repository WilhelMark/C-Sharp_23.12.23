Console.Write("Enter a three-digit number: ");
        int number = int.Parse(Console.ReadLine()!);
        int result = (number / 100) * 10 + (number % 10);
        Console.WriteLine("Result: " + result);