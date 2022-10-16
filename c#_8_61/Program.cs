// 61. Вывести первые N строк треугольника Паскаля.
// Сделать вывод в виде равнобедренного треугольника.

void PrintPascal(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(new string (' ', array.GetLength(1) - i));
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] != 0) Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    } 
}

int[,] CreatePascalTriang(int n)
{
    int[,] array = new int[n, n];
    array[0, 0] = 1;
    for (int i = 1; i < n; i++)
    {
        array[i, 0] = 1;
        for (int j = 1; j < n; j++)
        {
            array[i, j] = array[i-1, j-1] + array[i-1, j];
        }
    }
    return array;
}

int n = 5;
int[,] PascalTr = CreatePascalTriang(n);
PrintPascal(PascalTr);