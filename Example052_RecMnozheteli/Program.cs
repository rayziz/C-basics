/*Задача 3: Разложите число на множители. Желательно использовать рекурсию:
N = 12 -> "2, 2, 3"
*/

Multipliers(17);

// Methods

//(n / 2 < delitel) Решение с семинара


void Multipliers(int n, int delitel = 2)
{
    if (n / delitel == 1)
    {
        Console.WriteLine(n);
        return;
    }
    if (n % delitel == 0)
    {
        Console.Write(delitel + ", ");
        Multipliers(n / delitel, delitel);
    }
    else Multipliers(n, delitel + 1);
}