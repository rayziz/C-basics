int i = 0;
Console.WriteLine("Введите число");
string strValue = Console.ReadLine();
int value = int.Parse(strValue);
while (value > 0)
{
    value = value / 10;
    i++;
}

 Console.WriteLine($"В числе {i} знаков");