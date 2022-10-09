// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] RandomArray(int n, int from, int to)
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(from, to);
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

void EvenNumbers(int[] array)
{
    int numb = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            numb = numb + 1;
        }
    }
    Console.WriteLine(numb);
}

int[] arr = RandomArray(4, 100, 1000);
PrintArray(arr);
Console.Write(" -> ");
EvenNumbers(arr);
