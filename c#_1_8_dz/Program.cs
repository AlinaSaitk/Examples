// ДЗ - Задача 8: Напишите программу, которая на вход 
// принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int n = 2;
while (n <= N)
{
    Console.Write(n + ", ");
    n += 2;
}