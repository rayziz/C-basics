﻿//Задача 2: В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита.
//n = 2 -> аа, ии, сс, вв, аи, иа, ис, си, ас, са, 
//ав, ва, ви, ив, св, вс
int n = 1;
Find("аисв", new char[2]);


// Methods

void Find(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($" {n++} {new String (word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        Find(alphabet, word, length + 1);
    }
}

// Methods