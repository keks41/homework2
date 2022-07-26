//Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
/*System.Console.WriteLine("Введите M :");
int M = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите N :");
int N = int.Parse(Console.ReadLine());
int PrintSumNumbers(int M, int N)
{
    if (N < M) return;
    return PrintSumNumbers(M + (N - 1));

}
System.Console.WriteLine(PrintSumNumbers(M, N));
*/
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
