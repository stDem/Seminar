﻿// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());
int i;
for (i = 1; i <= N; i++)
    Console.Write($"{i} ");    