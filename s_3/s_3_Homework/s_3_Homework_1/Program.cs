// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
bool IsFive(int number_five)
{
    if ((number_five > 9999 && number_five < 100000) || (number_five < -9999 && number_five > -100000))
        return true;
    else 
        return false;
}
bool IsPalindrome(int Palindrome)
{
    int temp = 0;
    if ((Palindrome % 10) == (Palindrome / 10000))
    {
        temp = (Palindrome - 10000 * (Palindrome / 10000)) / 10;
        if ((temp % 10) == (temp / 100))
            return true;
    }
    return false;
}
//---------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------
int  Palin = Prompt ("Введите пятизначное число: ");
if (IsFive(Palin))
    {
        if (IsPalindrome(Palin))
            Console.Write("Да, это палиндром");
        else
            Console.Write("Нет, это не палиндром");
    }
else 
    Console.Write("Ошибка. Число не пятизначное");

//ДАЛЬШЕ КОД ДЛЯ ЛЮБОЙ ДЛИНЫ ЧИСЛА

// int Prompt(string message)
// {
//     Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }
// bool IsPalindrome(int Palindrome)
// {
//     if (Palindrome >= 0 && Palindrome < 10)
//         return true;
//     string Palindrome_str = Math.Abs(Palindrome).ToString();
//     for (int i = 0; i < Palindrome_str.Length / 2; i++)
//         if (Palindrome_str[i] == Palindrome_str[(Palindrome_str.Length -1) - i])   
//             return true;
//     return false;
// }
// //---------------------------------------------------------------------------------------------
// //---------------------------------------------------------------------------------------------
// int  Palin = Prompt ("Введите число: ");
//     if (IsPalindrome(Palin))
//         Console.Write("Да, это палиндром");
//     else
//         Console.Write("Нет, это не палиндром");
