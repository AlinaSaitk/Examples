﻿// 18. Напишите программу, которая по заданнома номеру четверти
//  показывает диапазон возможных координат точек в этой четверти (х и у).

Console.Clear();
Console.Write("Введите номер четверти: ");
int x = Convert.ToInt32(Console.ReadLine());
if (x == 1) Console.WriteLine("диапазон возможных координат точек в этой четверти ((0, +бесконечности]; (0, +бесконечности])");
else if (x == 2) Console.WriteLine("диапазон возможных координат точек в этой четверти ([-бесконечности, 0); (0, +бесконечности])");
else if (x == 3) Console.WriteLine("диапазон возможных координат точек в этой четверти ([-бесконечности, 0); [-бесконечности, 0))");
else if (x == 4) Console.WriteLine("диапазон возможных координат точек в этой четверти ((0, +бесконечности]; [-бесконечности, 0))");
else Console.WriteLine("Существует только 4 четверти");