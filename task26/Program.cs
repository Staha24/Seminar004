﻿// task26

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), count = 1;
while ( n / 10 != 0)
{
    n /= 10;
    count++;
}
Console.WriteLine(count);
