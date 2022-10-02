// Задача 26. Напишите программу, которая принимает на вход число 
// и выдает количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();
string a = Console.ReadLine();
int len = a.Length;
Console.WriteLine($"{a} -> {len}");