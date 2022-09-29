// 9. Напишите программу, которая выводит случайное число 
// из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8
// 12 -> 2
// 85 -> 8

Console.Clear();
int x = new Random().Next(10, 100);
int x1 = x / 10;
int x2 = x % 10;
if (x1 >= x2) Console.WriteLine($"{x} -> {x1}");
else Console.WriteLine($"{x} -> {x2}");

