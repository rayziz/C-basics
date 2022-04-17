//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
//M = 1; N = 5 -> "2, 4"
//M = 4; N = 8 -> "4, 6, 8"


int M = Prompt("Введите M");
int N = Prompt("Введите N");

PlusChetn(M, N);


// Methods

void PlusChetn(int M, int N)
{
    if (M > N) return;
    if (M % 2 == 1)
    {
        M++;
        Console.Write(M + ", ");
        PlusChetn(M + 2, N);
    }
    else if (M % 2 == 0)
    {
        Console.Write(M + ", ");
        PlusChetn(M + 2, N);
    }
}


int Prompt(string message)
{
    Console.WriteLine(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}