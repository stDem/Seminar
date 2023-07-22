// Задача 58: Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.

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
int[,] GetMatrixMultiplication(int[,] array, int[,] array1)
{
    int[,] array3 = new int[array.GetLength(0), array1.GetLength(1)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                array3[i, j] += array[i, k] * array1[k, j];
            }
        }
    }
    return array3;
}
int M = Prompt("Введите количество строк для первой и второй матриц: ");
int N = Prompt("Введите количество столбцов для первой и второй матриц: ");
int[,] array = FillArray(M, N);
int[,] array1 = FillArray(M, N);
PrintArray(array);
Console.WriteLine();
PrintArray(array1);
Console.WriteLine("Произведение двух матриц: ");
PrintArray(GetMatrixMultiplication(array, array1));