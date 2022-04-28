/*Задача 2: Проверка на простое число:
N = 13 -> "Это простое число"
N = 12 -> “Это не простое число”
*/

if (VerifySimple(13))
    Console.WriteLine("Это простое число");

else
    Console.WriteLine("Это не простое число");

// Methods

bool VerifySimple(int value)
{
    for (int i = 2; i < value; i++)
    {
        if (value % i == 0)
        {
            return false;
        }
    }
    return true;
}




/*
{
    if (value <= 0)
        return false;
    if (value == 1)
        return true;    //True т.к. 2 в нулевой степени это 1
    while ((value % 2) == 0)
    {
        if ((value /= 2) == 1)
            return true;
    }
    return false;
}
*/