// Задача 38: Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] RandomDoubleArray(int n, double from, double to)
{
    double[] array = new double[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().NextDouble() * (to - from);
    }
    return array;
}

void PrintDoubleArray(double[] array)
{
    Console.Write($"[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}]");
}

double[] MinMax(double[] array)
{
    double[] arrMinMax = new double[2];
    arrMinMax[0] = array[0];
    arrMinMax[1] = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > arrMinMax[1]) arrMinMax[1] = array[i];
        else if (array[i] < arrMinMax[0]) arrMinMax[0] = array[i];
    }
    return arrMinMax;
}

Console.Clear();
double[] arr1 = RandomDoubleArray(4, 0, 100);
PrintDoubleArray(arr1);
Console.Write(" -> ");
double[] arr2 = MinMax(arr1);
Console.WriteLine(arr2[1]-arr2[0]);



