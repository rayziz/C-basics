//Задача 1: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5  7    -2   -0,2
//1   -3,3   8   -9,9
//8    7,8  -7,1  9


double[,] array = new double [3, 4];
PrintArray(array);


// Methods

void PrintArray(double[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.NextDouble() * 100;
            Console.Write($"{array[i, j]:0.00}\t");
        }
        Console.WriteLine();
    }
}
