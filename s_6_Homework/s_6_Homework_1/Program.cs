// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = Prompt("Введите элемент " + (i + 1)+ ": ");
    return array;
}
void GetPositiveCount(int[] array, int size)
{
    int counter = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] > 0)
            counter++;
    }
    Console.Write("Чисел больше 0: "+ counter);
}
int size = Prompt("Введите количество цифр: ");
int[] array;
array = FillArray(size);
GetPositiveCount(array, size);
