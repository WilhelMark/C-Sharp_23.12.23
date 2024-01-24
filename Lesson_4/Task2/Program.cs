// Создаем метод для создания матрицы с заданным количеством строк и столбцов
static int[,] CreateMatrix(int rowsCount, int columnsCount)
{
    // Создаем матрицу размером rowsCount x columnsCount
    int[,] matrix = new int[rowsCount, columnsCount];

    // Создаем объект класса Random для генерации случайных чисел
    Random rnd = new Random();

    // Заполняем матрицу случайными числами от 1 до 1000
    for (int i = 0; i < rowsCount; i++)
    {
        for (int j = 0; j < columnsCount; j++)
        {
            // Генерируем случайное число от 1 до 1000 и записываем его в матрицу
            matrix[i, j] = rnd.Next(1, 1001);
        }
    }

    // Выводим исходную матрицу на консоль
    Console.WriteLine("Исходная матрица:");
    ShowMatrix(matrix);

    // Возвращаем созданную матрицу
    return matrix;
}

// Создаем метод для вывода на консоль элементов матрицы, проходящих проверку на интересность
static void ShowInterestingElements(int[,] matrix)
{
    // Создаем объект класса Random для генерации случайных чисел
    Random rnd = new Random();

    // Проходим по всем элементам матрицы
    foreach (int e in matrix)
    {
        // Если элемент является интересным, то выводим его на консоль
        if (IsInteresting(e) == true)
        {
            Console.Write($"{e} ");
        }
    }

    // Завершаем выполнение метода
    Console.WriteLine();
}

// Создаем метод для вывода на консоль матрицы
static void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

// Создаем метод для проверки числа на интересность
static bool IsInteresting(int value)
{
    // Вычисляем сумму цифр числа
    int sumOfDigits = GetSumOfDigits(value);

    // Проверяем, является ли сумма цифр четной
    if (sumOfDigits % 2 == 0)
    {
        return true;
    }

    return false;
}

// Создаем метод для вычисления суммы цифр числа
static int GetSumOfDigits(int value)
{
    int sum = 0;

    // Проходим по всем цифрам числа
    while (value > 0)
    {
        // Добавляем очередную цифру к сумме
        sum += value % 10;

        // Удаляем последнюю цифру из числа
        value /= 10;
    }

    return sum;
}

// Создаем матрицу размером 3x4 и выводим на консоль ее интересные элементы
int[,] matrix = CreateMatrix(3, 4);

// Выводим интересные элементы матрицы на консоль
Console.WriteLine("Интересные элементы матрицы:");
ShowInterestingElements(matrix);