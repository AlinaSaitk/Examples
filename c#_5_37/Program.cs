// 37. Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] Proizv(int[] arrayOld)
{
    int newLen = Convert.ToInt32(Math.Ceiling((double) arrayOld.Length / 2));
    int[] arrayNew = new int[newLen];
    if (arrayOld.Length % 2 == 0)
    {
        for (int i = 0; i < newLen; i++)
        {
            arrayNew[i] = arrayOld[i] * arrayOld[arrayOld.Length - 1 - i];
        }
    }
    else
    {
        for (int i = 0; i < newLen - 1; i++)
        {
            arrayNew[i] = arrayOld[i] * arrayOld[arrayOld.Length - 1 - i];
        }
        arrayNew[newLen - 1] = arrayOld[newLen - 1];
    }
    return arrayNew;
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

int[] arr3 = Proizv(arr1);
PrintArray(arr1);
Console.Write(" -> ");
PrintArray(arr3);
Console.WriteLine();

int[] arr4 = Proizv(arr2);
PrintArray(arr2);
Console.Write(" -> ");
PrintArray(arr4);
Console.WriteLine();
