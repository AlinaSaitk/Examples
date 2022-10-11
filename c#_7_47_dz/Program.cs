// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


double[,] Creat2DDoubleArray(int row, int col, int from = -9, int to = 10)
{
    double[,] array = new double[row, col];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(from, to) + Math.Round(new Random().NextDouble(), 2);
        }
        Console.WriteLine();
    }
    return array;
}

void Print2DDoubleArray(double[,] array)
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

double[,] arr = Creat2DDoubleArray(3, 4);
Print2DDoubleArray(arr);

// Вопросы:
// 1. Иногда, по непонятной причине, один из элементов массива 
// не округляется, причем всегда разные.
// 3,62 -8,89 4,75 -7,66
// 4,72 -7,91 7,54 -3,23
// -3,67 1,5699999999999998 7,38 0,51

// 2. Пришлось изменить созданный ранее метод печати массива c int на double,
// т.к. консоль выдает ошибку. Как можно сделать общий метод для печати любых 
// массивов (в т.ч. string и др.)