void Increase(int a, int b)
{    
    if (a == b)
        return;    
    Console.Write(a + 1 + ", ");    
    Increase(a+1, b);    
}
void Descend(int a, int b)
{    
    if (a == b)
        return;    
    Console.Write(a-1 + ", ");
    Descend(a-1, b);   
}
Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);
if (m<n) Increase(m-1, n);
else Descend(m+1, n);