// 12. Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Clear();
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
Console.Clear();
if (a % b == 0) Console.WriteLine($"{a}, {b} -> кратно");
else Console.WriteLine($"{a}, {b} -> не кратно, остаток {a % b}");