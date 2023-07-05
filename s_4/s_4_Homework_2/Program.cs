//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int GetCount (int num)
{
    int counter = 0;
    while (num != 0 )
        {
            num /= 10;
            counter++;
        }
    return counter;
}
void GetSum(int num, int length)
{
    int sum = 0;
    for (int i = 0; i < length; i++)
        {
        sum += num % 10;
        num /= 10;
        }
    Console.Write("Сумма цифр в числе: " + sum);
}
int number = Prompt("Введите число: ");
GetSum(number, GetCount(number));
