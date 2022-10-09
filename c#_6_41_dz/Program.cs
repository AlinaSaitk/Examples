// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.Clear();
Console.Write("Сколько чисел вы будете вводить?: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите числа по порядку: ");
int count = 0;
for (int i = 0; i < m; i++)
{
    int n = Convert.ToInt32(Console.ReadLine());
    if (n > 0) count++;
}
Console.WriteLine($"-> {count}");


