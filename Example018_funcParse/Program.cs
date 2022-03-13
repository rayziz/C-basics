
int Prompt(string message)
{
Console.WriteLine(message);
string strValue = Console.ReadLine();
int Value = int.Parse(strValue);
return Value;
}

int xValue1 = Prompt("Введите x координату первой точки");
int yValue1 = Prompt("Введите y координату первой точки");
int xValue2 = Prompt("Введите x координату второй точки");
int yValue2 = Prompt("Введите y координату второй точки");

Console.SetCursorPosition(xValue1, yValue1);
Console.WriteLine("+");

Console.SetCursorPosition(xValue2, yValue2);
Console.WriteLine("+");
