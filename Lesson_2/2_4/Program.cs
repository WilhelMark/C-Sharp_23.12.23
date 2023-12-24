Console.WriteLine("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number < 100)
        {
            Console.WriteLine("Третьей цифры нет");
        }
        else
        {
            int thirdFromEnd = (number / 100) % 10;
            Console.WriteLine("Третья цифра: " + thirdFromEnd);
        }