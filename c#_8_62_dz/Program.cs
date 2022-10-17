// ДЗ - Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] SpiralArray(int row, int col)
{
    int n = 2;
    int[,] array = new int[row, col];
    int i = 0;
    int j = 0;
    int x = 0;
    array[0, 0] = 1;
    while (n <= row * col)
    {
        while(j < col-1-x)
        {
            array[i, j+1] = n;
            n++;
            j++;
        }
        while (i < row-1-x)
        {
            array[i+1, j] = n;
            n++;
            i++;
        }
        while(j > 0+x)
        {
            array[i, j-1] = n;
            n++;
            j--;
        }
        x++;
        while (i > 0+x)
        {
            array[i-1, j] = n;
            n++;
            i--;
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
            if (array[i, j] < 10) Console.Write($"0{array[i, j]} ");
            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    } 
}

int[,] spiral = SpiralArray(6, 6);
Print2DArray(spiral);



// int[,] SpiralArray(int row, int col)
// {
//     int n = 1;
//     int[,] array = new int[row, col];
//     int i = 0;
//     int j = 0;
//     int x = 0;
//     while (n <= row * col)
//     {
//         while(j < col-x)
//         {
//             array[i, j] = n;
//             n++;
//             j++;
//         }
//         i++;
//         j--;
//         while (i < row-x)
//         {
            
//             array[i, j] = n;
//             n++;
//             i++;
//         }
//         i--;
//         j--;
//         while(j >= 0+x)
//         {
//             array[i, j] = n;
//             n++;
//             j--;
//         }
//         x++;
//         i--;
//         j++;
//         while (i >= 0+x)
//         {
//             array[i, j] = n;
//             n++;
//             i--;
//         }
//         i++;
//         j++;
//     }
//     return array;
// }
