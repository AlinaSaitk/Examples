// ДЗ - Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] CreateRandom3DArray(int row = 2, int col = 2, int layer = 2, int from = 10, int to = 100)
{
    int[,,] array = new int[row, col, layer];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = new Random().Next(from, to);
            }
        }
    }
    return array;
}

void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(2); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            if (i > 0)
            {
                Console.Write(new string (' ', i));
            }
            for (int k = 0; k < array.GetLength(1); k++)
            {
                Console.Write($"{array[j, k, i]} ");
            }
            Console.WriteLine();
        }
        
    } 
}

void Print3DArrayWithCoord(int[,,] array)
{
    for (int i = 0; i < array.GetLength(2); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            if (i > 0)
            {
                Console.Write(new string (' ', i));
            }
            for (int k = 0; k < array.GetLength(1); k++)
            {
                Console.Write($"{array[j, k, i]}({j},{k},{i}) ");
            }
            Console.WriteLine();
        }
        
    } 
}

int[,,] arr = CreateRandom3DArray(3, 4, 2);
Print3DArray(arr);
Print3DArrayWithCoord(arr);