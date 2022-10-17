// ДЗ - Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateRandom2DArray(int row = 4, int col = 4, int from = 0, int to = 10)
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

int[,] MatrixMultiplication(int[,] array1, int[,] array2)
{
    int[,] array1xArray2 = new int[array1.GetLength(0), array1.GetLength(0)];
    int sum;
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(0); j++)
        {
            sum = 0;
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                sum += array1[i, k] * array2[k, j];
            }
            array1xArray2[i, j] = sum;
        }
    }
    return array1xArray2;
}

int[,] arr1 = CreateRandom2DArray(2, 2);
Print2DArray(arr1);
Console.WriteLine();
int[,] arr2 = CreateRandom2DArray(2, 2);
Print2DArray(arr2);
Console.WriteLine();

if (arr1.GetLength(1) == arr2.GetLength(0) && arr1.GetLength(0) == arr2.GetLength(1))
{
    int[,] arr1xArr2 = MatrixMultiplication(arr1, arr2);
    Print2DArray(arr1xArr2);
}
else Console.WriteLine("Матрицы нельзя перемножить, изучите правила");


