// ДЗ - Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int[,] CreateRandom2DArray(int row = 3, int col = 4, int from = 0, int to = 10)
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

int[,] SortRowArray(int[,] array)
{
    int temp = 0;
    int max;
    int y = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1)-1; j++)
        {
            max = array[i, j];
            for (int k = j+1; k < array.GetLength(1); k++)
            {
                if (array[i, k] > max)
                {
                    max = array[i, k];
                    y = k;
                }
            }
            if (max > array[i, j])
            {
                temp = array[i, j];
                array[i, j] = max;
                array[i, y] = temp;
            }
        }
        Console.WriteLine();
    }
    return array; 
}

int[,] arr = CreateRandom2DArray();
Print2DArray(arr);

int[,] arr2 = SortRowArray(arr);
Print2DArray(arr2);
