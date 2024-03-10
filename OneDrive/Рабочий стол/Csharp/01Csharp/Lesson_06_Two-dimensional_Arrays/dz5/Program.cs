//Задача 1: Задайте двумерный массив символов (тип char [,]). 
//Создать строку из символов этого массива.

char[,] CharArray = new char[3, 5];

Random rnd = new Random();
for (int i = 0; i < CharArray.GetLength(0); i++)
{
    for (int j = 0; j < CharArray.GetLength(1); j++)
    {
        // Генерация случайной латинской буквы
        char randomChar = (char)rnd.Next('a', 'z' + 1); // для нижнего регистра
        // char randomChar = (char)rnd.Next('A', 'Z' + 1); // для верхнего регистра

        CharArray[i, j] = randomChar;
    }
}

for (int i = 0; i < CharArray.GetLength(0); i++)
{
    for (int j = 0; j < CharArray.GetLength(1); j++)
    {
        Console.Write($"{CharArray[i, j]} "); // интерполяция строк
    }
    Console.WriteLine();
}