int n;
            bool validInput = false;
            do
            {
                Console.Write("Enter a natural number: ");
                if (int.TryParse(Console.ReadLine()!, out n) && n > 0)
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a natural number.");
                }
            } while (!validInput);

            string digits = n.ToString();
            for (int i = 0; i < digits.Length; i++)
            {
                Console.Write(digits[i]);
                if (i < digits.Length - 1)
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine();