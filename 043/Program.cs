// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
Console.WriteLine("Введите значение 1 :");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение 2 :");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение 3 :");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение 4 :");
double k2 = Convert.ToInt32(Console.ReadLine());
double x = 0;
double y = 0;
//k1*x+b1= k2*x+b2;
x = (b1-b2) / (k2-k1);
y = (k2 * b1 - k1 * b2) / (k2 - k1);
Console.WriteLine($"({x}, {y})");
