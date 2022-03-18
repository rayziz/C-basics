Console.WriteLine("Введите в строчку 5 цифр");
string strValue = Console.ReadLine();

if (strValue[0] == strValue[4] && strValue[1] == strValue[3])
{   
     Console.WriteLine("Ну что палиндром, попался");
}
else 
{
     Console.WriteLine("Товарищи, мы его упустили");
}