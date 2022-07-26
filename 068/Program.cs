/*int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return Akkerman(m - 1, 1);
    if (m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
    return Akkerman(m, n);
}

Console.Write("Введите число начала диапазона: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число конца диапазона: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = Akkerman(m, n);
Console.Write($"А({result})");
*/
int m = 2;
int n = 3;

int AkkermanFunction( int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return AkkermanFunction(m - 1, 1);
    if (m > 0 && n > 0) return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
    return AkkermanFunction(m, n);
}
int result  = AkkermanFunction(m,n);
System.Console.WriteLine(result);