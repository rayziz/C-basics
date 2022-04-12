//Задача 2: Задайте прямоугольный двумерный массив.
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] array = FillArray(4, 5);
PrintArray(array);
Console.WriteLine();
Sum(array);



//Methosd
int[,] FillArray(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void Sum(int[,] array)
{
    int[] minStr = new int [array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        minStr[i] = sum;
    }
    int lowSum = minStr[0];
    int lowStrInd = 0;
    for (int i = 0; i < minStr.Length; i++)
    {
        if (minStr[0] < lowStrInd)
        {
            lowSum = minStr[i];
            lowStrInd = i;
        } 
    }
    Console.WriteLine($"Наименьшая сумма у строки {lowStrInd}");
}

