// Идеальный полиндром для букв и цифр

Console.WriteLine("Введите что-то, чтобы я мог повыпенидриваться");
string strValue = Console.ReadLine();

if (IsPalindrom(strValue))
{
    Console.WriteLine("Это Палиндром лови его");
}
else
{
    Console.WriteLine("Мы его потеряли");
}


// Далее функция IsPalindrom, которая как раз проверяет палиндром ли перед нами или нет

bool IsPalindrom(string digital)
{
    int len = digital.Length;
    int i = 0;
    while (i < len / 2)
    {
        if (digital[i] != digital[len - i - 1])
        {
            return false;
        }
        i++;
    }
    return true;
}

