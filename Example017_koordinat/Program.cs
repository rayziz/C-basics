Console.WriteLine("Сектор четверть на барабане. Ой да ладно я просто шучу, назовите четверть");
string strValue = Console.ReadLine();
int value = int.Parse(strValue);
if (value == 1)
{
    Console.WriteLine("X > 0 и Y > 0");
} 
else if (value == 2)
{
    Console.WriteLine("X < 0 и Y > 0");
} 
else if (value == 3)
{
    Console.WriteLine("X < 0 и Y < 0");
} 
else if (value == 4)
{
    Console.WriteLine("X > 0 и Y < 0");
} 
else Console.WriteLine("Сударь, в школе до какого класса учились? От 1 до 4 введите.");