
using static System.Console;
Clear();

WriteLine($"\"\"{GetStringNumbersRec(Input("M"), Input("N"))}\"\"");


int Input(string text)
{
    WriteLine($"Enter the number {text}: ");
    int number = int.Parse(ReadLine()!);
    return number;
}

string GetStringNumbersRec(int a, int b)
{
    if (a == b) return $"{b}";
    if (a > b) return $"{a}," + GetStringNumbersRec(a - 1, b);
    return $"{b}," + GetStringNumbersRec(b - 1, a);
}