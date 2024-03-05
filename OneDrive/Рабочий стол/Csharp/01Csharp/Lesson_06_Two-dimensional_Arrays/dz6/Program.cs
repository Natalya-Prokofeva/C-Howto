// Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

string abc = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
string result = "";

for (int i = 0; i < abc.Length; i++)
    if (char.IsUpper(abc[i]))
        result += char.ToLower(abc[i]);

Console.WriteLine(result);
Console.ReadKey(true);