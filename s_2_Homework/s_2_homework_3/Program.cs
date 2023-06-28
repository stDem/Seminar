//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.
Console.Write("Введите цифру дня недели: ");
int num_day = int.Parse(Console.ReadLine());
switch (num_day)
{
    case 1:
    Console.Write("Понедельник - не выходной");
    break;
    case 2:
    Console.Write("Вторник - не выходной");
    break;
    case 3:
    Console.Write("Среда - не выходной");
    break;
    case 4:
    Console.Write("Четверг - не выходной");
    break;
    case 5:
    Console.Write("Пятница - не выходной");
    break;
    case 6:
    Console.Write("Суббота - выходной!!");
    break;
    case 7:
    Console.Write("Воскресенье - выходной!!");
    break;
    default:
    Console.Write("Такого дня нет");
    break;
}

// int Prompt(string message)
// {
//     Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }
// bool IsWeekend(int WeekDay)
// {
//     if (WeekDay > 5)
//         return true;
//     return false;
// }
// bool ValidateWeekday(int num)
// {
//     if (num > 0 && num <= 7)
//         return true;
//     Console.Write("Такого дня недели нет");
//     return false;
// }

// int week_day = Prompt("Введите день недели: ");
 
// if (ValidateWeekday(week_day))
// {    
//     if (IsWeekend(week_day))
//         Console.WriteLine("Это выходной");
 
//     else 
//         Console.WriteLine("Это не выходной");
// }