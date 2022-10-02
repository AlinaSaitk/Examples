// Задача 24. Напишите программу, которая принимает на вход число (А) 
// и выдает сумму чисел от 1 до А
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Clear();
int a = Convert.ToInt32(Console.ReadLine());
Console.Clear();
int sum = 0;
for (int i = 1; i <= a; i++)
{
    sum = sum + i;
}
Console.WriteLine($"{a} -> {sum}");
