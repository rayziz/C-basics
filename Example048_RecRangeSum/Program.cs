//Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
//M = 1; N = 15 -> 120
//M = 4; N = 8 -> 30
int sum = 0;

int M = Prompt("Введите M");
int N = Prompt("Введите N");

Perebor(M, N);
Console.WriteLine();
Console.WriteLine(sum);


// Methods

void Perebor(int M, int N)
{
    if (M > N) return;
    Console.Write(M + ", ");
    Perebor(M + 1, N);
    sum = sum + M;
}


int Prompt(string message)
{
    Console.WriteLine(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}