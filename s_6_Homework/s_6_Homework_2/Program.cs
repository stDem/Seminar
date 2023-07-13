// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

const int coeff = 0;
const int constant = 1;
const int xCoord = 0;
const int yCoord = 1;
const int line1 = 1;
const int line2 = 2;
int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
double[] InputNums(int numOut)
{
    double[] lineNum = new double[2];
    lineNum[coeff] = Prompt("Введите коэффициент для " + numOut);
    lineNum[constant] = Prompt("Введите константу для " + numOut);
    return lineNum;
}
double[] FindCoords(double[] lineNum1, double[] lineNum2)
{
    double[] coord = new double[2];
    coord[xCoord] = (lineNum1[constant] - lineNum2[constant]) /
    (lineNum2[coeff] - lineNum1[coeff]);
    coord[yCoord] = lineNum1[constant] * coord[xCoord] +
    lineNum1[constant];
    return coord;
}
bool IsLineOk(double[] lineNum1, double[] lineNum2)
{
    if (lineNum1[coeff] == lineNum2[coeff])
    {
        if (lineNum1[constant] == lineNum2[constant])
        {
            Console.WriteLine("Прямые совпадают ");
            return false;
        }
        else
        {
            Console.WriteLine("Прямые параллельны ");
            return false;
        }
    }
    return true;

}

double[] lineNum1 = InputNums(line1);
double[] lineNum2 = InputNums(line2);
if (IsLineOk(lineNum1, lineNum2))
{
    double[] coord = FindCoords(lineNum1, lineNum2);
    Console.Write("пересечение уравнений 1 и 2: (" + coord[xCoord] + ", " + coord[yCoord] + ") ");
}