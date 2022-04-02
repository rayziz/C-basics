//Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] arr = RandArray(5);
PrintArray(arr);

int min = Min(arr);
int max = Max(arr);

Console.WriteLine(max);
Console.WriteLine(min);
Console.WriteLine(max-min);


int Min(int[] arr)
{
    int min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (min > arr[i])
        {
            min = arr[i];
        } 
    }
    return min;
}

int Max(int[] arr)
{
    int max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (max < arr[i])
        {
            max = arr[i];
        } 
    }
    return max;
}

int[] RandArray(int lenght)
{
    int[] answer = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        answer[i] = new Random().Next(1, 999);
    }
    return answer;
}

void PrintArray(int[] Mas)
{
    int count = Mas.Length;
    for (int pos = 0; pos < count; pos++)
    {
        Console.Write(Mas[pos] + ", ");
    }
    Console.WriteLine();
}