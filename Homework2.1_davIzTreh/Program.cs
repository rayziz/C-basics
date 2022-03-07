//456
//782
//918

Console.WriteLine("Введите трёхзначное число");
string A = Console.ReadLine();
int B = int.Parse(A);
int secondPlus = B % 100;
int second = secondPlus / 10;
Console.WriteLine(second);

