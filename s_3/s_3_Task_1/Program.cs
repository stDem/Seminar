//Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).
int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

void GetArea (int num)
{   
    switch (num) 
    {
        case 1:
            Console.Write("Координаты четверти: x > 0, y > 0");
        break;
        case 2:
            Console.Write("Координаты четверти: x < 0, y > 0");
        break;
        case 3:
            Console.Write("Координаты четверти: x < 0, y < 0");
        break;
        case 4:
            Console.Write("Координаты четверти: x > 0, y < 0");
        break;
        default:
            Console.Write("Идите в комплексную плоскость");
            break;
    }
}
int num = Prompt("Введите номер четверти: ");
GetArea(num);