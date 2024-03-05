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

// Задача: сообщить о наличии отрицательных элементах в строках двумерного массива.
int [,] table = {{1,1,1},
                {2,-2,2},
                {3,-3,3}};
for (int i = 0; i< table.GetLength(0); i++)
{
    for (int j = 0; j< table.GetLength(1); i++)
    {
        if (table[i,j]<0)
        {
            Console.WriteLine($"Здесь есть отрицательное число в строке {i}");
            break;
        }
    }
}

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