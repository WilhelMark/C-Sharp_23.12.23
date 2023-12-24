// Prompt the user to input the first and second numbers
        Console.Write("Input the first number: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the second number: ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        // Check if the first number is a square of the second number
        bool isFirstNumberASquare = firstNumber * firstNumber == secondNumber;

        // Print the result
        Console.WriteLine("Is the first number a square of the second number? " + isFirstNumberASquare);