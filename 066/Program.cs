//Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.



System.Console.WriteLine("Введите M :");
int M = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите N :");
int N = int.Parse(Console.ReadLine());
void PrintNumber(int m, int n)
{
    if (n < m) return;
    PrintNumber(m, n - 1);
    Console.Write(n + " ");
}
PrintNumber(M,N);
