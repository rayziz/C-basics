//Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] firstArray = FillArray(3, 3);
PrintArray(firstArray);
Console.WriteLine();

int[,] secondArray = FillArray(3, 3);
PrintArray(secondArray);
Console.WriteLine();

int[,] proizArray = new int[firstArray.GetLength(0), firstArray.GetLength(1)];
{
    for (int i = 0; i < firstArray.GetLength(0); i++)
    {
        for (int j = 0; j < firstArray.GetLength(1); j++)
        {
            for (int k = 0; k < firstArray.GetLength(1); k++)
            {
                proizArray[i, j] += firstArray[i, k] * secondArray[k, j];
            }
        }
    }
}

PrintArray(proizArray);


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
