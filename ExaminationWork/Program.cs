/***Задача**: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Примеры**:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> []

*/

string[] arrayInput = { "hello", "2", "world", ":-)" };

PrintArray(arrayInput);
LengthLimitation(arrayInput);



//Methods
void PrintArray(string[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void LengthLimitation(string[] array)
{
    int len = array.Length;
    int currentLimit = 3;
    int index = 0;
    string[] limitedArray = new string[len];
    while (index < len)
    {
        if (array[index].Length <= currentLimit)
        {
            limitedArray[index] = array[index];
            Console.Write($"{limitedArray[index]} ");
        }
        index++;
    }
    Console.WriteLine();
}





