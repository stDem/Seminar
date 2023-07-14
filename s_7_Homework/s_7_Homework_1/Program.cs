// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
double[,] FillArray(int m_QuantRow, int n_QuantColumn)
{
    double[,] array = new double[m_QuantRow, n_QuantColumn];
    Random rand = new Random();
    for (int i = 0; i < m_QuantRow; i++)
    {
        for (int j = 0; j < n_QuantColumn; j++)
        {
            array[i, j] = rand.Next(-9, 10) + rand.NextDouble();
        }
    }
    return array;
}
void PrintArray(double[,] array)
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
int M = Prompt("Введите количество строк: ");
int N = Prompt("Введите количество столбцов: ");
double[,] array = FillArray(M, N);
PrintArray(array);