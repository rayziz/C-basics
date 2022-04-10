//Задача 2: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.



int[,] array = FillArray(4, 8);
PrintArray(array);
Console.WriteLine();
int[,] transArrey = Reverse(array);
PrintArray(transArrey);


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

int[,] Reverse(int[,] array)
{
    int[,] reverseArrey = new int[array.GetLength(1), array.GetLength(0)];
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = 0; j < array.GetLength(0); j++)
            {
                reverseArrey [i, j] = array [j, i];
            }
        }
        return reverseArrey;
    }
}



