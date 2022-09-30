// 21. Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 2D пространстве.
// А(3,6); В(2,1) -> 5.09
// А(7,-5); В(1,-1) -> 7.21

Console.Clear();
Console.WriteLine("Введите координаты точки A (X и Y): ");
int xa = Convert.ToInt32(Console.ReadLine());
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B (X и Y): ");
int xb = Convert.ToInt32(Console.ReadLine());
int yb = Convert.ToInt32(Console.ReadLine());
double len = Math.Round(Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2)), 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками = {len}");
