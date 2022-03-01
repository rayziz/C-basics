Console.WriteLine("Введие первое число");
string strValue1 = Console.ReadLine();
Console.WriteLine("Давай второе число, не тормози");
string strValue2 = Console.ReadLine();
Console.WriteLine("Я сейчас кое-что проверю и не дай первое число является квадратом второго");
Console.WriteLine("*Пожалуйста, не мешайте идёт проверка*");

int value1 = int.Parse(strValue1);
int value2 = int.Parse(strValue2);

if (value1 == value2*value2)
{
    Console.WriteLine("Это КВАДРАТ, Тоби пизда");
}
else
{
    Console.WriteLine("Всё нормально, ладно иди уже");
}