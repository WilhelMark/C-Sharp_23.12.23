Console.Write("Введите координаты точки X и Y через пробел: ");
        string[] coordinates = Console.ReadLine()!.Split(' ');
        
        if (coordinates.Length < 2)
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите две координаты через пробел.");
            return;
        }

        int x = Convert.ToInt32(coordinates[0]);
        int y = Convert.ToInt32(coordinates[1]);

        if (x == 0 || y == 0)
        {
            Console.WriteLine("Точка находится на оси координат.");
        }
        else if (x > 0 && y > 0)
        {
            Console.WriteLine("1");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("2");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("3");
        }
        else
        {
            Console.WriteLine("4");
        }