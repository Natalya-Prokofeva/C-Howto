//Задача 3: Напишите программу, которая перевернёт одномерный массив 
//(первый элемент станет последним, второй – предпоследним и т.д.)

int[] numbers = new int[5]{2,4,6,8,5}; // Массив для хранения случайных чисел

for (int i = 0; i < numbers.Length / 2; i++)
{
    (numbers[i], numbers[numbers.Length - (i + 1)]) = (numbers[numbers.Length - (i + 1)], numbers[i]); //обмен элементов
}

Console.WriteLine(string.Join(" ", numbers));
