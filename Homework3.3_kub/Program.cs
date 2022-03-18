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
    partArray = index*index*index;
    Console.Write($"{partArray}, ");
    index++;
}