//Задача 10. Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трёхзначное число: ");
int num = int.Parse(Console.ReadLine());
if ((num >= 100 && num <= 999) || (num <= -100 && num >= -999))
    Console.Write($"Вторая цифра числа: {Math.Abs(num = num/10 % 10)}");
else 
    Console.Write("Ошибка. Введите трёхзначное число");

// int Prompt(string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }
// int number = Prompt("Введите трёхзначное число: ");
 
// if (number < 100 || number >= 1000)
// {
//     Console.WriteLine("Число не трехзначное");
//     return;
// }
// Console.WriteLine($"Вторая цифра: {number / 10 % 10 }");