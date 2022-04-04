//Задача 2: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3  -> 11
//2  -> 10

int val = Prompt("Введите число");
int [] dvoichArray = new int [10];
int i = 0;
int ostatok = 0;

while(val >= 1)
{
    ostatok = val % 2;
    val = val / 2;
    dvoichArray[i] = ostatok;
    i++;
    Console.Write(ostatok);
} 
Console.WriteLine();

for (int j = i-1; j >=0; j--)
Console.Write(dvoichArray[j]);

Console.WriteLine();

// Methods
int Prompt(string message)
{
    Console.WriteLine(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}