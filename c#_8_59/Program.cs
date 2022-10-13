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

void DeleteRowColOnMin(int[,] array)
{

}

int[,] arr = CreateRandom2DArray(5, 4);
Print2DArray(arr);
WriteElementsAmount(arr);
