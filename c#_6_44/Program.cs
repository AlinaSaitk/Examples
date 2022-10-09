// 44. Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

void Fibonacci(int n)
{
    int n1 = 0;
    int n2 = 1;
    if (n <= 0) Console.WriteLine("Введите число от 1 и выше");
    if (n == 1) Console.WriteLine(n1);
    else if (n == 2) Console.WriteLine($"{n1} {n2}");
    else
    {
        int i = 3;
        Console.Write($"{n1} {n2} ");
        while (i <= n)
        {
            Console.Write($"{n1 + n2} ");
            int temp = n2;
            n2 = n1 + n2;
            n1 = temp;
            i++;
        }  
    }
}

Console.Write("Введите число N от 1 и выше: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"Если N = {n} -> ");
Fibonacci(n);