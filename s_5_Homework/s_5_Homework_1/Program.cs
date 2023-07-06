// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

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
        mas[i] = new Random().Next(100, 1000);

    var temp = string.Join("  ", mas);
    Console.Write(temp);
    return mas;
}
void GetCountEvenNumber (int[] mas, int size)
{
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (mas[i] % 2 == 0)
            count++;
    }
    Console.WriteLine(" ");
    Console.Write("Количество четных чисел: " + count);
}

int size = Prompt("Введите длину массива: ");
int[] mas = new int[size];
FillArray (mas, size);
GetCountEvenNumber (mas, size);