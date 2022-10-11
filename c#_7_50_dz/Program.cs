// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

int[,] CreateRandom2DArray(int row, int col, int from = 0, int to = 10)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(from, to);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FindElementIn2DArrayByPosition(int n, int[,] array)
{
    int i = n / 10 - 1;
    int j = n % 10 - 1;
    if (i < array.GetLength(0) && j < array.GetLength(1))
    {
        Console.WriteLine($"Значение элемента: {array[i, j]}");
    }
    else
    {
        Console.WriteLine($"Такого элемента нет");
    }
}


Console.WriteLine("Задан массив: ");
int m = 3;
int n = 4;
int[,] arr = CreateRandom2DArray(m, n);
Print2DArray(arr);
Console.Write("Введите позицию элемента в двумерном массиве: ");
int position = Convert.ToInt32(Console.ReadLine());
FindElementIn2DArrayByPosition(position, arr);



