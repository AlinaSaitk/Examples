// Задача 67: Напишите программу, которая будет принимать на вход число 
// и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int Summ(int n)
{
    if (n == 0) return 0;
    else return n%10 + Summ(n/10);
}

int sum = Summ(45);
Console.WriteLine(sum);