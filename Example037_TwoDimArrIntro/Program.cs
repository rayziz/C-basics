//Задача 1: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
//m = 3, n = 4.
//1     4    8   19
//5   -2  33   -2
//77  3    8     1

int[,] array = FillArray(5, 4);
PrintArray(array);


// Methods
int[,] FillArray(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-10, 100);
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


