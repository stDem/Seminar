﻿//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
void PrintArray (int[] mas)
{         
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(0, 10);
        Console.Write(" " + mas[i]);
    }
}
int[] mas = new int[8];
PrintArray (mas);