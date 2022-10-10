// 46. Задайте двумерный массив размером m x n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

int[,] CreateRandom2DArray(int row, int col, int from = -99, int to = 100)
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


Console.WriteLine("Введите размеры двумерного массива m и n:");
int m = 3;
int n = 4;
int[,] arr = CreateRandom2DArray(m, n, -9, 10);
Console.WriteLine($"m = {m}, n = {n}");
Print2DArray(arr);
