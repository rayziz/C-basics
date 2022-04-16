//Задача 1: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N при помощи рекурсии

int N = Prompt("Введите N");

Plus1(N);


// Methods

void Plus1(int N)
{
    if (N == 0) return;
    Plus1(N-1);
    Console.Write(N + ", ");

}

int Prompt(string message)
{
    Console.WriteLine(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

