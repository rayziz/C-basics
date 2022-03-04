Console.WriteLine("Введите первое число");
string strValue1 = Console.ReadLine();
Console.WriteLine("Второе число быстрее, пожалуйста, я вообще-то спешу");
string strValue2 = Console.ReadLine();
Console.WriteLine("Третье число быстрее быстрее");
string strValue3 = Console.ReadLine();
Console.WriteLine("Так подумаем, первое число большое, но второе еще больше, а третье???, всё я запутался");
Console.WriteLine("*...*");

int value1 = int.Parse(strValue1);
int value2 = int.Parse(strValue2);
int value3 = int.Parse(strValue3);

int max = value1;

if (value2 > max) max = value2;
if (value3 > max) max = value3;

Console.WriteLine($"Могу ошибаться, но вроде самое большое число это {max}");
