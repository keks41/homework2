//Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
Console.WriteLine("Введите M  :");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N  :");
int N = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[M, N];
Random rnd = new Random();
for (int i = 0; i < M; i++)
{
    for (int j = 0; j < N; j++)
    {
        arr[i, j] = rnd.Next(-10, 10);
        Console.Write(arr[i, j] + "  ");
    }
    Console.WriteLine();
}
for (int j = 0; j < N; j++)
{
    double sum = 0;
    for (int i = 0; i < M; i++)
    {
        sum += arr[i, j];
    }
    Console.WriteLine("sum is{0}", sum / M);
}