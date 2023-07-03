// Задача 26: Напишите программу, которая принимает на вход число 
// и выдаёт количество цифр в числе.
int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
void GetCount (int num)
{
    int counter = 0;
    while (num != 0 )
        {
            num /= 10;
            counter++;
        }
    Console.WriteLine("Количество:" + counter);
}
int C = Prompt("Введите число: ");
GetCount(C);

// int Prompt(string message)
// {
//     Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }
// void GetCount (int num)
// {
//     String(num) = Math.Abs()
// }


