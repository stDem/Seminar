// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементом массива.
int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
double[] FillArray (double[] mas, int size)
{         
    for (int i = 0; i < size; i++)
        mas[i] = new Random().Next(-9, 10);
    var temp = string.Join("  ", mas);
    Console.Write("Исходный массив: " + temp);
    return mas;
}
double FindMax (double[] mas, int size)
{
    double max = mas[0];
    for (int i = 1; i < size; i++)
    {
        if (mas[i] > max)
            max = mas[i];
    }
    return max;
}
double FindMin (double[] mas, int size)
{
    double min = mas[0];
    for (int i = 1; i < size; i++)
    {
        if (mas[i] < min)
            min = mas[i];
    }
    return min;
}
int size = Prompt("Введите длину массива: ");
double[] mas = new double[size];
FillArray (mas, size);
Console.WriteLine();
double Max = FindMax(mas, size);
double Min = FindMin(mas, size);
Console.Write("Разница между максимальным и минимальным элементом массива: " +  (Max - Min));
