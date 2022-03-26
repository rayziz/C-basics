// программа принимает на вход число и считает произведение от 1 до N

int Prompt(string message)
{
    Console.WriteLine(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

int ProizvedenieDoN(digit)
{
    int proiz = 1;
    for (int i = 0; i < digit; i++)
    {
        int proiz = proiz*digit;
    }
    return proiz;
}
