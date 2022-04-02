//Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Prompt(string message)
{
    Console.WriteLine(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

int i = 1;

int ValA = Prompt("Введите A");
int ValB = Prompt("Введите B");

int ValATemp = ValA;

while (ValB > i)
{
    ValA = ValA * ValATemp;
    i++;
}

Console.WriteLine($"{ValA}");