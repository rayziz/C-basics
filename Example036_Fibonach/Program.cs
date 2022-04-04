//Задача 3: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
//Если N = 5 -> 0 1 1 2 3
//Если N = 3 -> 0 1 1
//Если N = 7 -> 0 1 1 2 3 5 8

int count = Prompt("Введите число Фибоначи");

int [] fibonachArray = new int [count];

int n1 = 0;
int n2 = 1;

fibonachArray[0] = n1;
fibonachArray[1] = n2;

for (int i = 2; i < count; i++)
{
    int n3 = n1 + n2;
    fibonachArray[i] = n3;
    n1 = n2;
    n2 = n3;
}

foreach (int element in fibonachArray)
{
    Console.WriteLine(element);
}


// Methods
int Prompt(string message)
{
    Console.WriteLine(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

