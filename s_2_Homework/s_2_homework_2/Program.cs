//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

if (num < 100)
    Console.Write("Третьей цифры нет");
else if (num > 999)
{
    while (num > 999)
    num = num / 10;
    Console.Write($"Третья цифра числа = {num % 10}");
}
else 
    Console.Write($"Третья цифра числа = {num % 10}");  

// int Prompt(string message)
// {
//     Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }
// int GetThirdRank(int number)
// {
//     while (number > 999)
//         number /= 10;
//     return number % 10;
// }
// bool ValidateNumber(int number)
// {
//     if (number < 100)
//     {
//         Console.WriteLine("Третьей цифры нет");
//         return false;
//     }
//     return true;
// }
// int number = Prompt("Введите число: ");
// if (ValidateNumber(number))
//     Console.WriteLine($"Третья цифра числа: {GetThirdRank(number)}");