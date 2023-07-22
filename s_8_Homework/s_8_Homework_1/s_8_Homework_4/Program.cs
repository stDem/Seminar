// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int[,,] FillArray(int m_QuantRow, int n_QuantColumn, int b)
{
    int[,,] array = new int[m_QuantRow, n_QuantColumn, b];
    for (int i = 0; i < m_QuantRow; i++)
    {
        for (int j = 0; j < n_QuantColumn; j++)
        {
            for (int k = 0; k < n_QuantColumn; k++)
            {
                array[i, j, k] = new Random().Next(0, 10);
                Console.Write($" ({i},{j},{k}) = {array[i, j, k]} ");
            }
        }
    }
    return array;
}
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i, j, k]);
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int M = Prompt("Введите количество 1: ");
int N = Prompt("Введите количество 2: ");
int B = Prompt("Введите количество 3: ");
int[,,] array = FillArray(M, N, B);
Console.WriteLine();
PrintArray(array);
