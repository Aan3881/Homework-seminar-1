﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
int coun = 1;
while (coun <= num)
{
    if (coun % 2 == 0)
    {
        Console.Write(coun);
    }
    coun++;
}
