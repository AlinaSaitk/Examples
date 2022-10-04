// Даны 2 отрезка на одной прямой с координатами (х1, х2) и (х3, х4), 
// необходимо найти пересечение 2-х отрезков.

int[] Line()
{
    int x1 = Convert.ToInt32(Console.ReadLine());
    int x2 = Convert.ToInt32(Console.ReadLine());
    if (x1 > x2) 
    {
        int tempX = x1;
        x1 = x2;
        x2 = tempX;
    }
    int len = x2 - x1 + 1;
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = x1;
        x1 = x1 + 1;
    }
    return arr;
}

Console.Clear();
Console.WriteLine("Введите координаты первой прямой Х1 и Х2: ");
int[] line1 = Line();

Console.WriteLine("Введите координаты второй прямой Х3 и Х4: ");
int[] line2 = Line();

Console.Write("Точки первого отрезка: ");
for (int i = 0; i < line1.Length; i++) Console.Write($"{line1[i]} ");
Console.WriteLine();
Console.Write("Точки второго отрезка: ");
for (int i = 0; i < line2.Length; i++) Console.Write($"{line2[i]} ");

int count = 0;
Console.WriteLine();
Console.Write("Точки пересечения: ");
for (int i = 0; i < line1.Length; i++)
{
    for (int j = 0; j < line2.Length; j++)
    {
        if (line1[i] == line2[j])
        {
            Console.Write($"{line1[i]} ");
            count++;
            break;
        }
    }
}

Console.WriteLine();
if (count == 0) Console.WriteLine("отрезки не пересекаются");