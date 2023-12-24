// Entering a three-digit number
        Console.Write("Enter a three-digit number: ");
        int number = Convert.ToInt32(Console.ReadLine()!);

        // Extracting the second and third digits
        int secondDigit = (number / 10) % 10;
        int thirdDigit = number % 10;

        // Elevation of the second digit to a degree equal to the third digit
        int result = (int)Math.Pow(secondDigit, thirdDigit);

        // Result output
        Console.WriteLine($"{secondDigit}^{thirdDigit} = {result}");