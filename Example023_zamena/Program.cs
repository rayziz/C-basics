

string text = "А уж куды бывает метко всё то, что вышло из глубины Руси," 
            + "нет ни немецких, ни чухонских, ни всяких иных племе,"
            + "а всё сам-самородок, живой и бойкой русской ум";

// string s = "qwerty"  мы можем обратиться к конкретному символу строки, нумерация ниже
//             012345
// s[3] = r

string Replace (string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);

Console.WriteLine();

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
