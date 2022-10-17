// ДЗ - Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

void MinSumRow(int[,] array)
{
    int sum;
    int min = 0;
    int y = 0;
    for (int k = 0; k < array.GetLength(0); k++)
    {
        min += array[0, k];
    }
    for (int i = 1; i < array.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < array.GetLength(1)-1; j++)
        {
            sum += array[i, j];
        }   
        if (sum < min)
        {
            min = sum;
            y = i;
        }
    }
    Console.WriteLine($"{y+1} строка");
}

int[,] arr = CreateRandom2DArray();
Print2DArray(arr);
MinSumRow(arr);





