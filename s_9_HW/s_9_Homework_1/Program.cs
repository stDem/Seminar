// Задача 1. Дан одномерный массив целых чисел, элементом которого, может быть либо 1, 
//либо 0. Ваша задача вывести на экран максимальное количество следующих друг за другом 1.
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
        mas[i] = new Random().Next(0, 2);

    var temp = string.Join("  ", mas);
    Console.Write("Исходный массив: " + temp);
    Console.WriteLine();
    return mas;
}
void FindCountMaxOne(int[] mas, int size, int i, int max, int count)
{
    while (i < size)
    {
        if (mas[i] == 1 && mas[i + 1] == 1)
        {
            count = count + 1;
            i++;
        }
        else
        {
            if (count > max)
                max = count + 1;
            count = 0;
            i++;
            if (i == (size - 1))
            {
                Console.Write(" Максимальная длина: " + max);
                break;
            }
            else
            {
                FindCountMaxOne(mas, size, i, max, count);
            }
        }
    }
    Console.Write("Максимальная длина: " + max);
}

int size = Prompt("Введите длину массива: ");
int[] mas = new int[size];
FillArray(mas, size);
int index = 0;
int max = 0;
int count = 0;
FindCountMaxOne(mas, size, index, max, count);