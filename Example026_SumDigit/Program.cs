//Написать, программу, которая принимает на вход число и говорит сколько там было цифр

//Это для того когда принимает ввод
string strValue = Prompt("Введите число");
Console.WriteLine(strValue.Length);

string Prompt(string message)
{
    Console.WriteLine(message);
    string strValue = Console.ReadLine();
    return strValue;
}
////////////////////////////////////////////////////////////


    //Это для того когда принимает Random

//string number = Randomize();
//int lenT = number.Length;
//Console.WriteLine($" {number}  {lenT}");
//
//string Randomize()
//{
//    Random rnd = new Random();
//    int digit = rnd.Next(1, 1000);
//    string newDigit = digit.ToString();
//    return newDigit;
//}


  