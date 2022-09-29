// 16. Напишите программу, которая принимает на вход два числа
//  и проверяет, является ли одно число квадратом другого.
//  5, 25 -> да
//  -4, 16 -> да
//  25, 5 -> да
//  8, 9 -> нет

Console.Clear();
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
Console.Clear();
if (a == b*b | b == a*a) Console.WriteLine($"{a}, {b} -> да");
else Console.WriteLine($"{a}, {b} -> нет");