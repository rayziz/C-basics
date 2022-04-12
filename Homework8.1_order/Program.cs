//Задача 1: Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] array = FillArray(4, 5);
PrintArray(array);
Console.WriteLine();
Sort(array);
PrintArray(array);


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

void Sort(int[,] sortArr)
{
    for (int i = 0; i < sortArr.GetLength(0); i++)
    {
        for (int j = 0; j < sortArr.GetLength(1); j++)
        {
            int maxPosition = j;
            for (int k = j; k < sortArr.GetLength(1); k++)
            {
                if (sortArr[i, k] > sortArr[i, maxPosition]) maxPosition = k;
            }
            if (sortArr[i, j] != sortArr[i, maxPosition])
            {
                int temporary = sortArr[i, j];
                sortArr[i, j] = sortArr[i, maxPosition];
                sortArr[i, maxPosition] = temporary;
            }
        }
    }
}

