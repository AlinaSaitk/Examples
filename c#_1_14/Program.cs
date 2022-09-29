// 14. Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Clear();
int x = Convert.ToInt32(Console.ReadLine());
Console.Clear();
if (x % 7 == 0 & x % 23 == 0) Console.WriteLine($"{x} -> да");
else Console.WriteLine($"{x} -> нет");