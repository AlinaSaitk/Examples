// 59. Задайте двумерный массив из целых чисел. Напишите программу,
// которая удалит строку и столбец, на пересечении которых расположен
// наименьший элемент массива.


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

// int[,] DeleteRowColOnMin(int[,] array)
// {
//     int min = array[0, 0];
//     int numb = 1;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] == min)
//             {
//                 numb++;
//             }
//             if (array[i, j] < min)
//             {
//                 numb = 1;
//                 min = array[i, j];
//             } 
//         }
//     }
//     Console.WriteLine($"min element = {min}");
//     Console.WriteLine(numb);

//     for (int p = 1; p <= numb; p++)
//     {
//         min = array[0, 0];
//         int[] minCoord = new int[2];
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 if (array[i, j] < min)
//                 {
//                     minCoord[0] = i;
//                     minCoord[1] = j;
//                 } 
//             }
//         }

//         int m = 0;
//         int[,] array2 = new int[array.GetLength(0)-1, array.GetLength(1)-1];
//         for (int k = 0; k < array.GetLength(0); k++)
//         {
//             if (k != minCoord[0])
//             {
//                 int n = 0;
//                 for (int l = 0; l < array.GetLength(1); l++)
//                 {
//                     if (l != minCoord[1])
//                     {
//                         array2[m, n] = array[k, l];
//                         n++;
//                     }
//                 }
//                 m++;
//             }
//         }
//         array = array2;
//     }
//     return array;   
// }


int[] FindMinAmount(int[,] array)
{
    int[] minArray = new int[2];
    int min = array[0, 0];
    int numb = 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == min)
            {
                numb++;
            }
            else if (array[i, j] < min)
            {
                numb = 1;
                min = array[i, j];
            } 
        }
    }
    minArray[0] = min;
    minArray[1] = numb;
    return minArray;
}

int[] FindElemCoord(int elem, int[,] array)
{
    int[] elemCoord = new int[2] {-1, -1};
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == elem)
            {
                elemCoord[0] = i;
                elemCoord[1] = j;
                break;
            } 
        }
    }
    return elemCoord;
}

int[,] DeleteRowCol(int[] elemCoord, int[,] array)
{
    if (elemCoord[0] >= 0)
    {
        int[,] array2 = new int[array.GetLength(0)-1, array.GetLength(1)-1];
        int m = 0;
        for (int k = 0; k < array.GetLength(0); k++)
        {
            if (k != elemCoord[0])
            {
                int n = 0;
                for (int l = 0; l < array.GetLength(1); l++)
                {
                    if (l != elemCoord[1])
                    {
                        array2[m, n] = array[k, l];
                        n++;
                    }
                }
                m++;
            }
        }
        return array2;
    }
    else return array;
}


int[,] arr = CreateRandom2DArray(5, 4);
Print2DArray(arr);

int[] minArr = FindMinAmount(arr); 
Console.WriteLine($"min element = {minArr[0]}");
Console.WriteLine($"Amount of min element = {minArr[1]}");

for (int i = 0; i < minArr[1]; i++)
{
    Console.WriteLine();
    int[] elemCoord = FindElemCoord(minArr[0], arr);
    if (elemCoord[0] < 0) break;
    Console.WriteLine($"Min coordinates ({elemCoord[0]}, {elemCoord[1]})");

    arr = DeleteRowCol(elemCoord, arr);

    Console.WriteLine();
    Print2DArray(arr);
}