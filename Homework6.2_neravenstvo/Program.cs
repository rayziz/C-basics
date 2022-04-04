// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double b1 = Prompt("Введите число b1");
double b2 = Prompt("Введите число b2");
double k1 = Prompt("Введите число k1");
double k2 = Prompt("Введите число k2");

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"Координата x = {x}, координата y = {y}");


// Methods
double Prompt(string message)
{
    Console.WriteLine(message);
    string strValue = Console.ReadLine();
    double Value = double.Parse(strValue);
    return Value;
}