//Задача 3.
//Считать с консоли строку, состоящую из цифр и латинских букв. 
//Сформировать новую строку, состоящую из букв исходной строки.
//Этапы решение:
//1.ввод строки 
//2.проход по элементам строки
//3.проверка элемнта: является ли он буквой?
//4.Дописать подходящий элемент к новой строке

string GetLetters(string s)
{
    string letters = "";
    foreach(char e in s)
    {
        if (char.IsAsciiLetter(e) == true)
        {
            letters = letters + e;
        }
    }
    return letters;
}
string str = Console.ReadLine(); 
string result = GetLetters(str); 
Console.WriteLine(result);
