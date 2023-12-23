Console.Write("Enter a three-digit number: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine(num1 % 10 + num1 / 100);