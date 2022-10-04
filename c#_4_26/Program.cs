// Задача 26. Напишите программу, которая принимает на вход число 
// и выдает количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();
int a = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (a >= 10)
{
    count++;
    a = a / 10;
}
Console.WriteLine($"{a} -> {count}");


// Console.Clear();
// string a = Console.ReadLine();
// int len = a.Length;
// Console.WriteLine($"{a} -> {len}");