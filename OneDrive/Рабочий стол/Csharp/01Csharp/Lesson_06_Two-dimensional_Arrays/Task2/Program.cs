//При создании функции ответь на 3 вопроса:
//1. Что делает функция? - Функция будет выделять память под массив некоторого размера и заполнять его случайными целыми числами.
//2. Какие данные ей для этого нужны? - Для выделения участка памяти  необходимо знать его размер строк и столбцов.
//3.Что будет результатом ее работы? - 

int[,] CreateMatrix(int rowsCount, int columsCount)
{
    int[,] matrix = new int[rowsCount, columsCount];

    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 11);
        }
    }
    return matrix;
}
void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} "); //интерполяция строк
        }
        Console.WriteLine();
    }
}
int[,] matrix = CreateMatrix(4, 5);
ShowMatrix(matrix);