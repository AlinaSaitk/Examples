// 42. Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write("Введите число: ");
int dec = Convert.ToInt32(Console.ReadLine());

string binary = string.Empty;

while (dec != 0)
{
    binary = Convert.ToString(dec % 2) + binary;
    dec = dec / 2;
}
Console.WriteLine(binary);


// int[] DecToBin(int num)
// {
//     int[] biNum = new int[256];
//     int i = 0;
//     while (num > 0)
//     {
//         biNum[i] = num % 2;
//         num = num / 2;
//         i++;
//     }
//     return biNum;
// }

// int[] TurnArray(int[] array)
// {
//     int temp;
//     for (int i = 0; i < array.Length/2; i++)
//     {
//         temp = array[i];
//         array[i] = array[array.Length -1 - i];
//         array[array.Length -1 - i] = temp;
//     }
//     return array;
// }

// void PrintBiNum(int[] array)
// {
//     int i = 0;
//     while (array[i] == 0)
//     {
//         i++;
//     }
//     for (int j = i; j < array.Length; j++)
//     {
//         Console.Write($"{array[j]}");
//     }
// }

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write($"{n} -> ");
// PrintBiNum(TurnArray(DecToBin(n)));
