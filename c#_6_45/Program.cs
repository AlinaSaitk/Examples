// 45. Напишите программу, которая будет создавать копию 
// заданного массива с помощью поэлементного копирования.

int[] CopyArray(int[] array1)
{
    int[] array2 = new int[array1.Length];
    for (int i = 0; i < array1.Length;  i++)
    {
        array2[i] = array1[i];
    }
    return array2;
}

void PrintArray(int[] array)
{
    Console.Write($"[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}]");
}

int[] RandomArray(int n, int from, int to)
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(from, to);
    }
    return array;
}


int[] arr1 = RandomArray(5, 0, 10);
int[] arr2 = CopyArray(arr1);
PrintArray(arr1);
Console.WriteLine();
PrintArray(arr2);