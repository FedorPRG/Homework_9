void Numbers(int a, int b)
{
    if (a == b)
    {
        Console.Write(a);
        return;
    }
    else
    {
        if (a < b)
        {
            Console.Write(a + ", ");
            Numbers(a + 1, b);
        }
        else
        {
            Console.Write(a + ", ");
            Numbers(a - 1, b);
        }
    }
}
Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);
Numbers(m, n);
