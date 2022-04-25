/*Задача 3: Заданы 2 массива: info и data. В массиве info хранятся двоичные представления нескольких чисел (без разделителя). 
В массиве data хранится информация о количестве бит, которые занимают числа из массива info. 
Напишите программу, которая составит массив десятичных представлений чисел массива data с учётом информации из массива info.
входные данные:

data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
info = {2, 3, 3, 1 }
выходные данные:
1, 7, 0, 1
*/

int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = { 2, 3, 3, 1 };

TwoToTen(data, info);
PrintArray(info);



//Methods
void PrintArray(int[] Mas)
{
    int count = Mas.Length;
    for (int pos = 0; pos < count - 1; pos++)
    {
        Console.Write(Mas[pos] + ", ");
    }
    Console.WriteLine(Mas[Mas.Length - 1]);
}

void TwoToTen(int[] data, int[] info, int begin = 0, int count = 0)
{
    if (begin >= data.Length)
        return;
    int c = info[count];
    int temp = 0;
    int TwoToStepen = 2;
    for (int i = 0; i < c; i++)
    {
        temp = temp + data[begin + c - i - 1] * Stepen(TwoToStepen, i);
    }
    info[count] = temp;
    TwoToTen(data, info, begin + c, count + 1);
}

int Stepen(int b, int a)
{
    if (a <= 0)
        return 1;
    return b * Stepen(b, a - 1);
}


