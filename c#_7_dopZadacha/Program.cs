﻿// Необходимо найти 5 целых положительных чисел, которые будут удовлетворять условию:
// x^5 + y^5 + z^5 + q^5 = w^5


int n = 2;

while (n < 100)
{
    Console.WriteLine(n);
    for (int x = 1; x < n; x++)
    {
        for (int y = 1; y < n; y++)
        {
            for (int z = 1; z < n; z++)
            {
                for (int q = 1; q < n; q++)
                {
                    for (int w = 1; w < n; w++)
                    {
                        if (Math.Pow(x, 5) + Math.Pow(y, 5) + Math.Pow(z, 5) + Math.Pow(q, 5) == Math.Pow(w, 5))
                        {
                            Console.WriteLine($"x = {x}, y = {y}, z = {z}, q = {q}, w = {w}");
                            break;
                        }
                    }
                }
            }
        }
    }
    n++;
}
