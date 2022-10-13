// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// Console.WriteLine("Введите число N: ");
// int n = int.Parse(Console.ReadLine()!);

void NaturalNumb(int numb)
{

    if (numb > 0)
    {
        NaturalNumb(numb - 1);
        Console.Write($"{numb}" + " ");
        
    }
}

NaturalNumb(5);

// Факториал
// int Fact(int n)
// {
//     if (n == 1) return 1;
//     return n * Fact(n - 1);
// }

// int x = Fact(5);
// Console.WriteLine(x);