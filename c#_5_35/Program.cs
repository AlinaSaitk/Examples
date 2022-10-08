// 35. Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых 
// лежат в отрезке [10, 99].

int[] CreateRamdomArray(int a)
{
    int[] array = new int[a];
    for (int i = 0; i < a; i++)
    {
        array[i] = new Random().Next(0, 1000);
    }
    return array;
}

int FindAmount(int a, int b, int[] array)
{
    int amount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= a & array[i] <= b) amount = amount + 1;
    }
    return amount;
}

void PrintArray(int[] array)
{
    Console.Write($"[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}]");
}

int[] arr = CreateRamdomArray(123);
int s = FindAmount(10, 99, arr);
PrintArray(arr);
Console.WriteLine($" -> {s}");

