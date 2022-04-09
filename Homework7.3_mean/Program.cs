//Задача 3: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4

//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] array = FillArray(3, 4);
PrintArray(array);

Mean(array);


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

void Mean(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double mean = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            mean = mean + array[i, j];
        }
        mean = mean / array.GetLength(0);
        Console.Write($"{mean:0.00}\t");
    }
}

