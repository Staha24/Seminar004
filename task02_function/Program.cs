﻿// function
//Найти максимум из 2-х чисел

int numbersMax(int n, int m)
{
    if (n > m)
        return n;
    return m;
}

Console.Clear();
Console.Write("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(numbersMax(n, m));
