//Задача 3: Задайте произвольную строку. 
//Выясните, является ли она палиндромом.


string input = "шалаш";
bool isPalindrome = IsPalindrome(input);

Console.WriteLine(isPalindrome ? "Да" : "Нет");
string normalized = new
string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
    return normalized.SequenceEqual(normalized.Reverse());
