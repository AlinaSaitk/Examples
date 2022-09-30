// 22. Напишите программу, которая принимает на вход 
// число (N) и выдает таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1, 4.

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"{n} -> ");
for (int i = 1; i <= n; i++) Console.Write($"{Math.Pow(i, 2)}, ");