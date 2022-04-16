//Задача 3: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр. Использовать рекурсию.
//453 -> 12
//45 -> 9

Console.WriteLine(RecSum(143));

// Methods

int RecSum(int N)
{
    if (N == 0) return 0;
    else return RecSum(N / 10) + N % 10;
}






