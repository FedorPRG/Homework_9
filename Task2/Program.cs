Console.Clear();
int Summa(int a, int b)
{
    if (a == b)
        return a;
    return a + Summa(a + 1, b);
}
Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(Summa(m, n));