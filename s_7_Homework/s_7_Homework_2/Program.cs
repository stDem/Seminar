// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int[,] FillArray()
{
    int size = 5;//сразу задаем размерность массива 5х5
    int[,] array = new int[size, size];
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(String.Format("{0,3} ", array[i, j]));
        }
        Console.WriteLine();
    }
}
bool IsPosition(int[,] array, int Pos_M, int Pos_N)
{
    if ((Pos_M <= array.GetLength(0)) && (Pos_N <= array.GetLength(1)))
        return true;
    else
        return false;
}
//------------------------------------
int Position_M = Prompt("Введите позицию строки: ");
int Position_N = Prompt("Введите позицию столбца: ");
int[,] array = FillArray();
PrintArray(array);
Console.WriteLine();
if (IsPosition(array, Position_M, Position_N))
    Console.Write($"Позиция [{Position_M},{Position_N}] равна {array[Position_M - 1, Position_N - 1]}");
else
    Console.Write("Такой позиции нет");
