// Задача 28. Напишите программу, которая принимает на вход число N 
// и выдает произведение чисел от 1 до N
// 4 -> 24
// 5 -> 120

Console.Clear();
int n = Convert.ToInt32(Console.ReadLine());
Console.Clear();
int sum = 1;
for (int i = 1; i <= n; i++)
{
    sum = sum*i;
}
Console.WriteLine($"{n} -> {sum}");