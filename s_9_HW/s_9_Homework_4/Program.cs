// Задача 4. Даны два положительных целых числа, представленных в виде строк. 
//Необходимо получить сумму чисел, которые представлены этими строками. 
//Причем полученная сумма должна быть преобразована в строку.

double[] GetArray(char[] array)
{
    double[] FinishArray = new double[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        switch (array[i])
        {
            case '0':
                FinishArray[i] = 0;
                break;
            case '1':
                FinishArray[i] = 1;
                break;
            case '2':
                FinishArray[i] = 2;
                break;
            case '3':
                FinishArray[i] = 3;
                break;
            case '4':
                FinishArray[i] = 4;
                break;
            case '5':
                FinishArray[i] = 5;
                break;
            case '6':
                FinishArray[i] = 6;
                break;
            case '7':
                FinishArray[i] = 7;
                break;
            case '8':
                FinishArray[i] = 8;
                break;
            case '9':
                FinishArray[i] = 9;
                break;
            default:
                Console.WriteLine("Ошибка");
                break;
        }
    }
    return FinishArray;
}
double GetConvert(string CharString, double num)
{
    char[] mas = CharString.ToCharArray();
    double[] array = GetArray(mas);
    double size = array.Length - 1;
    for (int i = 0; i < array.Length; i++)
    {
        num = num + array[i] * Math.Pow(10, size);
        size--;
    }
    return num;
}
double num = 0;
string number1 = "512";
string number2 = "101";
double num1 = GetConvert(number1, num);
double num2 = GetConvert(number2, num);
Console.Write("Сумма двух чисел:" + Convert.ToString(num1 + num2));