double Prompt(string message)
{
    Console.WriteLine(message);
    string strValue = Console.ReadLine();
    double Value = double.Parse(strValue);
    return Value;
}

double x1 = Prompt("Введите координату точки 1 по оси х");
double y1 = Prompt("Введите координату точки 1 по оси y");
double z1 = Prompt("Введите координату точки 1 по оси z");
double x2 = Prompt("Введите координату точки 2 по оси х");
double y2 = Prompt("Введите координату точки 2 по оси y");
double z2 = Prompt("Введите координату точки 2 по оси х");
double x3 = x1 - x2;
double y3 = y1 - y2;
double z3 = z1 - z2;

double distance = Math.Cbrt(Math.Pow(x3, 3) + Math.Pow(y3, 3) + Math.Pow(z3, 3));
Console.WriteLine(distance);