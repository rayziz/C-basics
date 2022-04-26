/*  Задача 4: Разверните число при помощи рекурсии:
N = 1234 -> "4321"
*/

Console.WriteLine(Reverse(1234));


// Methods

int Reverse(int value, int lastValue = 0)
{
    if (value == 0)
        return lastValue;
    return Reverse(value / 10, lastValue * 10 + value % 10);
}
