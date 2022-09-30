// ДЗ - 21. Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние 
// между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
int[] EnterCoord()
{
    int[] coord = new int[3];
    for (int i = 0; i < 3; i++)
    {
        coord[i] = Convert.ToInt32(Console.ReadLine());
    }
    return coord;
}

Console.WriteLine("Введите координаты точки A (X, Y, Z): ");
int[] a = EnterCoord();
Console.WriteLine("Введите координаты точки A (X, Y, Z): ");
int[] b = EnterCoord();

// length = sqrt[(xB-xA)^2+(yB-yA)^2+(zB-zA)^2]
// Сначала надем сумму квадратов.
double sum = 0;
for (int i=0; i<a.Length; i++) 
{
    sum = sum + Math.Pow((b[i] - a[i]), 2);
}

double len = Math.Round(Math.Sqrt(sum), 2);
Console.WriteLine($"Расстояние между точками = {len}");
