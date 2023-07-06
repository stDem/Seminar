// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int[] FillArray (int[] mas, int size)
{         
    for (int i = 0; i < size; i++)
        mas[i] = new Random().Next(0, 10);
    var temp = string.Join("  ", mas);
    Console.Write("Исходный массив: " + temp);
    return mas;
}
void GetSumEvenIndex (int[] mas, int size)
{
    int sum = 0;
    for (int i = 0; i < size; i++)
    {
        if (i % 2 == 0)
            sum += mas[i];
    }
    Console.WriteLine(" ");
    Console.Write("Сумма элементов на чётных позициях: " + sum);
}

int size = Prompt("Введите длину массива: ");
int[] mas = new int[size];
FillArray (mas, size);
GetSumEvenIndex (mas, size);

