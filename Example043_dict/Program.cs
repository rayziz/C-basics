//Задача 3: Составить частотный словарь элементов двумерного массива. 
//Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных. 
//Значения элементов массива 0..9



int[,] array = FillArray(4, 5);
PrintArray(array);
Console.WriteLine();
int[] dictionary = Count(array);
Output(dictionary);


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


int[] Count(int[,] array)
{
    int[] frec = new int[10];
    foreach (int element in array)
    {
        frec[element]++;
    }
    return frec;
}

void Output(int[] mass)
{
    int count = mass.Length;
    for (int pos = 0; pos < mass.Length; pos++)
    {
        Console.WriteLine(mass[pos] + " = " + pos);
    }
    Console.WriteLine();
}