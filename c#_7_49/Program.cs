// 46. Задайте двумерный массив. Найдите элементы, у которых
// оба индекса четные, и замените эти элементы на их квадраты.
// 
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

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

int[,] Change2DArrayEvenInd(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) array[i, j] = array[i, j] * array[i, j];
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



int m = 3;
int n = 4;
int[,] arr1 = CreateRandom2DArray(m, n, 1, 10);
Print2DArray(arr1);
Console.WriteLine();
int[,] arr2 = Change2DArrayEvenInd(arr1);
Print2DArray(arr2);