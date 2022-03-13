//Задача 3: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4



int Prompt(string message)
{
Console.WriteLine(message);
string strValue = Console.ReadLine();
int Value = int.Parse(strValue);
return Value;
}

int partArray = 0;
int index = 1;

int Val = Prompt("Введите N");

while (Val >= index)
{
    partArray = index*index;
    Console.Write($"{partArray}, ");
    index++;
}