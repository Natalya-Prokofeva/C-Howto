//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет: 
//"Позиция по рядам выходит за пределы массива"
//или "Позиция по колонкам выходит за пределы массива"
//Позиции в массиве считать от единицы.

using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] numbers = new int[,] {
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {9, 10, 11, 12}
        };

        int x = 2; // Позиция по рядам
        int y = 2; // Позиция по колонкам
        
//Поиск элемента по позициям
        int result = GetElement(numbers, x, y);
        if (result != -1)
        {
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Позиция выходит за пределы массива");
        }
    }

    static int GetElement(int[,] array, int x, int y)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        if (x < 1 || x > rows)
        {
            Console.WriteLine("Позиция по рядам выходит за пределы массива");
            return -1;
        }

        if (y < 1 || y > columns)
        {
            Console.WriteLine("Позиция по колонкам выходит за пределы массива");
            return -1;
        }

        // Возвращаем значение элемента по указанным координатам
        return array[x - 1, y - 1];
    }
}