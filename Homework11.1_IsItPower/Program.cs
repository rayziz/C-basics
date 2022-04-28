/*Задача 1: Определите, является ли число степенью двойки:
N = 16 -> "Является степень двойки"
N = 12 -> “Не является степенью двойки”
*/


Console.WriteLine(VerifyDecimal(1));


// Methods

bool VerifyDecimal(int value)
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


