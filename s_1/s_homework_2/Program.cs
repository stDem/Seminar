// Задача 4: Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.
// Console.WriteLine("Введите первое число");
// int num_1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите второе число");
// int num_2 = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите третье число");
// int num_3 = int.Parse(Console.ReadLine());

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

Console.WriteLine($"Максимальное число = {max}");

