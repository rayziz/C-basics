// индексы      0   1   2   3   4   5   6   7   8
int[] array = { 11, 41, 31, 41, 51, 61, 71, 81, 91 };

// Таким образом можно заменить значение чисел в массиве
array[0] = 12;

// Так задаётся длина массива, из расчёта, что она равна массиву
int n = array.Length;
int find = 41;

int index = 0;

while  (index < n)
{
    if(array[index] == find)
    {   
        Console.WriteLine(index);
        break;
    }
    index++;
}

// break заканчивает цикл