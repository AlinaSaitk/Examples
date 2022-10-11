// 55. Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, если 
// это невозможно, программа должна вывести сообщение для пользователя. (в рамках одгого массива)


// int[,] CreateRandom2DArray(int row, int col, int from = 0, int to = 10)
// {
//     int[,] array = new int[row, col];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(from, to);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     } 
// }

// void ChangeRows(int[,] array)
// {
//     int[] temp = new int[array.GetLength(1)];
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         temp[j] = array[0, j];
//         array[0, j] = array[array.GetLength(0)-1, j];
//         array[array.GetLength(0)-1, j] = temp[j];
//     }
// }


// int[,] arr = CreateRandom2DArray(3, 4);
// Print2DArray(arr);
// Console.WriteLine();
// ChangeRows(arr);
// Print2DArray(arr);
