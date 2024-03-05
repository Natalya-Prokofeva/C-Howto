// домашнее задание
// Считать с консоли строку, состоящую из цифрр и латинский букв.
//Сформировать массив, состоящий из цифр этой строки.

//пример abc123def06g => [1, 2, 3, 0, 6]

//Рекомендации:
//Разделить логику алгоритма на функции
//Выделить память под массив необходимого размера (не больше, чем кол-во элементов)

string vowelsChars = "abc123def06g";

int CountVowelsCharInString(string str)
{
    int countVowelsChar = 0;
    foreach (char 1234567890 in str) // первое решение через конкретные буквы
    {
        if (vowelsChars.Contains(1,2,3,4,5,6,7,8,9,0))
        {
            countVowelsChar++;
        }
    }
    return countVowelsChar;   
}

string inputString = Console.ReadLine()!;
Console.Write(CountVowelsCharInString(inputString));