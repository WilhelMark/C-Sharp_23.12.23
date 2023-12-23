Console.Write("Enter a number: ");
int num1 = int.Parse(Console.ReadLine()!);
int num2 = -num1;
while(num2 <= num1)
{
    Console.Write(num2 + " ");
    num2 ++;
}

