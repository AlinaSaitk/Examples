// 48. Задайте двумерный массив размером m x n,
// каждый элемент в массиве находится по формуле: А[m,n] = m + n.
//  Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int[,] Create2DArrayMN(int row, int col)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
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
int[,] arr = Create2DArrayMN(m, n);
Console.WriteLine($"m = {m}, n = {n}");
Print2DArray(arr);
