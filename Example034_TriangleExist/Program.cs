//Задача 1: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

int side1 = Prompt("Введите первую сторону треугольника");
int side2 = Prompt("Введите вторую сторону треугольника");
int side3 = Prompt("Введите третью сторону треугольника");

if ((side1 < side2 + side3) && (side2 < side1 + side3) && (side3 < side1 + side2))
{
    Console.WriteLine("Существует");
}
else Console.WriteLine("Существует Неочень");


// Methods
int Prompt(string message)
{
    Console.WriteLine(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}



