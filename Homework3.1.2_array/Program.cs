int Prompt(string message)
{
Console.WriteLine(message);
string strValue = Console.ReadLine();
int Value = int.Parse(strValue);
return Value;
}

int val = Prompt("Введите в строчку 5 цифр");

int firSymbol = (val/10000);
int secSymbol = (val/1000%10);
int fouSymbol = (val%100/10);
int fifSymbol = (val%10);

if (firSymbol == fifSymbol && secSymbol == fouSymbol)
{   
     Console.WriteLine("Ну что палиндром, попался");
}
else 
{
     Console.WriteLine("Товарищи, мы его упустили");
}


