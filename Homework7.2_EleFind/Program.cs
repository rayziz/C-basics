//Задача 2: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4

//1 7 -> такого числа в массиве нет


int rowVal = Prompt("Введите индекс строки");
int colVal = Prompt("Введите индекс колонки");

int[,] array = FillArray(3, 4);
PrintArray(array);
EleFind(array, rowVal, colVal);



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

int Prompt(string message)
{
    Console.WriteLine(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

void EleFind(int[,] array, int indexRow, int indexCol)
{
    if (indexRow > array.GetLength(0) || indexCol > array.GetLength(1))
    {
        Console.WriteLine("Такого числа нет");
        return;
    }
    Console.WriteLine(array[indexRow - 1, indexCol - 1]);
}

