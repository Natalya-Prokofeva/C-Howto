//Задайте массив из вещественных чисел с ненулевой дробной частью.
//Найдите разницу между максимальным и минимальным элементов массива.

double[] numbers= {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01}; // Создание массива

double FindMin = numbers[0];
double FindMax = numbers[0];
double diff = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] < FindMin)
        {   
        FindMin = numbers[i];
        }
    if (numbers[i] > FindMax)
        {   
        FindMax = numbers[i];
        }
}
diff = FindMax - FindMin ;
Console.Write(diff);