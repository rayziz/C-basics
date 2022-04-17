//Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
//3 и 4, N = 5 -> 3 4 7 11 18
//6 и 10, N = 4 -> 6 10 16 26 


Console.WriteLine(PlusPredTwo(3, 4, 5));


// Methods

int PlusPredTwo(int first, int second, int N)
{
    if (N == 0) return 0;
    Console.Write($"{first}, ");
    int temp = PlusPredTwo(second, first + second, N - 1) + first;
    return temp;

}
