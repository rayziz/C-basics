Console.WriteLine("Введите первое число");
string strValue1 = Console.ReadLine();
Console.WriteLine("Второе число быстрее, пожалуйста, я вообще-то спешу");
string strValue2 = Console.ReadLine();
Console.WriteLine("Я сейчас кое-что проверю и не дай бог эти числа равны");
Console.WriteLine("*Пожалуйста, не мешайте идёт проверка*");

int value1 = int.Parse(strValue1);
int value2 = int.Parse(strValue2);

if (value1 > value2)
{
    Console.WriteLine($"Число {value1} больше чем {value2}");
}
if (value2 > value1)
{
    Console.WriteLine($"Число {value2} больше чем {value1}");
}
if (value1 == value2)
{
    Console.WriteLine("ОНИ РАВНЫ, КАК ТЫ МОГ");
}