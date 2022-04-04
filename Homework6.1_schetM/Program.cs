//Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3


int count = Prompt("Количество числе на проверку?");
int j = 0;

for (int i = 0; i < count; i++)
{
    Console.WriteLine("Ведите число");
    int chekedCount = int.Parse(Console.ReadLine());
    if (chekedCount > 0)
    {
        j++;
    }
}

Console.WriteLine(j);

// Methods
int Prompt(string message)
{
    Console.WriteLine(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}