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

int[,] DeleteRowColOnMin(int[,] array)
{
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
            if (array[i, j] < min)
            {
                numb = 1;
                min = array[i, j];
            } 
        }
    }
    Console.WriteLine($"min element = {min}");
    Console.WriteLine(numb);

    for (int p = 1; p <= numb; p++)
    {
        min = array[0, 0];
        int[] minCoord = new int[2];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] < min)
                {
                    minCoord[0] = i;
                    minCoord[1] = j;
                } 
            }
        }

        int m = 0;
        int[,] array2 = new int[array.GetLength(0)-1, array.GetLength(1)-1];
        for (int k = 0; k < array.GetLength(0); k++)
        {
            if (k != minCoord[0])
            {
                int n = 0;
                for (int l = 0; l < array.GetLength(1); l++)
                {
                    if (l != minCoord[1])
                    {
                        array2[m, n] = array[k, l];
                        n++;
                    }
                }
                m++;
            }
        }
        array = array2;
    }
    return array;   
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

//     int[,] minCoord = new int[numb, 2];
//     int numbOrder = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] == min)
//             {
//                 minCoord[numbOrder, 0] = i;
//                 minCoord[numbOrder, 1] = j;
//                 numbOrder++;
//             }
//         }
//     }
    
//     // for (int p = 0; p < numb; p++)
//     // {
//     //     int m = 0;
//     //     int[,] array2 = new int[array.GetLength(0)-1, array.GetLength(1)-1];
//     //     for (int k = 0; k < array.GetLength(0); k++)
//     //     {
//     //         if (k != minCoord[p, 0])
//     //         {
//     //             int n = 0;
//     //             for (int l = 0; l < array.GetLength(1); l++)
//     //             {
//     //                 if (l != minCoord[p, 1])
//     //                 {
//     //                     array2[m, n] = array[k, l];
//     //                     n++;
//     //                 }
//     //             }
//     //             m++;
//     //         }
//     //     }
//     //     int[,] array = array2;




//     int[,] DelMinReq(int [,] array, n)
//     {
//         if (n == 0) return array;
//         else 
//         {
//             int m = 0;
//             int[,] array2 = new int[array.GetLength(0)-1, array.GetLength(1)-1];
//             for (int k = 0; k < array.GetLength(0); k++)
//             {
//                 if (k != minCoord[numb-1, 0])
//                 {
//                     int n = 0;
//                     for (int l = 0; l < array.GetLength(1); l++)
//                     {
//                         if (l != minCoord[p, 1])
//                         {
//                             array2[m, n] = array[k, l];
//                             n++;
//                         }
//                     }
//                     m++;
//                 }
//             }   
//         }
//     }

    
//     return array2;   
// }


int[,] arr = CreateRandom2DArray(5, 4);
Print2DArray(arr);
// for (int i = 0; i)
// int[,] arr2 = DeleteRowColOnMin(arr);
// Print2DArray(arr2);


arr = DeleteRowColOnMin(arr);
Console.WriteLine();
Print2DArray(arr);
