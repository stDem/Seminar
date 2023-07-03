// Задача 26: Напишите программу, которая принимает на вход число 
// и выдаёт количество цифр в числе.
// int Prompt(string message)
// {
//     Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }
// void GetCount (int num)
// {
//     int counter = 0;
//     while (num != 0 )
//         {
//             num /= 10;
//             counter++;
//         }
//     Console.WriteLine("Количество:" + counter);
// }
// int C = Prompt("Введите число: ");
// GetCount(C);

//РЕШЕНИЕ С ПЕРЕВОДОМ ЧИСЛА В СТРОКУ:
int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
void GetCount (int num)
{
    string numStr = Math.Abs(num).ToString();
    Console.Write("Количество цифр в числе: " + numStr.Length);
}

int num_1 = Prompt("Введите число: ");
GetCount(num_1);
