Console.WriteLine("Добрый день. Я ещё более универсальный помощник по определению чётности чисел");
Console.WriteLine("От Вас требуется только указать число, а всё остальное я беру на себя)");
string strValue = Console.ReadLine();
int value = int.Parse(strValue);
int index = 2;
int array = 0;
while (index <= value)
{
    array = index;
    Console.Write($"{array}, ");
    index = index+2;
}
Console.WriteLine();