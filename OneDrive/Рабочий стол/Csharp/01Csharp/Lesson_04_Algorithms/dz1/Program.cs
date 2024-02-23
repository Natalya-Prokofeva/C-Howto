//Задача 1: Напишите программу, 
//которая принимает на вход число и проверяет, 
//кратно ли оно одновременно 7 и 23.

int num1 = int.Parse(Console.ReadLine()!);

if(num1 % 7 == 0 && num1 % 23 == 0)
    Console.WriteLine("yes");
else
    Console.WriteLine("no");
