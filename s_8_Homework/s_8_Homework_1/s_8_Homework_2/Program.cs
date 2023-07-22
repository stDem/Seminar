// Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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
int[] GetSumRow(int[,] array)
{
    int[] ResultArray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumRow = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRow = sumRow + array[i, j];
        }
        ResultArray[i] = sumRow;
    }
    return ResultArray;
}
void GetMin(int[] array)
{
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
    }
    if (min == array[0])
        Console.Write("минимальная сумма находится в 1 строке = " + min);
    else Console.Write($"минимальная сумма = {min}");
}
int M = Prompt("Введите количество строк: ");
int N = Prompt("Введите количество столбцов: ");
int[,] array = FillArray(M, N);
PrintArray(array);
Console.WriteLine();
GetMin(GetSumRow(array));