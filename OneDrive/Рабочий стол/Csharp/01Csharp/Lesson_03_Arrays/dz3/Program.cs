﻿//Задайте одномерный массив из 10 целых чисел от 1 до 100. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,90].

int[] numbers = new int[] {1, 5, 10, 20, 30, 40, 99, 4, 90, 3};
    // 1 вариант
    int count = 0;
    foreach (int number in numbers)
        if (number >= 10 && number <= 90)
            count++;
 
    Console.WriteLine ("Количество элементов массива, значения которых лежат в отрезке от 10 до 90: " + count);
    // 2 вариант
    Console.WriteLine ($"Количество элементов массива, значения которых лежат в отрезке от 10 до 90: {numbers.Where (n => (n >= 10 && n <= 90)).Count()}");
    