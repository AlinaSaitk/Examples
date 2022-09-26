// Напишите программу, которая на вход принимает два числа и проверяет, 
// является ли первое число квадратом второго.
// а = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// а = -3, b = 9 -> нет

Console.Clear();
Console.Write("Первое число: ");
int sqr = Convert.ToInt32(Console.ReadLine());

Console.Write("Второе число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num*num == sqr)
{
    Console.Write("да");
}
else
{
    Console.Write("нет");
}

