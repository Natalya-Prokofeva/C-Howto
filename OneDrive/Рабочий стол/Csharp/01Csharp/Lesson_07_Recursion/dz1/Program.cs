//Задача 1: Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы.

void LineOFNums(int m, int n)
{
    if (m == n)
    {
        Console.Write($"{m} ");
        return;
    }
    else if (m < n)
    {
        Console.Write($"{m} ");
        LineOFNums(m + 1, n);
    }
    else
    {
        Console.Write($"{m} ");
        LineOFNums(m - 1, n);
    }
}

Console.WriteLine("Введите число m:");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число n:");
int n = int.Parse(Console.ReadLine()!);

LineOFNums(m, n);

