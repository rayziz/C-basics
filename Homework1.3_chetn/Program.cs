Console.WriteLine("Добрый день. Я универсальный помощник по определению чётности чисел");
Console.WriteLine("От Вас требуется только указать число, а всё остальное я беру на себя)");
string strValue = Console.ReadLine();
int value = int.Parse(strValue);

if((value % 2) == 0) Console.WriteLine("Это самое чётное число в мире");
else Console.WriteLine("Не видел ничего более нечётнёго в мире");