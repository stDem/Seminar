// Задача 3. Дана строка, содержащая только следующие символы:'(', ')', '{', '}', '[', ']'. 
//Определите, является ли ваша строка допустимой.
string Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    return value;
}
bool IsStringOk(string input)
{
    if (string.IsNullOrEmpty(input))
        return false;

    Stack<char> stack = new();

    static bool Open(char current) => current is '{' or '(';
    static bool Close(char current) => current is '}' or ')';
    bool Prev(char current) => stack.TryPop(out char previous) && previous == current switch { '}' => '{', ')' => '(' };

    foreach (char current in input)
    {
        if (Open(current))
            stack.Push(current);
        else if (Close(current) && !Prev(current))
            return false;
    }

    return !stack.Any();
}
string input = Prompt("Введите строку скобок: ");
Console.WriteLine();
if (IsStringOk(input))
    Console.WriteLine("Строка верная");
else
    Console.WriteLine("Строка неверная");