// 57. Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных.


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

void WriteElementsAmount(int[,] array)
{
    int[,] result = new int[array.GetLength(0)*array.GetLength(1), 2];
    int k = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {         
            result[k, 0] = array[i, j];
            result[k, 1] = 1;
            k++; 
        }
    }
    
    int temp;
    for (int l = 0; l < result.GetLength(0); l++)
    {
        for (int t = 1; t < result.GetLength(0); t++)
        {
            if (result[t, 0] < result[t-1, 0])
            {
                temp = result[t, 0];
                result[t, 0] = result[t-1, 0];
                result[t-1, 0] = temp;
            }
        }
    }

    for (int m = 0; m < result.GetLength(0); m++)
    {
        for (int n = m + 1; n < result.GetLength(0); n++)
        {
            if (result[m, 0] == result[n, 0])
            {
                result[m, 1] = result[m, 1] + result[n, 1];
                result[n, 1] = 0;
            }
        }
        if (result[m, 1] != 0)
        {
            Console.WriteLine($"{result[m, 0]} встречается {result[m, 1]} раз(а)");
        }
    }
}

int[,] arr =CreateRandom2DArray(3, 4);
Print2DArray(arr);
WriteElementsAmount(arr);