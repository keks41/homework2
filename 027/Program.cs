// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
Console.Write("Введите число  :");
int X = Convert.ToInt32(Console.ReadLine());
int sum = 0 ;

int result (int X)
{
    while ( X > 0)
    {
        sum = sum + X % 10;
        X /= 10;
    }
    return sum;
}
int res = result(X);
Console.WriteLine($"Сумма цифр в числе равно {res}");
