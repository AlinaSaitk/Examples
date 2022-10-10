// 51. Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1,1) и т.д.).
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2=12

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

int Sum2DArraysMainD(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j) sum = sum + array[i, j];
        }
    }
    return sum;
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



int m = 3;
int n = 4;
int[,] arr1 = CreateRandom2DArray(m, n, 1, 10);
Print2DArray(arr1);
int sum = Sum2DArraysMainD(arr1);
Console.WriteLine($"Сумма элементов главной диагонали: {sum}");
