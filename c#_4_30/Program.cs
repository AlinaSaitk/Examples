//Задача 30. Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]

Console.Clear();
int[] arr = new int[8];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(0, 2);
    if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
    else Console.WriteLine(arr[i]);
}
