﻿//Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
//Использовать рекурсию, не использовать циклы.

int[] myArray = { 1, 2, 3, 4, 5 };

int Fact(int n)
{
    if (n == 1 || n == 0)
    {
        //Console.WriteLine($"Stop: {n}"); // отладочный вывод на экран
        return 1;
    }
    int result = n * Fact(n - 1); // сохраняем результат рекурсивного вызова
    Console.WriteLine(n); // отладочный вывод на экран - отладчик это программа которая позволяет запустить программу в режим отладки
    //Console.WriteLine($"Возврат: {n}, fact = {result}");
    return result;
}

Console.WriteLine(Fact(5));
