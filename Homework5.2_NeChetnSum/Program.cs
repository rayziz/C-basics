// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int NechetnSum = 0;
int i = 0;
int[] arr = RandArray(5);
PrintArray(arr);

int len = arr.Length;

while (i < len)
{
    NechetnSum = NechetnSum + arr[i];
    i = i + 2;
}


Console.WriteLine(NechetnSum);

int[] RandArray(int lenght)
{
    int[] answer = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        answer[i] = new Random().Next(-999, 999);
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