// Задача 2. Дан одномерный массив целых однозначных чисел (элемент массива содержит число 
//от 1 до 9). Ваша задача вывести на экран число, которое формируется элементами массива слева-направо + 1.
int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int[] FillArray(int[] mas, int size)
{
    for (int i = 0; i < size; i++)
        mas[i] = new Random().Next(1, 10);

    var temp = string.Join("  ", mas);
    Console.Write("Исходный массив: " + temp);
    Console.WriteLine();
    return mas;
}
void GetPlusOne(int[] mas, int size)
{
    if (mas[size - 1] > 8)
    {
        mas[size - 1] = 0;
        mas[size - 2]++;
    }
    else
        mas[size - 1]++;
    var temp = string.Join("  ", mas);
    Console.Write("Массив +1: " + temp);
}
int size = Prompt("Введите длину массива: ");
int[] mas = new int[size];
GetPlusOne(FillArray(mas, size), size);

