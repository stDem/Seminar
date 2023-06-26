/*Задача 4: Напишите программу, которая принимает на вход три числа
и выдаёт максимальное из этих чисел.


(ПОСМОТРИТЕ ЕЩЕ КОД В КОММЕНТАРИЯХ, ПОЖАЛУЙСТА, ОН НЕ ЗАПУСКАЕТСЯ, ХОТЯ ВРОДЕ ПРАВИЛЬНО)


Console.WriteLine("Введите три числа");

string []new_read = new string[3];
for(int i = 0; i < new_read.length; i++)
    new_read[i]= Console.ReadLine();

int max = new_read[0];

for (int j = 1; j < new_read.length; j++)
    {
        if (new_read[j] > max)
            max = new_read[j];
    }

Console.WriteLine($"Максимальное число = {max}");*/

Console.Write("Введите первое число: ");
int num_1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int num_2 = int.Parse(Console.ReadLine());

Console.Write("Введите третье число: ");
int num_3 = int.Parse(Console.ReadLine());

int max = num_1;

if (num_2 > max)
    max = num_2;
if (num_3 > max)
    max = num_3;

Console.Write($"Максимальное число: {max}");

