//Напишите программу, которая будет принимать на
//вход два числа и выводить, является ли второе число
//кратным первому. Если число 2 не кратно числу 1, то
//программа выводит остаток от деление.
//34, 5 -> не кратно, остаток 4
//16, 4 -> кратно

Console.WriteLine("Введите первое число");
string strValue1 = Console.ReadLine();
Console.WriteLine("Второе число");
string strValue2 = Console.ReadLine();

int value1 = int.Parse(strValue1);
int value2 = int.Parse(strValue2);

if((value1 % value2) == 0) Console.WriteLine("К_Р_А_Т_Н_О");
else Console.WriteLine(value1 % value2);

