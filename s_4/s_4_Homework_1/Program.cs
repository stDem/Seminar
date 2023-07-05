// Задача 25: Напишите программу, которая принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
void GetPower(int A, int B)
{
    Console.Write("Число A, возведенное в натуральную степень B: " + Math.Pow(A, Math.Abs(B)));
}
int A = Prompt("Введите число A: ");
int B = Prompt("Введите число B: ");
GetPower(A, B);