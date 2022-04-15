//Задача 4: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


int[,,] array = FillArray(2, 3, 4);
PrintArray(array);


//Methods
int[,,] FillArray(int row, int column, int sheets)
{
    int[,,] array = new int[row, column, sheets];
    int element = 10;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        element += i;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            element += j;
            for (int k = 0; k < array.GetLength(2); k++)
            {
                element += k;
                array[i, j, k] = element;
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($" {i} {j} {k}: {array[i, j, k]}\t");
            }
        }
        Console.WriteLine();
    }
}
