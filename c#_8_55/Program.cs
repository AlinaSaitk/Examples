// 55. Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, если 
// это невозможно, программа должна вывести сообщение для пользователя. 
// (в рамках одгого массива)


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

// void CheckIfCanChange(int[,] array)
// {
//     for (int i = 1; i < array.GetLength(0); i++)
//     {
//         if (array[i].Length != array[0].Length)
//         {
//             Console.WriteLine("Замена невозможна");
//         } 
//     }
// }

int[,] ChangeRowToCol(int[,] array)
{
    int[,] array2 = new int[array.GetLength(1),array.GetLength(0)];
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            array2[i, j] = array[j, i];
        }
    }
    return array2;
}



int[,] arr = CreateRandom2DArray(3, 4);
Print2DArray(arr);
Console.WriteLine();
int [,] arr2 = ChangeRowToCol(arr);
Print2DArray(arr2);
