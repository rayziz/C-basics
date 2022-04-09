//Решение в группах задач:
//Задача 2: Задайте двумерный массив. Найдите элементы, у которых обе позиции чётные, и замените эти элементы на их квадраты.
//Например, изначально массив
// выглядел вот так:
//1 4 7 2       1   4  7  2
//5 9 2 3       5  81  2  9
//8 4 2 4       8   4  2  4


int[,] array = FillArray(3, 4);
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
            array[i, j] = rnd.Next(1, 10);
            if (i % 2 != 0 && j % 2 != 0)
            {
                array[i, j] *=  array[i, j];
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