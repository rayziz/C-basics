Random rnd = new Random();
int value = rnd.Next(100, 1000);
Console.WriteLine(value);

Console.WriteLine("Нажмите любую клавишу, чтобы была магия");
Console.ReadLine();

int firSymbol = (value/100);
int secSymbol = (value%10);

Console.WriteLine($"{firSymbol}{secSymbol}");