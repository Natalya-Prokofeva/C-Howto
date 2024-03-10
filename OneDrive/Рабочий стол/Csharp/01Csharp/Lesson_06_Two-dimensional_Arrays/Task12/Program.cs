// Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой заглавные и строчные буквы поменялись местами те заглавне стали строчными, а строчные заглавными.

string abc = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
string result = string.Empty;

for (int i = 0; i < abc.Length; i++)
    if (char.IsUpper(abc[i]))
        result += char.ToLower(abc[i]);
    else
        result += char.ToUpper(abc[i]);

Console.WriteLine(result);
Console.ReadKey(true);
