// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу квадратов чисел от 1 до N.
int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
void GetSqrt(int N)
{
    for (int i = 1; i <= N; i++)
        Console.Write($" {i * i}");
}

int N = Prompt("Введите число: ");
GetSqrt(N);

