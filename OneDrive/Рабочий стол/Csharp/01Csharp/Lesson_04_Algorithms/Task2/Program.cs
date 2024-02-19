int num1 = int.Parse(Console.ReadLine()!);
int num2 = num1 % 10;
int num3 = num1 / 10 % 10;

Console.WriteLine(Math.Pow(num2, num3));