// 39. Напишите программу, которая перевернет одномерный массив
// (последний элемент будет на первом месте, а первый на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] TurnArray(int[] array)
{
    int temp;
    for (int i = 0; i < array.Length/2; i++)
    {
        temp = array[i];
        array[i] = array[array.Length -1 - i];
        array[array.Length -1 - i] = temp;
    }
    return array;
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


Console.Clear();
int[] arr1 = new int[] {1, 2, 3, 4, 5};
int[] arr2 = new int[] {6, 7, 3, 6};

PrintArray(arr1);
Console.Write(" -> ");
PrintArray(TurnArray(arr1));
Console.WriteLine();

PrintArray(arr2);
Console.Write(" -> ");
PrintArray(TurnArray(arr2));
Console.WriteLine();