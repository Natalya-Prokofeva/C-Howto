//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
int Ackermann(int m, int n)
{
    if (m < 0 || n < 0)
    {
        Console.WriteLine("Ошибка: Аргументы m и n должны быть неотрицательными целыми числами.");
        return -0;
    }

    int result = 0; // объявление переменной result

    if (m == 0)
    {
        result = n + 1;
    }
    else if (n == 0)
    {
        result = Ackermann(m - 1, 1);
    }
    else
    {
        result = Ackermann(m - 1, Ackermann(m, n - 1));
    }

    return result; // возврат вычисленного значения
}
int m = 2;
int n = 3;

int result = Ackermann(m, n); // вызов функции Ackermann и сохранение результата

Console.WriteLine($"Ackermann({m}, {n}) = {result}");


