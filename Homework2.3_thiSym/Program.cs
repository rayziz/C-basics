int result = 0;
Console.WriteLine("Введите число");
string strValue = Console.ReadLine();
int value = int.Parse(strValue);
while (value > 999)
{
    value = value / 10;
}

if (value > 99) 
{
    result = value % 10;
    Console.WriteLine($"Третья цифра {result}");
}
else Console.WriteLine("Третьей цифhы нет");
