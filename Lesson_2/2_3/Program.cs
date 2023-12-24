 int firstNumber, secondNumber;

            Console.Write("Enter the first number: ");
            firstNumber = int.Parse(Console.ReadLine()!);

            Console.Write("Enter the second number: ");
            secondNumber = int.Parse(Console.ReadLine()!);

            if (firstNumber % secondNumber == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                int remainder = firstNumber % secondNumber;
                Console.WriteLine($"No, {remainder}");
            }