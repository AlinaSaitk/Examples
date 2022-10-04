//ДЗ - Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16


Console.Clear();
Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В: ");
int b = Convert.ToInt32(Console.ReadLine());
int sum = 1;

for (int i = 0; i < b; i++) sum = sum * a;

Console.WriteLine($"{a}, {b} -> {sum}");


// Console.Clear();
// Console.Write("Введите число А: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число В: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{a}, {b} -> {Math.Pow(a, b)}");
