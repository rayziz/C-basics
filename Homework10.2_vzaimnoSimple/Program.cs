/*Задача 4: Есть число N. Сколько групп M, можно получить при разбиении всех чисел на группы, 
так чтобы в одной группе все числа были взаимно просты 
(все числа в группе друг на друга не делятся)? 
Найдите M при заданном N и получите одно из разбиений на группы N ≤ 10²⁰.
*/
int N = 50;
int[] array = new int[N];
for (int m = 0; m < array.Length; m++)
{
    array[m] = m + 1;
}

int[] info = new int[N];
int count = 1;
Console.Write($"{count}: ");
ArraySimpleNumbers(array);
info = FillInfo(array);
int start = FindStartNumber(info);

while (start != 0)
{
    count++;
    array = FillNewArray(array, start);
    Console.Write($"{count}: ");
    ArraySimpleNumbers(array);
    FillInfo(array);
    start = FindStartNumber(info);
}


int[] ArraySimpleNumbers(int[] array)
{
    int i = 0;
    int j = 0;

    while (i < array.Length)
    {
        if (array[i] == 0)
        {
            i++;
            continue;
        }
        j = i + 1;
        while (j < array.Length)
        {
            if (array[j] == 0)
            {
                j++;
                continue;
            }
            if (array[j] % array[i] == 0) array[j] = 0;
            j++;

        }
        i++;
    }

    PrintString(array);
    return array;
}

int[] FillNewArray(int[] array, int count)
{
    int[] newarray = new int[array.Length];
    for (int n = count; n < array.Length; n++)
    {
        newarray[n] = n + 1;
    }
    ReplaceDouble(newarray);
    return newarray;
}


void PrintString(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i] != 0) Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine();
}

int[] FillInfo(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (info[i] == 0) info[i] = array[i];
    }
    return info;
}

int FindStartNumber(int[] info)
{
    for (int i = 0; i < info.Length; i++)
    {
        if (info[i] == 0)
        {
            return i;
        }
    }
    return 0;
}

int[] ReplaceDouble(int[] newarray)
{
    for (int i = 0; i < newarray.Length; i++)
    {
        if (newarray[i] == info[i]) newarray[i] = 0;
    }
    return newarray;
}