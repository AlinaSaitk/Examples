// 31. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например в массиве [3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6] 
// сумма положительных чисел равна 29, сумма отрицательных равна -20.


int[] CreatRandomArray(int a, int b)
{
    int[] array = new int[12];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(a, b);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write($"Массив [");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]}]");
}

void PlusSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sum = sum + array[i];
    }
    Console.WriteLine($"Cумма положительных чисел равна {sum}");
}

void MinusSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) sum = sum + array[i];
    }
    Console.WriteLine($"Cумма отрицательных чисел равна {sum}");
}


Console.Clear();
int[] arr = CreatRandomArray(-9, 9);
PrintArray(arr);
PlusSum(arr);
MinusSum(arr);