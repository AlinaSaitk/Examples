// 40. Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.

int[] InputArray(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < 3; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

Console.Clear();
Console.WriteLine("Введите три числа, стороны треугольника");
int[] arr = InputArray(3);

if (arr[0] >= arr[1] + arr[2] || 
    arr[1] >= arr[0] + arr[2] || 
    arr[2] >= arr[0] + arr[1]) 
{
    Console.WriteLine("Такого треугольника не существует");
}
else
{
    Console.WriteLine("Треугольник существует");
}