//Задача 3: Задайте двумерный массив. Найдите сумму элементов главной диагонали.
//Например, задан массив:
//1   4   7
//5   9   2
//8   4   2
//Сумма элементов главной диагонали: 1+9+2 = 12

int digSum = 0;
int[,] array = FillArray(3, 4);
PrintArray(array);
Console.WriteLine(digSum);


// Methods
int[,] FillArray(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
            if (i == j)
            {
                digSum = digSum + array[i, j];
            }

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