//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


int chetn = 0;
int[] arr = RandArray(5);
PrintArray(arr);

int len = arr.Length;
for (int i = 0; i < len; i++)
{
    if (arr[i] % 2 == 0)
    {
        chetn++;
    }
    
}

Console.WriteLine(chetn);

int[] RandArray(int lenght)
{
    int[] answer = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        answer[i] = new Random().Next(100, 999);
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


