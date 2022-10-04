//ДЗ - Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int temp = num;
int sum = 0;
while (temp > 0)
{
    sum = sum + temp%10;
    temp = temp / 10;
}
Console.WriteLine($"{num} -> {sum}");


// Ниже вариант решения через строки. Однако при конвертации из CHAR (String) в INT выдает какие то странные значения, Что делаю не так?

// Console.Clear();
// Console.Write("Введите число: ");
// string num = Console.ReadLine();
// int sum = 0;
// for (int i = 0; i < num.Length; i++)
// {
//     sum = sum + Convert.ToInt32(num[i]);
// }
// Console.WriteLine($"{num} -> {sum}");

// char x = num[0];
// Console.WriteLine(x);
// Console.WriteLine(Convert.ToInt32(x)); 

