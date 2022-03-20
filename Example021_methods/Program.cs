// вид1 -> Ничего не возращают и ничего не принимают
void Method1()
{
    Console.WriteLine("Автор ...");
}
//Method1();    вызов



// вид2 > Возвращают, но ничего не принимают
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2("Text");

void Method21(string msg, int count)
{
    int i = 0 ;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21(msg: "Text", count: 4);
//Method21("Text", 4);
// то что Выше "" это какое сообщение будет, а цифра сколько раз.

//Вид 3, возвращает, но не принемает
int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
//Console.WriteLine(year);

// Вид4 и принимают и возвращают

//string Method4(int count, string text)
//{
//    int i = 0;
//    string result = String.Empty;
//
//    while (i < count)
//    {
//        result = result + text;
//        i++;
//    }
//    return result;
//}
//
//string res = Method4(10, "text");
//Console.WriteLine(res);

//10 - это сколько раз, текст - что там будет написно

//Теперь тоже самое только через цикл for

string Method4(int count, string text)
{
    ;
    string result = String.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + text;
       
    }
    return result;
}

string res = Method4(10, "text");
Console.WriteLine(res);


//for(int i = 0; i < count; i++)
// Пояснение к for, инициалиция счётчика, условие цикла, инкремент