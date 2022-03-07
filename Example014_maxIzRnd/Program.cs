Random rnd = new Random();
int value = rnd.Next(10, 99);
Console.WriteLine(value);


if (value/10 > value%10)
{
    Console.WriteLine(value/10);
}
if (value/10 < value%10)
{
    Console.WriteLine(value%10);
}
if (value/10 == value%10)
{
    Console.WriteLine($"ОНИ РАВНЫ {value/10}");
}