// Задайте массив. Напишите программу которая определяет, 
// присутствуют ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

void FindSymbol(int a, int[] array)
{
    Console.Write($"{a}; массив [");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}]");

    for (int i = 0; i < array.Length; i++)
    {
        if (a == array[i])
        {
            Console.WriteLine(" -> да");
            break;
        }
    }
    if (a != array[array.Length - 1])
    {
        Console.WriteLine(" -> нет");
    }
    
}

Console.Clear();
int a = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[] {6, 7, 19, 345, 3};
FindSymbol(a, arr);
