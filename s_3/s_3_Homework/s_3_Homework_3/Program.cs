// Задача 23. Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
void GetSqrtPositive(int N)
{
    for (int i = 1; i <= N; i++)
        Console.Write($" {i * i * i}");
}
void GetSqrtNegative(int N)
{
    for (int i = -1; i >= N; i--)
        Console.Write($" {i * i*i}");
}
//------------------------------------------------------------------------
//------------------------------------------------------------------------
int N = Prompt("Введите число: ");
if (N > 0)
    GetSqrtPositive(N);
else if (N < 0) 
    GetSqrtNegative(N);
else 
    Console.Write("Ошибка. Число = 0");