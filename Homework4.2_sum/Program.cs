//Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Prompt(string message)
{
    Console.WriteLine(message);
    int.TryParse(Console.ReadLine(), out int value);
    return value;
}

int Summa(int val)
{
    int sum = 0;
    while (val != 0)
    {
        sum = sum + val % 10;
        val = val / 10;
    }
    return sum;
}

int val = Prompt("Введите число");

Console.WriteLine(Summa(val));





