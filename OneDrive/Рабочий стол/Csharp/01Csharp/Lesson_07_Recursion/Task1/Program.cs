// Рекурсивная функция вывода чисел от 1 до N

void OpenMatreshka(int size)
{
    Console.WriteLine($"Openning matreshka of size {size}..");
    if (size == 1)
    {
        Console.WriteLine($"Reached the smallest matreshka!");
        return;
    }
    
    OpenMatreshka(size-1);
}
OpenMatreshka(5);