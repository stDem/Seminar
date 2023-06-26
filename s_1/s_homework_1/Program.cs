// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее
Console.WriteLine("Введите первое число:");
int number_1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int number_2 = int.Parse(Console.ReadLine());
    if (number_1 > number_2)
        Console.WriteLine($"Результат: Макисмальное число = {number_1}, Минимальное число = {number_2}");
    else if (number_1 == number_2)
        Console.WriteLine("Результат: Числа одинаковые");
    else 
        Console.WriteLine($"Результат: Макисмальное число = {number_2}, Минимальное число = {number_1}");
        
