// 17. Напишите программу, которая принимает на вход координаты 
// точки (X и Y), причем Х != 0 и Y != 0 и выдаёт номер четверти 
// плоскости, в которой находится эта точка.

Console.Clear();
Console.WriteLine("Введите координаты точки (X и Y): ");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
if (x == 0 || y == 0) Console.WriteLine("Координаты точки (X и Y) не должны быть равны нулю ");
else if (x > 0 & y > 0) Console.WriteLine("Точка находится в 1-й четверти");
else if (x < 0 & y > 0) Console.WriteLine("Точка находится во 2-й четверти");
else if (x < 0 & y < 0) Console.WriteLine("Точка находится в 3-й четверти");
else if (x > 0 & y < 0) Console.WriteLine("Точка находится в 4-й четверти");