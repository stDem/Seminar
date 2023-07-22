// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
//элементы каждой строки двумерного массива.

int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int[,] FillArray(int m_QuantRow, int n_QuantColumn)
{
    int[,] array = new int[m_QuantRow, n_QuantColumn];
    for (int i = 0; i < m_QuantRow; i++)
    {
        for (int j = 0; j < n_QuantColumn; j++)
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
int[,] SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
    return array;
}
int M = Prompt("Введите количество строк: ");
int N = Prompt("Введите количество столбцов: ");
int[,] array = FillArray(M, N);
PrintArray(array);
SortArray(array);
Console.WriteLine("Отсортированный массив:");
PrintArray(array);
