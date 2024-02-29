// операторы управления break & continue
// break – позволяет прервать ближайший внешний цикл for, foreach или while.

Console.WriteLine("Start");

int [] numbers = {2, 4, 6, 7, 8, 10};
foreach (int number in numbers)
{
    if (number % 2 == 1)
    {
        Console.WriteLine("There is odd number");
        break;
    }
}
Console.WriteLine("Stop");

// continue - позволяет перейти к следующей итерации ближайшего внешнего цикла, когда
// появляются условия, при которых оставшееся тело цикла нужно пропустить.

for (int i = 1; i<= 5; i++)
{
    Console.Write($"Iteration{i}: ");
    if (i==3)
    {
        Console.WriteLine("Skip");
        continue;
    }
    Console.WriteLine("Some processing");
}